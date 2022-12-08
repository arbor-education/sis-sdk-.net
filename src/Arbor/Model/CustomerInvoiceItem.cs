using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerInvoiceItem : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOMER_INVOICE_ITEM;
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string ITEM_UNIT = "itemUnit";
        public const string ITEM_DESCRIPTION = "itemDescription";
        public const string ITEM_PRICE_EX_VAT = "itemPriceExVat";
        public const string QUANTITY_INVOICED = "quantityInvoiced";
        public const string VAT_RATE = "vatRate";
        public const string ITEM_VAT_AMOUNT = "itemVatAmount";
        public const string ITEM_TOTAL_AMOUNT = "itemTotalAmount";
        public const string LINE_NUMBER = "lineNumber";
        public const string FULLY_PAID_DATE = "fullyPaidDate";
        public const string ITEM_STATUS = "itemStatus";

        public CustomerInvoiceItem()
        {
            base.resourceType = this.resourceType;
        }

        public CustomerInvoiceItem(string resourceType = "CustomerInvoiceItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomerInvoiceItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomerInvoiceItem");
            RestGateway gateway = (RestGateway)CustomerInvoiceItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomerInvoiceItem> customerinvoiceitemCollection = new ModelCollection<CustomerInvoiceItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customerinvoiceitemCollection.add((CustomerInvoiceItem)model);
            }

            return customerinvoiceitemCollection;
        }

        public static CustomerInvoiceItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomerInvoiceItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomerInvoiceItem)gateway.retrieve(ResourceType.CUSTOMER_INVOICE_ITEM, id);
        }

        public CustomerInvoice getCustomerInvoice()
        {
            return (CustomerInvoice)this.getProperty("customerInvoice");
        }

        public void setCustomerInvoice(CustomerInvoice customerInvoice)
        {
            this.setProperty("customerInvoice", customerInvoice);
        }

        public ItemUnit getItemUnit()
        {
            return (ItemUnit)this.getProperty("itemUnit");
        }

        public void setItemUnit(ItemUnit itemUnit)
        {
            this.setProperty("itemUnit", itemUnit);
        }

        public string getItemDescription()
        {
            return this.getProperty("itemDescription").ToString();
        }

        public void setItemDescription(string itemDescription)
        {
            this.setProperty("itemDescription", itemDescription);
        }

        public string getItemPriceExVat()
        {
            return this.getProperty("itemPriceExVat").ToString();
        }

        public void setItemPriceExVat(string itemPriceExVat)
        {
            this.setProperty("itemPriceExVat", itemPriceExVat);
        }

        public int getQuantityInvoiced()
        {
            return Convert.ToInt32(this.getProperty("quantityInvoiced"));
        }

        public void setQuantityInvoiced(int quantityInvoiced)
        {
            this.setProperty("quantityInvoiced", quantityInvoiced);
        }

        public VatRate getVatRate()
        {
            return (VatRate)this.getProperty("vatRate");
        }

        public void setVatRate(VatRate vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }

        public string getItemVatAmount()
        {
            return this.getProperty("itemVatAmount").ToString();
        }

        public void setItemVatAmount(string itemVatAmount)
        {
            this.setProperty("itemVatAmount", itemVatAmount);
        }

        public string getItemTotalAmount()
        {
            return this.getProperty("itemTotalAmount").ToString();
        }

        public void setItemTotalAmount(string itemTotalAmount)
        {
            this.setProperty("itemTotalAmount", itemTotalAmount);
        }

        public int getLineNumber()
        {
            return Convert.ToInt32(this.getProperty("lineNumber"));
        }

        public void setLineNumber(int lineNumber)
        {
            this.setProperty("lineNumber", lineNumber);
        }

        public DateTime getFullyPaidDate()
        {
            return Convert.ToDateTime(this.getProperty("fullyPaidDate"));
        }

        public void setFullyPaidDate(DateTime fullyPaidDate)
        {
            this.setProperty("fullyPaidDate", fullyPaidDate);
        }

        public string getItemStatus()
        {
            return this.getProperty("itemStatus").ToString();
        }

        public void setItemStatus(string itemStatus)
        {
            this.setProperty("itemStatus", itemStatus);
        }


    }
}

