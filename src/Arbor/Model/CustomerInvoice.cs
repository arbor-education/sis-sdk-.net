using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerInvoice : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOMER_INVOICE;
        public const string PREVIOUS_CUSTOMER_INVOICE = "previousCustomerInvoice";
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string INVOICE_NUMBER = "invoiceNumber";
        public const string INVOICE_DATE = "invoiceDate";
        public const string INVOICE_ISSUED_DATE = "invoiceIssuedDate";
        public const string PAYMENT_DUE_DATE = "paymentDueDate";
        public const string FULLY_PAID_DATE = "fullyPaidDate";
        public const string NARRATIVE = "narrative";
        public const string TOTAL_AMOUNT_EX_VAT = "totalAmountExVat";
        public const string VAT_TOTAL = "vatTotal";
        public const string BALANCE = "balance";
        public const string CANCELLED_DATE = "cancelledDate";
        public const string REISSUED_DATE = "reissuedDate";

        public CustomerInvoice ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerInvoice (string resourceType = "CustomerInvoice", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerInvoice> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomerInvoice");
        	RestGateway gateway = (RestGateway) CustomerInvoice.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerInvoice> customerinvoiceCollection = new ModelCollection<CustomerInvoice> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customerinvoiceCollection.add((CustomerInvoice) model);
        	}
        
        	return customerinvoiceCollection;
        }

        public static CustomerInvoice retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerInvoice.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerInvoice) gateway.retrieve(ResourceType.CUSTOMER_INVOICE, id);
        }

        public CustomerInvoice getPreviousCustomerInvoice ()
        {
            return (CustomerInvoice) this.getProperty("previousCustomerInvoice");
        }

        public void setPreviousCustomerInvoice (CustomerInvoice previousCustomerInvoice)
        {
            this.setProperty("previousCustomerInvoice", previousCustomerInvoice);
        }

        public CustomerAccount getCustomerAccount ()
        {
            return (CustomerAccount) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public string getInvoiceNumber ()
        {
            return this.getProperty("invoiceNumber").ToString();
        }

        public void setInvoiceNumber (string invoiceNumber)
        {
            this.setProperty("invoiceNumber", invoiceNumber);
        }

        public DateTime getInvoiceDate ()
        {
            return Convert.ToDateTime(this.getProperty("invoiceDate"));
        }

        public void setInvoiceDate (DateTime invoiceDate)
        {
            this.setProperty("invoiceDate", invoiceDate);
        }

        public DateTime getInvoiceIssuedDate ()
        {
            return Convert.ToDateTime(this.getProperty("invoiceIssuedDate"));
        }

        public void setInvoiceIssuedDate (DateTime invoiceIssuedDate)
        {
            this.setProperty("invoiceIssuedDate", invoiceIssuedDate);
        }

        public DateTime getPaymentDueDate ()
        {
            return Convert.ToDateTime(this.getProperty("paymentDueDate"));
        }

        public void setPaymentDueDate (DateTime paymentDueDate)
        {
            this.setProperty("paymentDueDate", paymentDueDate);
        }

        public DateTime getFullyPaidDate ()
        {
            return Convert.ToDateTime(this.getProperty("fullyPaidDate"));
        }

        public void setFullyPaidDate (DateTime fullyPaidDate)
        {
            this.setProperty("fullyPaidDate", fullyPaidDate);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public string getTotalAmountExVat ()
        {
            return this.getProperty("totalAmountExVat").ToString();
        }

        public void setTotalAmountExVat (string totalAmountExVat)
        {
            this.setProperty("totalAmountExVat", totalAmountExVat);
        }

        public string getVatTotal ()
        {
            return this.getProperty("vatTotal").ToString();
        }

        public void setVatTotal (string vatTotal)
        {
            this.setProperty("vatTotal", vatTotal);
        }

        public string getBalance ()
        {
            return this.getProperty("balance").ToString();
        }

        public void setBalance (string balance)
        {
            this.setProperty("balance", balance);
        }

        public DateTime getCancelledDate ()
        {
            return Convert.ToDateTime(this.getProperty("cancelledDate"));
        }

        public void setCancelledDate (DateTime cancelledDate)
        {
            this.setProperty("cancelledDate", cancelledDate);
        }

        public DateTime getReissuedDate ()
        {
            return Convert.ToDateTime(this.getProperty("reissuedDate"));
        }

        public void setReissuedDate (DateTime reissuedDate)
        {
            this.setProperty("reissuedDate", reissuedDate);
        }


    }
}

