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
        public const string STAFF = "staff";
        public const string NAME = "name";
        public const string MAIN_ENTRANCE_LOCATION = "mainEntranceLocation";

        public RoomLayout()
        {
            base.resourceType = this.resourceType;
        }

        public RoomLayout(string resourceType = "RoomLayout", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<RoomLayout> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("RoomLayout");
            RestGateway gateway = (RestGateway)RoomLayout.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<RoomLayout> roomlayoutCollection = new ModelCollection<RoomLayout>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                roomlayoutCollection.add((RoomLayout)model);
            }

            return roomlayoutCollection;
        }

        public static RoomLayout retrieve(string id)
        {
            RestGateway gateway = (RestGateway)RoomLayout.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (RoomLayout)gateway.retrieve(ResourceType.ROOM_LAYOUT, id);
        }

        public Room getRoom()
        {
            return (Room)this.getProperty("room");
        }

        public void setRoom(Room room)
        {
            this.setProperty("room", room);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getMainEntranceLocation()
        {
            return this.getProperty("mainEntranceLocation").ToString();
        }

        public void setMainEntranceLocation(string mainEntranceLocation)
        {
            this.setProperty("mainEntranceLocation", mainEntranceLocation);
        }


    }
}

