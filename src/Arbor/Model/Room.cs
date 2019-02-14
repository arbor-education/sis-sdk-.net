using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Room : ModelBase
    {
        protected string resourceType = ResourceType.ROOM;
        public const string SITE = "site";
        public const string ROOM_NAME = "roomName";
        public const string SHORT_NAME = "shortName";
        public const string STUDENT_CAPACITY = "studentCapacity";
        public const string IS_INVIGILATION_ROOM = "isInvigilationRoom";
        public const string INVIGILATION_CAPACITY = "invigilationCapacity";

        public Room ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Room (string resourceType = "Room", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Room> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Room");
        	RestGateway gateway = (RestGateway) Room.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Room> roomCollection = new ModelCollection<Room> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    roomCollection.add((Room) model);
        	}
        
        	return roomCollection;
        }

        public static Room retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Room.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Room) gateway.retrieve(ResourceType.ROOM, id);
        }

        public Site getSite ()
        {
            return (Site) this.getProperty("site");
        }

        public void setSite (Site site)
        {
            this.setProperty("site", site);
        }

        public string getRoomName ()
        {
            return this.getProperty("roomName").ToString();
        }

        public void setRoomName (string roomName)
        {
            this.setProperty("roomName", roomName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public int getStudentCapacity ()
        {
            return Convert.ToInt32(this.getProperty("studentCapacity"));
        }

        public void setStudentCapacity (int studentCapacity)
        {
            this.setProperty("studentCapacity", studentCapacity);
        }

        public bool getIsInvigilationRoom ()
        {
            return Convert.ToBoolean(this.getProperty("isInvigilationRoom"))
        }

        public void setIsInvigilationRoom (bool isInvigilationRoom)
        {
            this.setProperty("isInvigilationRoom", isInvigilationRoom);
        }

        public int getInvigilationCapacity ()
        {
            return Convert.ToInt32(this.getProperty("invigilationCapacity"));
        }

        public void setInvigilationCapacity (int invigilationCapacity)
        {
            this.setProperty("invigilationCapacity", invigilationCapacity);
        }


    }
}

