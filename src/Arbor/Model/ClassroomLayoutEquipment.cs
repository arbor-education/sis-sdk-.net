using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClassroomLayoutEquipment : ModelBase
    {
        protected string resourceType = ResourceType.CLASSROOM_LAYOUT_EQUIPMENT;
        public const string CLASSROOM_EQUIPMENT = "classroomEquipment";
        public const string ROOM_LAYOUT = "roomLayout";
        public const string X = "x";
        public const string Y = "y";

        public ClassroomLayoutEquipment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClassroomLayoutEquipment (string resourceType = "ClassroomLayoutEquipment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClassroomLayoutEquipment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClassroomLayoutEquipment");
        	RestGateway gateway = (RestGateway) ClassroomLayoutEquipment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClassroomLayoutEquipment> classroomlayoutequipmentCollection = new ModelCollection<ClassroomLayoutEquipment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    classroomlayoutequipmentCollection.add((ClassroomLayoutEquipment) model);
        	}
        
        	return classroomlayoutequipmentCollection;
        }

        public static ClassroomLayoutEquipment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClassroomLayoutEquipment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClassroomLayoutEquipment) gateway.retrieve(ResourceType.CLASSROOM_LAYOUT_EQUIPMENT, id);
        }

        public ClassroomEquipment getClassroomEquipment ()
        {
            return (ClassroomEquipment) this.getProperty("classroomEquipment");
        }

        public void setClassroomEquipment (ClassroomEquipment classroomEquipment)
        {
            this.setProperty("classroomEquipment", classroomEquipment);
        }

        public RoomLayout getRoomLayout ()
        {
            return (RoomLayout) this.getProperty("roomLayout");
        }

        public void setRoomLayout (RoomLayout roomLayout)
        {
            this.setProperty("roomLayout", roomLayout);
        }

        public float getX ()
        {
            return (float) this.getProperty("x");
        }

        public void setX (float x)
        {
            this.setProperty("x", x);
        }

        public float getY ()
        {
            return (float) this.getProperty("y");
        }

        public void setY (float y)
        {
            this.setProperty("y", y);
        }


    }
}

