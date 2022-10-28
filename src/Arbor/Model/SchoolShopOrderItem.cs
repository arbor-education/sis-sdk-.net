using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolShopOrderItem : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOL_SHOP_ORDER_ITEM;
        public const string SCHOOL_SHOP_PRODUCT = "schoolShopProduct";
        public const string CUSTOMER_INVOICE_ITEM = "customerInvoiceItem";
        public const string STATUS = "status";
        public const string COMMENT = "comment";

        public SchoolShopOrderItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolShopOrderItem (string resourceType = "SchoolShopOrderItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolShopOrderItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolShopOrderItem");
        	RestGateway gateway = (RestGateway) SchoolShopOrderItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolShopOrderItem> schoolshoporderitemCollection = new ModelCollection<SchoolShopOrderItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolshoporderitemCollection.add((SchoolShopOrderItem) model);
        	}
        
        	return schoolshoporderitemCollection;
        }

        public static SchoolShopOrderItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolShopOrderItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolShopOrderItem) gateway.retrieve(ResourceType.SCHOOL_SHOP_ORDER_ITEM, id);
        }

        public SchoolShopProduct getSchoolShopProduct ()
        {
            return (SchoolShopProduct) this.getProperty("schoolShopProduct");
        }

        public void setSchoolShopProduct (SchoolShopProduct schoolShopProduct)
        {
            this.setProperty("schoolShopProduct", schoolShopProduct);
        }

        public CustomerInvoiceItem getCustomerInvoiceItem ()
        {
            return (CustomerInvoiceItem) this.getProperty("customerInvoiceItem");
        }

        public void setCustomerInvoiceItem (CustomerInvoiceItem customerInvoiceItem)
        {
            this.setProperty("customerInvoiceItem", customerInvoiceItem);
        }

        public string getStatus ()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus (string status)
        {
            this.setProperty("status", status);
        }

        public string getComment ()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment (string comment)
        {
            this.setProperty("comment", comment);
        }


    }
}

