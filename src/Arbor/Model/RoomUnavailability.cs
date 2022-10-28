using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomUnavailability : ModelBase
    {
        protected new string resourceType = ResourceType.ROOM_UNAVAILABILITY;
        public const string ROOM = "room";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string REASON = "reason";

        public RoomUnavailability ()
        {
            base.resourceType = this.resourceType;
        }
        
        public RoomUnavailability (string resourceType = "RoomUnavailability", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<RoomUnavailability> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("RoomUnavailability");
        	RestGateway gateway = (RestGateway) RoomUnavailability.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<RoomUnavailability> roomunavailabilityCollection = new ModelCollection<RoomUnavailability> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    roomunavailabilityCollection.add((RoomUnavailability) model);
        	}
        
        	return roomunavailabilityCollection;
        }

        public static RoomUnavailability retrieve (string id)
        {
            RestGateway gateway = (RestGateway) RoomUnavailability.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (RoomUnavailability) gateway.retrieve(ResourceType.ROOM_UNAVAILABILITY, id);
        }

        public Room getRoom ()
        {
            return (Room) this.getProperty("room");
        }

        public void setRoom (Room room)
        {
            this.setProperty("room", room);
        }

        public DateTime getStartDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public string getReason ()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason (string reason)
        {
            this.setProperty("reason", reason);
        }


    }
}

