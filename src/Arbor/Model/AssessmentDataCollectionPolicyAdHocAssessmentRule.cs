using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDataCollectionPolicyAdHocAssessmentRule : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY_AD_HOC_ASSESSMENT_RULE;
        public const string ASSESSMENT_DATA_COLLECTION_POLICY = "assessmentDataCollectionPolicy";
        public const string INPUT_STAFF_TYPE = "inputStaffType";
        public const string LEVEL_ONE_APPROVAL_STAFF_TYPE = "levelOneApprovalStaffType";
        public const string LEVEL_TWO_APPROVAL_STAFF_TYPE = "levelTwoApprovalStaffType";
        public const string COLLECT_CURRENT_MARK = "collectCurrentMark";
        public const string COLLECT_COMMENT = "collectComment";
        public const string AD_HOC_ASSESSMENT = "adHocAssessment";

        public AssessmentDataCollectionPolicyAdHocAssessmentRule()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentDataCollectionPolicyAdHocAssessmentRule(string resourceType = "AssessmentDataCollectionPolicyAdHocAssessmentRule", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentDataCollectionPolicyAdHocAssessmentRule> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentDataCollectionPolicyAdHocAssessmentRule");
            RestGateway gateway = (RestGateway)AssessmentDataCollectionPolicyAdHocAssessmentRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentDataCollectionPolicyAdHocAssessmentRule> assessmentdatacollectionpolicyadhocassessmentruleCollection = new ModelCollection<AssessmentDataCollectionPolicyAdHocAssessmentRule>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentdatacollectionpolicyadhocassessmentruleCollection.add((AssessmentDataCollectionPolicyAdHocAssessmentRule)model);
            }

            return assessmentdatacollectionpolicyadhocassessmentruleCollection;
        }

        public static AssessmentDataCollectionPolicyAdHocAssessmentRule retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentDataCollectionPolicyAdHocAssessmentRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentDataCollectionPolicyAdHocAssessmentRule)gateway.retrieve(ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY_AD_HOC_ASSESSMENT_RULE, id);
        }

        public AssessmentDataCollectionPolicy getAssessmentDataCollectionPolicy()
        {
            return (AssessmentDataCollectionPolicy)this.getProperty("assessmentDataCollectionPolicy");
        }

        public void setAssessmentDataCollectionPolicy(AssessmentDataCollectionPolicy assessmentDataCollectionPolicy)
        {
            this.setProperty("assessmentDataCollectionPolicy", assessmentDataCollectionPolicy);
        }

        public string getInputStaffType()
        {
            return this.getProperty("inputStaffType").ToString();
        }

        public void setInputStaffType(string inputStaffType)
        {
            this.setProperty("inputStaffType", inputStaffType);
        }

        public string getLevelOneApprovalStaffType()
        {
            return this.getProperty("levelOneApprovalStaffType").ToString();
        }

        public void setLevelOneApprovalStaffType(string levelOneApprovalStaffType)
        {
            this.setProperty("levelOneApprovalStaffType", levelOneApprovalStaffType);
        }

        public string getLevelTwoApprovalStaffType()
        {
            return this.getProperty("levelTwoApprovalStaffType").ToString();
        }

        public void setLevelTwoApprovalStaffType(string levelTwoApprovalStaffType)
        {
            this.setProperty("levelTwoApprovalStaffType", levelTwoApprovalStaffType);
        }

        public bool getCollectCurrentMark()
        {
            return (bool)this.getProperty("collectCurrentMark");
        }

        public void setCollectCurrentMark(bool collectCurrentMark)
        {
            this.setProperty("collectCurrentMark", collectCurrentMark);
        }

        public bool getCollectComment()
        {
            return (bool)this.getProperty("collectComment");
        }

        public void setCollectComment(bool collectComment)
        {
            this.setProperty("collectComment", collectComment);
        }

        public AdHocAssessment getAdHocAssessment()
        {
            return (AdHocAssessment)this.getProperty("adHocAssessment");
        }

        public void setAdHocAssessment(AdHocAssessment adHocAssessment)
        {
            this.setProperty("adHocAssessment", adHocAssessment);
        }


    }
}

