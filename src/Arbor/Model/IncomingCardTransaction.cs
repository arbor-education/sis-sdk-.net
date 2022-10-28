using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IncomingCardTransaction : ModelBase
    {
        protected new string resourceType = ResourceType.INCOMING_CARD_TRANSACTION;
        public const string BILL_PAYER = "billPayer";
        public const string PAYMENT_PROVIDER = "paymentProvider";
        public const string PAYMENT_PROVIDER_PAYOUT = "paymentProviderPayout";
        public const string PAYMENT_PROVIDER_TRANSACTION_IDENTIFIER = "paymentProviderTransactionIdentifier";
        public const string TRANSACTION_NET_AMOUNT = "transactionNetAmount";
        public const string TRANSACTION_FEE_AMOUNT = "transactionFeeAmount";
        public const string TRANSACTION_REFERENCE = "transactionReference";
        public const string TRANSACTION_INITIATED_DATETIME = "transactionInitiatedDatetime";
        public const string TRANSACTION_SUCCEEDED_DATETIME = "transactionSucceededDatetime";
        public const string TRANSACTION_FAILED_DATETIME = "transactionFailedDatetime";
        public const string TRANSACTION_REFUNDED_DATETIME = "transactionRefundedDatetime";
        public const string CARD_TOKEN_ID = "cardTokenId";
        public const string CANCELLED_DATETIME = "cancelledDatetime";

        public IncomingCardTransaction()
        {
            base.resourceType = this.resourceType;
        }

        public IncomingCardTransaction(string resourceType = "IncomingCardTransaction", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IncomingCardTransaction> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IncomingCardTransaction");
            RestGateway gateway = (RestGateway)IncomingCardTransaction.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IncomingCardTransaction> incomingcardtransactionCollection = new ModelCollection<IncomingCardTransaction>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                incomingcardtransactionCollection.add((IncomingCardTransaction)model);
            }

            return incomingcardtransactionCollection;
        }

        public static IncomingCardTransaction retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IncomingCardTransaction.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IncomingCardTransaction)gateway.retrieve(ResourceType.INCOMING_CARD_TRANSACTION, id);
        }

        public BillPayer getBillPayer()
        {
            return (BillPayer)this.getProperty("billPayer");
        }

        public void setBillPayer(BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public PaymentProvider getPaymentProvider()
        {
            return (PaymentProvider)this.getProperty("paymentProvider");
        }

        public void setPaymentProvider(PaymentProvider paymentProvider)
        {
            this.setProperty("paymentProvider", paymentProvider);
        }

        public PaymentProviderPayout getPaymentProviderPayout()
        {
            return (PaymentProviderPayout)this.getProperty("paymentProviderPayout");
        }

        public void setPaymentProviderPayout(PaymentProviderPayout paymentProviderPayout)
        {
            this.setProperty("paymentProviderPayout", paymentProviderPayout);
        }

        public string getPaymentProviderTransactionIdentifier()
        {
            return this.getProperty("paymentProviderTransactionIdentifier").ToString();
        }

        public void setPaymentProviderTransactionIdentifier(string paymentProviderTransactionIdentifier)
        {
            this.setProperty("paymentProviderTransactionIdentifier", paymentProviderTransactionIdentifier);
        }

        public string getTransactionNetAmount()
        {
            return this.getProperty("transactionNetAmount").ToString();
        }

        public void setTransactionNetAmount(string transactionNetAmount)
        {
            this.setProperty("transactionNetAmount", transactionNetAmount);
        }

        public string getTransactionFeeAmount()
        {
            return this.getProperty("transactionFeeAmount").ToString();
        }

        public void setTransactionFeeAmount(string transactionFeeAmount)
        {
            this.setProperty("transactionFeeAmount", transactionFeeAmount);
        }

        public string getTransactionReference()
        {
            return this.getProperty("transactionReference").ToString();
        }

        public void setTransactionReference(string transactionReference)
        {
            this.setProperty("transactionReference", transactionReference);
        }

        public DateTime getTransactionInitiatedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("transactionInitiatedDatetime"));
        }

        public void setTransactionInitiatedDatetime(DateTime transactionInitiatedDatetime)
        {
            this.setProperty("transactionInitiatedDatetime", transactionInitiatedDatetime);
        }

        public DateTime getTransactionSucceededDatetime()
        {
            return Convert.ToDateTime(this.getProperty("transactionSucceededDatetime"));
        }

        public void setTransactionSucceededDatetime(DateTime transactionSucceededDatetime)
        {
            this.setProperty("transactionSucceededDatetime", transactionSucceededDatetime);
        }

        public DateTime getTransactionFailedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("transactionFailedDatetime"));
        }

        public void setTransactionFailedDatetime(DateTime transactionFailedDatetime)
        {
            this.setProperty("transactionFailedDatetime", transactionFailedDatetime);
        }

        public DateTime getTransactionRefundedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("transactionRefundedDatetime"));
        }

        public void setTransactionRefundedDatetime(DateTime transactionRefundedDatetime)
        {
            this.setProperty("transactionRefundedDatetime", transactionRefundedDatetime);
        }

        public string getCardTokenId()
        {
            return this.getProperty("cardTokenId").ToString();
        }

        public void setCardTokenId(string cardTokenId)
        {
            this.setProperty("cardTokenId", cardTokenId);
        }

        public DateTime getCancelledDatetime()
        {
            return Convert.ToDateTime(this.getProperty("cancelledDatetime"));
        }

        public void setCancelledDatetime(DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }


    }
}

