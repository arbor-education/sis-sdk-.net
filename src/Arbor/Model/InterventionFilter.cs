using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionFilter : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_FILTER;
        public const string INTERVENTION = "intervention";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TRANSFORMATION_CLASS = "transformationClass";
        public const string CONDITION_CLASS = "conditionClass";
        public const string CONDITION_PARAMS = "conditionParams";
        public const string FILTER_GROUP_INDEX = "filterGroupIndex";
        public const string IS_OUTCOME = "isOutcome";

        public InterventionFilter()
        {
            base.resourceType = this.resourceType;
        }

        public InterventionFilter(string resourceType = "InterventionFilter", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InterventionFilter> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InterventionFilter");
            RestGateway gateway = (RestGateway)InterventionFilter.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InterventionFilter> interventionfilterCollection = new ModelCollection<InterventionFilter>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                interventionfilterCollection.add((InterventionFilter)model);
            }

            return interventionfilterCollection;
        }

        public static InterventionFilter retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InterventionFilter.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InterventionFilter)gateway.retrieve(ResourceType.INTERVENTION_FILTER, id);
        }

        public Intervention getIntervention()
        {
            return (Intervention)this.getProperty("intervention");
        }

        public void setIntervention(Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public string getFieldClass()
        {
            return this.getProperty("fieldClass").ToString();
        }

        public void setFieldClass(string fieldClass)
        {
            this.setProperty("fieldClass", fieldClass);
        }

        public string getFieldParams()
        {
            return this.getProperty("fieldParams").ToString();
        }

        public void setFieldParams(string fieldParams)
        {
            this.setProperty("fieldParams", fieldParams);
        }

        public string getTransformationClass()
        {
            return this.getProperty("transformationClass").ToString();
        }

        public void setTransformationClass(string transformationClass)
        {
            this.setProperty("transformationClass", transformationClass);
        }

        public string getConditionClass()
        {
            return this.getProperty("conditionClass").ToString();
        }

        public void setConditionClass(string conditionClass)
        {
            this.setProperty("conditionClass", conditionClass);
        }

        public string getConditionParams()
        {
            return this.getProperty("conditionParams").ToString();
        }

        public void setConditionParams(string conditionParams)
        {
            this.setProperty("conditionParams", conditionParams);
        }

        public int getFilterGroupIndex()
        {
            return Convert.ToInt32(this.getProperty("filterGroupIndex"));
        }

        public void setFilterGroupIndex(int filterGroupIndex)
        {
            this.setProperty("filterGroupIndex", filterGroupIndex);
        }

        public bool getIsOutcome()
        {
            return Convert.ToBoolean(this.getProperty("isOutcome"));
        }

        public void setIsOutcome(bool isOutcome)
        {
            this.setProperty("isOutcome", isOutcome);
        }


    }
}

