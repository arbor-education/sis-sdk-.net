using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClassroomEventEquipment : ModelBase
    {
        protected string resourceType = ResourceType.CLASSROOM_EVENT_EQUIPMENT;
        public const string CLASSROOM_SEATING_PLAN_EVENT = "classroomSeatingPlanEvent";
        public const string CLASSROOM_LAYOUT_EQUIPMENT = "classroomLayoutEquipment";
        public const string X = "x";
        public const string Y = "y";

        public ClassroomEventEquipment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClassroomEventEquipment (string resourceType = "ClassroomEventEquipment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClassroomEventEquipment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClassroomEventEquipment");
        	RestGateway gateway = (RestGateway) ClassroomEventEquipment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClassroomEventEquipment> classroomeventequipmentCollection = new ModelCollection<ClassroomEventEquipment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    classroomeventequipmentCollection.add((ClassroomEventEquipment) model);
        	}
        
        	return classroomeventequipmentCollection;
        }

        public static ClassroomEventEquipment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClassroomEventEquipment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClassroomEventEquipment) gateway.retrieve(ResourceType.CLASSROOM_EVENT_EQUIPMENT, id);
        }

        public ClassroomSeatingPlanEvent getClassroomSeatingPlanEvent ()
        {
            return (ClassroomSeatingPlanEvent) this.getProperty("classroomSeatingPlanEvent");
        }

        public void setClassroomSeatingPlanEvent (ClassroomSeatingPlanEvent classroomSeatingPlanEvent)
        {
            this.setProperty("classroomSeatingPlanEvent", classroomSeatingPlanEvent);
        }

        public ClassroomLayoutEquipment getClassroomLayoutEquipment ()
        {
            return (ClassroomLayoutEquipment) this.getProperty("classroomLayoutEquipment");
        }

        public void setClassroomLayoutEquipment (ClassroomLayoutEquipment classroomLayoutEquipment)
        {
            this.setProperty("classroomLayoutEquipment", classroomLayoutEquipment);
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

