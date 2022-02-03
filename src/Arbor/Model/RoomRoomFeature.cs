using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomRoomFeature : ModelBase
    {
        protected string resourceType = ResourceType.ROOM_ROOM_FEATURE;
        public const string ROOM = "room";
        public const string ROOM_FEATURE = "roomFeature";

        public RoomRoomFeature ()
        {
            base.resourceType = this.resourceType;
        }
        
        public RoomRoomFeature (string resourceType = "RoomRoomFeature", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<RoomRoomFeature> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("RoomRoomFeature");
        	RestGateway gateway = (RestGateway) RoomRoomFeature.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<RoomRoomFeature> roomroomfeatureCollection = new ModelCollection<RoomRoomFeature> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    roomroomfeatureCollection.add((RoomRoomFeature) model);
        	}
        
        	return roomroomfeatureCollection;
        }

        public static RoomRoomFeature retrieve (string id)
        {
            RestGateway gateway = (RestGateway) RoomRoomFeature.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (RoomRoomFeature) gateway.retrieve(ResourceType.ROOM_ROOM_FEATURE, id);
        }

        public Room getRoom ()
        {
            return (Room) this.getProperty("room");
        }

        public void setRoom (Room room)
        {
            this.setProperty("room", room);
        }

        public RoomFeature getRoomFeature ()
        {
            return (RoomFeature) this.getProperty("roomFeature");
        }

        public void setRoomFeature (RoomFeature roomFeature)
        {
            this.setProperty("roomFeature", roomFeature);
        }


    }
}

