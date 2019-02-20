using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StripeTransfer : ModelBase
    {
        protected string resourceType = ResourceType.STRIPE_TRANSFER;
        public const string TRANSACTION = "transaction";
        public const string TRANSFER_AMOUNT = "transferAmount";
        public const string TRANSFER_INITIATED_DATETIME = "transferInitiatedDatetime";
        public const string TRANSFER_SUCCEEDED_DATETIME = "transferSucceededDatetime";
        public const string TRANSFER_FAILED_DATETIME = "transferFailedDatetime";
        public const string STRIPE_TRANSFER_IDENTIFIER = "stripeTransferIdentifier";
        public const string DESCRIPTION = "description";

        public StripeTransfer ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StripeTransfer (string resourceType = "StripeTransfer", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StripeTransfer> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StripeTransfer");
        	RestGateway gateway = (RestGateway) StripeTransfer.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StripeTransfer> stripetransferCollection = new ModelCollection<StripeTransfer> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    stripetransferCollection.add((StripeTransfer) model);
        	}
        
        	return stripetransferCollection;
        }

        public static StripeTransfer retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StripeTransfer.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StripeTransfer) gateway.retrieve(ResourceType.STRIPE_TRANSFER, id);
        }

        public ModelBase getTransaction ()
        {
            return (ModelBase) this.getProperty("transaction");
        }

        public void setTransaction (ModelBase transaction)
        {
            this.setProperty("transaction", transaction);
        }

        public string getTransferAmount ()
        {
            return this.getProperty("transferAmount").ToString();
        }

        public void setTransferAmount (string transferAmount)
        {
            this.setProperty("transferAmount", transferAmount);
        }

        public DateTime getTransferInitiatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("transferInitiatedDatetime"));
        }

        public void setTransferInitiatedDatetime (DateTime transferInitiatedDatetime)
        {
            this.setProperty("transferInitiatedDatetime", transferInitiatedDatetime);
        }

        public DateTime getTransferSucceededDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("transferSucceededDatetime"));
        }

        public void setTransferSucceededDatetime (DateTime transferSucceededDatetime)
        {
            this.setProperty("transferSucceededDatetime", transferSucceededDatetime);
        }

        public DateTime getTransferFailedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("transferFailedDatetime"));
        }

        public void setTransferFailedDatetime (DateTime transferFailedDatetime)
        {
            this.setProperty("transferFailedDatetime", transferFailedDatetime);
        }

        public string getStripeTransferIdentifier ()
        {
            return this.getProperty("stripeTransferIdentifier").ToString();
        }

        public void setStripeTransferIdentifier (string stripeTransferIdentifier)
        {
            this.setProperty("stripeTransferIdentifier", stripeTransferIdentifier);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

