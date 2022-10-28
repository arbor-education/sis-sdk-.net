using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceRollCallTime : ModelBase
    {
        protected new string resourceType = ResourceType.ATTENDANCE_ROLL_CALL_TIME;
        public const string ATTENDANCE_ROLL_CALL = "attendanceRollCall";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string REGISTER_OPENS_TIME = "registerOpensTime";
        public const string REGISTER_CLOSES_TIME = "registerClosesTime";
        public const string ROLL_CALL_PERIOD_END_TIME = "rollCallPeriodEndTime";

        public AttendanceRollCallTime ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AttendanceRollCallTime (string resourceType = "AttendanceRollCallTime", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AttendanceRollCallTime> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AttendanceRollCallTime");
        	RestGateway gateway = (RestGateway) AttendanceRollCallTime.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AttendanceRollCallTime> attendancerollcalltimeCollection = new ModelCollection<AttendanceRollCallTime> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    attendancerollcalltimeCollection.add((AttendanceRollCallTime) model);
        	}
        
        	return attendancerollcalltimeCollection;
        }

        public static AttendanceRollCallTime retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AttendanceRollCallTime.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AttendanceRollCallTime) gateway.retrieve(ResourceType.ATTENDANCE_ROLL_CALL_TIME, id);
        }

        public AttendanceRollCall getAttendanceRollCall ()
        {
            return (AttendanceRollCall) this.getProperty("attendanceRollCall");
        }

        public void setAttendanceRollCall (AttendanceRollCall attendanceRollCall)
        {
            this.setProperty("attendanceRollCall", attendanceRollCall);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getRegisterOpensTime ()
        {
            return this.getProperty("registerOpensTime").ToString();
        }

        public void setRegisterOpensTime (string registerOpensTime)
        {
            this.setProperty("registerOpensTime", registerOpensTime);
        }

        public string getRegisterClosesTime ()
        {
            return this.getProperty("registerClosesTime").ToString();
        }

        public void setRegisterClosesTime (string registerClosesTime)
        {
            this.setProperty("registerClosesTime", registerClosesTime);
        }

        public string getRollCallPeriodEndTime ()
        {
            return this.getProperty("rollCallPeriodEndTime").ToString();
        }

        public void setRollCallPeriodEndTime (string rollCallPeriodEndTime)
        {
            this.setProperty("rollCallPeriodEndTime", rollCallPeriodEndTime);
        }


    }
}

