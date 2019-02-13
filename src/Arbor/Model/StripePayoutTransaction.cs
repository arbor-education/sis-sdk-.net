using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StripePayoutTransaction : ModelBase
    {
        protected string resourceType = ResourceType.STRIPE_PAYOUT_TRANSACTION;
        public const string STRIPE_PAYOUT_DESTINATION = "stripePayoutDestination";
        public const string STRIPE_PAYOUT_IDENTIFIER = "stripePayoutIdentifier";
        public const string PAYOUT_AMOUNT = "payoutAmount";
        public const string PAYOUT_INITIATED_DATETIME = "payoutInitiatedDatetime";
        public const string PAYOUT_SUCCEEDED_DATETIME = "payoutSucceededDatetime";
        public const string PAYOUT_FAILED_DATETIME = "payoutFailedDatetime";
        public const string PAYOUT_SCHEDULED_DATETIME = "payoutScheduledDatetime";
        public const string VAT_INVOICE_GENERATION_INITIATED_DATETIME = "vatInvoiceGenerationInitiatedDatetime";
        public const string VAT_INVOICE_GENERATION_STATUS = "vatInvoiceGenerationStatus";
        public const string PAYOUT_STATUS = "payoutStatus";

        public StripePayoutTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StripePayoutTransaction (string resourceType = "StripePayoutTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StripePayoutTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StripePayoutTransaction");
        	RestGateway gateway = (RestGateway) StripePayoutTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StripePayoutTransaction> stripepayouttransactionCollection = new ModelCollection<StripePayoutTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    stripepayouttransactionCollection.add((StripePayoutTransaction) model);
        	}
        
        	return stripepayouttransactionCollection;
        }

        public static StripePayoutTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StripePayoutTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StripePayoutTransaction) gateway.retrieve(ResourceType.STRIPE_PAYOUT_TRANSACTION, id);
        }

        public StripePayoutDestination getStripePayoutDestination ()
        {
            return (StripePayoutDestination) this.getProperty("stripePayoutDestination");
        }

        public void setStripePayoutDestination (StripePayoutDestination stripePayoutDestination)
        {
            this.setProperty("stripePayoutDestination", stripePayoutDestination);
        }

        public string getStripePayoutIdentifier ()
        {
            return this.getProperty("stripePayoutIdentifier").ToString();
        }

        public void setStripePayoutIdentifier (string stripePayoutIdentifier)
        {
            this.setProperty("stripePayoutIdentifier", stripePayoutIdentifier);
        }

        public string getPayoutAmount ()
        {
            return this.getProperty("payoutAmount").ToString();
        }

        public void setPayoutAmount (string payoutAmount)
        {
            this.setProperty("payoutAmount", payoutAmount);
        }

        public DateTime getPayoutInitiatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("payoutInitiatedDatetime"))
        }

        public void setPayoutInitiatedDatetime (DateTime payoutInitiatedDatetime)
        {
            this.setProperty("payoutInitiatedDatetime", payoutInitiatedDatetime);
        }

        public DateTime getPayoutSucceededDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("payoutSucceededDatetime"))
        }

        public void setPayoutSucceededDatetime (DateTime payoutSucceededDatetime)
        {
            this.setProperty("payoutSucceededDatetime", payoutSucceededDatetime);
        }

        public DateTime getPayoutFailedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("payoutFailedDatetime"))
        }

        public void setPayoutFailedDatetime (DateTime payoutFailedDatetime)
        {
            this.setProperty("payoutFailedDatetime", payoutFailedDatetime);
        }

        public DateTime getPayoutScheduledDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("payoutScheduledDatetime"))
        }

        public void setPayoutScheduledDatetime (DateTime payoutScheduledDatetime)
        {
            this.setProperty("payoutScheduledDatetime", payoutScheduledDatetime);
        }

        public DateTime getVatInvoiceGenerationInitiatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("vatInvoiceGenerationInitiatedDatetime"))
        }

        public void setVatInvoiceGenerationInitiatedDatetime (DateTime vatInvoiceGenerationInitiatedDatetime)
        {
            this.setProperty("vatInvoiceGenerationInitiatedDatetime", vatInvoiceGenerationInitiatedDatetime);
        }

        public string getVatInvoiceGenerationStatus ()
        {
            return this.getProperty("vatInvoiceGenerationStatus").ToString();
        }

        public void setVatInvoiceGenerationStatus (string vatInvoiceGenerationStatus)
        {
            this.setProperty("vatInvoiceGenerationStatus", vatInvoiceGenerationStatus);
        }

        public string getPayoutStatus ()
        {
            return this.getProperty("payoutStatus").ToString();
        }

        public void setPayoutStatus (string payoutStatus)
        {
            this.setProperty("payoutStatus", payoutStatus);
        }


    }
}

