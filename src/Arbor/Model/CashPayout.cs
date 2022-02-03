using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CashPayout : ModelBase
    {
        protected string resourceType = ResourceType.CASH_PAYOUT;
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string PAYOUT_DATETIME = "payoutDatetime";
        public const string PAYOUT = "payout";
        public const string NARRATIVE = "narrative";

        public CashPayout ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CashPayout (string resourceType = "CashPayout", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CashPayout> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CashPayout");
        	RestGateway gateway = (RestGateway) CashPayout.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CashPayout> cashpayoutCollection = new ModelCollection<CashPayout> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    cashpayoutCollection.add((CashPayout) model);
        	}
        
        	return cashpayoutCollection;
        }

        public static CashPayout retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CashPayout.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CashPayout) gateway.retrieve(ResourceType.CASH_PAYOUT, id);
        }

        public CustomerAccount getCustomerAccount ()
        {
            return (CustomerAccount) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public DateTime getPayoutDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("payoutDatetime"));
        }

        public void setPayoutDatetime (DateTime payoutDatetime)
        {
            this.setProperty("payoutDatetime", payoutDatetime);
        }

        public string getPayout ()
        {
            return this.getProperty("payout").ToString();
        }

        public void setPayout (string payout)
        {
            this.setProperty("payout", payout);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

