using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SessionRoomAssetRequirement : ModelBase
    {
        protected new string resourceType = ResourceType.SESSION_ROOM_ASSET_REQUIREMENT;
        public const string SESSION = "session";
        public const string ROOM_ASSET = "roomAsset";
        public const string QUANTITY = "quantity";

        public SessionRoomAssetRequirement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SessionRoomAssetRequirement (string resourceType = "SessionRoomAssetRequirement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SessionRoomAssetRequirement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SessionRoomAssetRequirement");
        	RestGateway gateway = (RestGateway) SessionRoomAssetRequirement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SessionRoomAssetRequirement> sessionroomassetrequirementCollection = new ModelCollection<SessionRoomAssetRequirement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sessionroomassetrequirementCollection.add((SessionRoomAssetRequirement) model);
        	}
        
        	return sessionroomassetrequirementCollection;
        }

        public static SessionRoomAssetRequirement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SessionRoomAssetRequirement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SessionRoomAssetRequirement) gateway.retrieve(ResourceType.SESSION_ROOM_ASSET_REQUIREMENT, id);
        }

        public Session getSession ()
        {
            return (Session) this.getProperty("session");
        }

        public void setSession (Session session)
        {
            this.setProperty("session", session);
        }

        public RoomAsset getRoomAsset ()
        {
            return (RoomAsset) this.getProperty("roomAsset");
        }

        public void setRoomAsset (RoomAsset roomAsset)
        {
            this.setProperty("roomAsset", roomAsset);
        }

        public int getQuantity ()
        {
            return Convert.ToInt32(this.getProperty("quantity"));
        }

        public void setQuantity (int quantity)
        {
            this.setProperty("quantity", quantity);
        }


    }
}

