using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerAccount : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOMER_ACCOUNT;
        public const string RELATED_ENTITY = "relatedEntity";
        public const string DELETED_RELATED_ENTITY_NAME = "deletedRelatedEntityName";
        public const string CUSTOMER_ACCOUNT_TYPE = "customerAccountType";
        public const string BILL_PAYER1 = "billPayer1";
        public const string BILL_PAYER2 = "billPayer2";
        public const string BILL_PAYER3 = "billPayer3";
        public const string BILL_PAYER1_PROPORTION = "billPayer1Proportion";
        public const string BILL_PAYER2_PROPORTION = "billPayer2Proportion";
        public const string BILL_PAYER3_PROPORTION = "billPayer3Proportion";
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
        	query.setResourceType ("CustomerAccount");
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
        	return (CustomerAccount) gateway.retrieve(ResourceType.CUSTOMER_ACCOUNT, id);
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

        public CustomerAccountType getCustomerAccountType ()
        {
            return (CustomerAccountType) this.getProperty("customerAccountType");
        }

        public void setCustomerAccountType (CustomerAccountType customerAccountType)
        {
            this.setProperty("customerAccountType", customerAccountType);
        }

        public BillPayer getBillPayer1 ()
        {
            return (BillPayer) this.getProperty("billPayer1");
        }

        public void setBillPayer1 (BillPayer billPayer1)
        {
            this.setProperty("billPayer1", billPayer1);
        }

        public BillPayer getBillPayer2 ()
        {
            return (BillPayer) this.getProperty("billPayer2");
        }

        public void setBillPayer2 (BillPayer billPayer2)
        {
            this.setProperty("billPayer2", billPayer2);
        }

        public BillPayer getBillPayer3 ()
        {
            return (BillPayer) this.getProperty("billPayer3");
        }

        public void setBillPayer3 (BillPayer billPayer3)
        {
            this.setProperty("billPayer3", billPayer3);
        }

        public float getBillPayer1Proportion ()
        {
            return (float) this.getProperty("billPayer1Proportion");
        }

        public void setBillPayer1Proportion (float billPayer1Proportion)
        {
            this.setProperty("billPayer1Proportion", billPayer1Proportion);
        }

        public float getBillPayer2Proportion ()
        {
            return (float) this.getProperty("billPayer2Proportion");
        }

        public void setBillPayer2Proportion (float billPayer2Proportion)
        {
            this.setProperty("billPayer2Proportion", billPayer2Proportion);
        }

        public float getBillPayer3Proportion ()
        {
            return (float) this.getProperty("billPayer3Proportion");
        }

        public void setBillPayer3Proportion (float billPayer3Proportion)
        {
            this.setProperty("billPayer3Proportion", billPayer3Proportion);
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
            return Convert.ToDateTime(this.getProperty("openingBalanceTransactionDatetime"))
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

