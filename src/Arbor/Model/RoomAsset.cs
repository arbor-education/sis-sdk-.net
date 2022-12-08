using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomAsset : ModelBase
    {
        protected string resourceType = ResourceType.ROOM_ASSET;
        public const string ROOM_ASSET_NAME = "roomAssetName";
        public const string ASSIGN_TO_PEOPLE = "assignToPeople";

        public RoomAsset()
        {
            base.resourceType = this.resourceType;
        }

        public RoomAsset(string resourceType = "RoomAsset", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<RoomAsset> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("RoomAsset");
            RestGateway gateway = (RestGateway)RoomAsset.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<RoomAsset> roomassetCollection = new ModelCollection<RoomAsset>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                roomassetCollection.add((RoomAsset)model);
            }

            return roomassetCollection;
        }

        public static RoomAsset retrieve(string id)
        {
            RestGateway gateway = (RestGateway)RoomAsset.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (RoomAsset)gateway.retrieve(ResourceType.ROOM_ASSET, id);
        }

        public string getRoomAssetName()
        {
            return this.getProperty("roomAssetName").ToString();
        }

        public void setRoomAssetName(string roomAssetName)
        {
            this.setProperty("roomAssetName", roomAssetName);
        }

        public bool getAssignToPeople()
        {
            return Convert.ToBoolean(this.getProperty("assignToPeople"));
        }

        public void setAssignToPeople(bool assignToPeople)
        {
            this.setProperty("assignToPeople", assignToPeople);
        }


    }
}

