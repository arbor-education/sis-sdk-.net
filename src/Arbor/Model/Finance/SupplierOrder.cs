using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierOrder : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_ORDER;
        public const string SUPPLIER = "supplier";
        public const string BOOK = "book";
        public const string SUPPLIER_INVOICE = "supplierInvoice";
        public const string REQUESTING_PERSON = "requestingPerson";
        public const string AUTHORISING_PERSON = "authorisingPerson";
        public const string DELIVERY_ADDRESS = "deliveryAddress";
        public const string ORDER_NUMBER = "orderNumber";
        public const string ORDER_DATETIME = "orderDatetime";
        public const string AUTHORISED_DATETIME = "authorisedDatetime";
        public const string DELIVERY_INSTRUCTIONS = "deliveryInstructions";
        public const string DELIVERY_STATUS = "deliveryStatus";
        public const string CANCELLED_DATETIME = "cancelledDatetime";

        public SupplierOrder ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierOrder (string resourceType = "SupplierOrder", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierOrder> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierOrder");
        	RestGateway gateway = (RestGateway) SupplierOrder.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierOrder> supplierorderCollection = new ModelCollection<SupplierOrder> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierorderCollection.add((SupplierOrder) model);
        	}
        
        	return supplierorderCollection;
        }

        public static SupplierOrder retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierOrder.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierOrder) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_ORDER, id);
        }

        public ModelBase getSupplier ()
        {
            return (ModelBase) this.getProperty("supplier");
        }

        public void setSupplier (ModelBase supplier)
        {
            this.setProperty("supplier", supplier);
        }

        public ModelBase getBook ()
        {
            return (ModelBase) this.getProperty("book");
        }

        public void setBook (ModelBase book)
        {
            this.setProperty("book", book);
        }

        public ModelBase getSupplierInvoice ()
        {
            return (ModelBase) this.getProperty("supplierInvoice");
        }

        public void setSupplierInvoice (ModelBase supplierInvoice)
        {
            this.setProperty("supplierInvoice", supplierInvoice);
        }

        public Person getRequestingPerson ()
        {
            return (Person) this.getProperty("requestingPerson");
        }

        public void setRequestingPerson (Person requestingPerson)
        {
            this.setProperty("requestingPerson", requestingPerson);
        }

        public Person getAuthorisingPerson ()
        {
            return (Person) this.getProperty("authorisingPerson");
        }

        public void setAuthorisingPerson (Person authorisingPerson)
        {
            this.setProperty("authorisingPerson", authorisingPerson);
        }

        public ModelBase getDeliveryAddress ()
        {
            return (ModelBase) this.getProperty("deliveryAddress");
        }

        public void setDeliveryAddress (ModelBase deliveryAddress)
        {
            this.setProperty("deliveryAddress", deliveryAddress);
        }

        public string getOrderNumber ()
        {
            return this.getProperty("orderNumber").ToString();
        }

        public void setOrderNumber (string orderNumber)
        {
            this.setProperty("orderNumber", orderNumber);
        }

        public DateTime getOrderDatetime ()
        {
            return (DateTime) this.getProperty("orderDatetime");
        }

        public void setOrderDatetime (DateTime orderDatetime)
        {
            this.setProperty("orderDatetime", orderDatetime);
        }

        public DateTime getAuthorisedDatetime ()
        {
            return (DateTime) this.getProperty("authorisedDatetime");
        }

        public void setAuthorisedDatetime (DateTime authorisedDatetime)
        {
            this.setProperty("authorisedDatetime", authorisedDatetime);
        }

        public string getDeliveryInstructions ()
        {
            return this.getProperty("deliveryInstructions").ToString();
        }

        public void setDeliveryInstructions (string deliveryInstructions)
        {
            this.setProperty("deliveryInstructions", deliveryInstructions);
        }

        public string getDeliveryStatus ()
        {
            return this.getProperty("deliveryStatus").ToString();
        }

        public void setDeliveryStatus (string deliveryStatus)
        {
            this.setProperty("deliveryStatus", deliveryStatus);
        }

        public DateTime getCancelledDatetime ()
        {
            return (DateTime) this.getProperty("cancelledDatetime");
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }


    }
}

