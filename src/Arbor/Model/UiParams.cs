using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UiParams : ModelBase
    {
        protected string resourceType = ResourceType.UI_PARAMS;
        public const string IDENTIFIER = "identifier";
        public const string PARAMS = "params";
        public const string HASH = "hash";
        public const string USER = "user";
        public const string SESSION_ID = "sessionId";
        public const string CREATED_DATETIME = "createdDatetime";
        public const string LAST_ACCESS_DATETIME = "lastAccessDatetime";

        public UiParams ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UiParams (string resourceType = "UiParams", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UiParams> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UiParams");
        	RestGateway gateway = (RestGateway) UiParams.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UiParams> uiparamsCollection = new ModelCollection<UiParams> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    uiparamsCollection.add((UiParams) model);
        	}
        
        	return uiparamsCollection;
        }

        public static UiParams retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UiParams.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UiParams) gateway.retrieve(ResourceType.UI_PARAMS, id);
        }

        public string getIdentifier ()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier (string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public string getParams ()
        {
            return this.getProperty("params").ToString();
        }

		public void setParams (string parameters)
        {
			this.setProperty("params", parameters);
        }

        public string getHash ()
        {
            return this.getProperty("hash").ToString();
        }

        public void setHash (string hash)
        {
            this.setProperty("hash", hash);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public string getSessionId ()
        {
            return this.getProperty("sessionId").ToString();
        }

        public void setSessionId (string sessionId)
        {
            this.setProperty("sessionId", sessionId);
        }

        public DateTime getCreatedDatetime ()
        {
            return (DateTime) this.getProperty("createdDatetime");
        }

        public void setCreatedDatetime (DateTime createdDatetime)
        {
            this.setProperty("createdDatetime", createdDatetime);
        }

        public DateTime getLastAccessDatetime ()
        {
            return (DateTime) this.getProperty("lastAccessDatetime");
        }

        public void setLastAccessDatetime (DateTime lastAccessDatetime)
        {
            this.setProperty("lastAccessDatetime", lastAccessDatetime);
        }


    }
}

