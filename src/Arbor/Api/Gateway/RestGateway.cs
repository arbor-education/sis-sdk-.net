using System;
using System.Net;
using System.IO;
using System.Text;
using System.Collections;
using Arbor.Model;
using Arbor.Model.Api;
using Arbor.Query;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Arbor.Filter;
using Arbor.ChangeLog;


namespace Arbor.Api.Gateway
{
	public class RestGateway : IGateway
	{
		public const string HTTP_METHOD_GET 	= "get";
    	public const string HTTP_METHOD_POST 	= "post";
     	public const string HTTP_METHOD_PUT 	= "put";
    	public const string HTTP_METHOD_DELETE 	= "delete";

		private string baseUrl;
		private string authUser;
		private string authPassword;
		private string userAgent;


		public RestGateway (string baseUrl, string authUser, string authPassword,
		                    string userAgent = "Arbor .NET SDK")
		{
			this.baseUrl 		= baseUrl;
			this.authUser 		= authUser;
			this.authPassword 	= authPassword;
			this.userAgent 		= userAgent;
		}

		public ModelBase create (ModelBase model)
		{
			PluralizeFilter filterPluralize = new PluralizeFilter();
	        CamelCaseToDash filterCamelToDash = new CamelCaseToDash();

	        string pluralResource = filterPluralize.filter(model.getResourceType());
	        string resource = filterCamelToDash.filter(pluralResource).ToLower();
			Uri url = new Uri(this.baseUrl + "/rest-v2/" + resource);

	        Hydrator hydrator = new Hydrator();
	        JObject arrayRepresentation = hydrator.extractArray(model);
	        string resourceRoot = lcfirst(model.getResourceType());

			// Format body
			Hashtable hBody = new Hashtable();
			Hashtable hResource = new Hashtable();
			hResource.Add(resourceRoot, arrayRepresentation);
			hBody.Add("request", hResource);

			string body = JsonConvert.SerializeObject(hBody, Formatting.None);

            //Console.WriteLine(hBody.ToString());
            //Console.WriteLine(body);
            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine(url.AbsoluteUri);

            JObject responseRepresentation = this.sendRequest(HTTP_METHOD_POST.ToString(), url.AbsoluteUri, body);
	        JToken resultingModelRepresentation = new JObject();

	        if(responseRepresentation[resourceRoot] != null)
	        {
	            resultingModelRepresentation = responseRepresentation[resourceRoot];
	        } else {
	            throw new Exception("API Error: " + responseRepresentation.ToString());
	        }

			hydrator.hydrateModel(model, (JObject) resultingModelRepresentation);

	        return model;
		}

		public ModelBase retrieve (string resource, string id)
		{
			// Filters
			PluralizeFilter filterPluralize = new PluralizeFilter();
			CamelCaseToDash filterCamelToDash = new CamelCaseToDash();

			string resourceSegment = (filterCamelToDash.filter(filterPluralize.filter(resource)));
			string url = baseUrl + "/rest-v2/" + resourceSegment + "/" + id;

			// Request / Response
			JObject arrayRepresentation = this.sendRequest (HTTP_METHOD_GET.ToString (), url);
			string resourceRoot = lcfirst(resource);
			ModelBase model = null;

			if (arrayRepresentation[resourceRoot] is JObject) {
				model = (ModelBase) this.instantiateModel(resource);
				Hydrator hydrator = new Hydrator();
				hydrator.hydrateModel(model, (JObject) arrayRepresentation[resourceRoot]);
			} else {
				throw new Exception ("Resource" + resource +" with ID " + id + " could not be retrieved from URL: "  + url);
			}

			return model;
		}

		public object instantiateModel(string resourceType)
		{
			char delimiter = '_';
			string modelClass = "";
			object instance;

			// This is a module resource
			if (resourceType.IndexOf (delimiter) != -1) {
				string[] resource = resourceType.Split (delimiter);
				string modulePrefix = resource [0];
				string moduleResource = resource [1];

				modelClass = "Arbor.Model." + modulePrefix + "." + moduleResource;
				Type model = Type.GetType (modelClass);
				instance = Activator.CreateInstance (model);
			} else {
				modelClass = "Arbor.Model." + resourceType;
				Type concreteModelType = Type.GetType (modelClass);

				// Check if resource for given model exists. If not, then use the base class.
				if (concreteModelType == null) {
					Console.WriteLine ("Could not find model: " + modelClass);
					return new ModelBase (resourceType, new Hashtable (), this);
				}

				instance = Activator.CreateInstance (concreteModelType, resourceType, new Hashtable (), this);
			}

