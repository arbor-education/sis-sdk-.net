using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDataCollectionPolicyProgressAssessmentRule : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY_PROGRESS_ASSESSMENT_RULE;
        public const string ASSESSMENT_DATA_COLLECTION_POLICY = "assessmentDataCollectionPolicy";
        public const string INPUT_STAFF_TYPE = "inputStaffType";
        public const string LEVEL_ONE_APPROVAL_STAFF_TYPE = "levelOneApprovalStaffType";
        public const string LEVEL_TWO_APPROVAL_STAFF_TYPE = "levelTwoApprovalStaffType";
        public const string COLLECT_CURRENT_MARK = "collectCurrentMark";
        public const string COLLECT_COMMENT = "collectComment";
        public const string ASSESSMENT = "assessment";
        public const string COLLECT_PREDICTED_MARK = "collectPredictedMark";

        public AssessmentDataCollectionPolicyProgressAssessmentRule ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentDataCollectionPolicyProgressAssessmentRule (string resourceType = "AssessmentDataCollectionPolicyProgressAssessmentRule", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentDataCollectionPolicyProgressAssessmentRule> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentDataCollectionPolicyProgressAssessmentRule");
        	RestGateway gateway = (RestGateway) AssessmentDataCollectionPolicyProgressAssessmentRule.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentDataCollectionPolicyProgressAssessmentRule> assessmentdatacollectionpolicyprogressassessmentruleCollection = new ModelCollection<AssessmentDataCollectionPolicyProgressAssessmentRule> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentdatacollectionpolicyprogressassessmentruleCollection.add((AssessmentDataCollectionPolicyProgressAssessmentRule) model);
        	}
        
        	return assessmentdatacollectionpolicyprogressassessmentruleCollection;
        }

        public static AssessmentDataCollectionPolicyProgressAssessmentRule retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentDataCollectionPolicyProgressAssessmentRule.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentDataCollectionPolicyProgressAssessmentRule) gateway.retrieve(ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY_PROGRESS_ASSESSMENT_RULE, id);
        }

        public AssessmentDataCollectionPolicy getAssessmentDataCollectionPolicy ()
        {
            return (AssessmentDataCollectionPolicy) this.getProperty("assessmentDataCollectionPolicy");
        }

        public void setAssessmentDataCollectionPolicy (AssessmentDataCollectionPolicy assessmentDataCollectionPolicy)
        {
            this.setProperty("assessmentDataCollectionPolicy", assessmentDataCollectionPolicy);
        }

        public string getInputStaffType ()
        {
            return this.getProperty("inputStaffType").ToString();
        }

        public void setInputStaffType (string inputStaffType)
        {
            this.setProperty("inputStaffType", inputStaffType);
        }

        public string getLevelOneApprovalStaffType ()
        {
            return this.getProperty("levelOneApprovalStaffType").ToString();
        }

        public void setLevelOneApprovalStaffType (string levelOneApprovalStaffType)
        {
            this.setProperty("levelOneApprovalStaffType", levelOneApprovalStaffType);
        }

        public string getLevelTwoApprovalStaffType ()
        {
            return this.getProperty("levelTwoApprovalStaffType").ToString();
        }

        public void setLevelTwoApprovalStaffType (string levelTwoApprovalStaffType)
        {
            this.setProperty("levelTwoApprovalStaffType", levelTwoApprovalStaffType);
        }

        public bool getCollectCurrentMark ()
        {
            return (bool) this.getProperty("collectCurrentMark");
        }

        public void setCollectCurrentMark (bool collectCurrentMark)
        {
            this.setProperty("collectCurrentMark", collectCurrentMark);
        }

        public bool getCollectComment ()
        {
            return (bool) this.getProperty("collectComment");
        }

        public void setCollectComment (bool collectComment)
        {
            this.setProperty("collectComment", collectComment);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public bool getCollectPredictedMark ()
        {
            return (bool) this.getProperty("collectPredictedMark");
        }

        public void setCollectPredictedMark (bool collectPredictedMark)
        {
            this.setProperty("collectPredictedMark", collectPredictedMark);
        }


    }
}

