using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierReturnedItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_RETURNED_ITEM;
        public const string SUPPLIER_DELIVERY_ITEM = "supplierDeliveryItem";
        public const string CARRIER_ENTITY = "carrierEntity";
        public const string RETURNED_DATETIME = "returnedDatetime";
        public const string SUPPLIER_REFERENCE_NUMBER = "supplierReferenceNumber";
        public const string QUANTITY_RETURNED = "quantityReturned";

        public SupplierReturnedItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierReturnedItem (string resourceType = "SupplierReturnedItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierReturnedItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierReturnedItem");
        	RestGateway gateway = (RestGateway) SupplierReturnedItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierReturnedItem> supplierreturneditemCollection = new ModelCollection<SupplierReturnedItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierreturneditemCollection.add((SupplierReturnedItem) model);
        	}
        
        	return supplierreturneditemCollection;
        }

        public static SupplierReturnedItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierReturnedItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierReturnedItem) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_RETURNED_ITEM, id);
        }

        public ModelBase getSupplierDeliveryItem ()
        {
            return (ModelBase) this.getProperty("supplierDeliveryItem");
        }

        public void setSupplierDeliveryItem (ModelBase supplierDeliveryItem)
        {
            this.setProperty("supplierDeliveryItem", supplierDeliveryItem);
        }

        public ModelBase getCarrierEntity ()
        {
            return (ModelBase) this.getProperty("carrierEntity");
        }

        public void setCarrierEntity (ModelBase carrierEntity)
        {
            this.setProperty("carrierEntity", carrierEntity);
        }

        public DateTime getReturnedDatetime ()
        {
            return (DateTime) this.getProperty("returnedDatetime");
        }

        public void setReturnedDatetime (DateTime returnedDatetime)
        {
            this.setProperty("returnedDatetime", returnedDatetime);
        }

        public string getSupplierReferenceNumber ()
        {
            return this.getProperty("supplierReferenceNumber").ToString();
        }

        public void setSupplierReferenceNumber (string supplierReferenceNumber)
        {
            this.setProperty("supplierReferenceNumber", supplierReferenceNumber);
        }

        public int getQuantityReturned ()
        {
            return Convert.ToInt32(this.getProperty("quantityReturned"));
        }

        public void setQuantityReturned (int quantityReturned)
        {
            this.setProperty("quantityReturned", quantityReturned);
        }


    }
}

