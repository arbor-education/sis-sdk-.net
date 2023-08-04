using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDataCollectionPolicyStudentGroup : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY_STUDENT_GROUP;
        public const string ASSESSMENT_DATA_COLLECTION_POLICY = "assessmentDataCollectionPolicy";
        public const string STUDENT_GROUP = "studentGroup";

        public AssessmentDataCollectionPolicyStudentGroup()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentDataCollectionPolicyStudentGroup(string resourceType = "AssessmentDataCollectionPolicyStudentGroup", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentDataCollectionPolicyStudentGroup> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentDataCollectionPolicyStudentGroup");
            RestGateway gateway = (RestGateway)AssessmentDataCollectionPolicyStudentGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentDataCollectionPolicyStudentGroup> assessmentdatacollectionpolicystudentgroupCollection = new ModelCollection<AssessmentDataCollectionPolicyStudentGroup>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentdatacollectionpolicystudentgroupCollection.add((AssessmentDataCollectionPolicyStudentGroup)model);
            }

            return assessmentdatacollectionpolicystudentgroupCollection;
        }

        public static AssessmentDataCollectionPolicyStudentGroup retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentDataCollectionPolicyStudentGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentDataCollectionPolicyStudentGroup)gateway.retrieve(ResourceType.ASSESSMENT_DATA_COLLECTION_POLICY_STUDENT_GROUP, id);
        }

        public AssessmentDataCollectionPolicy getAssessmentDataCollectionPolicy()
        {
            return (AssessmentDataCollectionPolicy)this.getProperty("assessmentDataCollectionPolicy");
        }

        public void setAssessmentDataCollectionPolicy(AssessmentDataCollectionPolicy assessmentDataCollectionPolicy)
        {
            this.setProperty("assessmentDataCollectionPolicy", assessmentDataCollectionPolicy);
        }

        public ModelBase getStudentGroup()
        {
            return (ModelBase)this.getProperty("studentGroup");
        }

        public void setStudentGroup(ModelBase studentGroup)
        {
            this.setProperty("studentGroup", studentGroup);
        }


    }
}

