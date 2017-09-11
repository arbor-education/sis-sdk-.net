using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerAccountRefund : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOMER_ACCOUNT_REFUND;
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string REFUND_DATETIME = "refundDatetime";
        public const string REFUND = "refund";
        public const string TRANSACTION = "transaction";

        public CustomerAccountRefund ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerAccountRefund (string resourceType = "CustomerAccountRefund", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerAccountRefund> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomerAccountRefund");
        	RestGateway gateway = (RestGateway) CustomerAccountRefund.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerAccountRefund> customeraccountrefundCollection = new ModelCollection<CustomerAccountRefund> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customeraccountrefundCollection.add((CustomerAccountRefund) model);
        	}
        
        	return customeraccountrefundCollection;
        }

        public static CustomerAccountRefund retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerAccountRefund.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerAccountRefund) gateway.retrieve(ResourceType.CUSTOMER_ACCOUNT_REFUND, id);
        }

        public CustomerAccount getCustomerAccount ()
        {
            return (CustomerAccount) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public DateTime getRefundDatetime ()
        {
            return (DateTime) this.getProperty("refundDatetime");
        }

        public void setRefundDatetime (DateTime refundDatetime)
        {
            this.setProperty("refundDatetime", refundDatetime);
        }

        public string getRefund ()
        {
            return this.getProperty("refund").ToString();
        }

        public void setRefund (string refund)
        {
            this.setProperty("refund", refund);
        }

        public ModelBase getTransaction ()
        {
            return (ModelBase) this.getProperty("transaction");
        }

        public void setTransaction (ModelBase transaction)
        {
            this.setProperty("transaction", transaction);
        }


    }
}

