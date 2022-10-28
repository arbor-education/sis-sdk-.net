using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendancePattern : ModelBase
    {
        protected new string resourceType = ResourceType.ATTENDANCE_PATTERN;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ATTENDANCE_PATTERN_NAME = "attendancePatternName";
        public const string IS_PART_TIME = "isPartTime";
        public const string IS_MORNING_ONLY = "isMorningOnly";
        public const string IS_AFTERNOON_ONLY = "isAfternoonOnly";

        public AttendancePattern ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AttendancePattern (string resourceType = "AttendancePattern", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AttendancePattern> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AttendancePattern");
        	RestGateway gateway = (RestGateway) AttendancePattern.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AttendancePattern> attendancepatternCollection = new ModelCollection<AttendancePattern> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    attendancepatternCollection.add((AttendancePattern) model);
        	}
        
        	return attendancepatternCollection;
        }

        public static AttendancePattern retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AttendancePattern.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AttendancePattern) gateway.retrieve(ResourceType.ATTENDANCE_PATTERN, id);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

        public string getAttendancePatternName ()
        {
            return this.getProperty("attendancePatternName").ToString();
        }

        public void setAttendancePatternName (string attendancePatternName)
        {
            this.setProperty("attendancePatternName", attendancePatternName);
        }

        public bool getIsPartTime ()
        {
            return Convert.ToBoolean(this.getProperty("isPartTime"));
        }

        public void setIsPartTime (bool isPartTime)
        {
            this.setProperty("isPartTime", isPartTime);
        }

        public bool getIsMorningOnly ()
        {
            return Convert.ToBoolean(this.getProperty("isMorningOnly"));
        }

        public void setIsMorningOnly (bool isMorningOnly)
        {
            this.setProperty("isMorningOnly", isMorningOnly);
        }

        public bool getIsAfternoonOnly ()
        {
            return Convert.ToBoolean(this.getProperty("isAfternoonOnly"));
        }

        public void setIsAfternoonOnly (bool isAfternoonOnly)
        {
            this.setProperty("isAfternoonOnly", isAfternoonOnly);
        }


    }
}

