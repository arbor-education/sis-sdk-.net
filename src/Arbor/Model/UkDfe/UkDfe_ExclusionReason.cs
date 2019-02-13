using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_ExclusionReason : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_EXCLUSION_REASON;
        public const string D00024 = "d00024";

        public UkDfe_ExclusionReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_ExclusionReason (string resourceType = "UkDfe_ExclusionReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_ExclusionReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ExclusionReason");
        	RestGateway gateway = (RestGateway) UkDfe_ExclusionReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_ExclusionReason> ukdfe_exclusionreasonCollection = new ModelCollection<UkDfe_ExclusionReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_exclusionreasonCollection.add((UkDfe_ExclusionReason) model);
        	}
        
        	return ukdfe_exclusionreasonCollection;
        }

        public static UkDfe_ExclusionReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_ExclusionReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_ExclusionReason) gateway.retrieve(ResourceType.UK_DFE_EXCLUSION_REASON, id);
        }

        public string getD00024 ()
        {
            return this.getProperty("d00024").ToString();
        }

        public void setD00024 (string d00024)
        {
            this.setProperty("d00024", d00024);
        }


    }
}

