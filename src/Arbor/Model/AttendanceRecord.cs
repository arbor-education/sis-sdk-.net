using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRecord : ModelBase
    {
        protected string resourceType = ResourceType.ATTENDANCE_RECORD;
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string ATTENDANCE_REGISTER = "attendanceRegister";
        public const string STUDENT = "student";
        public const string MINUTES_LATE = "minutesLate";
        public const string RECORD_NOTE = "recordNote";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string ATTENDANCE_FOLLOW_UP = "attendanceFollowUp";
        public const string STUDENT_ABSENCE_NOTE = "studentAbsenceNote";
        public const string SOURCE_ATTENDANCE_RECORD = "sourceAttendanceRecord";
        public const string SOURCE = "source";

        public AttendanceRecord ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AttendanceRecord (string resourceType = "AttendanceRecord", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AttendanceRecord> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AttendanceRecord");
        	RestGateway gateway = (RestGateway) AttendanceRecord.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AttendanceRecord> attendancerecordCollection = new ModelCollection<AttendanceRecord> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    attendancerecordCollection.add((AttendanceRecord) model);
        	}
        
        	return attendancerecordCollection;
        }

        public static AttendanceRecord retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AttendanceRecord.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AttendanceRecord) gateway.retrieve(ResourceType.ATTENDANCE_RECORD, id);
        }

        public AttendanceMark getAttendanceMark ()
        {
            return (AttendanceMark) this.getProperty("attendanceMark");
        }

        public void setAttendanceMark (AttendanceMark attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public AttendanceRegister getAttendanceRegister ()
        {
            return (AttendanceRegister) this.getProperty("attendanceRegister");
        }

        public void setAttendanceRegister (AttendanceRegister attendanceRegister)
        {
            this.setProperty("attendanceRegister", attendanceRegister);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public int getMinutesLate ()
        {
            return Convert.ToInt32(this.getProperty("minutesLate"));
        }

        public void setMinutesLate (int minutesLate)
        {
            this.setProperty("minutesLate", minutesLate);
        }

        public string getRecordNote ()
        {
            return this.getProperty("recordNote").ToString();
        }

        public void setRecordNote (string recordNote)
        {
            this.setProperty("recordNote", recordNote);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return (DateTime) this.getProperty("endDatetime");
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public AttendanceFollowUp getAttendanceFollowUp ()
        {
            return (AttendanceFollowUp) this.getProperty("attendanceFollowUp");
        }

        public void setAttendanceFollowUp (AttendanceFollowUp attendanceFollowUp)
        {
            this.setProperty("attendanceFollowUp", attendanceFollowUp);
        }

        public StudentAbsenceNote getStudentAbsenceNote ()
        {
            return (StudentAbsenceNote) this.getProperty("studentAbsenceNote");
        }

        public void setStudentAbsenceNote (StudentAbsenceNote studentAbsenceNote)
        {
            this.setProperty("studentAbsenceNote", studentAbsenceNote);
        }

        public AttendanceRecord getSourceAttendanceRecord ()
        {
            return (AttendanceRecord) this.getProperty("sourceAttendanceRecord");
        }

        public void setSourceAttendanceRecord (AttendanceRecord sourceAttendanceRecord)
        {
            this.setProperty("sourceAttendanceRecord", sourceAttendanceRecord);
        }

        public string getSource ()
        {
            return this.getProperty("source").ToString();
        }

        public void setSource (string source)
        {
            this.setProperty("source", source);
        }


    }
}

