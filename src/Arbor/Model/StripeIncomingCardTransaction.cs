using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StripeIncomingCardTransaction : ModelBase
    {
        protected string resourceType = ResourceType.STRIPE_INCOMING_CARD_TRANSACTION;
        public const string BILL_PAYER = "billPayer";
        public const string STRIPE_PAYOUT_TRANSACTION = "stripePayoutTransaction";
        public const string TRANSACTION_AMOUNT = "transactionAmount";
        public const string TRANSACTION_FEE_AMOUNT = "transactionFeeAmount";
        public const string TRANSACTION_FEE_VAT_AMOUNT = "transactionFeeVatAmount";
        public const string PAYOUT_AMOUNT = "payoutAmount";
        public const string REFUND_AMOUNT = "refundAmount";
        public const string STRIPE_CHARGE_STATUS = "stripeChargeStatus";
        public const string STRIPE_CHARGE_IDENTIFIER = "stripeChargeIdentifier";
        public const string TRANSACTION_INITIATED_DATETIME = "transactionInitiatedDatetime";

        public StripeIncomingCardTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StripeIncomingCardTransaction (string resourceType = "StripeIncomingCardTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StripeIncomingCardTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StripeIncomingCardTransaction");
        	RestGateway gateway = (RestGateway) StripeIncomingCardTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StripeIncomingCardTransaction> stripeincomingcardtransactionCollection = new ModelCollection<StripeIncomingCardTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    stripeincomingcardtransactionCollection.add((StripeIncomingCardTransaction) model);
        	}
        
        	return stripeincomingcardtransactionCollection;
        }

        public static StripeIncomingCardTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StripeIncomingCardTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StripeIncomingCardTransaction) gateway.retrieve(ResourceType.STRIPE_INCOMING_CARD_TRANSACTION, id);
        }

        public BillPayer getBillPayer ()
        {
            return (BillPayer) this.getProperty("billPayer");
        }

        public void setBillPayer (BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public StripePayoutTransaction getStripePayoutTransaction ()
        {
            return (StripePayoutTransaction) this.getProperty("stripePayoutTransaction");
        }

        public void setStripePayoutTransaction (StripePayoutTransaction stripePayoutTransaction)
        {
            this.setProperty("stripePayoutTransaction", stripePayoutTransaction);
        }

        public string getTransactionAmount ()
        {
            return this.getProperty("transactionAmount").ToString();
        }

        public void setTransactionAmount (string transactionAmount)
        {
            this.setProperty("transactionAmount", transactionAmount);
        }

        public string getTransactionFeeAmount ()
        {
            return this.getProperty("transactionFeeAmount").ToString();
        }

        public void setTransactionFeeAmount (string transactionFeeAmount)
        {
            this.setProperty("transactionFeeAmount", transactionFeeAmount);
        }

        public string getTransactionFeeVatAmount ()
        {
            return this.getProperty("transactionFeeVatAmount").ToString();
        }

        public void setTransactionFeeVatAmount (string transactionFeeVatAmount)
        {
            this.setProperty("transactionFeeVatAmount", transactionFeeVatAmount);
        }

        public string getPayoutAmount ()
        {
            return this.getProperty("payoutAmount").ToString();
        }

        public void setPayoutAmount (string payoutAmount)
        {
            this.setProperty("payoutAmount", payoutAmount);
        }

        public string getRefundAmount ()
        {
            return this.getProperty("refundAmount").ToString();
        }

        public void setRefundAmount (string refundAmount)
        {
            this.setProperty("refundAmount", refundAmount);
        }

        public string getStripeChargeStatus ()
        {
            return this.getProperty("stripeChargeStatus").ToString();
        }

        public void setStripeChargeStatus (string stripeChargeStatus)
        {
            this.setProperty("stripeChargeStatus", stripeChargeStatus);
        }

        public string getStripeChargeIdentifier ()
        {
            return this.getProperty("stripeChargeIdentifier").ToString();
        }

        public void setStripeChargeIdentifier (string stripeChargeIdentifier)
        {
            this.setProperty("stripeChargeIdentifier", stripeChargeIdentifier);
        }

        public DateTime getTransactionInitiatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("transactionInitiatedDatetime"))
        }

        public void setTransactionInitiatedDatetime (DateTime transactionInitiatedDatetime)
        {
            this.setProperty("transactionInitiatedDatetime", transactionInitiatedDatetime);
        }


    }
}

