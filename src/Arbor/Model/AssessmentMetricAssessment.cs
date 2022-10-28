using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetricAssessment : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_METRIC_ASSESSMENT;
        public const string ASSESSMENT_METRIC = "assessmentMetric";
        public const string ASSESSMENT = "assessment";
        public const string ASSESSMENT_METRIC_ASSESSMENT_BATCH = "assessmentMetricAssessmentBatch";

        public AssessmentMetricAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentMetricAssessment (string resourceType = "AssessmentMetricAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentMetricAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentMetricAssessment");
        	RestGateway gateway = (RestGateway) AssessmentMetricAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentMetricAssessment> assessmentmetricassessmentCollection = new ModelCollection<AssessmentMetricAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentmetricassessmentCollection.add((AssessmentMetricAssessment) model);
        	}
        
        	return assessmentmetricassessmentCollection;
        }

        public static AssessmentMetricAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentMetricAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentMetricAssessment) gateway.retrieve(ResourceType.ASSESSMENT_METRIC_ASSESSMENT, id);
        }

        public AssessmentMetric getAssessmentMetric ()
        {
            return (AssessmentMetric) this.getProperty("assessmentMetric");
        }

        public void setAssessmentMetric (AssessmentMetric assessmentMetric)
        {
            this.setProperty("assessmentMetric", assessmentMetric);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public AssessmentMetricAssessmentBatch getAssessmentMetricAssessmentBatch ()
        {
            return (AssessmentMetricAssessmentBatch) this.getProperty("assessmentMetricAssessmentBatch");
        }

        public void setAssessmentMetricAssessmentBatch (AssessmentMetricAssessmentBatch assessmentMetricAssessmentBatch)
        {
            this.setProperty("assessmentMetricAssessmentBatch", assessmentMetricAssessmentBatch);
        }


    }
}

