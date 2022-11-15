using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRollCallTimeGroup : ModelBase
    {
        protected new string resourceType = ResourceType.ATTENDANCE_ROLL_CALL_TIME_GROUP;
        public const string ATTENDANCE_ROLL_CALL_TIME = "attendanceRollCallTime";
        public const string STUDENT_GROUP = "studentGroup";

        public AttendanceRollCallTimeGroup()
        {
            base.resourceType = this.resourceType;
        }

        public AttendanceRollCallTimeGroup(string resourceType = "AttendanceRollCallTimeGroup", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AttendanceRollCallTimeGroup> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AttendanceRollCallTimeGroup");
            RestGateway gateway = (RestGateway)AttendanceRollCallTimeGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AttendanceRollCallTimeGroup> attendancerollcalltimegroupCollection = new ModelCollection<AttendanceRollCallTimeGroup>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                attendancerollcalltimegroupCollection.add((AttendanceRollCallTimeGroup)model);
            }

            return attendancerollcalltimegroupCollection;
        }

        public static AttendanceRollCallTimeGroup retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AttendanceRollCallTimeGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AttendanceRollCallTimeGroup)gateway.retrieve(ResourceType.ATTENDANCE_ROLL_CALL_TIME_GROUP, id);
        }

        public AttendanceRollCallTime getAttendanceRollCallTime()
        {
            return (AttendanceRollCallTime)this.getProperty("attendanceRollCallTime");
        }

        public void setAttendanceRollCallTime(AttendanceRollCallTime attendanceRollCallTime)
        {
            this.setProperty("attendanceRollCallTime", attendanceRollCallTime);
        }

        public ModelBase getStudentGroup()
        {
            return (ModelBase)this.getProperty("studentGroup");
        }

        public void setStudentGroup(ModelBase studentGroup)
        {
            this.setProperty("studentGroup", studentGroup);
        }


    }
}

