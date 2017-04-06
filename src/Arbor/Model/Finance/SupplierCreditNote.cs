using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierCreditNote : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_CREDIT_NOTE;
        public const string SUPPLIER = "supplier";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string GENERAL_JOURNAL_ENTRY = "generalJournalEntry";
        public const string CREDIT_NOTE_NUMBER = "creditNoteNumber";
        public const string CREDIT_NOTE_DATETIME = "creditNoteDatetime";
        public const string ISSUED_DATETIME = "issuedDatetime";
        public const string NARRATIVE = "narrative";

        public SupplierCreditNote ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierCreditNote (string resourceType = "SupplierCreditNote", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierCreditNote> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierCreditNote");
        	RestGateway gateway = (RestGateway) SupplierCreditNote.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierCreditNote> suppliercreditnoteCollection = new ModelCollection<SupplierCreditNote> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    suppliercreditnoteCollection.add((SupplierCreditNote) model);
        	}
        
        	return suppliercreditnoteCollection;
        }

        public static SupplierCreditNote retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierCreditNote.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierCreditNote) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_CREDIT_NOTE, id);
        }

        public ModelBase getSupplier ()
        {
            return (ModelBase) this.getProperty("supplier");
        }

        public void setSupplier (ModelBase supplier)
        {
            this.setProperty("supplier", supplier);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public ModelBase getGeneralJournalEntry ()
        {
            return (ModelBase) this.getProperty("generalJournalEntry");
        }

        public void setGeneralJournalEntry (ModelBase generalJournalEntry)
        {
            this.setProperty("generalJournalEntry", generalJournalEntry);
        }

        public string getCreditNoteNumber ()
        {
            return this.getProperty("creditNoteNumber").ToString();
        }

        public void setCreditNoteNumber (string creditNoteNumber)
        {
            this.setProperty("creditNoteNumber", creditNoteNumber);
        }

        public DateTime getCreditNoteDatetime ()
        {
            return (DateTime) this.getProperty("creditNoteDatetime");
        }

        public void setCreditNoteDatetime (DateTime creditNoteDatetime)
        {
            this.setProperty("creditNoteDatetime", creditNoteDatetime);
        }

        public DateTime getIssuedDatetime ()
        {
            return (DateTime) this.getProperty("issuedDatetime");
        }

        public void setIssuedDatetime (DateTime issuedDatetime)
        {
            this.setProperty("issuedDatetime", issuedDatetime);
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

