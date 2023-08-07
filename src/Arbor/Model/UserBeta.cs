using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserBeta : ModelBase
    {
        protected new string resourceType = ResourceType.USER_BETA;
        public const string USER = "user";
        public const string IS_ELIGIBLE = "isEligible";
        public const string IS_ENABLED = "isEnabled";

        public UserBeta ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UserBeta (string resourceType = "UserBeta", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UserBeta> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UserBeta");
        	RestGateway gateway = (RestGateway) UserBeta.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UserBeta> userbetaCollection = new ModelCollection<UserBeta> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    userbetaCollection.add((UserBeta) model);
        	}
        
        	return userbetaCollection;
        }

        public static UserBeta retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UserBeta.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UserBeta) gateway.retrieve(ResourceType.USER_BETA, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public bool getIsEligible ()
        {
            return Convert.ToBoolean(this.getProperty("isEligible"));
        }

        public void setIsEligible (bool isEligible)
        {
            this.setProperty("isEligible", isEligible);
        }

        public bool getIsEnabled ()
        {
            return Convert.ToBoolean(this.getProperty("isEnabled"));
        }

        public void setIsEnabled (bool isEnabled)
        {
            this.setProperty("isEnabled", isEnabled);
        }


    }
}

