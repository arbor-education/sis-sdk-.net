using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class ReceivedCheque : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_RECEIVED_CHEQUE;
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
        	query.setResourceType ("Finance_ReceivedCheque");
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
        	return (ReceivedCheque) gateway.retrieve(ResourceType.FINANCE_RECEIVED_CHEQUE, id);
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

