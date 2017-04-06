using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class PaymentBatch : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_PAYMENT_BATCH;
        public const string BATCH_SUBMITTED_DATETIME = "batchSubmittedDatetime";
        public const string NARRATIVE = "narrative";

        public PaymentBatch ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PaymentBatch (string resourceType = "PaymentBatch", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PaymentBatch> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_PaymentBatch");
        	RestGateway gateway = (RestGateway) PaymentBatch.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PaymentBatch> paymentbatchCollection = new ModelCollection<PaymentBatch> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    paymentbatchCollection.add((PaymentBatch) model);
        	}
        
        	return paymentbatchCollection;
        }

        public static PaymentBatch retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PaymentBatch.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PaymentBatch) gateway.retrieve(ResourceType.FINANCE_PAYMENT_BATCH, id);
        }

        public DateTime getBatchSubmittedDatetime ()
        {
            return (DateTime) this.getProperty("batchSubmittedDatetime");
        }

        public void setBatchSubmittedDatetime (DateTime batchSubmittedDatetime)
        {
            this.setProperty("batchSubmittedDatetime", batchSubmittedDatetime);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

