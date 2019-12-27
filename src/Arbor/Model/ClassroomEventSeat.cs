using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClassroomEventSeat : ModelBase
    {
        protected string resourceType = ResourceType.CLASSROOM_EVENT_SEAT;
        public const string CLASSROOM_EVENT_EQUIPMENT = "classroomEventEquipment";
        public const string CLASSROOM_LAYOUT_SEAT = "classroomLayoutSeat";
        public const string STUDENT = "student";
        public const string SEQUENCE_NUMBER = "sequenceNumber";

        public ClassroomEventSeat ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClassroomEventSeat (string resourceType = "ClassroomEventSeat", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClassroomEventSeat> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClassroomEventSeat");
        	RestGateway gateway = (RestGateway) ClassroomEventSeat.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClassroomEventSeat> classroomeventseatCollection = new ModelCollection<ClassroomEventSeat> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    classroomeventseatCollection.add((ClassroomEventSeat) model);
        	}
        
        	return classroomeventseatCollection;
        }

        public static ClassroomEventSeat retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClassroomEventSeat.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClassroomEventSeat) gateway.retrieve(ResourceType.CLASSROOM_EVENT_SEAT, id);
        }

        public ClassroomEventEquipment getClassroomEventEquipment ()
        {
            return (ClassroomEventEquipment) this.getProperty("classroomEventEquipment");
        }

        public void setClassroomEventEquipment (ClassroomEventEquipment classroomEventEquipment)
        {
            this.setProperty("classroomEventEquipment", classroomEventEquipment);
        }

        public ClassroomLayoutSeat getClassroomLayoutSeat ()
        {
            return (ClassroomLayoutSeat) this.getProperty("classroomLayoutSeat");
        }

        public void setClassroomLayoutSeat (ClassroomLayoutSeat classroomLayoutSeat)
        {
            this.setProperty("classroomLayoutSeat", classroomLayoutSeat);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public int getSequenceNumber ()
        {
            return Convert.ToInt32(this.getProperty("sequenceNumber"));
        }

        public void setSequenceNumber (int sequenceNumber)
        {
            this.setProperty("sequenceNumber", sequenceNumber);
        }


    }
}

