using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InternalExclusionSession : ModelBase
    {
        protected string resourceType = ResourceType.INTERNAL_EXCLUSION_SESSION;
        public const string INTERNAL_EXCLUSION_TYPE = "internalExclusionType";
        public const string SESSION_NAME = "sessionName";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION = "location";
        public const string LOCATION_TEXT = "locationText";
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string ATTENDANCE_REGISTER_OPENED_DATETIME = "attendanceRegisterOpenedDatetime";
        public const string ATTENDANCE_REGISTER_CLOSED_DATETIME = "attendanceRegisterClosedDatetime";

        public InternalExclusionSession ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InternalExclusionSession (string resourceType = "InternalExclusionSession", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InternalExclusionSession> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InternalExclusionSession");
        	RestGateway gateway = (RestGateway) InternalExclusionSession.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InternalExclusionSession> internalexclusionsessionCollection = new ModelCollection<InternalExclusionSession> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    internalexclusionsessionCollection.add((InternalExclusionSession) model);
        	}
        
        	return internalexclusionsessionCollection;
        }

        public static InternalExclusionSession retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InternalExclusionSession.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InternalExclusionSession) gateway.retrieve(ResourceType.INTERNAL_EXCLUSION_SESSION, id);
        }

        public InternalExclusionType getInternalExclusionType ()
        {
            return (InternalExclusionType) this.getProperty("internalExclusionType");
        }

        public void setInternalExclusionType (InternalExclusionType internalExclusionType)
        {
            this.setProperty("internalExclusionType", internalExclusionType);
        }

        public string getSessionName ()
        {
            return this.getProperty("sessionName").ToString();
        }

        public void setSessionName (string sessionName)
        {
            this.setProperty("sessionName", sessionName);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return (DateTime) this.getProperty("endDatetime");
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public ModelBase getLocation ()
        {
            return (ModelBase) this.getProperty("location");
        }

        public void setLocation (ModelBase location)
        {
            this.setProperty("location", location);
        }

        public string getLocationText ()
        {
            return this.getProperty("locationText").ToString();
        }

        public void setLocationText (string locationText)
        {
            this.setProperty("locationText", locationText);
        }

        public TimetableSlot getTimetableSlot ()
        {
            return (TimetableSlot) this.getProperty("timetableSlot");
        }

        public void setTimetableSlot (TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public AttendanceRegisterType getAttendanceRegisterType ()
        {
            return (AttendanceRegisterType) this.getProperty("attendanceRegisterType");
        }

        public void setAttendanceRegisterType (AttendanceRegisterType attendanceRegisterType)
        {
            this.setProperty("attendanceRegisterType", attendanceRegisterType);
        }

        public DateTime getAttendanceRegisterOpenedDatetime ()
        {
            return (DateTime) this.getProperty("attendanceRegisterOpenedDatetime");
        }

        public void setAttendanceRegisterOpenedDatetime (DateTime attendanceRegisterOpenedDatetime)
        {
            this.setProperty("attendanceRegisterOpenedDatetime", attendanceRegisterOpenedDatetime);
        }

        public DateTime getAttendanceRegisterClosedDatetime ()
        {
            return (DateTime) this.getProperty("attendanceRegisterClosedDatetime");
        }

        public void setAttendanceRegisterClosedDatetime (DateTime attendanceRegisterClosedDatetime)
        {
            this.setProperty("attendanceRegisterClosedDatetime", attendanceRegisterClosedDatetime);
        }


    }
}

