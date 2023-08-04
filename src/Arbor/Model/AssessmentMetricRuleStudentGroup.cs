using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetricRuleStudentGroup : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_METRIC_RULE_STUDENT_GROUP;
        public const string ASSESSMENT_METRIC_RULE = "assessmentMetricRule";
        public const string ACADEMIC_LEVEL = "academicLevel";

        public AssessmentMetricRuleStudentGroup ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentMetricRuleStudentGroup (string resourceType = "AssessmentMetricRuleStudentGroup", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentMetricRuleStudentGroup> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentMetricRuleStudentGroup");
        	RestGateway gateway = (RestGateway) AssessmentMetricRuleStudentGroup.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentMetricRuleStudentGroup> assessmentmetricrulestudentgroupCollection = new ModelCollection<AssessmentMetricRuleStudentGroup> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentmetricrulestudentgroupCollection.add((AssessmentMetricRuleStudentGroup) model);
        	}
        
        	return assessmentmetricrulestudentgroupCollection;
        }

        public static AssessmentMetricRuleStudentGroup retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentMetricRuleStudentGroup.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentMetricRuleStudentGroup) gateway.retrieve(ResourceType.ASSESSMENT_METRIC_RULE_STUDENT_GROUP, id);
        }

        public AssessmentMetricRule getAssessmentMetricRule ()
        {
            return (AssessmentMetricRule) this.getProperty("assessmentMetricRule");
        }

        public void setAssessmentMetricRule (AssessmentMetricRule assessmentMetricRule)
        {
            this.setProperty("assessmentMetricRule", assessmentMetricRule);
        }

        public AcademicLevel getAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("academicLevel");
        }

        public void setAcademicLevel (AcademicLevel academicLevel)
        {
            this.setProperty("academicLevel", academicLevel);
        }


    }
}

