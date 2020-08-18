using System;
using System.Collections;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Arbor.Model.Api
{
	public class Hydrator
	{
		public Hydrator ()
		{
		}

		public ModelBase hydrateModel (ModelBase model, JObject representation)
		{
			if (model.apiGateway == null) {
				throw new Exception ("Trying to hydrate an unconnected model");
			}

			foreach (var entry in representation) {
				string propertyName = entry.Key.ToString ();
				Object propertyValue = entry.Value;
				
				switch (propertyName) {
				case "entityType":
					model.setResourceType (propertyValue.ToString());
					break;
				case "href":
					model.setResourceUrl (new Uri (propertyValue.ToString(), UriKind.Relative));
					break;
				case "displayName":
					model.setDisplayName((string)propertyValue);
					break;
				case "userTags":
					if (propertyValue is JObject)
					{
						JObject tags = JObject.Parse(propertyValue.ToString());
						model.setUserTags(tags);
					}
					else if (propertyValue is JArray && (JArray.Parse(propertyValue.ToString()).Count == 0))
					{
						JObject tags = new JObject();
						model.setUserTags(tags);
					}
					break;
				default: //This is a normal property
					// If the property value is another representation then parse it recursivly
					if (propertyValue is JObject) {
						JObject nestedEntity = JObject.Parse(propertyValue.ToString());
						
						if (nestedEntity["entityType"] != null) {
							switch (nestedEntity ["entityType"].ToString ()) {
							case "date":
								model.setProperty (propertyName, Convert.ToDateTime (nestedEntity ["date"].ToString()));
								break;
							default :
								string nestedModel = nestedEntity ["entityType"].ToString ();
								ModelBase relatedModel = (ModelBase) model.apiGateway.instantiateModel (nestedModel);
								this.hydrateModel (relatedModel, nestedEntity);
								model.setProperty (propertyName, relatedModel);
								break;
							}
						}
					}
					else if (propertyValue is JArray) {
						// This is a collection returned by a collection property
						ModelCollection<ModelBase> collection = new ModelCollection<ModelBase>();
						
						JArray resources = (JArray) propertyValue;
						IEnumerator en = resources.GetEnumerator();

						while (en.MoveNext())
						{
							JObject resourceRepresentation = (JObject) en.Current;
							if (resourceRepresentation["entityType"] != null)
							{
								ModelBase relatedModel = 
									(ModelBase) model.getApiGateway().instantiateModel( resourceRepresentation["entityType"].ToString());
								this.hydrateModel(relatedModel, resourceRepresentation);
								collection.add(relatedModel);

							}
						}

						model.setProperty(propertyName, collection);
					}
					else if (propertyValue is JValue) {
						JValue jValue = (JValue) propertyValue;
						string type = "";
						
						if (jValue.Value != null)
						{
							type = jValue.Value.GetType().ToString();
						}

						switch (type)
						{
							case "System.Int16":
								model.setProperty (propertyName, Convert.ToInt16(propertyValue));
								break;
							case "System.Int32":
								model.setProperty (propertyName, Convert.ToInt32(propertyValue));
								break;
							case "System.Int64":
								model.setProperty (propertyName, Convert.ToInt64(propertyValue));
								break;
							default:
								model.setProperty (propertyName, propertyValue.ToString());
								break;
						}
					}
					break;
				}
			
			}

			return model;
		}

		public JObject extractArray (ModelBase model, bool abbreviate = false)
		{
			JObject representation = new JObject();

		    representation["entityType"] = model.getResourceType();
		    if(model.getResourceUrl() != null)
		    {
		        representation["href"] = model.getResourceUrl();
		    }

			if (!abbreviate)
			{
			    Hashtable properties = model.getProperties();
			    foreach(DictionaryEntry de in properties)
			    {
			        if(de.Value is ModelBase)
			        {
			            ModelBase relatedModel = (ModelBase) de.Value;
			            representation[de.Key] = this.extractArray(relatedModel);
			        }
			        else if(de.Value is DateTime)
			        {
                        JObject jDateTime=new JObject();
			            jDateTime["entityType"] = "date";
                        DateTime date = (DateTime)de.Value;
                        string sDate = date.ToString("yyyy-MM-dd HH:mm:ss");
			            jDateTime["date"] = sDate;
                        //Hashtable htDate = new Hashtable();
                        //htDate.Add("entityType", "date");
                        //DateTime date = (DateTime) de.Value;
                        //string sDate = date.ToString("yyyy-MM-dd HH:mm:ss");
                        //htDate.Add("date", sDate);
                        //string serializedDateTimeHashTable=JsonConvert.SerializeObject(htDate,Formatting.Indented);
                        representation[de.Key] = jDateTime;
			        }
			        else if(de.Value is ModelCollection<ModelBase>)
			        {
			            //This must be a navigation property which holds a collection of related objects
						ModelCollection<ModelBase> propertyValue = (ModelCollection<ModelBase>) de.Value;

						JArray jr = new JArray();
			            foreach(ModelBase relatedModel in propertyValue)
			            {
							jr.Add(this.extractArray(relatedModel));
			            }
						representation[de.Key] = jr;
			        }
			        else
			        {
			            representation[de.Key] = JsonConvert.SerializeObject(de.Value);
			        }
			    }
			}

		    return representation;
		}
	}
}

