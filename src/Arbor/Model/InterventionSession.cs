using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionSession : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_SESSION;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string INTERVENTION = "intervention";
        public const string STAFF_COUNT = "staffCount";
        public const string STUDENT_COUNT = "studentCount";
        public const string CALENDAR_WEEK = "calendarWeek";
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string INTERVENTION_GROUP = "interventionGroup";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string ATTENDANCE_REGISTER_OPENED_DATETIME = "attendanceRegisterOpenedDatetime";
        public const string ATTENDANCE_REGISTER_CLOSED_DATETIME = "attendanceRegisterClosedDatetime";

        public InterventionSession ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionSession (string resourceType = "InterventionSession", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionSession> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionSession");
        	RestGateway gateway = (RestGateway) InterventionSession.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionSession> interventionsessionCollection = new ModelCollection<InterventionSession> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventionsessionCollection.add((InterventionSession) model);
        	}
        
        	return interventionsessionCollection;
        }

        public static InterventionSession retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionSession.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionSession) gateway.retrieve(ResourceType.INTERVENTION_SESSION, id);
        }

        public DateTime getStartDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public string getLocationText ()
        {
            return this.getProperty("locationText").ToString();
        }

        public void setLocationText (string locationText)
        {
            this.setProperty("locationText", locationText);
        }

        public ModelBase getLocation ()
        {
            return (ModelBase) this.getProperty("location");
        }

        public void setLocation (ModelBase location)
        {
            this.setProperty("location", location);
        }

        public Intervention getIntervention ()
        {
            return (Intervention) this.getProperty("intervention");
        }

        public void setIntervention (Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public int getStaffCount ()
        {
            return Convert.ToInt32(this.getProperty("staffCount"));
        }

        public void setStaffCount (int staffCount)
        {
            this.setProperty("staffCount", staffCount);
        }

        public int getStudentCount ()
        {
            return Convert.ToInt32(this.getProperty("studentCount"));
        }

        public void setStudentCount (int studentCount)
        {
            this.setProperty("studentCount", studentCount);
        }

        public int getCalendarWeek ()
        {
            return Convert.ToInt32(this.getProperty("calendarWeek"));
        }

        public void setCalendarWeek (int calendarWeek)
        {
            this.setProperty("calendarWeek", calendarWeek);
        }

        public TimetableSlot getTimetableSlot ()
        {
            return (TimetableSlot) this.getProperty("timetableSlot");
        }

        public void setTimetableSlot (TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public InterventionGroup getInterventionGroup ()
        {
            return (InterventionGroup) this.getProperty("interventionGroup");
        }

        public void setInterventionGroup (InterventionGroup interventionGroup)
        {
            this.setProperty("interventionGroup", interventionGroup);
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
            return Convert.ToDateTime(this.getProperty("attendanceRegisterOpenedDatetime"));
        }

        public void setAttendanceRegisterOpenedDatetime (DateTime attendanceRegisterOpenedDatetime)
        {
            this.setProperty("attendanceRegisterOpenedDatetime", attendanceRegisterOpenedDatetime);
        }

        public DateTime getAttendanceRegisterClosedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("attendanceRegisterClosedDatetime"));
        }

        public void setAttendanceRegisterClosedDatetime (DateTime attendanceRegisterClosedDatetime)
        {
            this.setProperty("attendanceRegisterClosedDatetime", attendanceRegisterClosedDatetime);
        }


    }
}

