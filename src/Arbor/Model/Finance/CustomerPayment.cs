using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CustomerPayment : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CUSTOMER_PAYMENT;
        public const string BILL_PAYER = "billPayer";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string INCOMING_DIRECT_DEBIT_TRANSACTION = "incomingDirectDebitTransaction";
        public const string INCOMING_BANK_TRANSACTION = "incomingBankTransaction";
        public const string INCOMING_CARD_TRANSACTION = "incomingCardTransaction";
        public const string CUSTOMER_PREPAYMENT = "customerPrepayment";
        public const string RECEIVED_CHEQUE = "receivedCheque";
        public const string CASH_RECEIPT = "cashReceipt";
        public const string PAYMENT_METHOD = "paymentMethod";
        public const string PAYMENT_DATETIME = "paymentDatetime";
        public const string PAYMENT_SUCCEEDED_DATETIME = "paymentSucceededDatetime";
        public const string PAYMENT_FAILED_DATETIME = "paymentFailedDatetime";
        public const string TOTAL_PAYMENT = "totalPayment";
        public const string MATCHED_PAYMENT = "matchedPayment";
        public const string UNMATCHED_PAYMENT = "unmatchedPayment";

        public CustomerPayment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerPayment (string resourceType = "CustomerPayment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerPayment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_CustomerPayment");
        	RestGateway gateway = (RestGateway) CustomerPayment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerPayment> customerpaymentCollection = new ModelCollection<CustomerPayment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customerpaymentCollection.add((CustomerPayment) model);
        	}
        
        	return customerpaymentCollection;
        }

        public static CustomerPayment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerPayment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerPayment) gateway.retrieve(ResourceType.FINANCE_CUSTOMER_PAYMENT, id);
        }

        public ModelBase getBillPayer ()
        {
            return (ModelBase) this.getProperty("billPayer");
        }

        public void setBillPayer (ModelBase billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public ModelBase getIncomingDirectDebitTransaction ()
        {
            return (ModelBase) this.getProperty("incomingDirectDebitTransaction");
        }

        public void setIncomingDirectDebitTransaction (ModelBase incomingDirectDebitTransaction)
        {
            this.setProperty("incomingDirectDebitTransaction", incomingDirectDebitTransaction);
        }

        public ModelBase getIncomingBankTransaction ()
        {
            return (ModelBase) this.getProperty("incomingBankTransaction");
        }

        public void setIncomingBankTransaction (ModelBase incomingBankTransaction)
        {
            this.setProperty("incomingBankTransaction", incomingBankTransaction);
        }

        public ModelBase getIncomingCardTransaction ()
        {
            return (ModelBase) this.getProperty("incomingCardTransaction");
        }

        public void setIncomingCardTransaction (ModelBase incomingCardTransaction)
        {
            this.setProperty("incomingCardTransaction", incomingCardTransaction);
        }

        public ModelBase getCustomerPrepayment ()
        {
            return (ModelBase) this.getProperty("customerPrepayment");
        }

        public void setCustomerPrepayment (ModelBase customerPrepayment)
        {
            this.setProperty("customerPrepayment", customerPrepayment);
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

        public string getPaymentMethod ()
        {
            return this.getProperty("paymentMethod").ToString();
        }

        public void setPaymentMethod (string paymentMethod)
        {
            this.setProperty("paymentMethod", paymentMethod);
        }

        public DateTime getPaymentDatetime ()
        {
            return (DateTime) this.getProperty("paymentDatetime");
        }

        public void setPaymentDatetime (DateTime paymentDatetime)
        {
            this.setProperty("paymentDatetime", paymentDatetime);
        }

        public DateTime getPaymentSucceededDatetime ()
        {
            return (DateTime) this.getProperty("paymentSucceededDatetime");
        }

        public void setPaymentSucceededDatetime (DateTime paymentSucceededDatetime)
        {
            this.setProperty("paymentSucceededDatetime", paymentSucceededDatetime);
        }

        public DateTime getPaymentFailedDatetime ()
        {
            return (DateTime) this.getProperty("paymentFailedDatetime");
        }

        public void setPaymentFailedDatetime (DateTime paymentFailedDatetime)
        {
            this.setProperty("paymentFailedDatetime", paymentFailedDatetime);
        }

        public string getTotalPayment ()
        {
            return this.getProperty("totalPayment").ToString();
        }

        public void setTotalPayment (string totalPayment)
        {
            this.setProperty("totalPayment", totalPayment);
        }

        public string getMatchedPayment ()
        {
            return this.getProperty("matchedPayment").ToString();
        }

        public void setMatchedPayment (string matchedPayment)
        {
            this.setProperty("matchedPayment", matchedPayment);
        }

        public string getUnmatchedPayment ()
        {
            return this.getProperty("unmatchedPayment").ToString();
        }

        public void setUnmatchedPayment (string unmatchedPayment)
        {
            this.setProperty("unmatchedPayment", unmatchedPayment);
        }


    }
}

