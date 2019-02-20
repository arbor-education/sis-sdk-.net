using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BankDeposit : ModelBase
    {
        protected string resourceType = ResourceType.BANK_DEPOSIT;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string PAID_BY_STAFF = "paidByStaff";
        public const string DEPOSIT_DATETIME = "depositDatetime";
        public const string TOTAL_CHEQUE_AMOUNT = "totalChequeAmount";
        public const string TOTAL_CASH_AMOUNT = "totalCashAmount";
        public const string DEPOSIT_REFERENCE = "depositReference";

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
        	query.setResourceType ("BankDeposit");
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
        	return (BankDeposit) gateway.retrieve(ResourceType.BANK_DEPOSIT, id);
        }

        public BankAccount getBankAccount ()
        {
            return (BankAccount) this.getProperty("bankAccount");
        }

        public void setBankAccount (BankAccount bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
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
            return Convert.ToDateTime(this.getProperty("depositDatetime"));
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

        public string getDepositReference ()
        {
            return this.getProperty("depositReference").ToString();
        }

        public void setDepositReference (string depositReference)
        {
            this.setProperty("depositReference", depositReference);
        }


    }
}