			return instance;
		}

		private T Instantiate<T>()
		{
			return Activator.CreateInstance<T>();
		}

		/// <summary>
		/// Update the specified model.
		/// </summary>
		/// <param name='model'>
		/// ModelBase.
		/// </param>
		/// <exception cref='Exception'>
		/// Represents errors that occur during application execution.
		/// </exception>
		public ModelBase update(ModelBase model)
		{
			Uri url = new Uri(this.baseUrl + model.getResourceUrl().OriginalString);

	        Hydrator hydrator = new Hydrator();
	        JObject arrayRepresentation = hydrator.extractArray(model);

	        string resourceRoot = lcfirst(model.getResourceType());

			// Property "revisionId" is read-only and cannot be updated
			if (arrayRepresentation["revisionId"] != null)
			{
				arrayRepresentation.Remove("revisionId");
			}

			// Get current model (saved in database), before updating it
			ModelBase previousModel = this.retrieve(model.getResourceType().ToString(), model.getResourceId().ToString());
			JObject prevModelArrRepresentation = hydrator.extractArray(previousModel);
			JObject modelDiff = this.diffArrayRepresentationRecursive(arrayRepresentation, prevModelArrRepresentation);

			// Update model only if there are modifyied fields
			if (modelDiff.HasValues)
			{
				// Format body
				Hashtable hBody = new Hashtable();
				Hashtable hResource = new Hashtable();
				hResource.Add(resourceRoot, modelDiff);
				hBody.Add("request", hResource);

				string body = JsonConvert.SerializeObject(hBody, Formatting.None, new ArborJsonConverter());

				// Send request to the server and perform an update
				JObject responseRepresentation = this.sendRequest(HTTP_METHOD_PUT.ToString(), url.AbsoluteUri, body);
				JToken resultingModelRepresentation = new JObject();

				if(responseRepresentation[resourceRoot] != null)
				{
					resultingModelRepresentation = responseRepresentation[resourceRoot];
				} else {
					throw new Exception("API Error: " + responseRepresentation.ToString());
				}

				hydrator.hydrateModel(model, (JObject) resultingModelRepresentation);
			}
			else
			{
				return model;
			}

			return model;
		}

		public HttpWebResponse delete(ModelBase model)
		{
			string url = model.getResourceUrl().AbsoluteUri;
			WebRequest request = WebRequest.Create(url);
			request.Method = HTTP_METHOD_DELETE;
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			return response;
		}

		public ModelCollection<ModelBase> query(SimpleQuery query)
		{
			PluralizeFilter filterPluralize = new PluralizeFilter();
			CamelCaseToDash filterCamelToDash = new CamelCaseToDash();

			string pluralResource = filterPluralize.filter(query.getResourceType());
			string resource = (filterCamelToDash.filter(pluralResource)).ToLower();
			string resourceRoot = this.lcfirst(pluralResource);
			string url = this.baseUrl + "/rest-v2/" + resource;
			string queryString = query.getQueryString();

			if(queryString.Length > 0)
	        {
	            url += "?" + queryString;
	        }

			JObject arrayRepresentation = this.sendRequest(HTTP_METHOD_GET.ToString(), url);
			ModelCollection<ModelBase> listing = new ModelCollection<ModelBase>();

			if(arrayRepresentation[resourceRoot] != null)
	        {
	            Hydrator hydrator = new Hydrator();
	            string json = arrayRepresentation[resourceRoot].ToString();
				JArray result = JsonConvert.DeserializeObject<JArray>(json);

				foreach (JToken token in result)
	            {
	                ModelBase model = (ModelBase) this.instantiateModel(query.getResourceType());
	                hydrator.hydrateModel(model, JsonConvert.DeserializeObject<JObject>(token.ToString()));

	                listing.add(model);
	            }
	        }

			return listing;
		}

		public void setAuthPassword(string authPassword)
		{
		    this.authPassword = authPassword;
		}

		public string getAuthPassword()
	    {
			return this.authPassword;
	    }

		public void setAuthUser(string authUser)
	    {
	        this.authUser = authUser;
	    }

		public string getAuthUser()
	    {
	        return this.authUser;
	    }

		public void setBaseUrl(string baseUrl)
	    {
	        this.baseUrl = baseUrl;
	    }

		public string getBaseUrl()
	    {
	        return this.baseUrl;
	    }

