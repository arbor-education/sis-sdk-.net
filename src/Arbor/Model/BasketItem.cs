using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BasketItem : ModelBase
    {
        protected new string resourceType = ResourceType.BASKET_ITEM;
        public const string BASKET = "basket";
        public const string PAYMENT_AMOUNT = "paymentAmount";
        public const string ADDED_DATETIME = "addedDatetime";
        public const string PAYING_FOR = "payingFor";
        public const string QUANTITY = "quantity";
        public const string STUDENT = "student";

        public BasketItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BasketItem (string resourceType = "BasketItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BasketItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BasketItem");
        	RestGateway gateway = (RestGateway) BasketItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BasketItem> basketitemCollection = new ModelCollection<BasketItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    basketitemCollection.add((BasketItem) model);
        	}
        
        	return basketitemCollection;
        }

        public static BasketItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BasketItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BasketItem) gateway.retrieve(ResourceType.BASKET_ITEM, id);
        }

        public Basket getBasket ()
        {
            return (Basket) this.getProperty("basket");
        }

        public void setBasket (Basket basket)
        {
            this.setProperty("basket", basket);
        }

        public string getPaymentAmount ()
        {
            return this.getProperty("paymentAmount").ToString();
        }

        public void setPaymentAmount (string paymentAmount)
        {
            this.setProperty("paymentAmount", paymentAmount);
        }

        public DateTime getAddedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("addedDatetime"));
        }

        public void setAddedDatetime (DateTime addedDatetime)
        {
            this.setProperty("addedDatetime", addedDatetime);
        }

        public ModelBase getPayingFor ()
        {
            return (ModelBase) this.getProperty("payingFor");
        }

        public void setPayingFor (ModelBase payingFor)
        {
            this.setProperty("payingFor", payingFor);
        }

        public int getQuantity ()
        {
            return Convert.ToInt32(this.getProperty("quantity"));
        }

        public void setQuantity (int quantity)
        {
            this.setProperty("quantity", quantity);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }


    }
}

