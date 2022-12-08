using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentEducationalHistory : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_EDUCATIONAL_HISTORY;
        public const string STUDENT = "student";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string EXPECTED_ENTRY_DATE = "expectedEntryDate";
        public const string ACTUAL_ENTRY_DATE = "actualEntryDate";
        public const string LEAVING_DATE = "leavingDate";
        public const string UNENROLMENT_REASON = "unenrolmentReason";

        public StudentEducationalHistory()
        {
            base.resourceType = this.resourceType;
        }

        public StudentEducationalHistory(string resourceType = "StudentEducationalHistory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StudentEducationalHistory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StudentEducationalHistory");
            RestGateway gateway = (RestGateway)StudentEducationalHistory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StudentEducationalHistory> studenteducationalhistoryCollection = new ModelCollection<StudentEducationalHistory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studenteducationalhistoryCollection.add((StudentEducationalHistory)model);
            }

            return studenteducationalhistoryCollection;
        }

        public static StudentEducationalHistory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StudentEducationalHistory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StudentEducationalHistory)gateway.retrieve(ResourceType.STUDENT_EDUCATIONAL_HISTORY, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public EducationalInstitution getEducationalInstitution()
        {
            return (EducationalInstitution)this.getProperty("educationalInstitution");
        }

        public void setEducationalInstitution(EducationalInstitution educationalInstitution)
        {
            this.setProperty("educationalInstitution", educationalInstitution);
        }

        public DateTime getExpectedEntryDate()
        {
            return Convert.ToDateTime(this.getProperty("expectedEntryDate"));
        }

        public void setExpectedEntryDate(DateTime expectedEntryDate)
        {
            this.setProperty("expectedEntryDate", expectedEntryDate);
        }

        public DateTime getActualEntryDate()
        {
            return Convert.ToDateTime(this.getProperty("actualEntryDate"));
        }

        public void setActualEntryDate(DateTime actualEntryDate)
        {
            this.setProperty("actualEntryDate", actualEntryDate);
        }

        public DateTime getLeavingDate()
        {
            return Convert.ToDateTime(this.getProperty("leavingDate"));
        }

        public void setLeavingDate(DateTime leavingDate)
        {
            this.setProperty("leavingDate", leavingDate);
        }

        public UnenrolmentReason getUnenrolmentReason()
        {
            return (UnenrolmentReason)this.getProperty("unenrolmentReason");
        }

        public void setUnenrolmentReason(UnenrolmentReason unenrolmentReason)
        {
            this.setProperty("unenrolmentReason", unenrolmentReason);
        }


    }
}

