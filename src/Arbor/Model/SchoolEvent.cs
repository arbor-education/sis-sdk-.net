using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolEvent : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOL_EVENT;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string SCHOOL_EVENT_TYPE = "schoolEventType";
        public const string REPEATING_SCHOOL_EVENT = "repeatingSchoolEvent";
        public const string SCHOOL_EVENT_NAME = "schoolEventName";
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string NARRATIVE = "narrative";
        public const string COVER_REQUIRED = "coverRequired";

        public SchoolEvent()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolEvent(string resourceType = "SchoolEvent", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolEvent> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SchoolEvent");
            RestGateway gateway = (RestGateway)SchoolEvent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolEvent> schooleventCollection = new ModelCollection<SchoolEvent>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schooleventCollection.add((SchoolEvent)model);
            }

            return schooleventCollection;
        }

        public static SchoolEvent retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolEvent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolEvent)gateway.retrieve(ResourceType.SCHOOL_EVENT, id);
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

        public SchoolEventType getSchoolEventType()
        {
            return (SchoolEventType)this.getProperty("schoolEventType");
        }

        public void setSchoolEventType(SchoolEventType schoolEventType)
        {
            this.setProperty("schoolEventType", schoolEventType);
        }

        public RepeatingSchoolEvent getRepeatingSchoolEvent()
        {
            return (RepeatingSchoolEvent)this.getProperty("repeatingSchoolEvent");
        }

        public void setRepeatingSchoolEvent(RepeatingSchoolEvent repeatingSchoolEvent)
        {
            this.setProperty("repeatingSchoolEvent", repeatingSchoolEvent);
        }

        public string getSchoolEventName()
        {
            return this.getProperty("schoolEventName").ToString();
        }

        public void setSchoolEventName(string schoolEventName)
        {
            this.setProperty("schoolEventName", schoolEventName);
        }

        public TimetableSlot getTimetableSlot()
        {
            return (TimetableSlot)this.getProperty("timetableSlot");
        }

        public void setTimetableSlot(TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public bool getCoverRequired()
        {
            return Convert.ToBoolean(this.getProperty("coverRequired"));
        }

        public void setCoverRequired(bool coverRequired)
        {
            this.setProperty("coverRequired", coverRequired);
        }


    }
}

