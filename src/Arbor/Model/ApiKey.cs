using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ApiKey : ModelBase
    {
        protected string resourceType = ResourceType.API_KEY;
        public const string USER = "user";
        public const string API_KEY = "apiKey";
        public const string ISSUED_DATETIME = "issuedDatetime";
        public const string REVOKED_DATETIME = "revokedDatetime";

        public ApiKey ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ApiKey (string resourceType = "ApiKey", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ApiKey> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ApiKey");
        	RestGateway gateway = (RestGateway) ApiKey.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ApiKey> apikeyCollection = new ModelCollection<ApiKey> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    apikeyCollection.add((ApiKey) model);
        	}
        
        	return apikeyCollection;
        }

        public static ApiKey retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ApiKey.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ApiKey) gateway.retrieve(ResourceType.API_KEY, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public string getApiKey ()
        {
            return this.getProperty("apiKey").ToString();
        }

        public void setApiKey (string apiKey)
        {
            this.setProperty("apiKey", apiKey);
        }

        public DateTime getIssuedDatetime ()
        {
            Convert.ToDateTime(this.getProperty("issuedDatetime"))
        }

        public void setIssuedDatetime (DateTime issuedDatetime)
        {
            this.setProperty("issuedDatetime", issuedDatetime);
        }

        public DateTime getRevokedDatetime ()
        {
            Convert.ToDateTime(this.getProperty("revokedDatetime"))
        }

        public void setRevokedDatetime (DateTime revokedDatetime)
        {
            this.setProperty("revokedDatetime", revokedDatetime);
        }


    }
}

