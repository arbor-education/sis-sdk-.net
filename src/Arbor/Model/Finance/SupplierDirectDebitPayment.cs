using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierDirectDebitPayment : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_DIRECT_DEBIT_PAYMENT;
        public const string SUPPLIER_DIRECT_DEBIT_AGREEMENT = "supplierDirectDebitAgreement";
        public const string DEBIT_PAYMENT_DATE = "debitPaymentDate";
        public const string DEBIT_PAYMENT = "debitPayment";
        public const string BANK_TRANSACTION_REFERENCE = "bankTransactionReference";

        public SupplierDirectDebitPayment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierDirectDebitPayment (string resourceType = "SupplierDirectDebitPayment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierDirectDebitPayment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierDirectDebitPayment");
        	RestGateway gateway = (RestGateway) SupplierDirectDebitPayment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierDirectDebitPayment> supplierdirectdebitpaymentCollection = new ModelCollection<SupplierDirectDebitPayment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierdirectdebitpaymentCollection.add((SupplierDirectDebitPayment) model);
        	}
        
        	return supplierdirectdebitpaymentCollection;
        }

        public static SupplierDirectDebitPayment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierDirectDebitPayment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierDirectDebitPayment) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_DIRECT_DEBIT_PAYMENT, id);
        }

        public ModelBase getSupplierDirectDebitAgreement ()
        {
            return (ModelBase) this.getProperty("supplierDirectDebitAgreement");
        }

        public void setSupplierDirectDebitAgreement (ModelBase supplierDirectDebitAgreement)
        {
            this.setProperty("supplierDirectDebitAgreement", supplierDirectDebitAgreement);
        }

        public DateTime getDebitPaymentDate ()
        {
            return (DateTime) this.getProperty("debitPaymentDate");
        }

        public void setDebitPaymentDate (DateTime debitPaymentDate)
        {
            this.setProperty("debitPaymentDate", debitPaymentDate);
        }

        public string getDebitPayment ()
        {
            return this.getProperty("debitPayment").ToString();
        }

        public void setDebitPayment (string debitPayment)
        {
            this.setProperty("debitPayment", debitPayment);
        }

        public string getBankTransactionReference ()
        {
            return this.getProperty("bankTransactionReference").ToString();
        }

        public void setBankTransactionReference (string bankTransactionReference)
        {
            this.setProperty("bankTransactionReference", bankTransactionReference);
        }


    }
}

