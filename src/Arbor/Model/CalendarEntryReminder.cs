using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CalendarEntryReminder : ModelBase
    {
        protected string resourceType = ResourceType.CALENDAR_ENTRY_REMINDER;
        public const string CALENDAR_ENTRY_MAPPING = "calendarEntryMapping";
        public const string REMINDER_SENT_DATETIME = "reminderSentDatetime";

        public CalendarEntryReminder ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CalendarEntryReminder (string resourceType = "CalendarEntryReminder", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CalendarEntryReminder> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CalendarEntryReminder");
        	RestGateway gateway = (RestGateway) CalendarEntryReminder.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CalendarEntryReminder> calendarentryreminderCollection = new ModelCollection<CalendarEntryReminder> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    calendarentryreminderCollection.add((CalendarEntryReminder) model);
        	}
        
        	return calendarentryreminderCollection;
        }

        public static CalendarEntryReminder retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CalendarEntryReminder.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CalendarEntryReminder) gateway.retrieve(ResourceType.CALENDAR_ENTRY_REMINDER, id);
        }

        public CalendarEntryMapping getCalendarEntryMapping ()
        {
            return (CalendarEntryMapping) this.getProperty("calendarEntryMapping");
        }

        public void setCalendarEntryMapping (CalendarEntryMapping calendarEntryMapping)
        {
            this.setProperty("calendarEntryMapping", calendarEntryMapping);
        }

        public DateTime getReminderSentDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("reminderSentDatetime"));
        }

        public void setReminderSentDatetime (DateTime reminderSentDatetime)
        {
            this.setProperty("reminderSentDatetime", reminderSentDatetime);
        }


    }
}

