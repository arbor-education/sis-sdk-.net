using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentLinkedRelationshipType : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_LINKED_RELATIONSHIP_TYPE;
        public const string STUDENT_LINKED_RELATIONSHIP_TYPE_NAME = "studentLinkedRelationshipTypeName";
        public const string IS_MEDICAL = "isMedical";
        public const string IS_ACADEMIC = "isAcademic";

        public StudentLinkedRelationshipType()
        {
            base.resourceType = this.resourceType;
        }

        public StudentLinkedRelationshipType(string resourceType = "StudentLinkedRelationshipType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StudentLinkedRelationshipType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StudentLinkedRelationshipType");
            RestGateway gateway = (RestGateway)StudentLinkedRelationshipType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StudentLinkedRelationshipType> studentlinkedrelationshiptypeCollection = new ModelCollection<StudentLinkedRelationshipType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studentlinkedrelationshiptypeCollection.add((StudentLinkedRelationshipType)model);
            }

            return studentlinkedrelationshiptypeCollection;
        }

        public static StudentLinkedRelationshipType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StudentLinkedRelationshipType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StudentLinkedRelationshipType)gateway.retrieve(ResourceType.STUDENT_LINKED_RELATIONSHIP_TYPE, id);
        }

        public string getStudentLinkedRelationshipTypeName()
        {
            return this.getProperty("studentLinkedRelationshipTypeName").ToString();
        }

        public void setStudentLinkedRelationshipTypeName(string studentLinkedRelationshipTypeName)
        {
            this.setProperty("studentLinkedRelationshipTypeName", studentLinkedRelationshipTypeName);
        }

        public bool getIsMedical()
        {
            return Convert.ToBoolean(this.getProperty("isMedical"));
        }

        public void setIsMedical(bool isMedical)
        {
            this.setProperty("isMedical", isMedical);
        }

        public bool getIsAcademic()
        {
            return Convert.ToBoolean(this.getProperty("isAcademic"));
        }

        public void setIsAcademic(bool isAcademic)
        {
            this.setProperty("isAcademic", isAcademic);
        }


    }
}

