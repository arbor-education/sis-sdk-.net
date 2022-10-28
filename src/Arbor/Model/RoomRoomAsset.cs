using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomRoomAsset : ModelBase
    {
        protected new string resourceType = ResourceType.ROOM_ROOM_ASSET;
        public const string ROOM = "room";
        public const string ROOM_ASSET = "roomAsset";
        public const string QUANTITY = "quantity";

        public RoomRoomAsset()
        {
            base.resourceType = this.resourceType;
        }

        public RoomRoomAsset(string resourceType = "RoomRoomAsset", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<RoomRoomAsset> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("RoomRoomAsset");
            RestGateway gateway = (RestGateway)RoomRoomAsset.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<RoomRoomAsset> roomroomassetCollection = new ModelCollection<RoomRoomAsset>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                roomroomassetCollection.add((RoomRoomAsset)model);
            }

            return roomroomassetCollection;
        }

        public static RoomRoomAsset retrieve(string id)
        {
            RestGateway gateway = (RestGateway)RoomRoomAsset.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (RoomRoomAsset)gateway.retrieve(ResourceType.ROOM_ROOM_ASSET, id);
        }

        public Room getRoom()
        {
            return (Room)this.getProperty("room");
        }

        public void setRoom(Room room)
        {
            this.setProperty("room", room);
        }

        public RoomAsset getRoomAsset()
        {
            return (RoomAsset)this.getProperty("roomAsset");
        }

        public void setRoomAsset(RoomAsset roomAsset)
        {
            this.setProperty("roomAsset", roomAsset);
        }

        public int getQuantity()
        {
            return Convert.ToInt32(this.getProperty("quantity"));
        }

        public void setQuantity(int quantity)
        {
            this.setProperty("quantity", quantity);
        }


    }
}

