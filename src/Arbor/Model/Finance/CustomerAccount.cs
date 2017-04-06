using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CustomerAccount : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CUSTOMER_ACCOUNT;
        public const string RELATED_ENTITY = "relatedEntity";
        public const string DELETED_RELATED_ENTITY_NAME = "deletedRelatedEntityName";
        public const string CUSTOMER_ACCOUNT_TYPE = "customerAccountType";
        public const string BILL_PAYER_1 = "billPayer_1";
        public const string BILL_PAYER_2 = "billPayer_2";
        public const string BILL_PAYER_3 = "billPayer_3";
        public const string BILL_PAYER_1_PROPORTION = "billPayer_1Proportion";
        public const string BILL_PAYER_2_PROPORTION = "billPayer_2Proportion";
        public const string BILL_PAYER_3_PROPORTION = "billPayer_3Proportion";
        public const string ACCOUNT_BALANCE = "accountBalance";
        public const string CREDIT_LIMIT = "creditLimit";
        public const string OPENING_BALANCE_TRANSACTION_DATETIME = "openingBalanceTransactionDatetime";
        public const string OPENING_BALANCE_TRANSACTION = "openingBalanceTransaction";

        public CustomerAccount ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerAccount (string resourceType = "CustomerAccount", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerAccount> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_CustomerAccount");
        	RestGateway gateway = (RestGateway) CustomerAccount.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerAccount> customeraccountCollection = new ModelCollection<CustomerAccount> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customeraccountCollection.add((CustomerAccount) model);
        	}
        
        	return customeraccountCollection;
        }

        public static CustomerAccount retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerAccount.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerAccount) gateway.retrieve(ResourceType.FINANCE_CUSTOMER_ACCOUNT, id);
        }

        public ModelBase getRelatedEntity ()
        {
            return (ModelBase) this.getProperty("relatedEntity");
        }

        public void setRelatedEntity (ModelBase relatedEntity)
        {
            this.setProperty("relatedEntity", relatedEntity);
        }

        public string getDeletedRelatedEntityName ()
        {
            return this.getProperty("deletedRelatedEntityName").ToString();
        }

        public void setDeletedRelatedEntityName (string deletedRelatedEntityName)
        {
            this.setProperty("deletedRelatedEntityName", deletedRelatedEntityName);
        }

        public ModelBase getCustomerAccountType ()
        {
            return (ModelBase) this.getProperty("customerAccountType");
        }

        public void setCustomerAccountType (ModelBase customerAccountType)
        {
            this.setProperty("customerAccountType", customerAccountType);
        }

        public ModelBase getBillPayer_1 ()
        {
            return (ModelBase) this.getProperty("billPayer_1");
        }

        public void setBillPayer_1 (ModelBase billPayer_1)
        {
            this.setProperty("billPayer_1", billPayer_1);
        }

        public ModelBase getBillPayer_2 ()
        {
            return (ModelBase) this.getProperty("billPayer_2");
        }

        public void setBillPayer_2 (ModelBase billPayer_2)
        {
            this.setProperty("billPayer_2", billPayer_2);
        }

        public ModelBase getBillPayer_3 ()
        {
            return (ModelBase) this.getProperty("billPayer_3");
        }

        public void setBillPayer_3 (ModelBase billPayer_3)
        {
            this.setProperty("billPayer_3", billPayer_3);
        }

        public float getBillPayer_1Proportion ()
        {
            return (float) this.getProperty("billPayer_1Proportion");
        }

        public void setBillPayer_1Proportion (float billPayer_1Proportion)
        {
            this.setProperty("billPayer_1Proportion", billPayer_1Proportion);
        }

        public float getBillPayer_2Proportion ()
        {
            return (float) this.getProperty("billPayer_2Proportion");
        }

        public void setBillPayer_2Proportion (float billPayer_2Proportion)
        {
            this.setProperty("billPayer_2Proportion", billPayer_2Proportion);
        }

        public float getBillPayer_3Proportion ()
        {
            return (float) this.getProperty("billPayer_3Proportion");
        }

        public void setBillPayer_3Proportion (float billPayer_3Proportion)
        {
            this.setProperty("billPayer_3Proportion", billPayer_3Proportion);
        }

        public string getAccountBalance ()
        {
            return this.getProperty("accountBalance").ToString();
        }

        public void setAccountBalance (string accountBalance)
        {
            this.setProperty("accountBalance", accountBalance);
        }

        public string getCreditLimit ()
        {
            return this.getProperty("creditLimit").ToString();
        }

        public void setCreditLimit (string creditLimit)
        {
            this.setProperty("creditLimit", creditLimit);
        }

        public DateTime getOpeningBalanceTransactionDatetime ()
        {
            return (DateTime) this.getProperty("openingBalanceTransactionDatetime");
        }

        public void setOpeningBalanceTransactionDatetime (DateTime openingBalanceTransactionDatetime)
        {
            this.setProperty("openingBalanceTransactionDatetime", openingBalanceTransactionDatetime);
        }

        public ModelBase getOpeningBalanceTransaction ()
        {
            return (ModelBase) this.getProperty("openingBalanceTransaction");
        }

        public void setOpeningBalanceTransaction (ModelBase openingBalanceTransaction)
        {
            this.setProperty("openingBalanceTransaction", openingBalanceTransaction);
        }


    }
}

