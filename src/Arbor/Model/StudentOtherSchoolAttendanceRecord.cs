using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentOtherSchoolAttendanceRecord : ModelBase
    {
        protected new string resourceType = ResourceType.STUDENT_OTHER_SCHOOL_ATTENDANCE_RECORD;
        public const string STUDENT = "student";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string YEAR = "year";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string SESSIONS_POSSIBLE = "sessionsPossible";
        public const string SESSIONS_ATTENDED = "sessionsAttended";
        public const string SESSIONS_AUTHORIZED_ABSENCE = "sessionsAuthorizedAbsence";
        public const string SESSIONS_UNAUTHORIZED_ABSENCE = "sessionsUnauthorizedAbsence";
        public const string ATTENDANCE_START_DATE = "attendanceStartDate";
        public const string ATTENDANCE_MARKS = "attendanceMarks";

        public StudentOtherSchoolAttendanceRecord()
        {
            base.resourceType = this.resourceType;
        }

        public StudentOtherSchoolAttendanceRecord(string resourceType = "StudentOtherSchoolAttendanceRecord", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StudentOtherSchoolAttendanceRecord> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StudentOtherSchoolAttendanceRecord");
            RestGateway gateway = (RestGateway)StudentOtherSchoolAttendanceRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StudentOtherSchoolAttendanceRecord> studentotherschoolattendancerecordCollection = new ModelCollection<StudentOtherSchoolAttendanceRecord>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studentotherschoolattendancerecordCollection.add((StudentOtherSchoolAttendanceRecord)model);
            }

            return studentotherschoolattendancerecordCollection;
        }

        public static StudentOtherSchoolAttendanceRecord retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StudentOtherSchoolAttendanceRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StudentOtherSchoolAttendanceRecord)gateway.retrieve(ResourceType.STUDENT_OTHER_SCHOOL_ATTENDANCE_RECORD, id);
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

        public string getYear()
        {
            return this.getProperty("year").ToString();
        }

        public void setYear(string year)
        {
            this.setProperty("year", year);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public int getSessionsPossible()
        {
            return Convert.ToInt32(this.getProperty("sessionsPossible"));
        }

        public void setSessionsPossible(int sessionsPossible)
        {
            this.setProperty("sessionsPossible", sessionsPossible);
        }

        public int getSessionsAttended()
        {
            return Convert.ToInt32(this.getProperty("sessionsAttended"));
        }

        public void setSessionsAttended(int sessionsAttended)
        {
            this.setProperty("sessionsAttended", sessionsAttended);
        }

        public int getSessionsAuthorizedAbsence()
        {
            return Convert.ToInt32(this.getProperty("sessionsAuthorizedAbsence"));
        }

        public void setSessionsAuthorizedAbsence(int sessionsAuthorizedAbsence)
        {
            this.setProperty("sessionsAuthorizedAbsence", sessionsAuthorizedAbsence);
        }

        public int getSessionsUnauthorizedAbsence()
        {
            return Convert.ToInt32(this.getProperty("sessionsUnauthorizedAbsence"));
        }

        public void setSessionsUnauthorizedAbsence(int sessionsUnauthorizedAbsence)
        {
            this.setProperty("sessionsUnauthorizedAbsence", sessionsUnauthorizedAbsence);
        }

        public DateTime getAttendanceStartDate()
        {
            return Convert.ToDateTime(this.getProperty("attendanceStartDate"));
        }

        public void setAttendanceStartDate(DateTime attendanceStartDate)
        {
            this.setProperty("attendanceStartDate", attendanceStartDate);
        }

        public string getAttendanceMarks()
        {
            return this.getProperty("attendanceMarks").ToString();
        }

        public void setAttendanceMarks(string attendanceMarks)
        {
            this.setProperty("attendanceMarks", attendanceMarks);
        }


    }
}

