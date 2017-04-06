using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierPaymentItem : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_PAYMENT_ITEM;
        public const string SUPPLIER_PAYMENT = "supplierPayment";
        public const string SUPPLIER_INVOICE_ITEM = "supplierInvoiceItem";
        public const string PAYMENT_AMOUNT_PER_ITEM = "paymentAmountPerItem";
        public const string QUANTITY_PAID = "quantityPaid";
        public const string PAYMENT_REFERENCE = "paymentReference";

        public SupplierPaymentItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierPaymentItem (string resourceType = "SupplierPaymentItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierPaymentItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierPaymentItem");
        	RestGateway gateway = (RestGateway) SupplierPaymentItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierPaymentItem> supplierpaymentitemCollection = new ModelCollection<SupplierPaymentItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierpaymentitemCollection.add((SupplierPaymentItem) model);
        	}
        
        	return supplierpaymentitemCollection;
        }

        public static SupplierPaymentItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierPaymentItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierPaymentItem) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_PAYMENT_ITEM, id);
        }

        public ModelBase getSupplierPayment ()
        {
            return (ModelBase) this.getProperty("supplierPayment");
        }

        public void setSupplierPayment (ModelBase supplierPayment)
        {
            this.setProperty("supplierPayment", supplierPayment);
        }

        public ModelBase getSupplierInvoiceItem ()
        {
            return (ModelBase) this.getProperty("supplierInvoiceItem");
        }

        public void setSupplierInvoiceItem (ModelBase supplierInvoiceItem)
        {
            this.setProperty("supplierInvoiceItem", supplierInvoiceItem);
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

        public string getPaymentReference ()
        {
            return this.getProperty("paymentReference").ToString();
        }

        public void setPaymentReference (string paymentReference)
        {
            this.setProperty("paymentReference", paymentReference);
        }


    }
}

