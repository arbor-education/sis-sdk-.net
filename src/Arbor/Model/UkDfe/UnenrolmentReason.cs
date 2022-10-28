using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UnenrolmentReason : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_UNENROLMENT_REASON;
        public const string D00206 = "d00206";

        public UnenrolmentReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UnenrolmentReason (string resourceType = "UnenrolmentReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UnenrolmentReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_UnenrolmentReason");
        	RestGateway gateway = (RestGateway) UnenrolmentReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UnenrolmentReason> unenrolmentreasonCollection = new ModelCollection<UnenrolmentReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    unenrolmentreasonCollection.add((UnenrolmentReason) model);
        	}
        
        	return unenrolmentreasonCollection;
        }

        public static UnenrolmentReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UnenrolmentReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UnenrolmentReason) gateway.retrieve(ResourceType.UK_DFE_UNENROLMENT_REASON, id);
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

