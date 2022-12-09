using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionCategory : ModelBase
    {
        protected new string resourceType = ResourceType.INTERVENTION_CATEGORY;
        public const string INTERVENTION_CATEGORY_NAME = "interventionCategoryName";
        public const string SHORT_NAME = "shortName";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";

        public InterventionCategory()
        {
            base.resourceType = this.resourceType;
        }

        public InterventionCategory(string resourceType = "InterventionCategory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InterventionCategory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InterventionCategory");
            RestGateway gateway = (RestGateway)InterventionCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InterventionCategory> interventioncategoryCollection = new ModelCollection<InterventionCategory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                interventioncategoryCollection.add((InterventionCategory)model);
            }

            return interventioncategoryCollection;
        }

        public static InterventionCategory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InterventionCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InterventionCategory)gateway.retrieve(ResourceType.INTERVENTION_CATEGORY, id);
        }

        public string getInterventionCategoryName()
        {
            return this.getProperty("interventionCategoryName").ToString();
        }

        public void setInterventionCategoryName(string interventionCategoryName)
        {
            this.setProperty("interventionCategoryName", interventionCategoryName);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
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


    }
}

