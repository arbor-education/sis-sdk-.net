using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRegisterType : ModelBase
    {
        protected string resourceType = ResourceType.ATTENDANCE_REGISTER_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ATTENDANCE_REGISTER_TYPE_NAME = "attendanceRegisterTypeName";
        public const string IS_MORNING = "isMorning";
        public const string IS_AFTERNOON = "isAfternoon";
        public const string EVENT_OBJECT_TYPE_ID = "eventObjectTypeId";

        public AttendanceRegisterType()
        {
            base.resourceType = this.resourceType;
        }

        public AttendanceRegisterType(string resourceType = "AttendanceRegisterType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AttendanceRegisterType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AttendanceRegisterType");
            RestGateway gateway = (RestGateway)AttendanceRegisterType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AttendanceRegisterType> attendanceregistertypeCollection = new ModelCollection<AttendanceRegisterType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                attendanceregistertypeCollection.add((AttendanceRegisterType)model);
            }

            return attendanceregistertypeCollection;
        }

        public static AttendanceRegisterType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AttendanceRegisterType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AttendanceRegisterType)gateway.retrieve(ResourceType.ATTENDANCE_REGISTER_TYPE, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getAttendanceRegisterTypeName()
        {
            return this.getProperty("attendanceRegisterTypeName").ToString();
        }

        public void setAttendanceRegisterTypeName(string attendanceRegisterTypeName)
        {
            this.setProperty("attendanceRegisterTypeName", attendanceRegisterTypeName);
        }

        public bool getIsMorning()
        {
            return Convert.ToBoolean(this.getProperty("isMorning"));
        }

        public void setIsMorning(bool isMorning)
        {
            this.setProperty("isMorning", isMorning);
        }

        public bool getIsAfternoon()
        {
            return Convert.ToBoolean(this.getProperty("isAfternoon"));
        }

        public void setIsAfternoon(bool isAfternoon)
        {
            this.setProperty("isAfternoon", isAfternoon);
        }

        public int getEventObjectTypeId()
        {
            return Convert.ToInt32(this.getProperty("eventObjectTypeId"));
        }

        public void setEventObjectTypeId(int eventObjectTypeId)
        {
            this.setProperty("eventObjectTypeId", eventObjectTypeId);
        }


    }
}

