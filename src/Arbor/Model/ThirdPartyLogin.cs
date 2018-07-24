using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ThirdPartyLogin : ModelBase
    {
        protected string resourceType = ResourceType.THIRD_PARTY_LOGIN;
        public const string THIRD_PARTY_SITE = "thirdPartySite";
        public const string USERNAME = "username";
        public const string PASSWORD = "password";
        public const string VERIFIED_DATETIME = "verifiedDatetime";
        public const string FAILED_DATETIME = "failedDatetime";
        public const string PERSON = "person";

        public ThirdPartyLogin ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ThirdPartyLogin (string resourceType = "ThirdPartyLogin", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ThirdPartyLogin> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ThirdPartyLogin");
        	RestGateway gateway = (RestGateway) ThirdPartyLogin.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ThirdPartyLogin> thirdpartyloginCollection = new ModelCollection<ThirdPartyLogin> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    thirdpartyloginCollection.add((ThirdPartyLogin) model);
        	}
        
        	return thirdpartyloginCollection;
        }

        public static ThirdPartyLogin retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ThirdPartyLogin.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ThirdPartyLogin) gateway.retrieve(ResourceType.THIRD_PARTY_LOGIN, id);
        }

        public ThirdPartySite getThirdPartySite ()
        {
            return (ThirdPartySite) this.getProperty("thirdPartySite");
        }

        public void setThirdPartySite (ThirdPartySite thirdPartySite)
        {
            this.setProperty("thirdPartySite", thirdPartySite);
        }

        public string getUsername ()
        {
            return this.getProperty("username").ToString();
        }

        public void setUsername (string username)
        {
            this.setProperty("username", username);
        }

        public string getPassword ()
        {
            return this.getProperty("password").ToString();
        }

        public void setPassword (string password)
        {
            this.setProperty("password", password);
        }

        public DateTime getVerifiedDatetime (){
            return Convert.ToDateTime(this.getProperty("verifiedDatetime"));
        }

        public void setVerifiedDatetime (DateTime verifiedDatetime)
        {
            this.setProperty("verifiedDatetime", verifiedDatetime);
        }

        public DateTime getFailedDatetime (){
            return Convert.ToDateTime(this.getProperty("failedDatetime"));
        }

        public void setFailedDatetime (DateTime failedDatetime)
        {
            this.setProperty("failedDatetime", failedDatetime);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }


    }
}

