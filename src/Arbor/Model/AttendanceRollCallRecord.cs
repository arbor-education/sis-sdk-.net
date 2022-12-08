using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRollCallRecord : ModelBase
    {
        protected string resourceType = ResourceType.ATTENDANCE_ROLL_CALL_RECORD;
        public const string ATTENDANCE_ROLL_CALL = "attendanceRollCall";
        public const string RECORD_DATE = "recordDate";
        public const string STUDENT = "student";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string MINUTES_LATE = "minutesLate";
        public const string SOURCE_ATTENDANCE_RECORD = "sourceAttendanceRecord";
        public const string VALIDATION_ERROR = "validationError";
        public const string SOURCE = "source";

        public AttendanceRollCallRecord()
        {
            base.resourceType = this.resourceType;
        }

        public AttendanceRollCallRecord(string resourceType = "AttendanceRollCallRecord", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AttendanceRollCallRecord> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AttendanceRollCallRecord");
            RestGateway gateway = (RestGateway)AttendanceRollCallRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AttendanceRollCallRecord> attendancerollcallrecordCollection = new ModelCollection<AttendanceRollCallRecord>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                attendancerollcallrecordCollection.add((AttendanceRollCallRecord)model);
            }

            return attendancerollcallrecordCollection;
        }

        public static AttendanceRollCallRecord retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AttendanceRollCallRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AttendanceRollCallRecord)gateway.retrieve(ResourceType.ATTENDANCE_ROLL_CALL_RECORD, id);
        }

        public AttendanceRollCall getAttendanceRollCall()
        {
            return (AttendanceRollCall)this.getProperty("attendanceRollCall");
        }

        public void setAttendanceRollCall(AttendanceRollCall attendanceRollCall)
        {
            this.setProperty("attendanceRollCall", attendanceRollCall);
        }

        public DateTime getRecordDate()
        {
            return Convert.ToDateTime(this.getProperty("recordDate"));
        }

        public void setRecordDate(DateTime recordDate)
        {
            this.setProperty("recordDate", recordDate);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public AttendanceMark getAttendanceMark()
        {
            return (AttendanceMark)this.getProperty("attendanceMark");
        }

        public void setAttendanceMark(AttendanceMark attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public int getMinutesLate()
        {
            return Convert.ToInt32(this.getProperty("minutesLate"));
        }

        public void setMinutesLate(int minutesLate)
        {
            this.setProperty("minutesLate", minutesLate);
        }

        public AttendanceRecord getSourceAttendanceRecord()
        {
            return (AttendanceRecord)this.getProperty("sourceAttendanceRecord");
        }

        public void setSourceAttendanceRecord(AttendanceRecord sourceAttendanceRecord)
        {
            this.setProperty("sourceAttendanceRecord", sourceAttendanceRecord);
        }

        public string getValidationError()
        {
            return this.getProperty("validationError").ToString();
        }

        public void setValidationError(string validationError)
        {
            this.setProperty("validationError", validationError);
        }

        public string getSource()
        {
            return this.getProperty("source").ToString();
        }

        public void setSource(string source)
        {
            this.setProperty("source", source);
        }


    }
}

