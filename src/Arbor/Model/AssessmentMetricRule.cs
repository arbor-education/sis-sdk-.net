using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetricRule : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_METRIC_RULE;
        public const string ASSESSMENT_METRIC = "assessmentMetric";

        public AssessmentMetricRule ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentMetricRule (string resourceType = "AssessmentMetricRule", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentMetricRule> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentMetricRule");
        	RestGateway gateway = (RestGateway) AssessmentMetricRule.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentMetricRule> assessmentmetricruleCollection = new ModelCollection<AssessmentMetricRule> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentmetricruleCollection.add((AssessmentMetricRule) model);
        	}
        
        	return assessmentmetricruleCollection;
        }

        public static AssessmentMetricRule retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentMetricRule.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentMetricRule) gateway.retrieve(ResourceType.ASSESSMENT_METRIC_RULE, id);
        }

        public AssessmentMetric getAssessmentMetric ()
        {
            return (AssessmentMetric) this.getProperty("assessmentMetric");
        }

        public void setAssessmentMetric (AssessmentMetric assessmentMetric)
        {
            this.setProperty("assessmentMetric", assessmentMetric);
        }


    }
}

