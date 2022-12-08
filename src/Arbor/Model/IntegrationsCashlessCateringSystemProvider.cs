using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntegrationsCashlessCateringSystemProvider : ModelBase
    {
        protected string resourceType = ResourceType.INTEGRATIONS_CASHLESS_CATERING_SYSTEM_PROVIDER;
        public const string NAME = "name";
        public const string CUSTOMER_ACCOUNT_TYPE = "customerAccountType";
        public const string PROVIDER = "provider";
        public const string ENABLED = "enabled";

        public IntegrationsCashlessCateringSystemProvider()
        {
            base.resourceType = this.resourceType;
        }

        public IntegrationsCashlessCateringSystemProvider(string resourceType = "IntegrationsCashlessCateringSystemProvider", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IntegrationsCashlessCateringSystemProvider> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IntegrationsCashlessCateringSystemProvider");
            RestGateway gateway = (RestGateway)IntegrationsCashlessCateringSystemProvider.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IntegrationsCashlessCateringSystemProvider> integrationscashlesscateringsystemproviderCollection = new ModelCollection<IntegrationsCashlessCateringSystemProvider>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                integrationscashlesscateringsystemproviderCollection.add((IntegrationsCashlessCateringSystemProvider)model);
            }

            return integrationscashlesscateringsystemproviderCollection;
        }

        public static IntegrationsCashlessCateringSystemProvider retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IntegrationsCashlessCateringSystemProvider.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IntegrationsCashlessCateringSystemProvider)gateway.retrieve(ResourceType.INTEGRATIONS_CASHLESS_CATERING_SYSTEM_PROVIDER, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public CustomerAccountType getCustomerAccountType()
        {
            return (CustomerAccountType)this.getProperty("customerAccountType");
        }

        public void setCustomerAccountType(CustomerAccountType customerAccountType)
        {
            this.setProperty("customerAccountType", customerAccountType);
        }

        public string getProvider()
        {
            return this.getProperty("provider").ToString();
        }

        public void setProvider(string provider)
        {
            this.setProperty("provider", provider);
        }

        public bool getEnabled()
        {
            return Convert.ToBoolean(this.getProperty("enabled"));
        }

        public void setEnabled(bool enabled)
        {
            this.setProperty("enabled", enabled);
        }


    }
}

