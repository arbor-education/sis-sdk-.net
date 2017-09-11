using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomLayout : ModelBase
    {
        protected string resourceType = ResourceType.ROOM_LAYOUT;
        public const string ROOM = "room";

        public RoomLayout ()
        {
            base.resourceType = this.resourceType;
        }
        
        public RoomLayout (string resourceType = "RoomLayout", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<RoomLayout> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("RoomLayout");
        	RestGateway gateway = (RestGateway) RoomLayout.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<RoomLayout> roomlayoutCollection = new ModelCollection<RoomLayout> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    roomlayoutCollection.add((RoomLayout) model);
        	}
        
        	return roomlayoutCollection;
        }

        public static RoomLayout retrieve (string id)
        {
            RestGateway gateway = (RestGateway) RoomLayout.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (RoomLayout) gateway.retrieve(ResourceType.ROOM_LAYOUT, id);
        }

        public Room getRoom ()
        {
            return (Room) this.getProperty("room");
        }

        public void setRoom (Room room)
        {
            this.setProperty("room", room);
        }


    }
}