		public ModelBase refresh (ModelBase model)
		{
			Uri url = model.getResourceUrl ();
			HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create (this.baseUrl + url);
			// Create request and set request parameters
			string auth = Convert.ToBase64String (Encoding.Default.GetBytes (this.authUser + ":" + this.authPassword));
			webReq.Headers.Add ("Authorization", "Basic " + auth);
			webReq.Method = WebRequestMethods.Http.Get;
			webReq.AllowAutoRedirect = true;
			// webReq.Proxy = null;
			webReq.Accept = "application/json";
			webReq.UserAgent = this.userAgent;

			try
			{
				HttpWebResponse response = (HttpWebResponse)webReq.GetResponse ();
				Stream dataStream = response.GetResponseStream ();
				StreamReader reader = new StreamReader (dataStream);
				string serverResponse = reader.ReadToEnd ();

				JObject arrayRepresentation = JObject.Parse (serverResponse);
				string resource = model.getResourceType ();
				string resourceRoot = Char.ToLowerInvariant (resource [0]) + resource.Substring (1);

				if (arrayRepresentation [resourceRoot] != null) {
					Hydrator hydrator = new Hydrator ();
					hydrator.hydrateModel (model, (JObject) arrayRepresentation [resourceRoot]);
				} else {
					throw new Exception ("Resource" + resource
					                     +" with ID " + model.getResourceId()
					                     + " could not be retrieved from URL: "  + url.AbsolutePath);
				}
			}
			catch(WebException ex)
			{
				throw new ServerErrorException(ex.Message, ex);
			}


			return model;
		}


		public JObject sendRequest (string method, string url, string body=null, string headers=null)
		{
			string message = "API Error";
			HttpStatusCode code = new HttpStatusCode();
			JObject responsePayload = new JObject();
			HttpWebResponse response = null;
			string serverResponse = "";

			// Ignore certificateC
			System.Net.ServicePointManager.ServerCertificateValidationCallback += (s,ce,ca,p) => true;

			// Set authorizaton parameters
			HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create (url);
			string auth = Convert.ToBase64String (Encoding.Default.GetBytes (this.authUser + ":" + this.authPassword));

			// Create request and set request parameters
			webReq.Headers.Add("Authorization", "Basic " + auth);
	        webReq.Method = method;
	        webReq.AllowAutoRedirect = true;
			webReq.Accept = "application/json";
			webReq.UserAgent = this.userAgent;
			webReq.AllowAutoRedirect = true;
			webReq.MaximumAutomaticRedirections = 1;

			// Set request body
			if (body != null) {
				webReq.ContentType = "text/json";
				byte[] byteBody = Encoding.UTF8.GetBytes(body);
				webReq.ContentLength = byteBody.Length;
				Stream requestStream = webReq.GetRequestStream();
				requestStream.Write(byteBody, 0, byteBody.Length);
			}

			try
			{
				// Get server response
				response = (HttpWebResponse) webReq.GetResponse();
				Stream dataStream = response.GetResponseStream();
				StreamReader reader = new StreamReader (dataStream);
				serverResponse = reader.ReadToEnd ();
				code = response.StatusCode;
			}
			catch(WebException ex)
			{
				if (ex.Response.ContentLength > 0)
				{
					string sResponse = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
					responsePayload = JObject.Parse(sResponse);

					if (responsePayload["response"] != null)
					{
						if (responsePayload["response"]["errors"] != null)
						{
							string serverException = responsePayload["response"]["errors"][0]["exception"].ToString();
			                string serverMessage = responsePayload["response"]["errors"][0]["message"].ToString();
			                string serverTrace = responsePayload["response"]["errors"][0]["trace"].ToString();
							code = ((HttpWebResponse) ex.Response).StatusCode;

							message = "Server threw: " + serverException + " with message: " + serverMessage + " URL=" + url;
						}
						else if (responsePayload["response"]["reason"] != null)
						{
							message = responsePayload["response"]["reason"].ToString();
							int iCode = Convert.ToInt32(responsePayload["response"]["code"]);
							if (iCode == 404)
							{
								code = HttpStatusCode.NotFound;
							}
						}
					}
					else if (responsePayload["status"] != null){
						if (responsePayload["status"]["errors"] != null)
						{
							string serverException = responsePayload["status"]["errors"].ToString();

							message = "Server threw: " + serverException + " URL=" + url;
						}
					}
				}
				else{
					throw new ServerErrorException(ex.Message);
				}
			}

			switch (code)
			{
				case HttpStatusCode.OK:
				case HttpStatusCode.Created:
					responsePayload = JObject.Parse(serverResponse);
					break;
				case HttpStatusCode.NotFound:
				case HttpStatusCode.InternalServerError:
					throw new ServerErrorException(message);
				default:

				throw new ServerErrorException(message);
			}

			return responsePayload;
		}

