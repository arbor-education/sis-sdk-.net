using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRegister : ModelBase
    {
        protected string resourceType = ResourceType.ATTENDANCE_REGISTER;
        public const string EVENT = "event";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string OPENED_DATETIME = "openedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string VALIDATED_DATETIME = "validatedDatetime";
        public const string CLOSED_DATETIME = "closedDatetime";

        public AttendanceRegister ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AttendanceRegister (string resourceType = "AttendanceRegister", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AttendanceRegister> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AttendanceRegister");
        	RestGateway gateway = (RestGateway) AttendanceRegister.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AttendanceRegister> attendanceregisterCollection = new ModelCollection<AttendanceRegister> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    attendanceregisterCollection.add((AttendanceRegister) model);
        	}
        
        	return attendanceregisterCollection;
        }

        public static AttendanceRegister retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AttendanceRegister.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AttendanceRegister) gateway.retrieve(ResourceType.ATTENDANCE_REGISTER, id);
        }

        public ModelBase getEvent ()
        {
            return (ModelBase) this.getProperty("event");
        }

        public void setEvent (ModelBase _event)
        {
            this.setProperty("event", _event);
        }

        public AttendanceRegisterType getAttendanceRegisterType ()
        {
            return (AttendanceRegisterType) this.getProperty("attendanceRegisterType");
        }

        public void setAttendanceRegisterType (AttendanceRegisterType attendanceRegisterType)
        {
            this.setProperty("attendanceRegisterType", attendanceRegisterType);
        }

        public DateTime getOpenedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("openedDatetime"))
        }

        public void setOpenedDatetime (DateTime openedDatetime)
        {
            this.setProperty("openedDatetime", openedDatetime);
        }

        public DateTime getCompletedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("completedDatetime"))
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public DateTime getValidatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("validatedDatetime"))
        }

        public void setValidatedDatetime (DateTime validatedDatetime)
        {
            this.setProperty("validatedDatetime", validatedDatetime);
        }

        public DateTime getClosedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("closedDatetime"))
        }

        public void setClosedDatetime (DateTime closedDatetime)
        {
            this.setProperty("closedDatetime", closedDatetime);
        }


    }
}

