using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRegisterTypeMark : ModelBase
    {
        protected new string resourceType = ResourceType.ATTENDANCE_REGISTER_TYPE_MARK;
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string ATTENDANCE_MARK = "attendanceMark";

        public AttendanceRegisterTypeMark()
        {
            base.resourceType = this.resourceType;
        }

        public AttendanceRegisterTypeMark(string resourceType = "AttendanceRegisterTypeMark", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AttendanceRegisterTypeMark> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AttendanceRegisterTypeMark");
            RestGateway gateway = (RestGateway)AttendanceRegisterTypeMark.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AttendanceRegisterTypeMark> attendanceregistertypemarkCollection = new ModelCollection<AttendanceRegisterTypeMark>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                attendanceregistertypemarkCollection.add((AttendanceRegisterTypeMark)model);
            }

            return attendanceregistertypemarkCollection;
        }

        public static AttendanceRegisterTypeMark retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AttendanceRegisterTypeMark.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AttendanceRegisterTypeMark)gateway.retrieve(ResourceType.ATTENDANCE_REGISTER_TYPE_MARK, id);
        }

        public AttendanceRegisterType getAttendanceRegisterType()
        {
            return (AttendanceRegisterType)this.getProperty("attendanceRegisterType");
        }

        public void setAttendanceRegisterType(AttendanceRegisterType attendanceRegisterType)
        {
            this.setProperty("attendanceRegisterType", attendanceRegisterType);
        }

        public AttendanceMark getAttendanceMark()
        {
            return (AttendanceMark)this.getProperty("attendanceMark");
        }

        public void setAttendanceMark(AttendanceMark attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }


    }
}

