using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CustomerInvoiceItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CUSTOMER_INVOICE_ITEM;
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string ITEM_UNIT = "itemUnit";
        public const string DESTINATION_LEDGER = "destinationLedger";
        public const string COST_CENTER = "costCenter";
        public const string ITEM_DESCRIPTION = "itemDescription";
        public const string ITEM_COST = "itemCost";
        public const string QUANTITY_INVOICED = "quantityInvoiced";
        public const string VAT_RATE = "vatRate";
        public const string VAT_AMOUNT = "vatAmount";
        public const string TOTAL_AMOUNT = "totalAmount";
        public const string LINE_NUMBER = "lineNumber";
        public const string FULLY_PAID_DATE = "fullyPaidDate";

        public CustomerInvoiceItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerInvoiceItem (string resourceType = "CustomerInvoiceItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerInvoiceItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_CustomerInvoiceItem");
        	RestGateway gateway = (RestGateway) CustomerInvoiceItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerInvoiceItem> customerinvoiceitemCollection = new ModelCollection<CustomerInvoiceItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customerinvoiceitemCollection.add((CustomerInvoiceItem) model);
        	}
        
        	return customerinvoiceitemCollection;
        }

        public static CustomerInvoiceItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerInvoiceItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerInvoiceItem) gateway.retrieve(ResourceType.FINANCE_CUSTOMER_INVOICE_ITEM, id);
        }

        public ModelBase getCustomerInvoice ()
        {
            return (ModelBase) this.getProperty("customerInvoice");
        }

        public void setCustomerInvoice (ModelBase customerInvoice)
        {
            this.setProperty("customerInvoice", customerInvoice);
        }

        public ItemUnit getItemUnit ()
        {
            return (ItemUnit) this.getProperty("itemUnit");
        }

        public void setItemUnit (ItemUnit itemUnit)
        {
            this.setProperty("itemUnit", itemUnit);
        }

        public ModelBase getDestinationLedger ()
        {
            return (ModelBase) this.getProperty("destinationLedger");
        }

        public void setDestinationLedger (ModelBase destinationLedger)
        {
            this.setProperty("destinationLedger", destinationLedger);
        }

        public int getCostCenter ()
        {
            return Convert.ToInt32(this.getProperty("costCenter"));
        }

        public void setCostCenter (int costCenter)
        {
            this.setProperty("costCenter", costCenter);
        }

        public string getItemDescription ()
        {
            return this.getProperty("itemDescription").ToString();
        }

        public void setItemDescription (string itemDescription)
        {
            this.setProperty("itemDescription", itemDescription);
        }

        public string getItemCost ()
        {
            return this.getProperty("itemCost").ToString();
        }

        public void setItemCost (string itemCost)
        {
            this.setProperty("itemCost", itemCost);
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

        public string getVatAmount ()
        {
            return this.getProperty("vatAmount").ToString();
        }

        public void setVatAmount (string vatAmount)
        {
            this.setProperty("vatAmount", vatAmount);
        }

        public string getTotalAmount ()
        {
            return this.getProperty("totalAmount").ToString();
        }

        public void setTotalAmount (string totalAmount)
        {
            this.setProperty("totalAmount", totalAmount);
        }

        public int getLineNumber ()
        {
            return Convert.ToInt32(this.getProperty("lineNumber"));
        }

        public void setLineNumber (int lineNumber)
        {
            this.setProperty("lineNumber", lineNumber);
        }

        public DateTime getFullyPaidDate ()
        {
            return (DateTime) this.getProperty("fullyPaidDate");
        }

        public void setFullyPaidDate (DateTime fullyPaidDate)
        {
            this.setProperty("fullyPaidDate", fullyPaidDate);
        }


    }
}

