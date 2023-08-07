using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDataCollectionPolicy : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY;
        public const string POLICY_NAME = "policyName";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string INPUT_DEADLINE_OFFSET_DAYS = "inputDeadlineOffsetDays";
        public const string LEVEL_ONE_APPROVAL_DEADLINE_OFFSET_DAYS = "levelOneApprovalDeadlineOffsetDays";
        public const string LEVEL_TWO_APPROVAL_DEADLINE_OFFSET_DAYS = "levelTwoApprovalDeadlineOffsetDays";

        public AssessmentDataCollectionPolicy()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentDataCollectionPolicy(string resourceType = "AssessmentDataCollectionPolicy", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentDataCollectionPolicy> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentDataCollectionPolicy");
            RestGateway gateway = (RestGateway)AssessmentDataCollectionPolicy.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentDataCollectionPolicy> assessmentdatacollectionpolicyCollection = new ModelCollection<AssessmentDataCollectionPolicy>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentdatacollectionpolicyCollection.add((AssessmentDataCollectionPolicy)model);
            }

            return assessmentdatacollectionpolicyCollection;
        }

        public static AssessmentDataCollectionPolicy retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentDataCollectionPolicy.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentDataCollectionPolicy)gateway.retrieve(ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY, id);
        }

        public string getPolicyName()
        {
            return this.getProperty("policyName").ToString();
        }

        public void setPolicyName(string policyName)
        {
            this.setProperty("policyName", policyName);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public int getInputDeadlineOffsetDays()
        {
            return Convert.ToInt32(this.getProperty("inputDeadlineOffsetDays"));
        }

        public void setInputDeadlineOffsetDays(int inputDeadlineOffsetDays)
        {
            this.setProperty("inputDeadlineOffsetDays", inputDeadlineOffsetDays);
        }

        public int getLevelOneApprovalDeadlineOffsetDays()
        {
            return Convert.ToInt32(this.getProperty("levelOneApprovalDeadlineOffsetDays"));
        }

        public void setLevelOneApprovalDeadlineOffsetDays(int levelOneApprovalDeadlineOffsetDays)
        {
            this.setProperty("levelOneApprovalDeadlineOffsetDays", levelOneApprovalDeadlineOffsetDays);
        }

        public int getLevelTwoApprovalDeadlineOffsetDays()
        {
            return Convert.ToInt32(this.getProperty("levelTwoApprovalDeadlineOffsetDays"));
        }

        public void setLevelTwoApprovalDeadlineOffsetDays(int levelTwoApprovalDeadlineOffsetDays)
        {
            this.setProperty("levelTwoApprovalDeadlineOffsetDays", levelTwoApprovalDeadlineOffsetDays);
        }


    }
}

