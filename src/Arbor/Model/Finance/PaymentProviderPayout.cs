using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class PaymentProviderPayout : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_PAYMENT_PROVIDER_PAYOUT;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string PAYMENT_PROVIDER = "paymentProvider";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string PAYMENT_PROVIDER_PAYOUT_IDENTIFIER = "paymentProviderPayoutIdentifier";
        public const string PAYOUT_AMOUNT = "payoutAmount";
        public const string PAYOUT_REFERENCE = "payoutReference";
        public const string PAYOUT_INITIATED_DATETIME = "payoutInitiatedDatetime";
        public const string PAYOUT_SUCCEEDED_DATETIME = "payoutSucceededDatetime";
        public const string PAYOUT_FAILED_DATETIME = "payoutFailedDatetime";
        public const string PAYOUT_SOURCE_TYPE = "payoutSourceType";

        public PaymentProviderPayout ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PaymentProviderPayout (string resourceType = "PaymentProviderPayout", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PaymentProviderPayout> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_PaymentProviderPayout");
        	RestGateway gateway = (RestGateway) PaymentProviderPayout.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PaymentProviderPayout> paymentproviderpayoutCollection = new ModelCollection<PaymentProviderPayout> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    paymentproviderpayoutCollection.add((PaymentProviderPayout) model);
        	}
        
        	return paymentproviderpayoutCollection;
        }

        public static PaymentProviderPayout retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PaymentProviderPayout.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PaymentProviderPayout) gateway.retrieve(ResourceType.FINANCE_PAYMENT_PROVIDER_PAYOUT, id);
        }

        public ModelBase getBankAccount ()
        {
            return (ModelBase) this.getProperty("bankAccount");
        }

        public void setBankAccount (ModelBase bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public ModelBase getPaymentProvider ()
        {
            return (ModelBase) this.getProperty("paymentProvider");
        }

        public void setPaymentProvider (ModelBase paymentProvider)
        {
            this.setProperty("paymentProvider", paymentProvider);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public string getPaymentProviderPayoutIdentifier ()
        {
            return this.getProperty("paymentProviderPayoutIdentifier").ToString();
        }

        public void setPaymentProviderPayoutIdentifier (string paymentProviderPayoutIdentifier)
        {
            this.setProperty("paymentProviderPayoutIdentifier", paymentProviderPayoutIdentifier);
        }

        public string getPayoutAmount ()
        {
            return this.getProperty("payoutAmount").ToString();
        }

        public void setPayoutAmount (string payoutAmount)
        {
            this.setProperty("payoutAmount", payoutAmount);
        }

        public string getPayoutReference ()
        {
            return this.getProperty("payoutReference").ToString();
        }

        public void setPayoutReference (string payoutReference)
        {
            this.setProperty("payoutReference", payoutReference);
        }

        public DateTime getPayoutInitiatedDatetime ()
        {
            return (DateTime) this.getProperty("payoutInitiatedDatetime");
        }

        public void setPayoutInitiatedDatetime (DateTime payoutInitiatedDatetime)
        {
            this.setProperty("payoutInitiatedDatetime", payoutInitiatedDatetime);
        }

        public DateTime getPayoutSucceededDatetime ()
        {
            return (DateTime) this.getProperty("payoutSucceededDatetime");
        }

        public void setPayoutSucceededDatetime (DateTime payoutSucceededDatetime)
        {
            this.setProperty("payoutSucceededDatetime", payoutSucceededDatetime);
        }

        public DateTime getPayoutFailedDatetime ()
        {
            return (DateTime) this.getProperty("payoutFailedDatetime");
        }

        public void setPayoutFailedDatetime (DateTime payoutFailedDatetime)
        {
            this.setProperty("payoutFailedDatetime", payoutFailedDatetime);
        }

        public string getPayoutSourceType ()
        {
            return this.getProperty("payoutSourceType").ToString();
        }

        public void setPayoutSourceType (string payoutSourceType)
        {
            this.setProperty("payoutSourceType", payoutSourceType);
        }


    }
}

