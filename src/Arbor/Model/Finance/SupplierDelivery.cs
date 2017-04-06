using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierDelivery : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_DELIVERY;
        public const string SUPPLIER = "supplier";
        public const string SUPPLIER_ORDER = "supplierOrder";
        public const string CARRIER_ENTITY = "carrierEntity";
        public const string DELIVERY_DATETIME = "deliveryDatetime";
        public const string DELIVERY_TRACKING_NUMBER = "deliveryTrackingNumber";

        public SupplierDelivery ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierDelivery (string resourceType = "SupplierDelivery", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierDelivery> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierDelivery");
        	RestGateway gateway = (RestGateway) SupplierDelivery.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierDelivery> supplierdeliveryCollection = new ModelCollection<SupplierDelivery> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierdeliveryCollection.add((SupplierDelivery) model);
        	}
        
        	return supplierdeliveryCollection;
        }

        public static SupplierDelivery retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierDelivery.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierDelivery) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_DELIVERY, id);
        }

        public ModelBase getSupplier ()
        {
            return (ModelBase) this.getProperty("supplier");
        }

        public void setSupplier (ModelBase supplier)
        {
            this.setProperty("supplier", supplier);
        }

        public ModelBase getSupplierOrder ()
        {
            return (ModelBase) this.getProperty("supplierOrder");
        }

        public void setSupplierOrder (ModelBase supplierOrder)
        {
            this.setProperty("supplierOrder", supplierOrder);
        }

        public ModelBase getCarrierEntity ()
        {
            return (ModelBase) this.getProperty("carrierEntity");
        }

        public void setCarrierEntity (ModelBase carrierEntity)
        {
            this.setProperty("carrierEntity", carrierEntity);
        }

        public DateTime getDeliveryDatetime ()
        {
            return (DateTime) this.getProperty("deliveryDatetime");
        }

        public void setDeliveryDatetime (DateTime deliveryDatetime)
        {
            this.setProperty("deliveryDatetime", deliveryDatetime);
        }

        public string getDeliveryTrackingNumber ()
        {
            return this.getProperty("deliveryTrackingNumber").ToString();
        }

        public void setDeliveryTrackingNumber (string deliveryTrackingNumber)
        {
            this.setProperty("deliveryTrackingNumber", deliveryTrackingNumber);
        }


    }
}

