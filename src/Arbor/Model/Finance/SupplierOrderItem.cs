using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierOrderItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_ORDER_ITEM;
        public const string SUPPLIER_ORDER = "supplierOrder";
        public const string LEDGER = "ledger";
        public const string SUPPLIER_SERVICE = "supplierService";
        public const string COST_CENTER = "costCenter";
        public const string VAT_RATE = "vatRate";
        public const string SUPPLIER_CREDIT_NOTE = "supplierCreditNote";
        public const string ITEM_UNIT = "itemUnit";
        public const string ITEM_NAME = "itemName";
        public const string ITEM_DESCRIPTION = "itemDescription";
        public const string ITEM_UNIT_PRICE = "itemUnitPrice";
        public const string ITEM_QUANTITY = "itemQuantity";
        public const string ITEM_DISCOUNT = "itemDiscount";
        public const string VAT_AMOUNT = "vatAmount";
        public const string ESTIMATED_DELIVERY_DATE = "estimatedDeliveryDate";
        public const string QUANTITY_RECEIVED = "quantityReceived";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string LINE_NUMBER = "lineNumber";
        public const string EAN = "EAN";
        public const string ISBN_13 = "ISBN_13";

        public SupplierOrderItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierOrderItem (string resourceType = "SupplierOrderItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierOrderItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierOrderItem");
        	RestGateway gateway = (RestGateway) SupplierOrderItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierOrderItem> supplierorderitemCollection = new ModelCollection<SupplierOrderItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierorderitemCollection.add((SupplierOrderItem) model);
        	}
        
        	return supplierorderitemCollection;
        }

        public static SupplierOrderItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierOrderItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierOrderItem) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_ORDER_ITEM, id);
        }

        public ModelBase getSupplierOrder ()
        {
            return (ModelBase) this.getProperty("supplierOrder");
        }

        public void setSupplierOrder (ModelBase supplierOrder)
        {
            this.setProperty("supplierOrder", supplierOrder);
        }

        public ModelBase getLedger ()
        {
            return (ModelBase) this.getProperty("ledger");
        }

        public void setLedger (ModelBase ledger)
        {
            this.setProperty("ledger", ledger);
        }

        public ModelBase getSupplierService ()
        {
            return (ModelBase) this.getProperty("supplierService");
        }

        public void setSupplierService (ModelBase supplierService)
        {
            this.setProperty("supplierService", supplierService);
        }

        public ModelBase getCostCenter ()
        {
            return (ModelBase) this.getProperty("costCenter");
        }

        public void setCostCenter (ModelBase costCenter)
        {
            this.setProperty("costCenter", costCenter);
        }

        public ModelBase getVatRate ()
        {
            return (ModelBase) this.getProperty("vatRate");
        }

        public void setVatRate (ModelBase vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }

        public ModelBase getSupplierCreditNote ()
        {
            return (ModelBase) this.getProperty("supplierCreditNote");
        }

        public void setSupplierCreditNote (ModelBase supplierCreditNote)
        {
            this.setProperty("supplierCreditNote", supplierCreditNote);
        }

        public ItemUnit getItemUnit ()
        {
            return (ItemUnit) this.getProperty("itemUnit");
        }

        public void setItemUnit (ItemUnit itemUnit)
        {
            this.setProperty("itemUnit", itemUnit);
        }

        public string getItemName ()
        {
            return this.getProperty("itemName").ToString();
        }

        public void setItemName (string itemName)
        {
            this.setProperty("itemName", itemName);
        }

        public string getItemDescription ()
        {
            return this.getProperty("itemDescription").ToString();
        }

        public void setItemDescription (string itemDescription)
        {
            this.setProperty("itemDescription", itemDescription);
        }

        public string getItemUnitPrice ()
        {
            return this.getProperty("itemUnitPrice").ToString();
        }

        public void setItemUnitPrice (string itemUnitPrice)
        {
            this.setProperty("itemUnitPrice", itemUnitPrice);
        }

        public int getItemQuantity ()
        {
            return Convert.ToInt32(this.getProperty("itemQuantity"));
        }

        public void setItemQuantity (int itemQuantity)
        {
            this.setProperty("itemQuantity", itemQuantity);
        }

        public float getItemDiscount ()
        {
            return (float) this.getProperty("itemDiscount");
        }

        public void setItemDiscount (float itemDiscount)
        {
            this.setProperty("itemDiscount", itemDiscount);
        }

        public float getVatAmount ()
        {
            return (float) this.getProperty("vatAmount");
        }

        public void setVatAmount (float vatAmount)
        {
            this.setProperty("vatAmount", vatAmount);
        }

        public DateTime getEstimatedDeliveryDate ()
        {
            return (DateTime) this.getProperty("estimatedDeliveryDate");
        }

        public void setEstimatedDeliveryDate (DateTime estimatedDeliveryDate)
        {
            this.setProperty("estimatedDeliveryDate", estimatedDeliveryDate);
        }

        public int getQuantityReceived ()
        {
            return Convert.ToInt32(this.getProperty("quantityReceived"));
        }

        public void setQuantityReceived (int quantityReceived)
        {
            this.setProperty("quantityReceived", quantityReceived);
        }

        public DateTime getCancelledDatetime ()
        {
            return (DateTime) this.getProperty("cancelledDatetime");
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public int getLineNumber ()
        {
            return Convert.ToInt32(this.getProperty("lineNumber"));
        }

        public void setLineNumber (int lineNumber)
        {
            this.setProperty("lineNumber", lineNumber);
        }

        public int getEAN ()
        {
            return Convert.ToInt32(this.getProperty("EAN"));
        }

        public void setEAN (int EAN)
        {
            this.setProperty("EAN", EAN);
        }

        public string getISBN_13 ()
        {
            return this.getProperty("ISBN_13").ToString();
        }

        public void setISBN_13 (string ISBN_13)
        {
            this.setProperty("ISBN_13", ISBN_13);
        }


    }
}

