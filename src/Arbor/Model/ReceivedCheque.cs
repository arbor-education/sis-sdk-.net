using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReceivedCheque : ModelBase
    {
        protected string resourceType = ResourceType.RECEIVED_CHEQUE;
        public const string BILL_PAYER = "billPayer";
        public const string BANK_DEPOSIT = "bankDeposit";
        public const string RECEIVED_DATE = "receivedDate";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string CHEQUE_AMOUNT = "chequeAmount";

        public ReceivedCheque ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReceivedCheque (string resourceType = "ReceivedCheque", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReceivedCheque> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReceivedCheque");
        	RestGateway gateway = (RestGateway) ReceivedCheque.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReceivedCheque> receivedchequeCollection = new ModelCollection<ReceivedCheque> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    receivedchequeCollection.add((ReceivedCheque) model);
        	}
        
        	return receivedchequeCollection;
        }

        public static ReceivedCheque retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReceivedCheque.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReceivedCheque) gateway.retrieve(ResourceType.RECEIVED_CHEQUE, id);
        }

        public BillPayer getBillPayer ()
        {
            return (BillPayer) this.getProperty("billPayer");
        }

        public void setBillPayer (BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public BankDeposit getBankDeposit ()
        {
            return (BankDeposit) this.getProperty("bankDeposit");
        }

        public void setBankDeposit (BankDeposit bankDeposit)
        {
            this.setProperty("bankDeposit", bankDeposit);
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

        public string getChequeAmount ()
        {
            return this.getProperty("chequeAmount").ToString();
        }

        public void setChequeAmount (string chequeAmount)
        {
            this.setProperty("chequeAmount", chequeAmount);
        }


    }
}

