using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CalendarType : ModelBase
    {
        protected string resourceType = ResourceType.CALENDAR_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string CALENDAR_TYPE_NAME = "calendarTypeName";
        public const string CALENDAR_TYPE_COLOR = "calendarTypeColor";

        public CalendarType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CalendarType (string resourceType = "CalendarType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CalendarType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CalendarType");
        	RestGateway gateway = (RestGateway) CalendarType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CalendarType> calendartypeCollection = new ModelCollection<CalendarType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    calendartypeCollection.add((CalendarType) model);
        	}
        
        	return calendartypeCollection;
        }

        public static CalendarType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CalendarType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CalendarType) gateway.retrieve(ResourceType.CALENDAR_TYPE, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getCalendarTypeName ()
        {
            return this.getProperty("calendarTypeName").ToString();
        }

        public void setCalendarTypeName (string calendarTypeName)
        {
            this.setProperty("calendarTypeName", calendarTypeName);
        }

        public string getCalendarTypeColor ()
        {
            return this.getProperty("calendarTypeColor").ToString();
        }

        public void setCalendarTypeColor (string calendarTypeColor)
        {
            this.setProperty("calendarTypeColor", calendarTypeColor);
        }


    }
}

