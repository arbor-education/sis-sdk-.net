using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerCreditNoteItem : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOMER_CREDIT_NOTE_ITEM;
        public const string CUSTOMER_CREDIT_NOTE = "customerCreditNote";
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string CUSTOMER_INVOICE_ITEM = "customerInvoiceItem";
        public const string CREDIT_AMOUNT = "creditAmount";
        public const string QUANTITY_CREDITED = "quantityCredited";
        public const string NARRATIVE = "narrative";

        public CustomerCreditNoteItem()
        {
            base.resourceType = this.resourceType;
        }

        public CustomerCreditNoteItem(string resourceType = "CustomerCreditNoteItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomerCreditNoteItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomerCreditNoteItem");
            RestGateway gateway = (RestGateway)CustomerCreditNoteItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomerCreditNoteItem> customercreditnoteitemCollection = new ModelCollection<CustomerCreditNoteItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customercreditnoteitemCollection.add((CustomerCreditNoteItem)model);
            }

            return customercreditnoteitemCollection;
        }

        public static CustomerCreditNoteItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomerCreditNoteItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomerCreditNoteItem)gateway.retrieve(ResourceType.CUSTOMER_CREDIT_NOTE_ITEM, id);
        }

        public CustomerCreditNote getCustomerCreditNote()
        {
            return (CustomerCreditNote)this.getProperty("customerCreditNote");
        }

        public void setCustomerCreditNote(CustomerCreditNote customerCreditNote)
        {
            this.setProperty("customerCreditNote", customerCreditNote);
        }

        public CustomerInvoice getCustomerInvoice()
        {
            return (CustomerInvoice)this.getProperty("customerInvoice");
        }

        public void setCustomerInvoice(CustomerInvoice customerInvoice)
        {
            this.setProperty("customerInvoice", customerInvoice);
        }

        public CustomerInvoiceItem getCustomerInvoiceItem()
        {
            return (CustomerInvoiceItem)this.getProperty("customerInvoiceItem");
        }

        public void setCustomerInvoiceItem(CustomerInvoiceItem customerInvoiceItem)
        {
            this.setProperty("customerInvoiceItem", customerInvoiceItem);
        }

        public string getCreditAmount()
        {
            return this.getProperty("creditAmount").ToString();
        }

        public void setCreditAmount(string creditAmount)
        {
            this.setProperty("creditAmount", creditAmount);
        }

        public int getQuantityCredited()
        {
            return Convert.ToInt32(this.getProperty("quantityCredited"));
        }

        public void setQuantityCredited(int quantityCredited)
        {
            this.setProperty("quantityCredited", quantityCredited);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

