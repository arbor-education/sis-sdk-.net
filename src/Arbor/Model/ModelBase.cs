using System;
using System.Collections;
using Newtonsoft.Json.Linq;
using Arbor.Api.Gateway;

namespace Arbor.Model
{
	public class ModelBase
	{
		public Hashtable properties;
		protected string resourceType;
		protected Uri resourceUrl;
		public IGateway apiGateway;
		protected static IGateway defaultApiGateway;
		public String displayName;

		public ModelBase (string resourceType = null, Hashtable properties = null, IGateway apiGateway = null)
		{
			if (resourceType != string.Empty && resourceType != null) {
				this.resourceType = resourceType;
			}

			if (apiGateway == null) {
				apiGateway = ModelBase.getDefaultGateway ();
			}

			if (properties == null) {
				this.properties = new Hashtable ();
			} else {
				this.setProperties (properties);
			}

			this.connect(apiGateway);
			//this.SetProperty("userTags", new Hashtable());
		}

		public static void setDefaultGateway(IGateway gateway)
		{
			ModelBase.defaultApiGateway = gateway;
		}

		public static IGateway getDefaultGateway()
		{
			return ModelBase.defaultApiGateway;
		}

		public Hashtable GetProperties()
		{
			return this.properties;
		}

		public object GetProperty(String name)
		{
			if (this.properties.Contains(name)) {
				return this.properties [name];
			}
			return null;
		}

		public void setProperty (String name, Object property)
		{
			if (this.properties.ContainsKey (name)) {
				this.properties [name] = property;
			} else {
				this.properties.Add(name, property);
			}
		}

		public Uri getResourceUrl()
		{
			return this.resourceUrl;
		}

		public void setResourceUrl(Uri uri)
		{
			this.resourceUrl = uri;
		}

		public int getResourceId ()
		{
			int id = 0;

			if (this.resourceUrl != null) {
				string [] separator = new string []{"/"};
				string [] urlParts = this.resourceUrl.ToString().Split(separator, StringSplitOptions.None);

				try
				{
					id = Convert.ToInt32(urlParts[3]);
				}
				catch (Exception ex)
				{
					throw new Exception ("Incorrect ID in resource URL found!", ex.InnerException);
				}
			}

			return id;
		}

		public void connect(IGateway apiGateway)
		{
			this.apiGateway = apiGateway;
		}

		public IGateway getApiGateway ()
		{
			return this.apiGateway;
		}

		public Hashtable getProperties ()
		{
			return this.properties;
		}

		public void setProperties (Hashtable properties)
		{
			this.properties = properties;
		}

		public object getProperty (string propertyName)
		{
			if (!this.properties.Contains (propertyName)) {
				if (this.getResourceUrl() != null) {
					this.refresh();
				}
				else {
					return null;
				}
			}

			return this.properties[propertyName];
		}

		public object getCollectionProperty (string propertyName)
		{
			if (!this.properties.Contains (propertyName)) {
				this.refresh ();
			}
			if (this.properties [propertyName] == null) {
				this.properties.Add(propertyName, new ModelCollection<ModelBase>());
			}

			return this.properties[propertyName];
		}

		public ModelBase refresh ()
		{
			if (this.getApiGateway() != null) {
				return this.getApiGateway ().refresh (this);
			} else {
				throw new Exception ("Trying to refresh an unconnected model: " + this.getResourceUrl().ToString());
			}
		}

		public void save()
		{
			if(this.getApiGateway() != null)
	        {
	            Uri identity = this.getResourceUrl();
	            if(identity != null)
	            {
	                this.getApiGateway().update(this);
	            }
	            else
	            {
	                this.getApiGateway().create(this);
	            }
	        }
	        else
	        {
	            throw new Exception("Trying to save an unconnected model. Please call connect() first.");
	        }
		}

		public void setResourceType(String type)
		{
			this.resourceType = type;
		}

		public string getResourceType()
		{
			return this.resourceType;
		}

		public void setDisplayName(string displayName)
		{
			this.displayName = displayName;
		}

		public string getDisplayName()
		{
			return this.displayName;
		}

		public void setUserTags (object tags)
		{
			this.setProperty("userTags", tags);
		}

		public JObject getUserTags()
	    {
	        if (this.getProperty("userTags") == null)
	        {
                Tag tag = new Tag(ResourceType.TAG, new Hashtable(), apiGateway);
                this.setUserTags(tag);
            }
            return JObject.FromObject(this.getProperty("userTags"));
	    }

		public void tag (string tagName, object value)
		{
		    Tag tags = this.getUserTags().ToObject<Tag>();
		    tags.properties.Add(tagName, value.ToString());
		    this.setUserTags(tags);
	    }
		
	}
}

