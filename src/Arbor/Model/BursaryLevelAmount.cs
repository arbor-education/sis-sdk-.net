using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryLevelAmount : ModelBase
    {
        protected new string resourceType = ResourceType.BURSARY_LEVEL_AMOUNT;
        public const string BURSARY_LEVEL = "bursaryLevel";
        public const string AMOUNT = "amount";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public BursaryLevelAmount ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BursaryLevelAmount (string resourceType = "BursaryLevelAmount", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BursaryLevelAmount> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BursaryLevelAmount");
        	RestGateway gateway = (RestGateway) BursaryLevelAmount.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BursaryLevelAmount> bursarylevelamountCollection = new ModelCollection<BursaryLevelAmount> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bursarylevelamountCollection.add((BursaryLevelAmount) model);
        	}
        
        	return bursarylevelamountCollection;
        }

        public static BursaryLevelAmount retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BursaryLevelAmount.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BursaryLevelAmount) gateway.retrieve(ResourceType.BURSARY_LEVEL_AMOUNT, id);
        }

        public BursaryLevel getBursaryLevel ()
        {
            return (BursaryLevel) this.getProperty("bursaryLevel");
        }

        public void setBursaryLevel (BursaryLevel bursaryLevel)
        {
            this.setProperty("bursaryLevel", bursaryLevel);
        }

        public string getAmount ()
        {
            return this.getProperty("amount").ToString();
        }

        public void setAmount (string amount)
        {
            this.setProperty("amount", amount);
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

