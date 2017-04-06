using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class ExtraJournalEntry : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_EXTRA_JOURNAL_ENTRY;
        public const string GENERAL_JOURNAL_ENTRY = "generalJournalEntry";
        public const string RELATED_OBJECT = "relatedObject";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string AUTHORISING_STAFF = "authorisingStaff";
        public const string JOURNAL_TYPE = "journalType";
        public const string JOURNAL_DATETIME = "journalDatetime";
        public const string NARRATIVE = "narrative";
        public const string BANK_REFERENCE = "bankReference";

        public ExtraJournalEntry ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ExtraJournalEntry (string resourceType = "ExtraJournalEntry", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ExtraJournalEntry> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_ExtraJournalEntry");
        	RestGateway gateway = (RestGateway) ExtraJournalEntry.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ExtraJournalEntry> extrajournalentryCollection = new ModelCollection<ExtraJournalEntry> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    extrajournalentryCollection.add((ExtraJournalEntry) model);
        	}
        
        	return extrajournalentryCollection;
        }

        public static ExtraJournalEntry retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ExtraJournalEntry.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ExtraJournalEntry) gateway.retrieve(ResourceType.FINANCE_EXTRA_JOURNAL_ENTRY, id);
        }

        public ModelBase getGeneralJournalEntry ()
        {
            return (ModelBase) this.getProperty("generalJournalEntry");
        }

        public void setGeneralJournalEntry (ModelBase generalJournalEntry)
        {
            this.setProperty("generalJournalEntry", generalJournalEntry);
        }

        public ModelBase getRelatedObject ()
        {
            return (ModelBase) this.getProperty("relatedObject");
        }

        public void setRelatedObject (ModelBase relatedObject)
        {
            this.setProperty("relatedObject", relatedObject);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public Staff getAuthorisingStaff ()
        {
            return (Staff) this.getProperty("authorisingStaff");
        }

        public void setAuthorisingStaff (Staff authorisingStaff)
        {
            this.setProperty("authorisingStaff", authorisingStaff);
        }

        public string getJournalType ()
        {
            return this.getProperty("journalType").ToString();
        }

        public void setJournalType (string journalType)
        {
            this.setProperty("journalType", journalType);
        }

        public DateTime getJournalDatetime ()
        {
            return (DateTime) this.getProperty("journalDatetime");
        }

        public void setJournalDatetime (DateTime journalDatetime)
        {
            this.setProperty("journalDatetime", journalDatetime);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public string getBankReference ()
        {
            return this.getProperty("bankReference").ToString();
        }

        public void setBankReference (string bankReference)
        {
            this.setProperty("bankReference", bankReference);
        }


    }
}

