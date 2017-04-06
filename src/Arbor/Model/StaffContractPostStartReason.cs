using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContractPostStartReason : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT_POST_START_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";

        public StaffContractPostStartReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffContractPostStartReason (string resourceType = "StaffContractPostStartReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffContractPostStartReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffContractPostStartReason");
        	RestGateway gateway = (RestGateway) StaffContractPostStartReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffContractPostStartReason> staffcontractpoststartreasonCollection = new ModelCollection<StaffContractPostStartReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffcontractpoststartreasonCollection.add((StaffContractPostStartReason) model);
        	}
        
        	return staffcontractpoststartreasonCollection;
        }

        public static StaffContractPostStartReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffContractPostStartReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffContractPostStartReason) gateway.retrieve(ResourceType.STAFF_CONTRACT_POST_START_REASON, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

