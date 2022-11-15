using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntegrationVleProvider : ModelBase
    {
        protected new string resourceType = ResourceType.INTEGRATION_VLE_PROVIDER;
        public const string NAME = "name";
        public const string CONFIGURATION = "configuration";
        public const string ENABLED = "enabled";
        public const string CODE = "code";

        public IntegrationVleProvider()
        {
            base.resourceType = this.resourceType;
        }

        public IntegrationVleProvider(string resourceType = "IntegrationVleProvider", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IntegrationVleProvider> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IntegrationVleProvider");
            RestGateway gateway = (RestGateway)IntegrationVleProvider.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IntegrationVleProvider> integrationvleproviderCollection = new ModelCollection<IntegrationVleProvider>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                integrationvleproviderCollection.add((IntegrationVleProvider)model);
            }

            return integrationvleproviderCollection;
        }

        public static IntegrationVleProvider retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IntegrationVleProvider.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IntegrationVleProvider)gateway.retrieve(ResourceType.INTEGRATION_VLE_PROVIDER, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getConfiguration()
        {
            return this.getProperty("configuration").ToString();
        }

        public void setConfiguration(string configuration)
        {
            this.setProperty("configuration", configuration);
        }

        public bool getEnabled()
        {
            return Convert.ToBoolean(this.getProperty("enabled"));
        }

        public void setEnabled(bool enabled)
        {
            this.setProperty("enabled", enabled);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }


    }
}

