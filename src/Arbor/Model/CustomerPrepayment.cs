using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerPrepayment : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOMER_PREPAYMENT;
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string BILL_PAYER = "billPayer";
        public const string INCOMING_DIRECT_DEBIT_TRANSACTION = "incomingDirectDebitTransaction";
        public const string INCOMING_CARD_TRANSACTION = "incomingCardTransaction";
        public const string INCOMING_BANK_TRANSACTION = "incomingBankTransaction";
        public const string RECEIVED_CHEQUE = "receivedCheque";
        public const string CASH_RECEIPT = "cashReceipt";
        public const string PREPAYMENT_AMOUNT = "prepaymentAmount";
        public const string PREPAYMENT_DATETIME = "prepaymentDatetime";
        public const string PREPAYMENT_SUCCEEDED_DATETIME = "prepaymentSucceededDatetime";
        public const string PREPAYMENT_FAILED_DATETIME = "prepaymentFailedDatetime";
        public const string NARRATIVE = "narrative";
        public const string PREPAYMENT_CANCELLED_DATETIME = "prepaymentCancelledDatetime";

        public CustomerPrepayment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerPrepayment (string resourceType = "CustomerPrepayment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerPrepayment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomerPrepayment");
        	RestGateway gateway = (RestGateway) CustomerPrepayment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerPrepayment> customerprepaymentCollection = new ModelCollection<CustomerPrepayment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customerprepaymentCollection.add((CustomerPrepayment) model);
        	}
        
        	return customerprepaymentCollection;
        }

        public static CustomerPrepayment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerPrepayment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerPrepayment) gateway.retrieve(ResourceType.CUSTOMER_PREPAYMENT, id);
        }

        public CustomerAccount getCustomerAccount ()
        {
            return (CustomerAccount) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public BillPayer getBillPayer ()
        {
            return (BillPayer) this.getProperty("billPayer");
        }

        public void setBillPayer (BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public IncomingDirectDebitTransaction getIncomingDirectDebitTransaction ()
        {
            return (IncomingDirectDebitTransaction) this.getProperty("incomingDirectDebitTransaction");
        }

        public void setIncomingDirectDebitTransaction (IncomingDirectDebitTransaction incomingDirectDebitTransaction)
        {
            this.setProperty("incomingDirectDebitTransaction", incomingDirectDebitTransaction);
        }

        public IncomingCardTransaction getIncomingCardTransaction ()
        {
            return (IncomingCardTransaction) this.getProperty("incomingCardTransaction");
        }

        public void setIncomingCardTransaction (IncomingCardTransaction incomingCardTransaction)
        {
            this.setProperty("incomingCardTransaction", incomingCardTransaction);
        }

        public IncomingBankTransaction getIncomingBankTransaction ()
        {
            return (IncomingBankTransaction) this.getProperty("incomingBankTransaction");
        }

        public void setIncomingBankTransaction (IncomingBankTransaction incomingBankTransaction)
        {
            this.setProperty("incomingBankTransaction", incomingBankTransaction);
        }

        public ReceivedCheque getReceivedCheque ()
        {
            return (ReceivedCheque) this.getProperty("receivedCheque");
        }

        public void setReceivedCheque (ReceivedCheque receivedCheque)
        {
            this.setProperty("receivedCheque", receivedCheque);
        }

        public CashReceipt getCashReceipt ()
        {
            return (CashReceipt) this.getProperty("cashReceipt");
        }

        public void setCashReceipt (CashReceipt cashReceipt)
        {
            this.setProperty("cashReceipt", cashReceipt);
        }

        public string getPrepaymentAmount ()
        {
            return this.getProperty("prepaymentAmount").ToString();
        }

        public void setPrepaymentAmount (string prepaymentAmount)
        {
            this.setProperty("prepaymentAmount", prepaymentAmount);
        }

        public DateTime getPrepaymentDatetime ()
        {
            return (DateTime) this.getProperty("prepaymentDatetime");
        }

        public void setPrepaymentDatetime (DateTime prepaymentDatetime)
        {
            this.setProperty("prepaymentDatetime", prepaymentDatetime);
        }

        public DateTime getPrepaymentSucceededDatetime ()
        {
            return (DateTime) this.getProperty("prepaymentSucceededDatetime");
        }

        public void setPrepaymentSucceededDatetime (DateTime prepaymentSucceededDatetime)
        {
            this.setProperty("prepaymentSucceededDatetime", prepaymentSucceededDatetime);
        }

        public DateTime getPrepaymentFailedDatetime ()
        {
            return (DateTime) this.getProperty("prepaymentFailedDatetime");
        }

        public void setPrepaymentFailedDatetime (DateTime prepaymentFailedDatetime)
        {
            this.setProperty("prepaymentFailedDatetime", prepaymentFailedDatetime);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getPrepaymentCancelledDatetime ()
        {
            return (DateTime) this.getProperty("prepaymentCancelledDatetime");
        }

        public void setPrepaymentCancelledDatetime (DateTime prepaymentCancelledDatetime)
        {
            this.setProperty("prepaymentCancelledDatetime", prepaymentCancelledDatetime);
        }


    }
}

