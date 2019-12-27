using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClassroomSeatingPlan : ModelBase
    {
        protected string resourceType = ResourceType.CLASSROOM_SEATING_PLAN;
        public const string ROOM_LAYOUT = "roomLayout";
        public const string STAFF = "staff";
        public const string TIMETABLE_SLOT = "timetableSlot";

        public ClassroomSeatingPlan ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClassroomSeatingPlan (string resourceType = "ClassroomSeatingPlan", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClassroomSeatingPlan> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClassroomSeatingPlan");
        	RestGateway gateway = (RestGateway) ClassroomSeatingPlan.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClassroomSeatingPlan> classroomseatingplanCollection = new ModelCollection<ClassroomSeatingPlan> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    classroomseatingplanCollection.add((ClassroomSeatingPlan) model);
        	}
        
        	return classroomseatingplanCollection;
        }

        public static ClassroomSeatingPlan retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClassroomSeatingPlan.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClassroomSeatingPlan) gateway.retrieve(ResourceType.CLASSROOM_SEATING_PLAN, id);
        }

        public RoomLayout getRoomLayout ()
        {
            return (RoomLayout) this.getProperty("roomLayout");
        }

        public void setRoomLayout (RoomLayout roomLayout)
        {
            this.setProperty("roomLayout", roomLayout);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public TimetableSlot getTimetableSlot ()
        {
            return (TimetableSlot) this.getProperty("timetableSlot");
        }

        public void setTimetableSlot (TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }


    }
}

