using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class BankDeposit : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_BANK_DEPOSIT;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string PAID_TO_BANK_DATE = "paidToBankDate";
        public const string PAID_BY_STAFF = "paidByStaff";
        public const string DEPOSIT_DATETIME = "depositDatetime";
        public const string TOTAL_CHEQUE_AMOUNT = "totalChequeAmount";
        public const string TOTAL_CASH_AMOUNT = "totalCashAmount";

        public BankDeposit ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BankDeposit (string resourceType = "BankDeposit", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BankDeposit> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_BankDeposit");
        	RestGateway gateway = (RestGateway) BankDeposit.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BankDeposit> bankdepositCollection = new ModelCollection<BankDeposit> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bankdepositCollection.add((BankDeposit) model);
        	}
        
        	return bankdepositCollection;
        }

        public static BankDeposit retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BankDeposit.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BankDeposit) gateway.retrieve(ResourceType.FINANCE_BANK_DEPOSIT, id);
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

        public DateTime getPaidToBankDate ()
        {
            return (DateTime) this.getProperty("paidToBankDate");
        }

        public void setPaidToBankDate (DateTime paidToBankDate)
        {
            this.setProperty("paidToBankDate", paidToBankDate);
        }

        public Staff getPaidByStaff ()
        {
            return (Staff) this.getProperty("paidByStaff");
        }

        public void setPaidByStaff (Staff paidByStaff)
        {
            this.setProperty("paidByStaff", paidByStaff);
        }

        public DateTime getDepositDatetime ()
        {
            return (DateTime) this.getProperty("depositDatetime");
        }

        public void setDepositDatetime (DateTime depositDatetime)
        {
            this.setProperty("depositDatetime", depositDatetime);
        }

        public string getTotalChequeAmount ()
        {
            return this.getProperty("totalChequeAmount").ToString();
        }

        public void setTotalChequeAmount (string totalChequeAmount)
        {
            this.setProperty("totalChequeAmount", totalChequeAmount);
        }

        public string getTotalCashAmount ()
        {
            return this.getProperty("totalCashAmount").ToString();
        }

        public void setTotalCashAmount (string totalCashAmount)
        {
            this.setProperty("totalCashAmount", totalCashAmount);
        }


    }
}

