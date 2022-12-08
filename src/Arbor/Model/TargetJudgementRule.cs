using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TargetJudgementRule : ModelBase
    {
        protected string resourceType = ResourceType.TARGET_JUDGEMENT_RULE;
        public const string ASSESSMENT_ASPECT = "assessmentAspect";
        public const string TARGET_JUDGEMENT = "targetJudgement";
        public const string AMOUNT = "amount";
        public const string AMOUNT_UNIT = "amountUnit";

        public TargetJudgementRule()
        {
            base.resourceType = this.resourceType;
        }

        public TargetJudgementRule(string resourceType = "TargetJudgementRule", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TargetJudgementRule> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TargetJudgementRule");
            RestGateway gateway = (RestGateway)TargetJudgementRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TargetJudgementRule> targetjudgementruleCollection = new ModelCollection<TargetJudgementRule>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                targetjudgementruleCollection.add((TargetJudgementRule)model);
            }

            return targetjudgementruleCollection;
        }

        public static TargetJudgementRule retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TargetJudgementRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TargetJudgementRule)gateway.retrieve(ResourceType.TARGET_JUDGEMENT_RULE, id);
        }

        public AssessmentAspect getAssessmentAspect()
        {
            return (AssessmentAspect)this.getProperty("assessmentAspect");
        }

        public void setAssessmentAspect(AssessmentAspect assessmentAspect)
        {
            this.setProperty("assessmentAspect", assessmentAspect);
        }

        public TargetJudgement getTargetJudgement()
        {
            return (TargetJudgement)this.getProperty("targetJudgement");
        }

        public void setTargetJudgement(TargetJudgement targetJudgement)
        {
            this.setProperty("targetJudgement", targetJudgement);
        }

        public float getAmount()
        {
            return (float)this.getProperty("amount");
        }

        public void setAmount(float amount)
        {
            this.setProperty("amount", amount);
        }

        public string getAmountUnit()
        {
            return this.getProperty("amountUnit").ToString();
        }

        public void setAmountUnit(string amountUnit)
        {
            this.setProperty("amountUnit", amountUnit);
        }


    }
}

