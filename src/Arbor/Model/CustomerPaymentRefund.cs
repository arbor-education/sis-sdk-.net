using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerPaymentRefund : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOMER_PAYMENT_REFUND;
        public const string CUSTOMER_PAYMENT = "customerPayment";
        public const string REFUND_DATETIME = "refundDatetime";
        public const string REFUND_AMOUNT = "refundAmount";
        public const string REFUND_TRANSACTION = "refundTransaction";
        public const string REFUND_SUCCEEDED_DATETIME = "refundSucceededDatetime";
        public const string REFUND_FAILED_DATETIME = "refundFailedDatetime";

        public CustomerPaymentRefund ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerPaymentRefund (string resourceType = "CustomerPaymentRefund", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerPaymentRefund> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomerPaymentRefund");
        	RestGateway gateway = (RestGateway) CustomerPaymentRefund.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerPaymentRefund> customerpaymentrefundCollection = new ModelCollection<CustomerPaymentRefund> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customerpaymentrefundCollection.add((CustomerPaymentRefund) model);
        	}
        
        	return customerpaymentrefundCollection;
        }

        public static CustomerPaymentRefund retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerPaymentRefund.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerPaymentRefund) gateway.retrieve(ResourceType.CUSTOMER_PAYMENT_REFUND, id);
        }

        public CustomerPayment getCustomerPayment ()
        {
            return (CustomerPayment) this.getProperty("customerPayment");
        }

        public void setCustomerPayment (CustomerPayment customerPayment)
        {
            this.setProperty("customerPayment", customerPayment);
        }

        public DateTime getRefundDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("refundDatetime"));
        }

        public void setRefundDatetime (DateTime refundDatetime)
        {
            this.setProperty("refundDatetime", refundDatetime);
        }

        public string getRefundAmount ()
        {
            return this.getProperty("refundAmount").ToString();
        }

        public void setRefundAmount (string refundAmount)
        {
            this.setProperty("refundAmount", refundAmount);
        }

        public ModelBase getRefundTransaction ()
        {
            return (ModelBase) this.getProperty("refundTransaction");
        }

        public void setRefundTransaction (ModelBase refundTransaction)
        {
            this.setProperty("refundTransaction", refundTransaction);
        }

        public DateTime getRefundSucceededDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("refundSucceededDatetime"));
        }

        public void setRefundSucceededDatetime (DateTime refundSucceededDatetime)
        {
            this.setProperty("refundSucceededDatetime", refundSucceededDatetime);
        }

        public DateTime getRefundFailedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("refundFailedDatetime"));
        }

        public void setRefundFailedDatetime (DateTime refundFailedDatetime)
        {
            this.setProperty("refundFailedDatetime", refundFailedDatetime);
        }


    }
}

