using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClassroomLayoutSeat : ModelBase
    {
        protected string resourceType = ResourceType.CLASSROOM_LAYOUT_SEAT;
        public const string CLASSROOM_LAYOUT_EQUIPMENT = "classroomLayoutEquipment";
        public const string SEQUENCE_NUMBER = "sequenceNumber";

        public ClassroomLayoutSeat ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClassroomLayoutSeat (string resourceType = "ClassroomLayoutSeat", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClassroomLayoutSeat> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClassroomLayoutSeat");
        	RestGateway gateway = (RestGateway) ClassroomLayoutSeat.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClassroomLayoutSeat> classroomlayoutseatCollection = new ModelCollection<ClassroomLayoutSeat> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    classroomlayoutseatCollection.add((ClassroomLayoutSeat) model);
        	}
        
        	return classroomlayoutseatCollection;
        }

        public static ClassroomLayoutSeat retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClassroomLayoutSeat.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClassroomLayoutSeat) gateway.retrieve(ResourceType.CLASSROOM_LAYOUT_SEAT, id);
        }

        public ClassroomLayoutEquipment getClassroomLayoutEquipment ()
        {
            return (ClassroomLayoutEquipment) this.getProperty("classroomLayoutEquipment");
        }

        public void setClassroomLayoutEquipment (ClassroomLayoutEquipment classroomLayoutEquipment)
        {
            this.setProperty("classroomLayoutEquipment", classroomLayoutEquipment);
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

