using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class GeneralJournalEntry : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_GENERAL_JOURNAL_ENTRY;
        public const string RELATED_OBJECT = "relatedObject";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string AUTHORISING_STAFF = "authorisingStaff";
        public const string JOURNAL_TYPE = "journalType";
        public const string JOURNAL_DATETIME = "journalDatetime";
        public const string NARRATIVE = "narrative";

        public GeneralJournalEntry ()
        {
            base.resourceType = this.resourceType;
        }
        
        public GeneralJournalEntry (string resourceType = "GeneralJournalEntry", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<GeneralJournalEntry> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_GeneralJournalEntry");
        	RestGateway gateway = (RestGateway) GeneralJournalEntry.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<GeneralJournalEntry> generaljournalentryCollection = new ModelCollection<GeneralJournalEntry> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    generaljournalentryCollection.add((GeneralJournalEntry) model);
        	}
        
        	return generaljournalentryCollection;
        }

        public static GeneralJournalEntry retrieve (string id)
        {
            RestGateway gateway = (RestGateway) GeneralJournalEntry.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (GeneralJournalEntry) gateway.retrieve(ResourceType.FINANCE_GENERAL_JOURNAL_ENTRY, id);
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


    }
}

