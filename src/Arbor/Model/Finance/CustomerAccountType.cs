using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CustomerAccountType : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CUSTOMER_ACCOUNT_TYPE;
        public const string ACCOUNT_TYPE_NAME = "accountTypeName";
        public const string ACCOUNT_TYPE_DESCRIPTION = "accountTypeDescription";
        public const string CODE = "code";
        public const string IS_PREPAYMENT = "isPrepayment";
        public const string AUTO_CREATE_FOR_STUDENTS = "autoCreateForStudents";
        public const string AUTO_CREATE_FOR_STAFF = "autoCreateForStaff";

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
        	query.setResourceType ("Finance_CustomerAccountType");
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
        	return (CustomerAccountType) gateway.retrieve(ResourceType.FINANCE_CUSTOMER_ACCOUNT_TYPE, id);
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

        public bool getIsPrepayment ()
        {
            return (bool) this.getProperty("isPrepayment");
        }

        public void setIsPrepayment (bool isPrepayment)
        {
            this.setProperty("isPrepayment", isPrepayment);
        }

        public bool getAutoCreateForStudents ()
        {
            return (bool) this.getProperty("autoCreateForStudents");
        }

        public void setAutoCreateForStudents (bool autoCreateForStudents)
        {
            this.setProperty("autoCreateForStudents", autoCreateForStudents);
        }

        public bool getAutoCreateForStaff ()
        {
            return (bool) this.getProperty("autoCreateForStaff");
        }

        public void setAutoCreateForStaff (bool autoCreateForStaff)
        {
            this.setProperty("autoCreateForStaff", autoCreateForStaff);
        }


    }
}

