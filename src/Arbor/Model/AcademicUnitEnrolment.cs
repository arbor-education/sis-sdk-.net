using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_UNIT_ENROLMENT;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string ENROLMENT_STATUS = "enrolmentStatus";
        public const string REPEAT_ENROLMENT = "repeatEnrolment";
        public const string ACADEMIC_UNIT_AUTOMATIC_ENROLMENT = "academicUnitAutomaticEnrolment";
        public const string ENROLMENT_DEPENDENCY = "enrolmentDependency";
        public const string STUDENT_ATTENDANCE_PATTERN_DEPENDENCY = "studentAttendancePatternDependency";

        public AcademicUnitEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitEnrolment (string resourceType = "AcademicUnitEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicUnitEnrolment");
        	RestGateway gateway = (RestGateway) AcademicUnitEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitEnrolment> academicunitenrolmentCollection = new ModelCollection<AcademicUnitEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunitenrolmentCollection.add((AcademicUnitEnrolment) model);
        	}
        
        	return academicunitenrolmentCollection;
        }

        public static AcademicUnitEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitEnrolment) gateway.retrieve(ResourceType.ACADEMIC_UNIT_ENROLMENT, id);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getEnrolmentStatus ()
        {
            return this.getProperty("enrolmentStatus").ToString();
        }

        public void setEnrolmentStatus (string enrolmentStatus)
        {
            this.setProperty("enrolmentStatus", enrolmentStatus);
        }

        public bool getRepeatEnrolment ()
        {
            return (bool) this.getProperty("repeatEnrolment");
        }

        public void setRepeatEnrolment (bool repeatEnrolment)
        {
            this.setProperty("repeatEnrolment", repeatEnrolment);
        }

        public AcademicUnitAutomaticEnrolment getAcademicUnitAutomaticEnrolment ()
        {
            return (AcademicUnitAutomaticEnrolment) this.getProperty("academicUnitAutomaticEnrolment");
        }

        public void setAcademicUnitAutomaticEnrolment (AcademicUnitAutomaticEnrolment academicUnitAutomaticEnrolment)
        {
            this.setProperty("academicUnitAutomaticEnrolment", academicUnitAutomaticEnrolment);
        }

        public ModelBase getEnrolmentDependency ()
        {
            return (ModelBase) this.getProperty("enrolmentDependency");
        }

        public void setEnrolmentDependency (ModelBase enrolmentDependency)
        {
            this.setProperty("enrolmentDependency", enrolmentDependency);
        }

        public StudentAttendancePattern getStudentAttendancePatternDependency ()
        {
            return (StudentAttendancePattern) this.getProperty("studentAttendancePatternDependency");
        }

        public void setStudentAttendancePatternDependency (StudentAttendancePattern studentAttendancePatternDependency)
        {
            this.setProperty("studentAttendancePatternDependency", studentAttendancePatternDependency);
        }


    }
}

