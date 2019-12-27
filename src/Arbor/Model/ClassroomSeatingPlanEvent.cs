using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClassroomSeatingPlanEvent : ModelBase
    {
        protected string resourceType = ResourceType.CLASSROOM_SEATING_PLAN_EVENT;
        public const string EVENT = "event";
        public const string CLASSROOM_SEATING_PLAN = "classroomSeatingPlan";

        public ClassroomSeatingPlanEvent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClassroomSeatingPlanEvent (string resourceType = "ClassroomSeatingPlanEvent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClassroomSeatingPlanEvent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClassroomSeatingPlanEvent");
        	RestGateway gateway = (RestGateway) ClassroomSeatingPlanEvent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClassroomSeatingPlanEvent> classroomseatingplaneventCollection = new ModelCollection<ClassroomSeatingPlanEvent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    classroomseatingplaneventCollection.add((ClassroomSeatingPlanEvent) model);
        	}
        
        	return classroomseatingplaneventCollection;
        }

        public static ClassroomSeatingPlanEvent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClassroomSeatingPlanEvent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClassroomSeatingPlanEvent) gateway.retrieve(ResourceType.CLASSROOM_SEATING_PLAN_EVENT, id);
        }

        public ModelBase getEvent ()
        {
            return (ModelBase) this.getProperty("event");
        }

        public void setEvent (ModelBase _event)
        {
            this.setProperty("event", _event);
        }

        public ClassroomSeatingPlan getClassroomSeatingPlan ()
        {
            return (ClassroomSeatingPlan) this.getProperty("classroomSeatingPlan");
        }

        public void setClassroomSeatingPlan (ClassroomSeatingPlan classroomSeatingPlan)
        {
            this.setProperty("classroomSeatingPlan", classroomSeatingPlan);
        }


    }
}

