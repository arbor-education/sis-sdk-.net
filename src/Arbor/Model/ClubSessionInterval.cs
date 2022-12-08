using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubSessionInterval : ModelBase
    {
        protected string resourceType = ResourceType.CLUB_SESSION_INTERVAL;
        public const string CLUB = "club";
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";
        public const string NAME = "name";

        public ClubSessionInterval()
        {
            base.resourceType = this.resourceType;
        }

        public ClubSessionInterval(string resourceType = "ClubSessionInterval", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ClubSessionInterval> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ClubSessionInterval");
            RestGateway gateway = (RestGateway)ClubSessionInterval.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ClubSessionInterval> clubsessionintervalCollection = new ModelCollection<ClubSessionInterval>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                clubsessionintervalCollection.add((ClubSessionInterval)model);
            }

            return clubsessionintervalCollection;
        }

        public static ClubSessionInterval retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ClubSessionInterval.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ClubSessionInterval)gateway.retrieve(ResourceType.CLUB_SESSION_INTERVAL, id);
        }

        public Club getClub()
        {
            return (Club)this.getProperty("club");
        }

        public void setClub(Club club)
        {
            this.setProperty("club", club);
        }

        public TimetableSlot getTimetableSlot()
        {
            return (TimetableSlot)this.getProperty("timetableSlot");
        }

        public void setTimetableSlot(TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public string getStartTime()
        {
            return this.getProperty("startTime").ToString();
        }

        public void setStartTime(string startTime)
        {
            this.setProperty("startTime", startTime);
        }

        public string getEndTime()
        {
            return this.getProperty("endTime").ToString();
        }

        public void setEndTime(string endTime)
        {
            this.setProperty("endTime", endTime);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }


    }
}

