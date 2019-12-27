using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerAccountType : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOMER_ACCOUNT_TYPE;
        public const string ACCOUNT_TYPE_NAME = "accountTypeName";
        public const string ACCOUNT_TYPE_DESCRIPTION = "accountTypeDescription";
        public const string CODE = "code";
        public const string CATEGORY = "category";
        public const string IS_PREPAYMENT = "isPrepayment";
        public const string AUTO_CREATE_FOR_STUDENTS = "autoCreateForStudents";
        public const string AUTO_CREATE_FOR_STAFF = "autoCreateForStaff";
        public const string CARD_PAYMENTS_ENABLED = "cardPaymentsEnabled";
        public const string SHOW_IN_PARENT_PORTAL = "showInParentPortal";
        public const string ACCOUNTING_CODE = "accountingCode";

        public CustomerAccountType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerAccountType (string resourceType = "CustomerAccountType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerAccountType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomerAccountType");
        	RestGateway gateway = (RestGateway) CustomerAccountType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerAccountType> customeraccounttypeCollection = new ModelCollection<CustomerAccountType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customeraccounttypeCollection.add((CustomerAccountType) model);
        	}
        
        	return customeraccounttypeCollection;
        }

        public static CustomerAccountType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerAccountType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerAccountType) gateway.retrieve(ResourceType.CUSTOMER_ACCOUNT_TYPE, id);
        }

        public string getAccountTypeName ()
        {
            return this.getProperty("accountTypeName").ToString();
        }

        public void setAccountTypeName (string accountTypeName)
        {
            this.setProperty("accountTypeName", accountTypeName);
        }

        public string getAccountTypeDescription ()
        {
            return this.getProperty("accountTypeDescription").ToString();
        }

        public void setAccountTypeDescription (string accountTypeDescription)
        {
            this.setProperty("accountTypeDescription", accountTypeDescription);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getCategory ()
        {
            return this.getProperty("category").ToString();
        }

        public void setCategory (string category)
        {
            this.setProperty("category", category);
        }

        public bool getIsPrepayment ()
        {
            return Convert.ToBoolean(this.getProperty("isPrepayment"));
        }

        public void setIsPrepayment (bool isPrepayment)
        {
            this.setProperty("isPrepayment", isPrepayment);
        }

        public bool getAutoCreateForStudents ()
        {
            return Convert.ToBoolean(this.getProperty("autoCreateForStudents"));
        }

        public void setAutoCreateForStudents (bool autoCreateForStudents)
        {
            this.setProperty("autoCreateForStudents", autoCreateForStudents);
        }

        public bool getAutoCreateForStaff ()
        {
            return Convert.ToBoolean(this.getProperty("autoCreateForStaff"));
        }

        public void setAutoCreateForStaff (bool autoCreateForStaff)
        {
            this.setProperty("autoCreateForStaff", autoCreateForStaff);
        }

        public bool getCardPaymentsEnabled ()
        {
            return Convert.ToBoolean(this.getProperty("cardPaymentsEnabled"));
        }

        public void setCardPaymentsEnabled (bool cardPaymentsEnabled)
        {
            this.setProperty("cardPaymentsEnabled", cardPaymentsEnabled);
        }

        public bool getShowInParentPortal ()
        {
            return Convert.ToBoolean(this.getProperty("showInParentPortal"));
        }

        public void setShowInParentPortal (bool showInParentPortal)
        {
            this.setProperty("showInParentPortal", showInParentPortal);
        }

        public string getAccountingCode ()
        {
            return this.getProperty("accountingCode").ToString();
        }

        public void setAccountingCode (string accountingCode)
        {
            this.setProperty("accountingCode", accountingCode);
        }


    }
}

