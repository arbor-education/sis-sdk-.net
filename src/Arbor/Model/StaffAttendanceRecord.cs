using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffAttendanceRecord : ModelBase
    {
        protected new string resourceType = ResourceType.STAFF_ATTENDANCE_RECORD;
        public const string STAFF = "staff";
        public const string ATTENDANCE_PERIOD_DATE = "attendancePeriodDate";
        public const string ATTENDANCE_PERIOD_START_TIME = "attendancePeriodStartTime";
        public const string ATTENDANCE_PERIOD_END_TIME = "attendancePeriodEndTime";
        public const string ACTUAL_START_TIME = "actualStartTime";
        public const string ACTUAL_END_TIME = "actualEndTime";
        public const string STAFF_ATTENDANCE_MARK = "staffAttendanceMark";
        public const string NARRATIVE = "narrative";
        public const string STAFF_ABSENCE = "staffAbsence";

        public StaffAttendanceRecord()
        {
            base.resourceType = this.resourceType;
        }

        public StaffAttendanceRecord(string resourceType = "StaffAttendanceRecord", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StaffAttendanceRecord> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StaffAttendanceRecord");
            RestGateway gateway = (RestGateway)StaffAttendanceRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StaffAttendanceRecord> staffattendancerecordCollection = new ModelCollection<StaffAttendanceRecord>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                staffattendancerecordCollection.add((StaffAttendanceRecord)model);
            }

            return staffattendancerecordCollection;
        }

        public static StaffAttendanceRecord retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StaffAttendanceRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StaffAttendanceRecord)gateway.retrieve(ResourceType.STAFF_ATTENDANCE_RECORD, id);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getAttendancePeriodDate()
        {
            return Convert.ToDateTime(this.getProperty("attendancePeriodDate"));
        }

        public void setAttendancePeriodDate(DateTime attendancePeriodDate)
        {
            this.setProperty("attendancePeriodDate", attendancePeriodDate);
        }

        public string getAttendancePeriodStartTime()
        {
            return this.getProperty("attendancePeriodStartTime").ToString();
        }

        public void setAttendancePeriodStartTime(string attendancePeriodStartTime)
        {
            this.setProperty("attendancePeriodStartTime", attendancePeriodStartTime);
        }

        public string getAttendancePeriodEndTime()
        {
            return this.getProperty("attendancePeriodEndTime").ToString();
        }

        public void setAttendancePeriodEndTime(string attendancePeriodEndTime)
        {
            this.setProperty("attendancePeriodEndTime", attendancePeriodEndTime);
        }

        public string getActualStartTime()
        {
            return this.getProperty("actualStartTime").ToString();
        }

        public void setActualStartTime(string actualStartTime)
        {
            this.setProperty("actualStartTime", actualStartTime);
        }

        public string getActualEndTime()
        {
            return this.getProperty("actualEndTime").ToString();
        }

        public void setActualEndTime(string actualEndTime)
        {
            this.setProperty("actualEndTime", actualEndTime);
        }

        public StaffAttendanceMark getStaffAttendanceMark()
        {
            return (StaffAttendanceMark)this.getProperty("staffAttendanceMark");
        }

        public void setStaffAttendanceMark(StaffAttendanceMark staffAttendanceMark)
        {
            this.setProperty("staffAttendanceMark", staffAttendanceMark);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public StaffAbsence getStaffAbsence()
        {
            return (StaffAbsence)this.getProperty("staffAbsence");
        }

        public void setStaffAbsence(StaffAbsence staffAbsence)
        {
            this.setProperty("staffAbsence", staffAbsence);
        }


    }
}

