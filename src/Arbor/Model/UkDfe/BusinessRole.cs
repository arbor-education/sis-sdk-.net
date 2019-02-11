using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class BusinessRole : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_BUSINESS_ROLE;
        public const string SWF_CENSUS_IDENTIFIER = "swfCensusIdentifier";
        public const string MANAGED_BY_CLIENT = "managedByClient";

        public BusinessRole ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BusinessRole (string resourceType = "BusinessRole", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BusinessRole> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_BusinessRole");
        	RestGateway gateway = (RestGateway) BusinessRole.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BusinessRole> businessroleCollection = new ModelCollection<BusinessRole> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    businessroleCollection.add((BusinessRole) model);
        	}
        
        	return businessroleCollection;
        }

        public static BusinessRole retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BusinessRole.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BusinessRole) gateway.retrieve(ResourceType.UK_DFE_BUSINESS_ROLE, id);
        }

        public string getSwfCensusIdentifier ()
        {
            return this.getProperty("swfCensusIdentifier").ToString();
        }

        public void setSwfCensusIdentifier (string swfCensusIdentifier)
        {
            this.setProperty("swfCensusIdentifier", swfCensusIdentifier);
        }

        public bool getManagedByClient ()
        {
            return Convert.ToBoolean( this.getProperty("managedByClient"));
        }

        public void setManagedByClient (bool managedByClient)
        {
            this.setProperty("managedByClient", managedByClient);
        }


    }
}

