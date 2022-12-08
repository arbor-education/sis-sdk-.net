using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendancePatternPeriod : ModelBase
    {
        protected string resourceType = ResourceType.ATTENDANCE_PATTERN_PERIOD;
        public const string ATTENDANCE_PATTERN = "attendancePattern";
        public const string DAY_OF_CYCLE = "dayOfCycle";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";

        public AttendancePatternPeriod()
        {
            base.resourceType = this.resourceType;
        }

        public AttendancePatternPeriod(string resourceType = "AttendancePatternPeriod", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AttendancePatternPeriod> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AttendancePatternPeriod");
            RestGateway gateway = (RestGateway)AttendancePatternPeriod.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AttendancePatternPeriod> attendancepatternperiodCollection = new ModelCollection<AttendancePatternPeriod>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                attendancepatternperiodCollection.add((AttendancePatternPeriod)model);
            }

            return attendancepatternperiodCollection;
        }

        public static AttendancePatternPeriod retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AttendancePatternPeriod.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AttendancePatternPeriod)gateway.retrieve(ResourceType.ATTENDANCE_PATTERN_PERIOD, id);
        }

        public AttendancePattern getAttendancePattern()
        {
            return (AttendancePattern)this.getProperty("attendancePattern");
        }

        public void setAttendancePattern(AttendancePattern attendancePattern)
        {
            this.setProperty("attendancePattern", attendancePattern);
        }

        public int getDayOfCycle()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle(int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
        }

        public string getStartTime()
        {
            return this.getProperty("startTime").ToString();
        }

        public void setStartTime(string startTime)
        {
            this.setProperty("startTime", startTime);
        }

        public string getEndTime()
        {
            return this.getProperty("endTime").ToString();
        }

        public void setEndTime(string endTime)
        {
            this.setProperty("endTime", endTime);
        }


    }
}

