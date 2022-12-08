using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntegrationsHrFinanceProvider : ModelBase
    {
        protected string resourceType = ResourceType.INTEGRATIONS_HR_FINANCE_PROVIDER;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string CONFIGURATION = "configuration";
        public const string ENABLED = "enabled";

        public IntegrationsHrFinanceProvider()
        {
            base.resourceType = this.resourceType;
        }

        public IntegrationsHrFinanceProvider(string resourceType = "IntegrationsHrFinanceProvider", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IntegrationsHrFinanceProvider> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IntegrationsHrFinanceProvider");
            RestGateway gateway = (RestGateway)IntegrationsHrFinanceProvider.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IntegrationsHrFinanceProvider> integrationshrfinanceproviderCollection = new ModelCollection<IntegrationsHrFinanceProvider>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                integrationshrfinanceproviderCollection.add((IntegrationsHrFinanceProvider)model);
            }

            return integrationshrfinanceproviderCollection;
        }

        public static IntegrationsHrFinanceProvider retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IntegrationsHrFinanceProvider.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IntegrationsHrFinanceProvider)gateway.retrieve(ResourceType.INTEGRATIONS_HR_FINANCE_PROVIDER, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
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


    }
}

