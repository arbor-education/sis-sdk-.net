using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class PettyCashTransaction : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_PETTY_CASH_TRANSACTION;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string TRANSACTION_AMOUNT = "transactionAmount";
        public const string TRANSACTION_DATETIME = "transactionDatetime";
        public const string PETTY_CASH_TRANSACTION_NUMBER = "pettyCashTransactionNumber";
        public const string NARRATIVE = "narrative";
        public const string TRANSACTION_CANCELLED_DATETIME = "transactionCancelledDatetime";
        public const string TRANSACTION_CANCELLED_NARRATIVE = "transactionCancelledNarrative";

        public PettyCashTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PettyCashTransaction (string resourceType = "PettyCashTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PettyCashTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_PettyCashTransaction");
        	RestGateway gateway = (RestGateway) PettyCashTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PettyCashTransaction> pettycashtransactionCollection = new ModelCollection<PettyCashTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pettycashtransactionCollection.add((PettyCashTransaction) model);
        	}
        
        	return pettycashtransactionCollection;
        }

        public static PettyCashTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PettyCashTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PettyCashTransaction) gateway.retrieve(ResourceType.FINANCE_PETTY_CASH_TRANSACTION, id);
        }

        public ModelBase getBankAccount ()
        {
            return (ModelBase) this.getProperty("bankAccount");
        }

        public void setBankAccount (ModelBase bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public string getTransactionAmount ()
        {
            return this.getProperty("transactionAmount").ToString();
        }

        public void setTransactionAmount (string transactionAmount)
        {
            this.setProperty("transactionAmount", transactionAmount);
        }

        public DateTime getTransactionDatetime ()
        {
            return (DateTime) this.getProperty("transactionDatetime");
        }

        public void setTransactionDatetime (DateTime transactionDatetime)
        {
            this.setProperty("transactionDatetime", transactionDatetime);
        }

        public string getPettyCashTransactionNumber ()
        {
            return this.getProperty("pettyCashTransactionNumber").ToString();
        }

        public void setPettyCashTransactionNumber (string pettyCashTransactionNumber)
        {
            this.setProperty("pettyCashTransactionNumber", pettyCashTransactionNumber);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getTransactionCancelledDatetime ()
        {
            return (DateTime) this.getProperty("transactionCancelledDatetime");
        }

        public void setTransactionCancelledDatetime (DateTime transactionCancelledDatetime)
        {
            this.setProperty("transactionCancelledDatetime", transactionCancelledDatetime);
        }

        public string getTransactionCancelledNarrative ()
        {
            return this.getProperty("transactionCancelledNarrative").ToString();
        }

        public void setTransactionCancelledNarrative (string transactionCancelledNarrative)
        {
            this.setProperty("transactionCancelledNarrative", transactionCancelledNarrative);
        }


    }
}

