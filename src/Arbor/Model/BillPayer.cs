using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BillPayer : ModelBase
    {
        protected string resourceType = ResourceType.BILL_PAYER;
        public const string LEGAL_ENTITY = "legalEntity";
        public const string DELETED_LEGAL_ENTITY_NAME = "deletedLegalEntityName";
        public const string STRIPE_CUSTOMER_ID = "stripeCustomerId";

        public BillPayer ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BillPayer (string resourceType = "BillPayer", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BillPayer> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BillPayer");
        	RestGateway gateway = (RestGateway) BillPayer.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BillPayer> billpayerCollection = new ModelCollection<BillPayer> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    billpayerCollection.add((BillPayer) model);
        	}
        
        	return billpayerCollection;
        }

        public static BillPayer retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BillPayer.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BillPayer) gateway.retrieve(ResourceType.BILL_PAYER, id);
        }

        public ModelBase getLegalEntity ()
        {
            return (ModelBase) this.getProperty("legalEntity");
        }

        public void setLegalEntity (ModelBase legalEntity)
        {
            this.setProperty("legalEntity", legalEntity);
        }

        public string getDeletedLegalEntityName ()
        {
            return this.getProperty("deletedLegalEntityName").ToString();
        }

        public void setDeletedLegalEntityName (string deletedLegalEntityName)
        {
            this.setProperty("deletedLegalEntityName", deletedLegalEntityName);
        }

        public string getStripeCustomerId ()
        {
            return this.getProperty("stripeCustomerId").ToString();
        }

        public void setStripeCustomerId (string stripeCustomerId)
        {
            this.setProperty("stripeCustomerId", stripeCustomerId);
        }


    }
}

