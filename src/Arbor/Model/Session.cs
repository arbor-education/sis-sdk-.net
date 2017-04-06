using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Session : ModelBase
    {
        protected string resourceType = ResourceType.SESSION;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string SCHEDULED_BY = "scheduledBy";
        public const string SESSION_NAME = "sessionName";
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string SESSION_STREAM = "sessionStream";
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string ATTENDANCE_REGISTER_OPENED_DATETIME = "attendanceRegisterOpenedDatetime";
        public const string ATTENDANCE_REGISTER_CLOSED_DATETIME = "attendanceRegisterClosedDatetime";
        public const string LESSON_PLAN = "lessonPlan";

        public Session ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Session (string resourceType = "Session", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Session> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Session");
        	RestGateway gateway = (RestGateway) Session.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Session> sessionCollection = new ModelCollection<Session> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sessionCollection.add((Session) model);
        	}
        
        	return sessionCollection;
        }

        public static Session retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Session.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Session) gateway.retrieve(ResourceType.SESSION, id);
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

        public string getLocationText ()
        {
            return this.getProperty("locationText").ToString();
        }

        public void setLocationText (string locationText)
        {
            this.setProperty("locationText", locationText);
        }

        public Room getLocation ()
        {
            return (Room) this.getProperty("location");
        }

        public void setLocation (Room location)
        {
            this.setProperty("location", location);
        }

        public ModelBase getScheduledBy ()
        {
            return (ModelBase) this.getProperty("scheduledBy");
        }

        public void setScheduledBy (ModelBase scheduledBy)
        {
            this.setProperty("scheduledBy", scheduledBy);
        }

        public string getSessionName ()
        {
            return this.getProperty("sessionName").ToString();
        }

        public void setSessionName (string sessionName)
        {
            this.setProperty("sessionName", sessionName);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public SessionStream getSessionStream ()
        {
            return (SessionStream) this.getProperty("sessionStream");
        }

        public void setSessionStream (SessionStream sessionStream)
        {
            this.setProperty("sessionStream", sessionStream);
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

        public LessonPlan getLessonPlan ()
        {
            return (LessonPlan) this.getProperty("lessonPlan");
        }

        public void setLessonPlan (LessonPlan lessonPlan)
        {
            this.setProperty("lessonPlan", lessonPlan);
        }


    }
}

