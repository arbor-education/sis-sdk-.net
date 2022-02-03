using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetableSlotException : ModelBase
    {
        protected string resourceType = ResourceType.TIMETABLE_SLOT_EXCEPTION;
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string EXCEPTION_DATE = "exceptionDate";
        public const string NO_EVENT_EXCEPTION = "noEventException";
        public const string LOCATION_EXCEPTION = "locationException";
        public const string TIME_EXCEPTION = "timeException";

        public TimetableSlotException ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetableSlotException (string resourceType = "TimetableSlotException", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetableSlotException> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetableSlotException");
        	RestGateway gateway = (RestGateway) TimetableSlotException.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetableSlotException> timetableslotexceptionCollection = new ModelCollection<TimetableSlotException> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetableslotexceptionCollection.add((TimetableSlotException) model);
        	}
        
        	return timetableslotexceptionCollection;
        }

        public static TimetableSlotException retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetableSlotException.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetableSlotException) gateway.retrieve(ResourceType.TIMETABLE_SLOT_EXCEPTION, id);
        }

        public TimetableSlot getTimetableSlot ()
        {
            return (TimetableSlot) this.getProperty("timetableSlot");
        }

        public void setTimetableSlot (TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public DateTime getExceptionDate ()
        {
            return Convert.ToDateTime(this.getProperty("exceptionDate"));
        }

        public void setExceptionDate (DateTime exceptionDate)
        {
            this.setProperty("exceptionDate", exceptionDate);
        }

        public bool getNoEventException ()
        {
            return Convert.ToBoolean(this.getProperty("noEventException"));
        }

        public void setNoEventException (bool noEventException)
        {
            this.setProperty("noEventException", noEventException);
        }

        public bool getLocationException ()
        {
            return Convert.ToBoolean(this.getProperty("locationException"));
        }

        public void setLocationException (bool locationException)
        {
            this.setProperty("locationException", locationException);
        }

        public bool getTimeException ()
        {
            return Convert.ToBoolean(this.getProperty("timeException"));
        }

        public void setTimeException (bool timeException)
        {
            this.setProperty("timeException", timeException);
        }


    }
}

