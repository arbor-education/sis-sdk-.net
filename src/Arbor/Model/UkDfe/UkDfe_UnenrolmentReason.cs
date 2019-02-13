using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_UnenrolmentReason : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_UNENROLMENT_REASON;
        public const string D00206 = "d00206";

        public UkDfe_UnenrolmentReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_UnenrolmentReason (string resourceType = "UkDfe_UnenrolmentReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_UnenrolmentReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_UnenrolmentReason");
        	RestGateway gateway = (RestGateway) UkDfe_UnenrolmentReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_UnenrolmentReason> ukdfe_unenrolmentreasonCollection = new ModelCollection<UkDfe_UnenrolmentReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_unenrolmentreasonCollection.add((UkDfe_UnenrolmentReason) model);
        	}
        
        	return ukdfe_unenrolmentreasonCollection;
        }

        public static UkDfe_UnenrolmentReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_UnenrolmentReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_UnenrolmentReason) gateway.retrieve(ResourceType.UK_DFE_UNENROLMENT_REASON, id);
        }

        public string getD00206 ()
        {
            return this.getProperty("d00206").ToString();
        }

        public void setD00206 (string d00206)
        {
            this.setProperty("d00206", d00206);
        }


    }
}

