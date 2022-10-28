using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AdditionalPaymentReason : ModelBase
    {
        protected new string resourceType = ResourceType.ADDITIONAL_PAYMENT_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";

        public AdditionalPaymentReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AdditionalPaymentReason (string resourceType = "AdditionalPaymentReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AdditionalPaymentReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AdditionalPaymentReason");
        	RestGateway gateway = (RestGateway) AdditionalPaymentReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AdditionalPaymentReason> additionalpaymentreasonCollection = new ModelCollection<AdditionalPaymentReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    additionalpaymentreasonCollection.add((AdditionalPaymentReason) model);
        	}
        
        	return additionalpaymentreasonCollection;
        }

        public static AdditionalPaymentReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AdditionalPaymentReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AdditionalPaymentReason) gateway.retrieve(ResourceType.ADDITIONAL_PAYMENT_REASON, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
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

