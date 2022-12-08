using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CalendarEntryMapping : ModelBase
    {
        protected string resourceType = ResourceType.CALENDAR_ENTRY_MAPPING;
        public const string EVENT = "event";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string MAPPED = "mapped";
        public const string CALENDAR = "calendar";
        public const string TIMESLOT_BLOCKED = "timeslotBlocked";

        public CalendarEntryMapping()
        {
            base.resourceType = this.resourceType;
        }

        public CalendarEntryMapping(string resourceType = "CalendarEntryMapping", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CalendarEntryMapping> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CalendarEntryMapping");
            RestGateway gateway = (RestGateway)CalendarEntryMapping.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CalendarEntryMapping> calendarentrymappingCollection = new ModelCollection<CalendarEntryMapping>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                calendarentrymappingCollection.add((CalendarEntryMapping)model);
            }

            return calendarentrymappingCollection;
        }

        public static CalendarEntryMapping retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CalendarEntryMapping.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CalendarEntryMapping)gateway.retrieve(ResourceType.CALENDAR_ENTRY_MAPPING, id);
        }

        public ModelBase getEvent()
        {
            return (ModelBase)this.getProperty("event");
        }

        public void setEvent(ModelBase _event)
        {
            this.setProperty("event", _event);
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

        public ModelBase getMapped()
        {
            return (ModelBase)this.getProperty("mapped");
        }

        public void setMapped(ModelBase mapped)
        {
            this.setProperty("mapped", mapped);
        }

        public Calendar getCalendar()
        {
            return (Calendar)this.getProperty("calendar");
        }

        public void setCalendar(Calendar calendar)
        {
            this.setProperty("calendar", calendar);
        }

        public bool getTimeslotBlocked()
        {
            return Convert.ToBoolean(this.getProperty("timeslotBlocked"));
        }

        public void setTimeslotBlocked(bool timeslotBlocked)
        {
            this.setProperty("timeslotBlocked", timeslotBlocked);
        }


    }
}

