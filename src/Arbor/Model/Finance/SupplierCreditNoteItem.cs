using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierCreditNoteItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_CREDIT_NOTE_ITEM;
        public const string SUPPLIER_CREDIT_NOTE = "supplierCreditNote";
        public const string SUPPLIER_INVOICE_ITEM = "supplierInvoiceItem";
        public const string CREDIT_AMOUNT = "creditAmount";
        public const string QUANTITY_CREDITED = "quantityCredited";
        public const string NARRATIVE = "narrative";

        public SupplierCreditNoteItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierCreditNoteItem (string resourceType = "SupplierCreditNoteItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierCreditNoteItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierCreditNoteItem");
        	RestGateway gateway = (RestGateway) SupplierCreditNoteItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierCreditNoteItem> suppliercreditnoteitemCollection = new ModelCollection<SupplierCreditNoteItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    suppliercreditnoteitemCollection.add((SupplierCreditNoteItem) model);
        	}
        
        	return suppliercreditnoteitemCollection;
        }

        public static SupplierCreditNoteItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierCreditNoteItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierCreditNoteItem) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_CREDIT_NOTE_ITEM, id);
        }

        public ModelBase getSupplierCreditNote ()
        {
            return (ModelBase) this.getProperty("supplierCreditNote");
        }

        public void setSupplierCreditNote (ModelBase supplierCreditNote)
        {
            this.setProperty("supplierCreditNote", supplierCreditNote);
        }

        public ModelBase getSupplierInvoiceItem ()
        {
            return (ModelBase) this.getProperty("supplierInvoiceItem");
        }

        public void setSupplierInvoiceItem (ModelBase supplierInvoiceItem)
        {
            this.setProperty("supplierInvoiceItem", supplierInvoiceItem);
        }

        public string getCreditAmount ()
        {
            return this.getProperty("creditAmount").ToString();
        }

        public void setCreditAmount (string creditAmount)
        {
            this.setProperty("creditAmount", creditAmount);
        }

        public int getQuantityCredited ()
        {
            return Convert.ToInt32(this.getProperty("quantityCredited"));
        }

        public void setQuantityCredited (int quantityCredited)
        {
            this.setProperty("quantityCredited", quantityCredited);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

