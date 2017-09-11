using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IncomingDirectDebitTransaction : ModelBase
    {
        protected string resourceType = ResourceType.INCOMING_DIRECT_DEBIT_TRANSACTION;
        public const string INCOMING_DIRECT_DEBIT_AGREEMENT = "incomingDirectDebitAgreement";
        public const string PAYMENT_PROVIDER_PAYOUT = "paymentProviderPayout";
        public const string PAYMENT_PROVIDER_TRANSACTION_IDENTIFIER = "paymentProviderTransactionIdentifier";
        public const string TRANSACTION_NET_AMOUNT = "transactionNetAmount";
        public const string TRANSACTION_FEE = "transactionFee";
        public const string TRANSACTION_REFERENCE = "transactionReference";
        public const string TRANSACTION_INITIATED_DATETIME = "transactionInitiatedDatetime";
        public const string TRANSACTION_SUCCEEDED_DATETIME = "transactionSucceededDatetime";
        public const string TRANSACTION_FAILED_DATETIME = "transactionFailedDatetime";
        public const string TRANSACTION_REFUNDED_DATETIME = "transactionRefundedDatetime";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string CUSTOMER_NOTIFICATION_DATETIME = "customerNotificationDatetime";

        public IncomingDirectDebitTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IncomingDirectDebitTransaction (string resourceType = "IncomingDirectDebitTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IncomingDirectDebitTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("IncomingDirectDebitTransaction");
        	RestGateway gateway = (RestGateway) IncomingDirectDebitTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IncomingDirectDebitTransaction> incomingdirectdebittransactionCollection = new ModelCollection<IncomingDirectDebitTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    incomingdirectdebittransactionCollection.add((IncomingDirectDebitTransaction) model);
        	}
        
        	return incomingdirectdebittransactionCollection;
        }

        public static IncomingDirectDebitTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IncomingDirectDebitTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IncomingDirectDebitTransaction) gateway.retrieve(ResourceType.INCOMING_DIRECT_DEBIT_TRANSACTION, id);
        }

        public IncomingDirectDebitAgreement getIncomingDirectDebitAgreement ()
        {
            return (IncomingDirectDebitAgreement) this.getProperty("incomingDirectDebitAgreement");
        }

        public void setIncomingDirectDebitAgreement (IncomingDirectDebitAgreement incomingDirectDebitAgreement)
        {
            this.setProperty("incomingDirectDebitAgreement", incomingDirectDebitAgreement);
        }

        public PaymentProviderPayout getPaymentProviderPayout ()
        {
            return (PaymentProviderPayout) this.getProperty("paymentProviderPayout");
        }

        public void setPaymentProviderPayout (PaymentProviderPayout paymentProviderPayout)
        {
            this.setProperty("paymentProviderPayout", paymentProviderPayout);
        }

        public string getPaymentProviderTransactionIdentifier ()
        {
            return this.getProperty("paymentProviderTransactionIdentifier").ToString();
        }

        public void setPaymentProviderTransactionIdentifier (string paymentProviderTransactionIdentifier)
        {
            this.setProperty("paymentProviderTransactionIdentifier", paymentProviderTransactionIdentifier);
        }

        public string getTransactionNetAmount ()
        {
            return this.getProperty("transactionNetAmount").ToString();
        }

        public void setTransactionNetAmount (string transactionNetAmount)
        {
            this.setProperty("transactionNetAmount", transactionNetAmount);
        }

        public string getTransactionFee ()
        {
            return this.getProperty("transactionFee").ToString();
        }

        public void setTransactionFee (string transactionFee)
        {
            this.setProperty("transactionFee", transactionFee);
        }

        public string getTransactionReference ()
        {
            return this.getProperty("transactionReference").ToString();
        }

        public void setTransactionReference (string transactionReference)
        {
            this.setProperty("transactionReference", transactionReference);
        }

        public DateTime getTransactionInitiatedDatetime ()
        {
            return (DateTime) this.getProperty("transactionInitiatedDatetime");
        }

        public void setTransactionInitiatedDatetime (DateTime transactionInitiatedDatetime)
        {
            this.setProperty("transactionInitiatedDatetime", transactionInitiatedDatetime);
        }

        public DateTime getTransactionSucceededDatetime ()
        {
            return (DateTime) this.getProperty("transactionSucceededDatetime");
        }

        public void setTransactionSucceededDatetime (DateTime transactionSucceededDatetime)
        {
            this.setProperty("transactionSucceededDatetime", transactionSucceededDatetime);
        }

        public DateTime getTransactionFailedDatetime ()
        {
            return (DateTime) this.getProperty("transactionFailedDatetime");
        }

        public void setTransactionFailedDatetime (DateTime transactionFailedDatetime)
        {
            this.setProperty("transactionFailedDatetime", transactionFailedDatetime);
        }

        public DateTime getTransactionRefundedDatetime ()
        {
            return (DateTime) this.getProperty("transactionRefundedDatetime");
        }

        public void setTransactionRefundedDatetime (DateTime transactionRefundedDatetime)
        {
            this.setProperty("transactionRefundedDatetime", transactionRefundedDatetime);
        }

        public DateTime getCancelledDatetime ()
        {
            return (DateTime) this.getProperty("cancelledDatetime");
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public DateTime getCustomerNotificationDatetime ()
        {
            return (DateTime) this.getProperty("customerNotificationDatetime");
        }

        public void setCustomerNotificationDatetime (DateTime customerNotificationDatetime)
        {
            this.setProperty("customerNotificationDatetime", customerNotificationDatetime);
        }


    }
}

