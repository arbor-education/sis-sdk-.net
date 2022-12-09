using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionFundingSource : ModelBase
    {
        protected new string resourceType = ResourceType.INTERVENTION_FUNDING_SOURCE;
        public const string NAME = "name";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";

        public InterventionFundingSource()
        {
            base.resourceType = this.resourceType;
        }

        public InterventionFundingSource(string resourceType = "InterventionFundingSource", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InterventionFundingSource> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InterventionFundingSource");
            RestGateway gateway = (RestGateway)InterventionFundingSource.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InterventionFundingSource> interventionfundingsourceCollection = new ModelCollection<InterventionFundingSource>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                interventionfundingsourceCollection.add((InterventionFundingSource)model);
            }

            return interventionfundingsourceCollection;
        }

        public static InterventionFundingSource retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InterventionFundingSource.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InterventionFundingSource)gateway.retrieve(ResourceType.INTERVENTION_FUNDING_SOURCE, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
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

        public bool getDataOrder()
        {
            return Convert.ToBoolean(this.getProperty("dataOrder"));
        }

        public void setDataOrder(bool dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }


    }
}

