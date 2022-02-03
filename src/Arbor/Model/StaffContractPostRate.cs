using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContractPostRate : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT_POST_RATE;
        public const string STAFF_CONTRACT_POST = "staffContractPost";
        public const string RATE = "rate";
        public const string RATE_FREQUENCY = "rateFrequency";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public StaffContractPostRate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffContractPostRate (string resourceType = "StaffContractPostRate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffContractPostRate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffContractPostRate");
        	RestGateway gateway = (RestGateway) StaffContractPostRate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffContractPostRate> staffcontractpostrateCollection = new ModelCollection<StaffContractPostRate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffcontractpostrateCollection.add((StaffContractPostRate) model);
        	}
        
        	return staffcontractpostrateCollection;
        }

        public static StaffContractPostRate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffContractPostRate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffContractPostRate) gateway.retrieve(ResourceType.STAFF_CONTRACT_POST_RATE, id);
        }

        public StaffContractPost getStaffContractPost ()
        {
            return (StaffContractPost) this.getProperty("staffContractPost");
        }

        public void setStaffContractPost (StaffContractPost staffContractPost)
        {
            this.setProperty("staffContractPost", staffContractPost);
        }

        public string getRate ()
        {
            return this.getProperty("rate").ToString();
        }

        public void setRate (string rate)
        {
            this.setProperty("rate", rate);
        }

        public string getRateFrequency ()
        {
            return this.getProperty("rateFrequency").ToString();
        }

        public void setRateFrequency (string rateFrequency)
        {
            this.setProperty("rateFrequency", rateFrequency);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