		private string lcfirst (string text)
		{
			text = Char.ToLowerInvariant (text [0]) + text.Substring (1);
			return text;
		}

		public object castCollection<T>(ModelCollection<ModelBase> genericCollection)
		{
			ModelCollection<T> specificCollection = new ModelCollection<T>();

			foreach(ModelBase element in genericCollection)
			{
				specificCollection.add((T)(object)element);
			}

			return (Object) specificCollection;
		}

		/// <summary>
		/// Gets the changes.
		/// </summary>
		/// <returns>
		/// The changes.
		/// </returns>
		/// <param name='resourceType'>
		/// Resource type.
		/// </param>
		/// <param name='fromRevision'>
		/// From revision.
		/// </param>
		/// <param name='toRevision'>
		/// To revision.
		/// </param>
		public List<Change> getChanges(string resourceType, int fromRevision, int toRevision = -1)
		{
			PluralizeFilter filterPluralize = new PluralizeFilter();
	        CamelCaseToDash filterCamelToDash = new CamelCaseToDash();

	        string pluralResource = filterPluralize.filter(resourceType);
	        string resourceSegment = (filterCamelToDash.filter(pluralResource)).ToLower();

	        string uri = this.getBaseUrl() + string.Format("/rest-v2/{0}/changelog?", resourceSegment);
	        if(fromRevision > 0)
	        {
	            uri += string.Format("fromRevision={0}&", fromRevision);
	        }

	        if(toRevision > -1)
	        {
	            uri += string.Format("toRevision={0}&", toRevision);
	        }

	        JObject arrayRepresentation = this.sendRequest(HTTP_METHOD_GET, uri);

	        List<Change> changes = new List<Change>();
	        if(arrayRepresentation["changes"] != null)
	        {
	            Hydrator hydrator = new Hydrator();
	            JArray results = (JArray) arrayRepresentation["changes"];
	            foreach(JObject result in results)
	            {
	                ModelBase model = (ModelBase) this.instantiateModel(resourceType);
	                hydrator.hydrateModel(model, (JObject) result["changedObject"]);
	                Change change = new Change(
						model,
						result["changeType"].ToString(),
						Convert.ToInt32(result["fromRevision"]),
						Convert.ToInt32(result["toRevision"]));
					changes.Add(change);
	            }
	        }
	        return changes;
		}

		/// <summary>
		/// Diffs the array representation recursive.
		/// </summary>
		/// <returns>
		/// The array representation recursive.
		/// </returns>
		/// <param name='array1'>
		/// Array1.
		/// </param>
		/// <param name='array2'>
		/// Array2.
		/// </param>
		public JObject diffArrayRepresentationRecursive(JObject array1, JObject array2)
		{
			JObject difference = new JObject();

			foreach (KeyValuePair<string, JToken> kvp in array1)
			{
				if (kvp.Value.GetType() == typeof(JObject))
				{
					if (array2[kvp.Key] == null)
					{
						difference[kvp.Key] = kvp.Value;
					}
					else if (array2[kvp.Key].GetType() == typeof(JToken))
					{
						difference[kvp.Key] = kvp.Value;
					}
					else // This is some of MIS model types
					{
						JObject nestedArray1 = (JObject) kvp.Value;
						JObject nestedArray2 = (array2[kvp.Key].HasValues) ? (JObject) array2[kvp.Key] : new JObject();
						JObject new_diff = this.diffArrayRepresentationRecursive( nestedArray1, nestedArray2);

						if (new_diff.HasValues)
						{
							difference[kvp.Key] = new_diff;

							if (array2[kvp.Key].HasValues)
							{
								if (array2[kvp.Key]["entityType"] != null) // Preserve 'entityType' and 'href' since those values are mandatory, but not changed
								{
									difference[kvp.Key]["entityType"] = array1[kvp.Key]["entityType"];
									difference[kvp.Key]["href"] = array1[kvp.Key]["href"];
								}
							}
						}
					}
				}
				else if (array2[kvp.Key] == null || !kvp.Value.Equals(array2[kvp.Key]))
				{
					difference[kvp.Key] = kvp.Value;
				}
			}

			return difference;
		}
	}
}
