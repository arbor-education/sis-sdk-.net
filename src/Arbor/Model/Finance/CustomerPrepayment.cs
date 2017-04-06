using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CustomerPrepayment : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CUSTOMER_PREPAYMENT;
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string BILL_PAYER = "billPayer";
        public const string SOURCE_LEDGER = "sourceLedger";
        public const string DESTINATION_LEDGER = "destinationLedger";
        public const string INCOMING_DIRECT_DEBIT_TRANSACTION = "incomingDirectDebitTransaction";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
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
        	query.setResourceType ("Finance_CustomerPrepayment");
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
        	return (CustomerPrepayment) gateway.retrieve(ResourceType.FINANCE_CUSTOMER_PREPAYMENT, id);
        }

        public ModelBase getCustomerAccount ()
        {
            return (ModelBase) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (ModelBase customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public ModelBase getBillPayer ()
        {
            return (ModelBase) this.getProperty("billPayer");
        }

        public void setBillPayer (ModelBase billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public ModelBase getSourceLedger ()
        {
            return (ModelBase) this.getProperty("sourceLedger");
        }

        public void setSourceLedger (ModelBase sourceLedger)
        {
            this.setProperty("sourceLedger", sourceLedger);
        }

        public ModelBase getDestinationLedger ()
        {
            return (ModelBase) this.getProperty("destinationLedger");
        }

        public void setDestinationLedger (ModelBase destinationLedger)
        {
            this.setProperty("destinationLedger", destinationLedger);
        }

        public ModelBase getIncomingDirectDebitTransaction ()
        {
            return (ModelBase) this.getProperty("incomingDirectDebitTransaction");
        }

        public void setIncomingDirectDebitTransaction (ModelBase incomingDirectDebitTransaction)
        {
            this.setProperty("incomingDirectDebitTransaction", incomingDirectDebitTransaction);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public ModelBase getIncomingCardTransaction ()
        {
            return (ModelBase) this.getProperty("incomingCardTransaction");
        }

        public void setIncomingCardTransaction (ModelBase incomingCardTransaction)
        {
            this.setProperty("incomingCardTransaction", incomingCardTransaction);
        }

        public ModelBase getIncomingBankTransaction ()
        {
            return (ModelBase) this.getProperty("incomingBankTransaction");
        }

        public void setIncomingBankTransaction (ModelBase incomingBankTransaction)
        {
            this.setProperty("incomingBankTransaction", incomingBankTransaction);
        }

        public ModelBase getReceivedCheque ()
        {
            return (ModelBase) this.getProperty("receivedCheque");
        }

        public void setReceivedCheque (ModelBase receivedCheque)
        {
            this.setProperty("receivedCheque", receivedCheque);
        }

        public ModelBase getCashReceipt ()
        {
            return (ModelBase) this.getProperty("cashReceipt");
        }

        public void setCashReceipt (ModelBase cashReceipt)
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

