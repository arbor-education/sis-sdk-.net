using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentSchool : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_SCHOOL;
        public const string STUDENT = "student";
        public const string SCHOOL = "school";
        public const string ARRIVAL_DATE = "arrivalDate";
        public const string LEAVING_DATE = "leavingDate";
        public const string UNENROLMENT_REASON = "unenrolmentReason";
        public const string ENROLMENT_MODE = "enrolmentMode";
        public const string ATTENDANCE_MODE = "attendanceMode";

        public StudentSchool ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentSchool (string resourceType = "StudentSchool", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentSchool> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentSchool");
        	RestGateway gateway = (RestGateway) StudentSchool.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentSchool> studentschoolCollection = new ModelCollection<StudentSchool> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentschoolCollection.add((StudentSchool) model);
        	}
        
        	return studentschoolCollection;
        }

        public static StudentSchool retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentSchool.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentSchool) gateway.retrieve(ResourceType.STUDENT_SCHOOL, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public School getSchool ()
        {
            return (School) this.getProperty("school");
        }

        public void setSchool (School school)
        {
            this.setProperty("school", school);
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

