using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_ProgrammeInstance : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PROGRAMME_INSTANCE;
        public const string PARTNER_UKPRN = "partnerUkprn";

        public UkDfe_ProgrammeInstance ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_ProgrammeInstance (string resourceType = "UkDfe_ProgrammeInstance", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_ProgrammeInstance> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ProgrammeInstance");
        	RestGateway gateway = (RestGateway) UkDfe_ProgrammeInstance.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_ProgrammeInstance> ukdfe_programmeinstanceCollection = new ModelCollection<UkDfe_ProgrammeInstance> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_programmeinstanceCollection.add((UkDfe_ProgrammeInstance) model);
        	}
        
        	return ukdfe_programmeinstanceCollection;
        }

        public static UkDfe_ProgrammeInstance retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_ProgrammeInstance.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_ProgrammeInstance) gateway.retrieve(ResourceType.UK_DFE_PROGRAMME_INSTANCE, id);
        }

        public string getPartnerUkprn ()
        {
            return this.getProperty("partnerUkprn").ToString();
        }

        public void setPartnerUkprn (string partnerUkprn)
        {
            this.setProperty("partnerUkprn", partnerUkprn);
        }


    }
}

