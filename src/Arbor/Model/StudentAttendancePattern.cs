using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentAttendancePattern : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_ATTENDANCE_PATTERN;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string STUDENT = "student";
        public const string ATTENDANCE_PATTERN = "attendancePattern";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public StudentAttendancePattern ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentAttendancePattern (string resourceType = "StudentAttendancePattern", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentAttendancePattern> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentAttendancePattern");
        	RestGateway gateway = (RestGateway) StudentAttendancePattern.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentAttendancePattern> studentattendancepatternCollection = new ModelCollection<StudentAttendancePattern> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentattendancepatternCollection.add((StudentAttendancePattern) model);
        	}
        
        	return studentattendancepatternCollection;
        }

        public static StudentAttendancePattern retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentAttendancePattern.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentAttendancePattern) gateway.retrieve(ResourceType.STUDENT_ATTENDANCE_PATTERN, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public AttendancePattern getAttendancePattern ()
        {
            return (AttendancePattern) this.getProperty("attendancePattern");
        }

        public void setAttendancePattern (AttendancePattern attendancePattern)
        {
            this.setProperty("attendancePattern", attendancePattern);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

