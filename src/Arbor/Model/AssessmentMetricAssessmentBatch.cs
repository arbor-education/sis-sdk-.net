using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetricAssessmentBatch : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_METRIC_ASSESSMENT_BATCH;
        public const string ASSESSMENT_METRIC = "assessmentMetric";
        public const string OPERATOR = "operator";
        public const string PARENT_ASSESSMENT_METRIC_ASSESSMENT_BATCH = "parentAssessmentMetricAssessmentBatch";

        public AssessmentMetricAssessmentBatch()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentMetricAssessmentBatch(string resourceType = "AssessmentMetricAssessmentBatch", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentMetricAssessmentBatch> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentMetricAssessmentBatch");
            RestGateway gateway = (RestGateway)AssessmentMetricAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentMetricAssessmentBatch> assessmentmetricassessmentbatchCollection = new ModelCollection<AssessmentMetricAssessmentBatch>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentmetricassessmentbatchCollection.add((AssessmentMetricAssessmentBatch)model);
            }

            return assessmentmetricassessmentbatchCollection;
        }

        public static AssessmentMetricAssessmentBatch retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentMetricAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentMetricAssessmentBatch)gateway.retrieve(ResourceType.ASSESSMENT_METRIC_ASSESSMENT_BATCH, id);
        }

        public AssessmentMetric getAssessmentMetric()
        {
            return (AssessmentMetric)this.getProperty("assessmentMetric");
        }

        public void setAssessmentMetric(AssessmentMetric assessmentMetric)
        {
            this.setProperty("assessmentMetric", assessmentMetric);
        }

        public string getOperator()
        {
            return this.getProperty("operator").ToString();
        }

        public void setOperator(string operator)
        {
            this.setProperty("operator", operator);
        }

        public AssessmentMetricAssessmentBatch getParentAssessmentMetricAssessmentBatch()
        {
            return (AssessmentMetricAssessmentBatch)this.getProperty("parentAssessmentMetricAssessmentBatch");
        }

        public void setParentAssessmentMetricAssessmentBatch(AssessmentMetricAssessmentBatch parentAssessmentMetricAssessmentBatch)
        {
            this.setProperty("parentAssessmentMetricAssessmentBatch", parentAssessmentMetricAssessmentBatch);
        }


    }
}

