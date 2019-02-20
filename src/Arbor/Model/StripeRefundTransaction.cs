using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StripeRefundTransaction : ModelBase
    {
        protected string resourceType = ResourceType.STRIPE_REFUND_TRANSACTION;
        public const string STRIPE_INCOMING_CARD_TRANSACTION = "stripeIncomingCardTransaction";
        public const string BILL_PAYER = "billPayer";
        public const string STRIPE_PAYOUT_TRANSACTION = "stripePayoutTransaction";
        public const string FAILED_REFUND_STRIPE_PAYOUT_TRANSACTION = "failedRefundStripePayoutTransaction";
        public const string REFUND_AMOUNT = "refundAmount";
        public const string REFUND_INITIATED_DATETIME = "refundInitiatedDatetime";
        public const string REFUND_SUCCEEDED_DATETIME = "refundSucceededDatetime";
        public const string REFUND_FAILED_DATETIME = "refundFailedDatetime";
        public const string STRIPE_REFUND_IDENTIFIER = "stripeRefundIdentifier";
        public const string STRIPE_REFUND_STATUS = "stripeRefundStatus";
        public const string REFUND_REASON = "refundReason";

        public StripeRefundTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StripeRefundTransaction (string resourceType = "StripeRefundTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StripeRefundTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StripeRefundTransaction");
        	RestGateway gateway = (RestGateway) StripeRefundTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StripeRefundTransaction> striperefundtransactionCollection = new ModelCollection<StripeRefundTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    striperefundtransactionCollection.add((StripeRefundTransaction) model);
        	}
        
        	return striperefundtransactionCollection;
        }

        public static StripeRefundTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StripeRefundTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StripeRefundTransaction) gateway.retrieve(ResourceType.STRIPE_REFUND_TRANSACTION, id);
        }

        public StripeIncomingCardTransaction getStripeIncomingCardTransaction ()
        {
            return (StripeIncomingCardTransaction) this.getProperty("stripeIncomingCardTransaction");
        }

        public void setStripeIncomingCardTransaction (StripeIncomingCardTransaction stripeIncomingCardTransaction)
        {
            this.setProperty("stripeIncomingCardTransaction", stripeIncomingCardTransaction);
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

        public StripePayoutTransaction getFailedRefundStripePayoutTransaction ()
        {
            return (StripePayoutTransaction) this.getProperty("failedRefundStripePayoutTransaction");
        }

        public void setFailedRefundStripePayoutTransaction (StripePayoutTransaction failedRefundStripePayoutTransaction)
        {
            this.setProperty("failedRefundStripePayoutTransaction", failedRefundStripePayoutTransaction);
        }

        public string getRefundAmount ()
        {
            return this.getProperty("refundAmount").ToString();
        }

        public void setRefundAmount (string refundAmount)
        {
            this.setProperty("refundAmount", refundAmount);
        }

        public DateTime getRefundInitiatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("refundInitiatedDatetime"));
        }

        public void setRefundInitiatedDatetime (DateTime refundInitiatedDatetime)
        {
            this.setProperty("refundInitiatedDatetime", refundInitiatedDatetime);
        }

        public DateTime getRefundSucceededDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("refundSucceededDatetime"));
        }

        public void setRefundSucceededDatetime (DateTime refundSucceededDatetime)
        {
            this.setProperty("refundSucceededDatetime", refundSucceededDatetime);
        }

        public DateTime getRefundFailedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("refundFailedDatetime"));
        }

        public void setRefundFailedDatetime (DateTime refundFailedDatetime)
        {
            this.setProperty("refundFailedDatetime", refundFailedDatetime);
        }

        public string getStripeRefundIdentifier ()
        {
            return this.getProperty("stripeRefundIdentifier").ToString();
        }

        public void setStripeRefundIdentifier (string stripeRefundIdentifier)
        {
            this.setProperty("stripeRefundIdentifier", stripeRefundIdentifier);
        }

        public string getStripeRefundStatus ()
        {
            return this.getProperty("stripeRefundStatus").ToString();
        }

        public void setStripeRefundStatus (string stripeRefundStatus)
        {
            this.setProperty("stripeRefundStatus", stripeRefundStatus);
        }

        public string getRefundReason ()
        {
            return this.getProperty("refundReason").ToString();
        }

        public void setRefundReason (string refundReason)
        {
            this.setProperty("refundReason", refundReason);
        }


    }
}

