using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class PaymentRun : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_PAYMENT_RUN;
        public const string BANK = "bank";
        public const string GENERAL_JOURNAL_ENTRY = "generalJournalEntry";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string RUN_DATETIME = "runDatetime";
        public const string NARRATIVE = "narrative";
        public const string PAYMENT_RUN_STATUS = "paymentRunStatus";
        public const string PAYMENT_RUN_NUMBER = "paymentRunNumber";

        public PaymentRun ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PaymentRun (string resourceType = "PaymentRun", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PaymentRun> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_PaymentRun");
        	RestGateway gateway = (RestGateway) PaymentRun.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PaymentRun> paymentrunCollection = new ModelCollection<PaymentRun> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    paymentrunCollection.add((PaymentRun) model);
        	}
        
        	return paymentrunCollection;
        }

        public static PaymentRun retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PaymentRun.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PaymentRun) gateway.retrieve(ResourceType.FINANCE_PAYMENT_RUN, id);
        }

        public ModelBase getBank ()
        {
            return (ModelBase) this.getProperty("bank");
        }

        public void setBank (ModelBase bank)
        {
            this.setProperty("bank", bank);
        }

        public ModelBase getGeneralJournalEntry ()
        {
            return (ModelBase) this.getProperty("generalJournalEntry");
        }

        public void setGeneralJournalEntry (ModelBase generalJournalEntry)
        {
            this.setProperty("generalJournalEntry", generalJournalEntry);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public DateTime getRunDatetime ()
        {
            return (DateTime) this.getProperty("runDatetime");
        }

        public void setRunDatetime (DateTime runDatetime)
        {
            this.setProperty("runDatetime", runDatetime);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public string getPaymentRunStatus ()
        {
            return this.getProperty("paymentRunStatus").ToString();
        }

        public void setPaymentRunStatus (string paymentRunStatus)
        {
            this.setProperty("paymentRunStatus", paymentRunStatus);
        }

        public string getPaymentRunNumber ()
        {
            return this.getProperty("paymentRunNumber").ToString();
        }

        public void setPaymentRunNumber (string paymentRunNumber)
        {
            this.setProperty("paymentRunNumber", paymentRunNumber);
        }


    }
}

