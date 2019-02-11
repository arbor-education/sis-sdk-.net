using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RoomFeature : ModelBase
    {
        protected string resourceType = ResourceType.ROOM_FEATURE;
        public const string ROOM_FEATURE_NAME = "roomFeatureName";
        public const string ASSIGN_TO_PEOPLE = "assignToPeople";

        public RoomFeature ()
        {
            base.resourceType = this.resourceType;
        }
        
        public RoomFeature (string resourceType = "RoomFeature", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<RoomFeature> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("RoomFeature");
        	RestGateway gateway = (RestGateway) RoomFeature.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<RoomFeature> roomfeatureCollection = new ModelCollection<RoomFeature> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    roomfeatureCollection.add((RoomFeature) model);
        	}
        
        	return roomfeatureCollection;
        }

        public static RoomFeature retrieve (string id)
        {
            RestGateway gateway = (RestGateway) RoomFeature.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (RoomFeature) gateway.retrieve(ResourceType.ROOM_FEATURE, id);
        }

        public string getRoomFeatureName ()
        {
            return this.getProperty("roomFeatureName").ToString();
        }

        public void setRoomFeatureName (string roomFeatureName)
        {
            this.setProperty("roomFeatureName", roomFeatureName);
        }

        public bool getAssignToPeople ()
        {
            return Convert.ToBoolean( this.getProperty("assignToPeople"));
        }

        public void setAssignToPeople (bool assignToPeople)
        {
            this.setProperty("assignToPeople", assignToPeople);
        }


    }
}

