using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierInvoice : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_INVOICE;
        public const string SUPPLIER = "supplier";
        public const string SUPPLIER_ORDER = "supplierOrder";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string INVOICE_NUMBER = "invoiceNumber";
        public const string INVOICE_DATE = "invoiceDate";
        public const string PAYMENT_DUE_DATE = "paymentDueDate";
        public const string PAY_ON_DATE = "payOnDate";
        public const string NARRATIVE = "narrative";
        public const string TOTAL_AMOUNT_EX_VAT = "totalAmountExVat";
        public const string TOTAL_VAT_AMOUNT = "totalVatAmount";
        public const string BALANCE = "balance";
        public const string CANCELLED_DATE = "cancelledDate";
        public const string SETTLEMENT_DATE = "settlementDate";
        public const string PAYMENT_AUTHORISED_DATETIME = "paymentAuthorisedDatetime";
        public const string PAYMENT_AUTHORISED_STAFF = "paymentAuthorisedStaff";

        public SupplierInvoice ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierInvoice (string resourceType = "SupplierInvoice", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierInvoice> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierInvoice");
        	RestGateway gateway = (RestGateway) SupplierInvoice.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierInvoice> supplierinvoiceCollection = new ModelCollection<SupplierInvoice> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierinvoiceCollection.add((SupplierInvoice) model);
        	}
        
        	return supplierinvoiceCollection;
        }

        public static SupplierInvoice retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierInvoice.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierInvoice) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_INVOICE, id);
        }

        public ModelBase getSupplier ()
        {
            return (ModelBase) this.getProperty("supplier");
        }

        public void setSupplier (ModelBase supplier)
        {
            this.setProperty("supplier", supplier);
        }

        public ModelBase getSupplierOrder ()
        {
            return (ModelBase) this.getProperty("supplierOrder");
        }

        public void setSupplierOrder (ModelBase supplierOrder)
        {
            this.setProperty("supplierOrder", supplierOrder);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
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
            return (DateTime) this.getProperty("invoiceDate");
        }

        public void setInvoiceDate (DateTime invoiceDate)
        {
            this.setProperty("invoiceDate", invoiceDate);
        }

        public DateTime getPaymentDueDate ()
        {
            return (DateTime) this.getProperty("paymentDueDate");
        }

        public void setPaymentDueDate (DateTime paymentDueDate)
        {
            this.setProperty("paymentDueDate", paymentDueDate);
        }

        public DateTime getPayOnDate ()
        {
            return (DateTime) this.getProperty("payOnDate");
        }

        public void setPayOnDate (DateTime payOnDate)
        {
            this.setProperty("payOnDate", payOnDate);
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

        public string getTotalVatAmount ()
        {
            return this.getProperty("totalVatAmount").ToString();
        }

        public void setTotalVatAmount (string totalVatAmount)
        {
            this.setProperty("totalVatAmount", totalVatAmount);
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
            return (DateTime) this.getProperty("cancelledDate");
        }

        public void setCancelledDate (DateTime cancelledDate)
        {
            this.setProperty("cancelledDate", cancelledDate);
        }

        public DateTime getSettlementDate ()
        {
            return (DateTime) this.getProperty("settlementDate");
        }

        public void setSettlementDate (DateTime settlementDate)
        {
            this.setProperty("settlementDate", settlementDate);
        }

        public DateTime getPaymentAuthorisedDatetime ()
        {
            return (DateTime) this.getProperty("paymentAuthorisedDatetime");
        }

        public void setPaymentAuthorisedDatetime (DateTime paymentAuthorisedDatetime)
        {
            this.setProperty("paymentAuthorisedDatetime", paymentAuthorisedDatetime);
        }

        public Staff getPaymentAuthorisedStaff ()
        {
            return (Staff) this.getProperty("paymentAuthorisedStaff");
        }

        public void setPaymentAuthorisedStaff (Staff paymentAuthorisedStaff)
        {
            this.setProperty("paymentAuthorisedStaff", paymentAuthorisedStaff);
        }


    }
}

