using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubSession : ModelBase
    {
        protected string resourceType = ResourceType.CLUB_SESSION;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string CLUB = "club";
        public const string NAME = "name";
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";

        public ClubSession()
        {
            base.resourceType = this.resourceType;
        }

        public ClubSession(string resourceType = "ClubSession", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ClubSession> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ClubSession");
            RestGateway gateway = (RestGateway)ClubSession.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ClubSession> clubsessionCollection = new ModelCollection<ClubSession>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                clubsessionCollection.add((ClubSession)model);
            }

            return clubsessionCollection;
        }

        public static ClubSession retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ClubSession.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ClubSession)gateway.retrieve(ResourceType.CLUB_SESSION, id);
        }

        public DateTime getStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime(DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime(DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public string getLocationText()
        {
            return this.getProperty("locationText").ToString();
        }

        public void setLocationText(string locationText)
        {
            this.setProperty("locationText", locationText);
        }

        public ModelBase getLocation()
        {
            return (ModelBase)this.getProperty("location");
        }

        public void setLocation(ModelBase location)
        {
            this.setProperty("location", location);
        }

        public Club getClub()
        {
            return (Club)this.getProperty("club");
        }

        public void setClub(Club club)
        {
            this.setProperty("club", club);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public TimetableSlot getTimetableSlot()
        {
            return (TimetableSlot)this.getProperty("timetableSlot");
        }

        public void setTimetableSlot(TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public AttendanceRegisterType getAttendanceRegisterType()
        {
            return (AttendanceRegisterType)this.getProperty("attendanceRegisterType");
        }

        public void setAttendanceRegisterType(AttendanceRegisterType attendanceRegisterType)
        {
            this.setProperty("attendanceRegisterType", attendanceRegisterType);
        }


    }
}

