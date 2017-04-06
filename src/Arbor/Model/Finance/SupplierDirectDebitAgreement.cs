using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierDirectDebitAgreement : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_DIRECT_DEBIT_AGREEMENT;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string SUPPLIER = "supplier";
        public const string AGREEMENT_START_DATE = "agreementStartDate";
        public const string AGREEMENT_END_DATE = "agreementEndDate";
        public const string NARRATIVE = "narrative";

        public SupplierDirectDebitAgreement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierDirectDebitAgreement (string resourceType = "SupplierDirectDebitAgreement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierDirectDebitAgreement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierDirectDebitAgreement");
        	RestGateway gateway = (RestGateway) SupplierDirectDebitAgreement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierDirectDebitAgreement> supplierdirectdebitagreementCollection = new ModelCollection<SupplierDirectDebitAgreement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierdirectdebitagreementCollection.add((SupplierDirectDebitAgreement) model);
        	}
        
        	return supplierdirectdebitagreementCollection;
        }

        public static SupplierDirectDebitAgreement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierDirectDebitAgreement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierDirectDebitAgreement) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_DIRECT_DEBIT_AGREEMENT, id);
        }

        public ModelBase getBankAccount ()
        {
            return (ModelBase) this.getProperty("bankAccount");
        }

        public void setBankAccount (ModelBase bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public ModelBase getSupplier ()
        {
            return (ModelBase) this.getProperty("supplier");
        }

        public void setSupplier (ModelBase supplier)
        {
            this.setProperty("supplier", supplier);
        }

        public DateTime getAgreementStartDate ()
        {
            return (DateTime) this.getProperty("agreementStartDate");
        }

        public void setAgreementStartDate (DateTime agreementStartDate)
        {
            this.setProperty("agreementStartDate", agreementStartDate);
        }

        public DateTime getAgreementEndDate ()
        {
            return (DateTime) this.getProperty("agreementEndDate");
        }

        public void setAgreementEndDate (DateTime agreementEndDate)
        {
            this.setProperty("agreementEndDate", agreementEndDate);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

