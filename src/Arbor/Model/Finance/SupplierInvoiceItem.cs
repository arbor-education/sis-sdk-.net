using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierInvoiceItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_INVOICE_ITEM;
        public const string SUPPLIER_INVOICE = "supplierInvoice";
        public const string SUPPLIER_ORDER_ITEM = "supplierOrderItem";
        public const string ITEM_NAME = "itemName";
        public const string ITEM_UNIT = "itemUnit";
        public const string ITEM_PRICE_EX_VAT = "itemPriceExVat";
        public const string QUANTITY_INVOICED = "quantityInvoiced";
        public const string VAT_RATE = "vatRate";
        public const string ITEM_VAT_AMOUNT = "itemVatAmount";
        public const string DISCOUNT = "discount";
        public const string INVOICE_LINE_NUMBER = "invoiceLineNumber";

        public SupplierInvoiceItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierInvoiceItem (string resourceType = "SupplierInvoiceItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierInvoiceItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierInvoiceItem");
        	RestGateway gateway = (RestGateway) SupplierInvoiceItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierInvoiceItem> supplierinvoiceitemCollection = new ModelCollection<SupplierInvoiceItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierinvoiceitemCollection.add((SupplierInvoiceItem) model);
        	}
        
        	return supplierinvoiceitemCollection;
        }

        public static SupplierInvoiceItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierInvoiceItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierInvoiceItem) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_INVOICE_ITEM, id);
        }

        public ModelBase getSupplierInvoice ()
        {
            return (ModelBase) this.getProperty("supplierInvoice");
        }

        public void setSupplierInvoice (ModelBase supplierInvoice)
        {
            this.setProperty("supplierInvoice", supplierInvoice);
        }

        public ModelBase getSupplierOrderItem ()
        {
            return (ModelBase) this.getProperty("supplierOrderItem");
        }

        public void setSupplierOrderItem (ModelBase supplierOrderItem)
        {
            this.setProperty("supplierOrderItem", supplierOrderItem);
        }

        public string getItemName ()
        {
            return this.getProperty("itemName").ToString();
        }

        public void setItemName (string itemName)
        {
            this.setProperty("itemName", itemName);
        }

        public ItemUnit getItemUnit ()
        {
            return (ItemUnit) this.getProperty("itemUnit");
        }

        public void setItemUnit (ItemUnit itemUnit)
        {
            this.setProperty("itemUnit", itemUnit);
        }

        public string getItemPriceExVat ()
        {
            return this.getProperty("itemPriceExVat").ToString();
        }

        public void setItemPriceExVat (string itemPriceExVat)
        {
            this.setProperty("itemPriceExVat", itemPriceExVat);
        }

        public int getQuantityInvoiced ()
        {
            return Convert.ToInt32(this.getProperty("quantityInvoiced"));
        }

        public void setQuantityInvoiced (int quantityInvoiced)
        {
            this.setProperty("quantityInvoiced", quantityInvoiced);
        }

        public ModelBase getVatRate ()
        {
            return (ModelBase) this.getProperty("vatRate");
        }

        public void setVatRate (ModelBase vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }

        public float getItemVatAmount ()
        {
            return (float) this.getProperty("itemVatAmount");
        }

        public void setItemVatAmount (float itemVatAmount)
        {
            this.setProperty("itemVatAmount", itemVatAmount);
        }

        public string getDiscount ()
        {
            return this.getProperty("discount").ToString();
        }

        public void setDiscount (string discount)
        {
            this.setProperty("discount", discount);
        }

        public string getInvoiceLineNumber ()
        {
            return this.getProperty("invoiceLineNumber").ToString();
        }

        public void setInvoiceLineNumber (string invoiceLineNumber)
        {
            this.setProperty("invoiceLineNumber", invoiceLineNumber);
        }


    }
}

