using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Calendar : ModelBase
    {
        protected new string resourceType = ResourceType.CALENDAR;
        public const string OWNER = "owner";
        public const string CALENDAR_TYPE = "calendarType";
        public const string CALENDAR_NAME = "calendarName";
        public const string CALENDAR_DESCRIPTION = "calendarDescription";
        public const string CALENDAR_COLOR = "calendarColor";

        public Calendar ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Calendar (string resourceType = "Calendar", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Calendar> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Calendar");
        	RestGateway gateway = (RestGateway) Calendar.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Calendar> calendarCollection = new ModelCollection<Calendar> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    calendarCollection.add((Calendar) model);
        	}
        
        	return calendarCollection;
        }

        public static Calendar retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Calendar.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Calendar) gateway.retrieve(ResourceType.CALENDAR, id);
        }

        public ModelBase getOwner ()
        {
            return (ModelBase) this.getProperty("owner");
        }

        public void setOwner (ModelBase owner)
        {
            this.setProperty("owner", owner);
        }

        public CalendarType getCalendarType ()
        {
            return (CalendarType) this.getProperty("calendarType");
        }

        public void setCalendarType (CalendarType calendarType)
        {
            this.setProperty("calendarType", calendarType);
        }

        public string getCalendarName ()
        {
            return this.getProperty("calendarName").ToString();
        }

        public void setCalendarName (string calendarName)
        {
            this.setProperty("calendarName", calendarName);
        }

        public string getCalendarDescription ()
        {
            return this.getProperty("calendarDescription").ToString();
        }

        public void setCalendarDescription (string calendarDescription)
        {
            this.setProperty("calendarDescription", calendarDescription);
        }

        public string getCalendarColor ()
        {
            return this.getProperty("calendarColor").ToString();
        }

        public void setCalendarColor (string calendarColor)
        {
            this.setProperty("calendarColor", calendarColor);
        }


    }
}

