using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InCareStatus : ModelBase
    {
        protected string resourceType = ResourceType.IN_CARE_STATUS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string IN_CARE_STATUS_NAME = "inCareStatusName";
        public const string COUNTS_AS_IN_CARE_STATUS = "countsAsInCareStatus";

        public InCareStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InCareStatus (string resourceType = "InCareStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InCareStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InCareStatus");
        	RestGateway gateway = (RestGateway) InCareStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InCareStatus> incarestatusCollection = new ModelCollection<InCareStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    incarestatusCollection.add((InCareStatus) model);
        	}
        
        	return incarestatusCollection;
        }

        public static InCareStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InCareStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InCareStatus) gateway.retrieve(ResourceType.IN_CARE_STATUS, id);
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
            return Convert.ToBoolean(this.getProperty("active"))
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

        public string getInCareStatusName ()
        {
            return this.getProperty("inCareStatusName").ToString();
        }

        public void setInCareStatusName (string inCareStatusName)
        {
            this.setProperty("inCareStatusName", inCareStatusName);
        }

        public bool getCountsAsInCareStatus ()
        {
            return Convert.ToBoolean(this.getProperty("countsAsInCareStatus"))
        }

        public void setCountsAsInCareStatus (bool countsAsInCareStatus)
        {
            this.setProperty("countsAsInCareStatus", countsAsInCareStatus);
        }


    }
}

