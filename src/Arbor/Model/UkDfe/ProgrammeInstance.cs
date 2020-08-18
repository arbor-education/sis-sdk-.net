using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class ProgrammeInstance : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PROGRAMME_INSTANCE;
        public const string PARTNER_UKPRN = "partnerUkprn";

        public ProgrammeInstance ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgrammeInstance (string resourceType = "ProgrammeInstance", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgrammeInstance> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ProgrammeInstance");
        	RestGateway gateway = (RestGateway) ProgrammeInstance.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgrammeInstance> programmeinstanceCollection = new ModelCollection<ProgrammeInstance> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    programmeinstanceCollection.add((ProgrammeInstance) model);
        	}
        
        	return programmeinstanceCollection;
        }

        public static ProgrammeInstance retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgrammeInstance.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgrammeInstance) gateway.retrieve(ResourceType.UK_DFE_PROGRAMME_INSTANCE, id);
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

