using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffRoomFeatureRequirement : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_ROOM_FEATURE_REQUIREMENT;
        public const string STAFF = "staff";
        public const string ROOM_FEATURE = "roomFeature";

        public StaffRoomFeatureRequirement()
        {
            base.resourceType = this.resourceType;
        }

        public StaffRoomFeatureRequirement(string resourceType = "StaffRoomFeatureRequirement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StaffRoomFeatureRequirement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StaffRoomFeatureRequirement");
            RestGateway gateway = (RestGateway)StaffRoomFeatureRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StaffRoomFeatureRequirement> staffroomfeaturerequirementCollection = new ModelCollection<StaffRoomFeatureRequirement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                staffroomfeaturerequirementCollection.add((StaffRoomFeatureRequirement)model);
            }

            return staffroomfeaturerequirementCollection;
        }

        public static StaffRoomFeatureRequirement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StaffRoomFeatureRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StaffRoomFeatureRequirement)gateway.retrieve(ResourceType.STAFF_ROOM_FEATURE_REQUIREMENT, id);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public RoomFeature getRoomFeature()
        {
            return (RoomFeature)this.getProperty("roomFeature");
        }

        public void setRoomFeature(RoomFeature roomFeature)
        {
            this.setProperty("roomFeature", roomFeature);
        }


    }
}

