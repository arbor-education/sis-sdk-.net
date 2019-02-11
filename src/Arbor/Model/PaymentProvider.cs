using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PaymentProvider : ModelBase
    {
        protected string resourceType = ResourceType.PAYMENT_PROVIDER;
        public const string PAYMENT_PROVIDER_NAME = "paymentProviderName";
        public const string PROVIDER_CODE = "providerCode";
        public const string SECRET_KEY = "secretKey";
        public const string PUBLISHABLE_KEY = "publishableKey";
        public const string IS_ENABLED = "isEnabled";
        public const string MINIMUM_TRANSACTION_AMOUNT = "minimumTransactionAmount";

        public PaymentProvider ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PaymentProvider (string resourceType = "PaymentProvider", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PaymentProvider> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PaymentProvider");
        	RestGateway gateway = (RestGateway) PaymentProvider.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PaymentProvider> paymentproviderCollection = new ModelCollection<PaymentProvider> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    paymentproviderCollection.add((PaymentProvider) model);
        	}
        
        	return paymentproviderCollection;
        }

        public static PaymentProvider retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PaymentProvider.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PaymentProvider) gateway.retrieve(ResourceType.PAYMENT_PROVIDER, id);
        }

        public string getPaymentProviderName ()
        {
            return this.getProperty("paymentProviderName").ToString();
        }

        public void setPaymentProviderName (string paymentProviderName)
        {
            this.setProperty("paymentProviderName", paymentProviderName);
        }

        public string getProviderCode ()
        {
            return this.getProperty("providerCode").ToString();
        }

        public void setProviderCode (string providerCode)
        {
            this.setProperty("providerCode", providerCode);
        }

        public string getSecretKey ()
        {
            return this.getProperty("secretKey").ToString();
        }

        public void setSecretKey (string secretKey)
        {
            this.setProperty("secretKey", secretKey);
        }

        public string getPublishableKey ()
        {
            return this.getProperty("publishableKey").ToString();
        }

        public void setPublishableKey (string publishableKey)
        {
            this.setProperty("publishableKey", publishableKey);
        }

        public bool getIsEnabled ()
        {
            return Convert.ToBoolean( this.getProperty("isEnabled"));
        }

        public void setIsEnabled (bool isEnabled)
        {
            this.setProperty("isEnabled", isEnabled);
        }

        public string getMinimumTransactionAmount ()
        {
            return this.getProperty("minimumTransactionAmount").ToString();
        }

        public void setMinimumTransactionAmount (string minimumTransactionAmount)
        {
            this.setProperty("minimumTransactionAmount", minimumTransactionAmount);
        }


    }
}

