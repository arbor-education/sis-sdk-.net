using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BankAccount : ModelBase
    {
        protected new string resourceType = ResourceType.BANK_ACCOUNT;
        public const string BANK = "bank";
        public const string PAYMENT_PROVIDER = "paymentProvider";
        public const string ACCOUNT_HOLDER_NAME = "accountHolderName";
        public const string ACCOUNT_NUMBER = "accountNumber";
        public const string SORT_CODE = "sortCode";
        public const string SWIFT_CODE = "swiftCode";
        public const string IBAN = "iban";
        public const string BACS_USER_NUMBER = "bacsUserNumber";

        public BankAccount ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BankAccount (string resourceType = "BankAccount", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BankAccount> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BankAccount");
        	RestGateway gateway = (RestGateway) BankAccount.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BankAccount> bankaccountCollection = new ModelCollection<BankAccount> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bankaccountCollection.add((BankAccount) model);
        	}
        
        	return bankaccountCollection;
        }

        public static BankAccount retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BankAccount.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BankAccount) gateway.retrieve(ResourceType.BANK_ACCOUNT, id);
        }

        public Bank getBank ()
        {
            return (Bank) this.getProperty("bank");
        }

        public void setBank (Bank bank)
        {
            this.setProperty("bank", bank);
        }

        public PaymentProvider getPaymentProvider ()
        {
            return (PaymentProvider) this.getProperty("paymentProvider");
        }

        public void setPaymentProvider (PaymentProvider paymentProvider)
        {
            this.setProperty("paymentProvider", paymentProvider);
        }

        public string getAccountHolderName ()
        {
            return this.getProperty("accountHolderName").ToString();
        }

        public void setAccountHolderName (string accountHolderName)
        {
            this.setProperty("accountHolderName", accountHolderName);
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

        public string getSwiftCode ()
        {
            return this.getProperty("swiftCode").ToString();
        }

        public void setSwiftCode (string swiftCode)
        {
            this.setProperty("swiftCode", swiftCode);
        }

        public string getIban ()
        {
            return this.getProperty("iban").ToString();
        }

        public void setIban (string iban)
        {
            this.setProperty("iban", iban);
        }

        public string getBacsUserNumber ()
        {
            return this.getProperty("bacsUserNumber").ToString();
        }

        public void setBacsUserNumber (string bacsUserNumber)
        {
            this.setProperty("bacsUserNumber", bacsUserNumber);
        }


    }
}

