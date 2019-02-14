using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetableSlotLocation : ModelBase
    {
        protected string resourceType = ResourceType.TIMETABLE_SLOT_LOCATION;
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string LOCATION = "location";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public TimetableSlotLocation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetableSlotLocation (string resourceType = "TimetableSlotLocation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetableSlotLocation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetableSlotLocation");
        	RestGateway gateway = (RestGateway) TimetableSlotLocation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetableSlotLocation> timetableslotlocationCollection = new ModelCollection<TimetableSlotLocation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetableslotlocationCollection.add((TimetableSlotLocation) model);
        	}
        
        	return timetableslotlocationCollection;
        }

        public static TimetableSlotLocation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetableSlotLocation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetableSlotLocation) gateway.retrieve(ResourceType.TIMETABLE_SLOT_LOCATION, id);
        }

        public TimetableSlot getTimetableSlot ()
        {
            return (TimetableSlot) this.getProperty("timetableSlot");
        }

        public void setTimetableSlot (TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public Room getLocation ()
        {
            return (Room) this.getProperty("location");
        }

        public void setLocation (Room location)
        {
            this.setProperty("location", location);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

