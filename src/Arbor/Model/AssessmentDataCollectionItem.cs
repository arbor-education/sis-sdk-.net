using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDataCollectionItem : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DATA_COLLECTION_ITEM;
        public const string ASSESSMENT_DATA_COLLECTION = "assessmentDataCollection";
        public const string ASSESSMENT_ENTITY = "assessmentEntity";
        public const string STUDENT_GROUP = "studentGroup";
        public const string COLLECTION_TYPE = "collectionType";
        public const string ASSIGNED_STAFF = "assignedStaff";
        public const string DEADLINE_DATE = "deadlineDate";
        public const string COMPLETION_NUMERATOR = "completionNumerator";
        public const string COMPLETION_DENOMINATOR = "completionDenominator";
        public const string DERIVE_ASSIGNED_STAFF = "deriveAssignedStaff";

        public AssessmentDataCollectionItem()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentDataCollectionItem(string resourceType = "AssessmentDataCollectionItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentDataCollectionItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentDataCollectionItem");
            RestGateway gateway = (RestGateway)AssessmentDataCollectionItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentDataCollectionItem> assessmentdatacollectionitemCollection = new ModelCollection<AssessmentDataCollectionItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentdatacollectionitemCollection.add((AssessmentDataCollectionItem)model);
            }

            return assessmentdatacollectionitemCollection;
        }

        public static AssessmentDataCollectionItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentDataCollectionItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentDataCollectionItem)gateway.retrieve(ResourceType.ASSESSMENT_DATA_COLLECTION_ITEM, id);
        }

        public AssessmentDataCollection getAssessmentDataCollection()
        {
            return (AssessmentDataCollection)this.getProperty("assessmentDataCollection");
        }

        public void setAssessmentDataCollection(AssessmentDataCollection assessmentDataCollection)
        {
            this.setProperty("assessmentDataCollection", assessmentDataCollection);
        }

        public ModelBase getAssessmentEntity()
        {
            return (ModelBase)this.getProperty("assessmentEntity");
        }

        public void setAssessmentEntity(ModelBase assessmentEntity)
        {
            this.setProperty("assessmentEntity", assessmentEntity);
        }

        public ModelBase getStudentGroup()
        {
            return (ModelBase)this.getProperty("studentGroup");
        }

        public void setStudentGroup(ModelBase studentGroup)
        {
            this.setProperty("studentGroup", studentGroup);
        }

        public string getCollectionType()
        {
            return this.getProperty("collectionType").ToString();
        }

        public void setCollectionType(string collectionType)
        {
            this.setProperty("collectionType", collectionType);
        }

        public Staff getAssignedStaff()
        {
            return (Staff)this.getProperty("assignedStaff");
        }

        public void setAssignedStaff(Staff assignedStaff)
        {
            this.setProperty("assignedStaff", assignedStaff);
        }

        public DateTime getDeadlineDate()
        {
            return Convert.ToDateTime(this.getProperty("deadlineDate"));
        }

        public void setDeadlineDate(DateTime deadlineDate)
        {
            this.setProperty("deadlineDate", deadlineDate);
        }

        public int getCompletionNumerator()
        {
            return Convert.ToInt32(this.getProperty("completionNumerator"));
        }

        public void setCompletionNumerator(int completionNumerator)
        {
            this.setProperty("completionNumerator", completionNumerator);
        }

        public int getCompletionDenominator()
        {
            return Convert.ToInt32(this.getProperty("completionDenominator"));
        }

        public void setCompletionDenominator(int completionDenominator)
        {
            this.setProperty("completionDenominator", completionDenominator);
        }

        public bool getDeriveAssignedStaff()
        {
            return Convert.ToBoolean(this.getProperty("deriveAssignedStaff"));
        }

        public void setDeriveAssignedStaff(bool deriveAssignedStaff)
        {
            this.setProperty("deriveAssignedStaff", deriveAssignedStaff);
        }


    }
}

