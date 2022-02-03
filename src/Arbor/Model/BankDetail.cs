using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BankDetail : ModelBase
    {
        protected string resourceType = ResourceType.BANK_DETAIL;
        public const string ACCOUNT_HOLDER = "accountHolder";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string BANK = "bank";
        public const string ACCOUNT_NAME = "accountName";
        public const string ACCOUNT_NUMBER = "accountNumber";
        public const string SORT_CODE = "sortCode";

        public BankDetail ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BankDetail (string resourceType = "BankDetail", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BankDetail> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BankDetail");
        	RestGateway gateway = (RestGateway) BankDetail.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BankDetail> bankdetailCollection = new ModelCollection<BankDetail> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bankdetailCollection.add((BankDetail) model);
        	}
        
        	return bankdetailCollection;
        }

        public static BankDetail retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BankDetail.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BankDetail) gateway.retrieve(ResourceType.BANK_DETAIL, id);
        }

        public Staff getAccountHolder ()
        {
            return (Staff) this.getProperty("accountHolder");
        }

        public void setAccountHolder (Staff accountHolder)
        {
            this.setProperty("accountHolder", accountHolder);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public Bank getBank ()
        {
            return (Bank) this.getProperty("bank");
        }

        public void setBank (Bank bank)
        {
            this.setProperty("bank", bank);
        }

        public string getAccountName ()
        {
            return this.getProperty("accountName").ToString();
        }

        public void setAccountName (string accountName)
        {
            this.setProperty("accountName", accountName);
        }

        public string getAccountNumber ()
        {
            return this.getProperty("accountNumber").ToString();
        }

        public void setAccountNumber (string accountNumber)
        {
            this.setProperty("accountNumber", accountNumber);
        }

        public string getSortCode ()
        {
            return this.getProperty("sortCode").ToString();
        }

        public void setSortCode (string sortCode)
        {
            this.setProperty("sortCode", sortCode);
        }


    }
}

