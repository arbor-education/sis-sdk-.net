using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentAbsenceNote : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_ABSENCE_NOTE;
        public const string STUDENT = "student";
        public const string ABSENCE_START_DATETIME = "absenceStartDatetime";
        public const string ABSENCE_END_DATETIME = "absenceEndDatetime";
        public const string NOTES = "notes";
        public const string APPROVED_DATE = "approvedDate";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string TEMPORARY_EXCLUSION = "temporaryExclusion";

        public StudentAbsenceNote ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentAbsenceNote (string resourceType = "StudentAbsenceNote", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentAbsenceNote> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentAbsenceNote");
        	RestGateway gateway = (RestGateway) StudentAbsenceNote.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentAbsenceNote> studentabsencenoteCollection = new ModelCollection<StudentAbsenceNote> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentabsencenoteCollection.add((StudentAbsenceNote) model);
        	}
        
        	return studentabsencenoteCollection;
        }

        public static StudentAbsenceNote retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentAbsenceNote.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentAbsenceNote) gateway.retrieve(ResourceType.STUDENT_ABSENCE_NOTE, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getAbsenceStartDatetime ()
        {
            return (DateTime) this.getProperty("absenceStartDatetime");
        }

        public void setAbsenceStartDatetime (DateTime absenceStartDatetime)
        {
            this.setProperty("absenceStartDatetime", absenceStartDatetime);
        }

        public DateTime getAbsenceEndDatetime ()
        {
            return (DateTime) this.getProperty("absenceEndDatetime");
        }

        public void setAbsenceEndDatetime (DateTime absenceEndDatetime)
        {
            this.setProperty("absenceEndDatetime", absenceEndDatetime);
        }

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }

        public DateTime getApprovedDate ()
        {
            return (DateTime) this.getProperty("approvedDate");
        }

        public void setApprovedDate (DateTime approvedDate)
        {
            this.setProperty("approvedDate", approvedDate);
        }

        public Staff getApprovedByStaff ()
        {
            return (Staff) this.getProperty("approvedByStaff");
        }

        public void setApprovedByStaff (Staff approvedByStaff)
        {
            this.setProperty("approvedByStaff", approvedByStaff);
        }

        public AttendanceMark getAttendanceMark ()
        {
            return (AttendanceMark) this.getProperty("attendanceMark");
        }

        public void setAttendanceMark (AttendanceMark attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public TemporaryExclusion getTemporaryExclusion ()
        {
            return (TemporaryExclusion) this.getProperty("temporaryExclusion");
        }

        public void setTemporaryExclusion (TemporaryExclusion temporaryExclusion)
        {
            this.setProperty("temporaryExclusion", temporaryExclusion);
        }


    }
}

