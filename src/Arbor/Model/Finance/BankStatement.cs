using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class BankStatement : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_BANK_STATEMENT;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string STATEMENT_DATE = "statementDate";
        public const string STATEMENT_NUMBER = "statementNumber";
        public const string PERIOD_COVERED_START_DATE = "periodCoveredStartDate";
        public const string PERIOD_COVERED_END_DATE = "periodCoveredEndDate";
        public const string OPENING_BALANCE = "openingBalance";
        public const string CLOSING_BALANCE = "closingBalance";

        public BankStatement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BankStatement (string resourceType = "BankStatement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BankStatement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_BankStatement");
        	RestGateway gateway = (RestGateway) BankStatement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BankStatement> bankstatementCollection = new ModelCollection<BankStatement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bankstatementCollection.add((BankStatement) model);
        	}
        
        	return bankstatementCollection;
        }

        public static BankStatement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BankStatement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BankStatement) gateway.retrieve(ResourceType.FINANCE_BANK_STATEMENT, id);
        }

        public ModelBase getBankAccount ()
        {
            return (ModelBase) this.getProperty("bankAccount");
        }

        public void setBankAccount (ModelBase bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public DateTime getStatementDate ()
        {
            return (DateTime) this.getProperty("statementDate");
        }

        public void setStatementDate (DateTime statementDate)
        {
            this.setProperty("statementDate", statementDate);
        }

        public int getStatementNumber ()
        {
            return Convert.ToInt32(this.getProperty("statementNumber"));
        }

        public void setStatementNumber (int statementNumber)
        {
            this.setProperty("statementNumber", statementNumber);
        }

        public DateTime getPeriodCoveredStartDate ()
        {
            return (DateTime) this.getProperty("periodCoveredStartDate");
        }

        public void setPeriodCoveredStartDate (DateTime periodCoveredStartDate)
        {
            this.setProperty("periodCoveredStartDate", periodCoveredStartDate);
        }

        public DateTime getPeriodCoveredEndDate ()
        {
            return (DateTime) this.getProperty("periodCoveredEndDate");
        }

        public void setPeriodCoveredEndDate (DateTime periodCoveredEndDate)
        {
            this.setProperty("periodCoveredEndDate", periodCoveredEndDate);
        }

        public string getOpeningBalance ()
        {
            return this.getProperty("openingBalance").ToString();
        }

        public void setOpeningBalance (string openingBalance)
        {
            this.setProperty("openingBalance", openingBalance);
        }

        public string getClosingBalance ()
        {
            return this.getProperty("closingBalance").ToString();
        }

        public void setClosingBalance (string closingBalance)
        {
            this.setProperty("closingBalance", closingBalance);
        }


    }
}

