using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomChangeRequirement : ModelBase
    {
        protected string resourceType = ResourceType.ROOM_CHANGE_REQUIREMENT;
        public const string EVENT = "event";
        public const string UNAVAILABLE_ROOM = "unavailableRoom";
        public const string NEW_ROOM = "newRoom";
        public const string UNAVAILABILITY_EVENT = "unavailabilityEvent";
        public const string ROOM_CHANGED_DATETIME = "roomChangedDatetime";
        public const string IGNORED_DATETIME = "ignoredDatetime";

        public RoomChangeRequirement()
        {
            base.resourceType = this.resourceType;
        }

        public RoomChangeRequirement(string resourceType = "RoomChangeRequirement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<RoomChangeRequirement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("RoomChangeRequirement");
            RestGateway gateway = (RestGateway)RoomChangeRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<RoomChangeRequirement> roomchangerequirementCollection = new ModelCollection<RoomChangeRequirement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                roomchangerequirementCollection.add((RoomChangeRequirement)model);
            }

            return roomchangerequirementCollection;
        }

        public static RoomChangeRequirement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)RoomChangeRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (RoomChangeRequirement)gateway.retrieve(ResourceType.ROOM_CHANGE_REQUIREMENT, id);
        }

        public ModelBase getEvent()
        {
            return (ModelBase)this.getProperty("event");
        }

        public void setEvent(ModelBase _event)
        {
            this.setProperty("event", _event);
        }

        public Room getUnavailableRoom()
        {
            return (Room)this.getProperty("unavailableRoom");
        }

        public void setUnavailableRoom(Room unavailableRoom)
        {
            this.setProperty("unavailableRoom", unavailableRoom);
        }

        public Room getNewRoom()
        {
            return (Room)this.getProperty("newRoom");
        }

        public void setNewRoom(Room newRoom)
        {
            this.setProperty("newRoom", newRoom);
        }

        public RoomUnavailability getUnavailabilityEvent()
        {
            return (RoomUnavailability)this.getProperty("unavailabilityEvent");
        }

        public void setUnavailabilityEvent(RoomUnavailability unavailabilityEvent)
        {
            this.setProperty("unavailabilityEvent", unavailabilityEvent);
        }

        public DateTime getRoomChangedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("roomChangedDatetime"));
        }

        public void setRoomChangedDatetime(DateTime roomChangedDatetime)
        {
            this.setProperty("roomChangedDatetime", roomChangedDatetime);
        }

        public DateTime getIgnoredDatetime()
        {
            return Convert.ToDateTime(this.getProperty("ignoredDatetime"));
        }

        public void setIgnoredDatetime(DateTime ignoredDatetime)
        {
            this.setProperty("ignoredDatetime", ignoredDatetime);
        }


    }
}

