using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CustomerPaymentItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CUSTOMER_PAYMENT_ITEM;
        public const string CUSTOMER_PAYMENT = "customerPayment";
        public const string CUSTOMER_INVOICE_ITEM = "customerInvoiceItem";
        public const string DESTINATION_LEDGER = "destinationLedger";
        public const string PAYMENT_AMOUNT_PER_ITEM = "paymentAmountPerItem";
        public const string QUANTITY_PAID = "quantityPaid";

        public CustomerPaymentItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerPaymentItem (string resourceType = "CustomerPaymentItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerPaymentItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_CustomerPaymentItem");
        	RestGateway gateway = (RestGateway) CustomerPaymentItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerPaymentItem> customerpaymentitemCollection = new ModelCollection<CustomerPaymentItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customerpaymentitemCollection.add((CustomerPaymentItem) model);
        	}
        
        	return customerpaymentitemCollection;
        }

        public static CustomerPaymentItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerPaymentItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerPaymentItem) gateway.retrieve(ResourceType.FINANCE_CUSTOMER_PAYMENT_ITEM, id);
        }

        public ModelBase getCustomerPayment ()
        {
            return (ModelBase) this.getProperty("customerPayment");
        }

        public void setCustomerPayment (ModelBase customerPayment)
        {
            this.setProperty("customerPayment", customerPayment);
        }

        public ModelBase getCustomerInvoiceItem ()
        {
            return (ModelBase) this.getProperty("customerInvoiceItem");
        }

        public void setCustomerInvoiceItem (ModelBase customerInvoiceItem)
        {
            this.setProperty("customerInvoiceItem", customerInvoiceItem);
        }

        public ModelBase getDestinationLedger ()
        {
            return (ModelBase) this.getProperty("destinationLedger");
        }

        public void setDestinationLedger (ModelBase destinationLedger)
        {
            this.setProperty("destinationLedger", destinationLedger);
        }

        public string getPaymentAmountPerItem ()
        {
            return this.getProperty("paymentAmountPerItem").ToString();
        }

        public void setPaymentAmountPerItem (string paymentAmountPerItem)
        {
            this.setProperty("paymentAmountPerItem", paymentAmountPerItem);
        }

        public int getQuantityPaid ()
        {
            return Convert.ToInt32(this.getProperty("quantityPaid"));
        }

        public void setQuantityPaid (int quantityPaid)
        {
            this.setProperty("quantityPaid", quantityPaid);
        }


    }
}

