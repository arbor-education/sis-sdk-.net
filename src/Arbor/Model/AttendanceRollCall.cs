using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRollCall : ModelBase
    {
        protected string resourceType = ResourceType.ATTENDANCE_ROLL_CALL;
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string AUTO_FILL_CLASS = "autoFillClass";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";

        public AttendanceRollCall ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AttendanceRollCall (string resourceType = "AttendanceRollCall", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AttendanceRollCall> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AttendanceRollCall");
        	RestGateway gateway = (RestGateway) AttendanceRollCall.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AttendanceRollCall> attendancerollcallCollection = new ModelCollection<AttendanceRollCall> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    attendancerollcallCollection.add((AttendanceRollCall) model);
        	}
        
        	return attendancerollcallCollection;
        }

        public static AttendanceRollCall retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AttendanceRollCall.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AttendanceRollCall) gateway.retrieve(ResourceType.ATTENDANCE_ROLL_CALL, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getAutoFillClass ()
        {
            return this.getProperty("autoFillClass").ToString();
        }

        public void setAutoFillClass (string autoFillClass)
        {
            this.setProperty("autoFillClass", autoFillClass);
        }

        public AttendanceRegisterType getAttendanceRegisterType ()
        {
            return (AttendanceRegisterType) this.getProperty("attendanceRegisterType");
        }

        public void setAttendanceRegisterType (AttendanceRegisterType attendanceRegisterType)
        {
            this.setProperty("attendanceRegisterType", attendanceRegisterType);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }


    }
}

