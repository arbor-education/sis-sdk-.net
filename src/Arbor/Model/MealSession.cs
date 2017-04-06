using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealSession : ModelBase
    {
        protected string resourceType = ResourceType.MEAL_SESSION;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string SCHEDULED_BY = "scheduledBy";
        public const string MEAL_SITTING = "mealSitting";
        public const string MEAL_SESSION_NAME = "mealSessionName";
        public const string REGISTER_OPENED_DATETIME = "registerOpenedDatetime";
        public const string REGISTER_CLOSED_DATETIME = "registerClosedDatetime";
        public const string INVOICED_DATETIME = "invoicedDatetime";
        public const string TIMETABLE_SLOT = "timetableSlot";

        public MealSession ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MealSession (string resourceType = "MealSession", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MealSession> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MealSession");
        	RestGateway gateway = (RestGateway) MealSession.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MealSession> mealsessionCollection = new ModelCollection<MealSession> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    mealsessionCollection.add((MealSession) model);
        	}
        
        	return mealsessionCollection;
        }

        public static MealSession retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MealSession.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MealSession) gateway.retrieve(ResourceType.MEAL_SESSION, id);
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

        public MealSitting getMealSitting ()
        {
            return (MealSitting) this.getProperty("mealSitting");
        }

        public void setMealSitting (MealSitting mealSitting)
        {
            this.setProperty("mealSitting", mealSitting);
        }

        public string getMealSessionName ()
        {
            return this.getProperty("mealSessionName").ToString();
        }

        public void setMealSessionName (string mealSessionName)
        {
            this.setProperty("mealSessionName", mealSessionName);
        }

        public DateTime getRegisterOpenedDatetime ()
        {
            return (DateTime) this.getProperty("registerOpenedDatetime");
        }

        public void setRegisterOpenedDatetime (DateTime registerOpenedDatetime)
        {
            this.setProperty("registerOpenedDatetime", registerOpenedDatetime);
        }

        public DateTime getRegisterClosedDatetime ()
        {
            return (DateTime) this.getProperty("registerClosedDatetime");
        }

        public void setRegisterClosedDatetime (DateTime registerClosedDatetime)
        {
            this.setProperty("registerClosedDatetime", registerClosedDatetime);
        }

        public DateTime getInvoicedDatetime ()
        {
            return (DateTime) this.getProperty("invoicedDatetime");
        }

        public void setInvoicedDatetime (DateTime invoicedDatetime)
        {
            this.setProperty("invoicedDatetime", invoicedDatetime);
        }

        public TimetableSlot getTimetableSlot ()
        {
            return (TimetableSlot) this.getProperty("timetableSlot");
        }

        public void setTimetableSlot (TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }


    }
}

