using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMetricRuleGradeItem : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_METRIC_RULE_GRADE_ITEM;
        public const string OPERATOR = "operator";
        public const string GRADE = "grade";
        public const string ASSESSMENT_METRIC_RULE = "assessmentMetricRule";
        public const string ASSESSMENT_METRIC_ASSESSMENT = "assessmentMetricAssessment";
        public const string ASSESSMENT = "assessment";

        public AssessmentMetricRuleGradeItem()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentMetricRuleGradeItem(string resourceType = "AssessmentMetricRuleGradeItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentMetricRuleGradeItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentMetricRuleGradeItem");
            RestGateway gateway = (RestGateway)AssessmentMetricRuleGradeItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentMetricRuleGradeItem> assessmentmetricrulegradeitemCollection = new ModelCollection<AssessmentMetricRuleGradeItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentmetricrulegradeitemCollection.add((AssessmentMetricRuleGradeItem)model);
            }

            return assessmentmetricrulegradeitemCollection;
        }

        public static AssessmentMetricRuleGradeItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentMetricRuleGradeItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentMetricRuleGradeItem)gateway.retrieve(ResourceType.ASSESSMENT_METRIC_RULE_GRADE_ITEM, id);
        }

        public string getOperator()
        {
            return this.getProperty("operator").ToString();
        }

        public void setOperator(string _operator)
        {
            this.setProperty("operator", _operator);
        }

        public Grade getGrade()
        {
            return (Grade)this.getProperty("grade");
        }

        public void setGrade(Grade grade)
        {
            this.setProperty("grade", grade);
        }

        public AssessmentMetricRule getAssessmentMetricRule()
        {
            return (AssessmentMetricRule)this.getProperty("assessmentMetricRule");
        }

        public void setAssessmentMetricRule(AssessmentMetricRule assessmentMetricRule)
        {
            this.setProperty("assessmentMetricRule", assessmentMetricRule);
        }

        public AssessmentMetricAssessment getAssessmentMetricAssessment()
        {
            return (AssessmentMetricAssessment)this.getProperty("assessmentMetricAssessment");
        }

        public void setAssessmentMetricAssessment(AssessmentMetricAssessment assessmentMetricAssessment)
        {
            this.setProperty("assessmentMetricAssessment", assessmentMetricAssessment);
        }

        public Assessment getAssessment()
        {
            return (Assessment)this.getProperty("assessment");
        }

        public void setAssessment(Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }


    }
}

