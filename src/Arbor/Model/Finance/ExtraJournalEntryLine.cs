using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class ExtraJournalEntryLine : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_EXTRA_JOURNAL_ENTRY_LINE;
        public const string EXTRA_JOURNAL_ENTRY = "extraJournalEntry";
        public const string RELATED_OBJECT = "relatedObject";
        public const string LEDGER = "ledger";
        public const string COST_CENTER = "costCenter";
        public const string VAT_RATE = "vatRate";
        public const string DEBIT_AMOUNT = "debitAmount";
        public const string CREDIT_AMOUNT = "creditAmount";
        public const string VAT_AMOUNT = "vatAmount";

        public ExtraJournalEntryLine ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ExtraJournalEntryLine (string resourceType = "ExtraJournalEntryLine", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ExtraJournalEntryLine> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_ExtraJournalEntryLine");
        	RestGateway gateway = (RestGateway) ExtraJournalEntryLine.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ExtraJournalEntryLine> extrajournalentrylineCollection = new ModelCollection<ExtraJournalEntryLine> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    extrajournalentrylineCollection.add((ExtraJournalEntryLine) model);
        	}
        
        	return extrajournalentrylineCollection;
        }

        public static ExtraJournalEntryLine retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ExtraJournalEntryLine.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ExtraJournalEntryLine) gateway.retrieve(ResourceType.FINANCE_EXTRA_JOURNAL_ENTRY_LINE, id);
        }

        public ModelBase getExtraJournalEntry ()
        {
            return (ModelBase) this.getProperty("extraJournalEntry");
        }

        public void setExtraJournalEntry (ModelBase extraJournalEntry)
        {
            this.setProperty("extraJournalEntry", extraJournalEntry);
        }

        public ModelBase getRelatedObject ()
        {
            return (ModelBase) this.getProperty("relatedObject");
        }

        public void setRelatedObject (ModelBase relatedObject)
        {
            this.setProperty("relatedObject", relatedObject);
        }

        public ModelBase getLedger ()
        {
            return (ModelBase) this.getProperty("ledger");
        }

        public void setLedger (ModelBase ledger)
        {
            this.setProperty("ledger", ledger);
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

        public string getDebitAmount ()
        {
            return this.getProperty("debitAmount").ToString();
        }

        public void setDebitAmount (string debitAmount)
        {
            this.setProperty("debitAmount", debitAmount);
        }

        public string getCreditAmount ()
        {
            return this.getProperty("creditAmount").ToString();
        }

        public void setCreditAmount (string creditAmount)
        {
            this.setProperty("creditAmount", creditAmount);
        }

        public string getVatAmount ()
        {
            return this.getProperty("vatAmount").ToString();
        }

        public void setVatAmount (string vatAmount)
        {
            this.setProperty("vatAmount", vatAmount);
        }


    }
}

