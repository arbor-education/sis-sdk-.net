using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IncomingBankTransaction : ModelBase
    {
        protected new string resourceType = ResourceType.INCOMING_BANK_TRANSACTION;
        public const string BILL_PAYER = "billPayer";
        public const string RECEIVED_DATE = "receivedDate";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string PAYMENT = "payment";

        public IncomingBankTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IncomingBankTransaction (string resourceType = "IncomingBankTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IncomingBankTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("IncomingBankTransaction");
        	RestGateway gateway = (RestGateway) IncomingBankTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IncomingBankTransaction> incomingbanktransactionCollection = new ModelCollection<IncomingBankTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    incomingbanktransactionCollection.add((IncomingBankTransaction) model);
        	}
        
        	return incomingbanktransactionCollection;
        }

        public static IncomingBankTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IncomingBankTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IncomingBankTransaction) gateway.retrieve(ResourceType.INCOMING_BANK_TRANSACTION, id);
        }

        public BillPayer getBillPayer ()
        {
            return (BillPayer) this.getProperty("billPayer");
        }

        public void setBillPayer (BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public DateTime getReceivedDate ()
        {
            return Convert.ToDateTime(this.getProperty("receivedDate"));
        }

        public void setReceivedDate (DateTime receivedDate)
        {
            this.setProperty("receivedDate", receivedDate);
        }

        public DateTime getCancelledDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("cancelledDatetime"));
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public string getPayment ()
        {
            return this.getProperty("payment").ToString();
        }

        public void setPayment (string payment)
        {
            this.setProperty("payment", payment);
        }


    }
}

