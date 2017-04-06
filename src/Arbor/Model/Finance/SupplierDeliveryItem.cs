using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierDeliveryItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_DELIVERY_ITEM;
        public const string SUPPLIER_DELIVERY = "supplierDelivery";
        public const string SUPPLIER_ORDER = "supplierOrder";
        public const string SUPPLIER_ORDER_ITEM = "supplierOrderItem";
        public const string SUPPLIER_INVOICE_ITEM = "supplierInvoiceItem";
        public const string QUANTITY_DELIVERED = "quantityDelivered";

        public SupplierDeliveryItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierDeliveryItem (string resourceType = "SupplierDeliveryItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierDeliveryItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierDeliveryItem");
        	RestGateway gateway = (RestGateway) SupplierDeliveryItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierDeliveryItem> supplierdeliveryitemCollection = new ModelCollection<SupplierDeliveryItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierdeliveryitemCollection.add((SupplierDeliveryItem) model);
        	}
        
        	return supplierdeliveryitemCollection;
        }

        public static SupplierDeliveryItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierDeliveryItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierDeliveryItem) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_DELIVERY_ITEM, id);
        }

        public ModelBase getSupplierDelivery ()
        {
            return (ModelBase) this.getProperty("supplierDelivery");
        }

        public void setSupplierDelivery (ModelBase supplierDelivery)
        {
            this.setProperty("supplierDelivery", supplierDelivery);
        }

        public ModelBase getSupplierOrder ()
        {
            return (ModelBase) this.getProperty("supplierOrder");
        }

        public void setSupplierOrder (ModelBase supplierOrder)
        {
            this.setProperty("supplierOrder", supplierOrder);
        }

        public ModelBase getSupplierOrderItem ()
        {
            return (ModelBase) this.getProperty("supplierOrderItem");
        }

        public void setSupplierOrderItem (ModelBase supplierOrderItem)
        {
            this.setProperty("supplierOrderItem", supplierOrderItem);
        }

        public ModelBase getSupplierInvoiceItem ()
        {
            return (ModelBase) this.getProperty("supplierInvoiceItem");
        }

        public void setSupplierInvoiceItem (ModelBase supplierInvoiceItem)
        {
            this.setProperty("supplierInvoiceItem", supplierInvoiceItem);
        }

        public float getQuantityDelivered ()
        {
            return (float) this.getProperty("quantityDelivered");
        }

        public void setQuantityDelivered (float quantityDelivered)
        {
            this.setProperty("quantityDelivered", quantityDelivered);
        }


    }
}

