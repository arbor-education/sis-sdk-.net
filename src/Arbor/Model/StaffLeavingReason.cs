using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffLeavingReason : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_LEAVING_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";

        public StaffLeavingReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffLeavingReason (string resourceType = "StaffLeavingReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffLeavingReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffLeavingReason");
        	RestGateway gateway = (RestGateway) StaffLeavingReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffLeavingReason> staffleavingreasonCollection = new ModelCollection<StaffLeavingReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffleavingreasonCollection.add((StaffLeavingReason) model);
        	}
        
        	return staffleavingreasonCollection;
        }

        public static StaffLeavingReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffLeavingReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffLeavingReason) gateway.retrieve(ResourceType.STAFF_LEAVING_REASON, id);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

