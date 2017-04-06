using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CashReceipt : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CASH_RECEIPT;
        public const string BILL_PAYER = "billPayer";
        public const string BANK_DEPOSIT = "bankDeposit";
        public const string RECEIVED_DATE = "receivedDate";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string RECEIVED_PAYMENT = "receivedPayment";

        public CashReceipt ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CashReceipt (string resourceType = "CashReceipt", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CashReceipt> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_CashReceipt");
        	RestGateway gateway = (RestGateway) CashReceipt.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CashReceipt> cashreceiptCollection = new ModelCollection<CashReceipt> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    cashreceiptCollection.add((CashReceipt) model);
        	}
        
        	return cashreceiptCollection;
        }

        public static CashReceipt retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CashReceipt.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CashReceipt) gateway.retrieve(ResourceType.FINANCE_CASH_RECEIPT, id);
        }

        public ModelBase getBillPayer ()
        {
            return (ModelBase) this.getProperty("billPayer");
        }

        public void setBillPayer (ModelBase billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public ModelBase getBankDeposit ()
        {
            return (ModelBase) this.getProperty("bankDeposit");
        }

        public void setBankDeposit (ModelBase bankDeposit)
        {
            this.setProperty("bankDeposit", bankDeposit);
        }

        public DateTime getReceivedDate ()
        {
            return (DateTime) this.getProperty("receivedDate");
        }

        public void setReceivedDate (DateTime receivedDate)
        {
            this.setProperty("receivedDate", receivedDate);
        }

        public DateTime getCancelledDatetime ()
        {
            return (DateTime) this.getProperty("cancelledDatetime");
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public string getReceivedPayment ()
        {
            return this.getProperty("receivedPayment").ToString();
        }

        public void setReceivedPayment (string receivedPayment)
        {
            this.setProperty("receivedPayment", receivedPayment);
        }


    }
}

