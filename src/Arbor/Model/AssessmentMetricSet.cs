using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetricSet : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_METRIC_SET;
        public const string NAME = "name";
        public const string IS_KEY_METRIC = "isKeyMetric";
        public const string RULE_ITEM_TYPE = "ruleItemType";
        public const string UPWARD_TREND = "upwardTrend";

        public AssessmentMetricSet()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentMetricSet(string resourceType = "AssessmentMetricSet", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentMetricSet> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentMetricSet");
            RestGateway gateway = (RestGateway)AssessmentMetricSet.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentMetricSet> assessmentmetricsetCollection = new ModelCollection<AssessmentMetricSet>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentmetricsetCollection.add((AssessmentMetricSet)model);
            }

            return assessmentmetricsetCollection;
        }

        public static AssessmentMetricSet retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentMetricSet.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentMetricSet)gateway.retrieve(ResourceType.ASSESSMENT_METRIC_SET, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public bool getIsKeyMetric()
        {
            return Convert.ToBoolean(this.getProperty("isKeyMetric"));
        }

        public void setIsKeyMetric(bool isKeyMetric)
        {
            this.setProperty("isKeyMetric", isKeyMetric);
        }

        public string getRuleItemType()
        {
            return this.getProperty("ruleItemType").ToString();
        }

        public void setRuleItemType(string ruleItemType)
        {
            this.setProperty("ruleItemType", ruleItemType);
        }

        public string getUpwardTrend()
        {
            return this.getProperty("upwardTrend").ToString();
        }

        public void setUpwardTrend(string upwardTrend)
        {
            this.setProperty("upwardTrend", upwardTrend);
        }


    }
}

