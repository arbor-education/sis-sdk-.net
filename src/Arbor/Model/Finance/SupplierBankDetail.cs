using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierBankDetail : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_BANK_DETAIL;
        public const string SUPPLIER = "supplier";
        public const string ACCOUNT_HOLDER_NAME = "accountHolderName";
        public const string ACCOUNT_NUMBER = "accountNumber";
        public const string SORT_CODE = "sortCode";
        public const string SWIFT_CODE = "swiftCode";
        public const string IBAN = "iban";
        public const string DEFAULT_PAYMENT_REFERENCE = "defaultPaymentReference";

        public SupplierBankDetail ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierBankDetail (string resourceType = "SupplierBankDetail", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierBankDetail> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierBankDetail");
        	RestGateway gateway = (RestGateway) SupplierBankDetail.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierBankDetail> supplierbankdetailCollection = new ModelCollection<SupplierBankDetail> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierbankdetailCollection.add((SupplierBankDetail) model);
        	}
        
        	return supplierbankdetailCollection;
        }

        public static SupplierBankDetail retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierBankDetail.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierBankDetail) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_BANK_DETAIL, id);
        }

        public ModelBase getSupplier ()
        {
            return (ModelBase) this.getProperty("supplier");
        }

        public void setSupplier (ModelBase supplier)
        {
            this.setProperty("supplier", supplier);
        }

        public string getAccountHolderName ()
        {
            return this.getProperty("accountHolderName").ToString();
        }

        public void setAccountHolderName (string accountHolderName)
        {
            this.setProperty("accountHolderName", accountHolderName);
        }

        public string getAccountNumber ()
        {
            return this.getProperty("accountNumber").ToString();
        }

        public void setAccountNumber (string accountNumber)
        {
            this.setProperty("accountNumber", accountNumber);
        }

        public string getSortCode ()
        {
            return this.getProperty("sortCode").ToString();
        }

        public void setSortCode (string sortCode)
        {
            this.setProperty("sortCode", sortCode);
        }

        public string getSwiftCode ()
        {
            return this.getProperty("swiftCode").ToString();
        }

        public void setSwiftCode (string swiftCode)
        {
            this.setProperty("swiftCode", swiftCode);
        }

        public string getIban ()
        {
            return this.getProperty("iban").ToString();
        }

        public void setIban (string iban)
        {
            this.setProperty("iban", iban);
        }

        public string getDefaultPaymentReference ()
        {
            return this.getProperty("defaultPaymentReference").ToString();
        }

        public void setDefaultPaymentReference (string defaultPaymentReference)
        {
            this.setProperty("defaultPaymentReference", defaultPaymentReference);
        }


    }
}

