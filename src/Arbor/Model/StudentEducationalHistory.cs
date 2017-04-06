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
        public const string EDUCATION_RECORD_TYPE = "educationRecordType";
        public const string ARRIVAL_DATE = "arrivalDate";
        public const string LEAVING_DATE = "leavingDate";
        public const string UNENROLMENT_REASON = "unenrolmentReason";
        public const string ENROLMENT_MODE = "enrolmentMode";
        public const string ATTENDANCE_MODE = "attendanceMode";

        public StudentEducationalHistory ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentEducationalHistory (string resourceType = "StudentEducationalHistory", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentEducationalHistory> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentEducationalHistory");
        	RestGateway gateway = (RestGateway) StudentEducationalHistory.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentEducationalHistory> studenteducationalhistoryCollection = new ModelCollection<StudentEducationalHistory> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studenteducationalhistoryCollection.add((StudentEducationalHistory) model);
        	}
        
        	return studenteducationalhistoryCollection;
        }

        public static StudentEducationalHistory retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentEducationalHistory.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentEducationalHistory) gateway.retrieve(ResourceType.STUDENT_EDUCATIONAL_HISTORY, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public EducationalInstitution getEducationalInstitution ()
        {
            return (EducationalInstitution) this.getProperty("educationalInstitution");
        }

        public void setEducationalInstitution (EducationalInstitution educationalInstitution)
        {
            this.setProperty("educationalInstitution", educationalInstitution);
        }

        public EducationRecordType getEducationRecordType ()
        {
            return (EducationRecordType) this.getProperty("educationRecordType");
        }

        public void setEducationRecordType (EducationRecordType educationRecordType)
        {
            this.setProperty("educationRecordType", educationRecordType);
        }

        public DateTime getArrivalDate ()
        {
            return (DateTime) this.getProperty("arrivalDate");
        }

        public void setArrivalDate (DateTime arrivalDate)
        {
            this.setProperty("arrivalDate", arrivalDate);
        }

        public DateTime getLeavingDate ()
        {
            return (DateTime) this.getProperty("leavingDate");
        }

        public void setLeavingDate (DateTime leavingDate)
        {
            this.setProperty("leavingDate", leavingDate);
        }

        public UnenrolmentReason getUnenrolmentReason ()
        {
            return (UnenrolmentReason) this.getProperty("unenrolmentReason");
        }

        public void setUnenrolmentReason (UnenrolmentReason unenrolmentReason)
        {
            this.setProperty("unenrolmentReason", unenrolmentReason);
        }

        public EnrolmentMode getEnrolmentMode ()
        {
            return (EnrolmentMode) this.getProperty("enrolmentMode");
        }

        public void setEnrolmentMode (EnrolmentMode enrolmentMode)
        {
            this.setProperty("enrolmentMode", enrolmentMode);
        }

        public string getAttendanceMode ()
        {
            return this.getProperty("attendanceMode").ToString();
        }

        public void setAttendanceMode (string attendanceMode)
        {
            this.setProperty("attendanceMode", attendanceMode);
        }


    }
}

