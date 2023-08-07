using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetricRuleTargetItem : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_METRIC_RULE_TARGET_ITEM;
        public const string OPERATOR = "operator";
        public const string TARGET_TYPE = "targetType";
        public const string ASSESSMENT_METRIC_RULE = "assessmentMetricRule";
        public const string ASSESSMENT_METRIC_ASSESSMENT = "assessmentMetricAssessment";
        public const string ASSESSMENT = "assessment";

        public AssessmentMetricRuleTargetItem ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentMetricRuleTargetItem (string resourceType = "AssessmentMetricRuleTargetItem", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentMetricRuleTargetItem> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentMetricRuleTargetItem");
        	RestGateway gateway = (RestGateway) AssessmentMetricRuleTargetItem.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentMetricRuleTargetItem> assessmentmetricruletargetitemCollection = new ModelCollection<AssessmentMetricRuleTargetItem> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentmetricruletargetitemCollection.add((AssessmentMetricRuleTargetItem) model);
        	}
        
        	return assessmentmetricruletargetitemCollection;
        }

        public static AssessmentMetricRuleTargetItem retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentMetricRuleTargetItem.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentMetricRuleTargetItem) gateway.retrieve(ResourceType.ASSESSMENT_METRIC_RULE_TARGET_ITEM, id);
        }

        public string getOperator ()
        {
            return this.getProperty("operator").ToString();
        }

        public void setOperator (string _operator)
        {
            this.setProperty("operator", _operator);
        }

        public string getTargetType ()
        {
            return this.getProperty("targetType").ToString();
        }

        public void setTargetType (string targetType)
        {
            this.setProperty("targetType", targetType);
        }

        public AssessmentMetricRule getAssessmentMetricRule ()
        {
            return (AssessmentMetricRule) this.getProperty("assessmentMetricRule");
        }

        public void setAssessmentMetricRule (AssessmentMetricRule assessmentMetricRule)
        {
            this.setProperty("assessmentMetricRule", assessmentMetricRule);
        }

        public AssessmentMetricAssessment getAssessmentMetricAssessment ()
        {
            return (AssessmentMetricAssessment) this.getProperty("assessmentMetricAssessment");
        }

        public void setAssessmentMetricAssessment (AssessmentMetricAssessment assessmentMetricAssessment)
        {
            this.setProperty("assessmentMetricAssessment", assessmentMetricAssessment);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }


    }
}

