using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EnabledFeature : ModelBase
    {
        protected string resourceType = ResourceType.ENABLED_FEATURE;
        public const string FEATURE_IDENTIFIER = "featureIdentifier";
        public const string CRM_CONTRACT_SERVICE_SUBSCRIPTION_ID = "crmContractServiceSubscriptionId";
        public const string BILLING_SERVICE_CONTRACT_SUBSCRIPTION_ID = "billingServiceContractSubscriptionId";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public EnabledFeature()
        {
            base.resourceType = this.resourceType;
        }

        public EnabledFeature(string resourceType = "EnabledFeature", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EnabledFeature> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EnabledFeature");
            RestGateway gateway = (RestGateway)EnabledFeature.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EnabledFeature> enabledfeatureCollection = new ModelCollection<EnabledFeature>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                enabledfeatureCollection.add((EnabledFeature)model);
            }

            return enabledfeatureCollection;
        }

        public static EnabledFeature retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EnabledFeature.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EnabledFeature)gateway.retrieve(ResourceType.ENABLED_FEATURE, id);
        }

        public string getFeatureIdentifier()
        {
            return this.getProperty("featureIdentifier").ToString();
        }

        public void setFeatureIdentifier(string featureIdentifier)
        {
            this.setProperty("featureIdentifier", featureIdentifier);
        }

        public int getCrmContractServiceSubscriptionId()
        {
            return Convert.ToInt32(this.getProperty("crmContractServiceSubscriptionId"));
        }

        public void setCrmContractServiceSubscriptionId(int crmContractServiceSubscriptionId)
        {
            this.setProperty("crmContractServiceSubscriptionId", crmContractServiceSubscriptionId);
        }

        public int getBillingServiceContractSubscriptionId()
        {
            return Convert.ToInt32(this.getProperty("billingServiceContractSubscriptionId"));
        }

        public void setBillingServiceContractSubscriptionId(int billingServiceContractSubscriptionId)
        {
            this.setProperty("billingServiceContractSubscriptionId", billingServiceContractSubscriptionId);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

