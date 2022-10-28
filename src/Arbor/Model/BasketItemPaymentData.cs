using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BasketItemPaymentData : ModelBase
    {
        protected new string resourceType = ResourceType.BASKET_ITEM_PAYMENT_DATA;
        public const string BASKET_ITEM = "basketItem";
        public const string NAME = "name";
        public const string VALUE = "value";

        public BasketItemPaymentData ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BasketItemPaymentData (string resourceType = "BasketItemPaymentData", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BasketItemPaymentData> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BasketItemPaymentData");
        	RestGateway gateway = (RestGateway) BasketItemPaymentData.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BasketItemPaymentData> basketitempaymentdataCollection = new ModelCollection<BasketItemPaymentData> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    basketitempaymentdataCollection.add((BasketItemPaymentData) model);
        	}
        
        	return basketitempaymentdataCollection;
        }

        public static BasketItemPaymentData retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BasketItemPaymentData.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BasketItemPaymentData) gateway.retrieve(ResourceType.BASKET_ITEM_PAYMENT_DATA, id);
        }

        public BasketItem getBasketItem ()
        {
            return (BasketItem) this.getProperty("basketItem");
        }

        public void setBasketItem (BasketItem basketItem)
        {
            this.setProperty("basketItem", basketItem);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getValue ()
        {
            return this.getProperty("value").ToString();
        }

        public void setValue (string value)
        {
            this.setProperty("value", value);
        }


    }
}

