using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SessionRoomFeatureRequirement : ModelBase
    {
        protected new string resourceType = ResourceType.SESSION_ROOM_FEATURE_REQUIREMENT;
        public const string SESSION = "session";
        public const string ROOM_FEATURE = "roomFeature";

        public SessionRoomFeatureRequirement()
        {
            base.resourceType = this.resourceType;
        }

        public SessionRoomFeatureRequirement(string resourceType = "SessionRoomFeatureRequirement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SessionRoomFeatureRequirement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SessionRoomFeatureRequirement");
            RestGateway gateway = (RestGateway)SessionRoomFeatureRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SessionRoomFeatureRequirement> sessionroomfeaturerequirementCollection = new ModelCollection<SessionRoomFeatureRequirement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                sessionroomfeaturerequirementCollection.add((SessionRoomFeatureRequirement)model);
            }

            return sessionroomfeaturerequirementCollection;
        }

        public static SessionRoomFeatureRequirement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SessionRoomFeatureRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SessionRoomFeatureRequirement)gateway.retrieve(ResourceType.SESSION_ROOM_FEATURE_REQUIREMENT, id);
        }

        public Session getSession()
        {
            return (Session)this.getProperty("session");
        }

        public void setSession(Session session)
        {
            this.setProperty("session", session);
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

