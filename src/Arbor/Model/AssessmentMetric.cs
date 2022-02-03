using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetric : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_METRIC;
        public const string ASSESSMENT_METRIC_SET = "assessmentMetricSet";
        public const string ACADEMIC_YEAR = "academicYear";

        public AssessmentMetric ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentMetric (string resourceType = "AssessmentMetric", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentMetric> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentMetric");
        	RestGateway gateway = (RestGateway) AssessmentMetric.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentMetric> assessmentmetricCollection = new ModelCollection<AssessmentMetric> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentmetricCollection.add((AssessmentMetric) model);
        	}
        
        	return assessmentmetricCollection;
        }

        public static AssessmentMetric retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentMetric.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentMetric) gateway.retrieve(ResourceType.ASSESSMENT_METRIC, id);
        }

        public AssessmentMetricSet getAssessmentMetricSet ()
        {
            return (AssessmentMetricSet) this.getProperty("assessmentMetricSet");
        }

        public void setAssessmentMetricSet (AssessmentMetricSet assessmentMetricSet)
        {
            this.setProperty("assessmentMetricSet", assessmentMetricSet);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }


    }
}

