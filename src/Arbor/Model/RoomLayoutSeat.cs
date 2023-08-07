using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomLayoutSeat : ModelBase
    {
        protected new string resourceType = ResourceType.ROOM_LAYOUT_SEAT;
        public const string ROOM_LAYOUT = "roomLayout";
        public const string X = "x";
        public const string Y = "y";

        public RoomLayoutSeat()
        {
            base.resourceType = this.resourceType;
        }

        public RoomLayoutSeat(string resourceType = "RoomLayoutSeat", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<RoomLayoutSeat> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("RoomLayoutSeat");
            RestGateway gateway = (RestGateway)RoomLayoutSeat.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<RoomLayoutSeat> roomlayoutseatCollection = new ModelCollection<RoomLayoutSeat>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                roomlayoutseatCollection.add((RoomLayoutSeat)model);
            }

            return roomlayoutseatCollection;
        }

        public static RoomLayoutSeat retrieve(string id)
        {
            RestGateway gateway = (RestGateway)RoomLayoutSeat.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (RoomLayoutSeat)gateway.retrieve(ResourceType.ROOM_LAYOUT_SEAT, id);
        }

        public RoomLayout getRoomLayout()
        {
            return (RoomLayout)this.getProperty("roomLayout");
        }

        public void setRoomLayout(RoomLayout roomLayout)
        {
            this.setProperty("roomLayout", roomLayout);
        }

        public int getX()
        {
            return Convert.ToInt32(this.getProperty("x"));
        }

        public void setX(int x)
        {
            this.setProperty("x", x);
        }

        public int getY()
        {
            return Convert.ToInt32(this.getProperty("y"));
        }

        public void setY(int y)
        {
            this.setProperty("y", y);
        }


    }
}

