using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IncomingDirectDebitAgreement : ModelBase
    {
        protected string resourceType = ResourceType.INCOMING_DIRECT_DEBIT_AGREEMENT;
        public const string BILL_PAYER = "billPayer";
        public const string PAYMENT_PROVIDER = "paymentProvider";
        public const string PAYMENT_PROVIDER_AGREEMENT_IDENTIFIER = "paymentProviderAgreementIdentifier";
        public const string AGREEMENT_START_DATE = "agreementStartDate";
        public const string AGREEMENT_END_DATE = "agreementEndDate";
        public const string AGREEMENT_REFERENCE = "agreementReference";
        public const string NARRATIVE = "narrative";

        public IncomingDirectDebitAgreement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IncomingDirectDebitAgreement (string resourceType = "IncomingDirectDebitAgreement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IncomingDirectDebitAgreement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("IncomingDirectDebitAgreement");
        	RestGateway gateway = (RestGateway) IncomingDirectDebitAgreement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IncomingDirectDebitAgreement> incomingdirectdebitagreementCollection = new ModelCollection<IncomingDirectDebitAgreement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    incomingdirectdebitagreementCollection.add((IncomingDirectDebitAgreement) model);
        	}
        
        	return incomingdirectdebitagreementCollection;
        }

        public static IncomingDirectDebitAgreement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IncomingDirectDebitAgreement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IncomingDirectDebitAgreement) gateway.retrieve(ResourceType.INCOMING_DIRECT_DEBIT_AGREEMENT, id);
        }

        public BillPayer getBillPayer ()
        {
            return (BillPayer) this.getProperty("billPayer");
        }

        public void setBillPayer (BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public PaymentProvider getPaymentProvider ()
        {
            return (PaymentProvider) this.getProperty("paymentProvider");
        }

        public void setPaymentProvider (PaymentProvider paymentProvider)
        {
            this.setProperty("paymentProvider", paymentProvider);
        }

        public string getPaymentProviderAgreementIdentifier ()
        {
            return this.getProperty("paymentProviderAgreementIdentifier").ToString();
        }

        public void setPaymentProviderAgreementIdentifier (string paymentProviderAgreementIdentifier)
        {
            this.setProperty("paymentProviderAgreementIdentifier", paymentProviderAgreementIdentifier);
        }

        public DateTime getAgreementStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("agreementStartDate"));
        }

        public void setAgreementStartDate (DateTime agreementStartDate)
        {
            this.setProperty("agreementStartDate", agreementStartDate);
        }

        public DateTime getAgreementEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("agreementEndDate"));
        }

        public void setAgreementEndDate (DateTime agreementEndDate)
        {
            this.setProperty("agreementEndDate", agreementEndDate);
        }

        public string getAgreementReference ()
        {
            return this.getProperty("agreementReference").ToString();
        }

        public void setAgreementReference (string agreementReference)
        {
            this.setProperty("agreementReference", agreementReference);
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

