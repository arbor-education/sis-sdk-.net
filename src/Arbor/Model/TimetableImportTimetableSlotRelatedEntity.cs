using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetableImportTimetableSlotRelatedEntity : ModelBase
    {
        protected new string resourceType = ResourceType.TIMETABLE_IMPORT_TIMETABLE_SLOT_RELATED_ENTITY;
        public const string TIMETABLE_IMPORT_TIMETABLE_SLOT = "timetableImportTimetableSlot";
        public const string RELATED_ENTITY = "relatedEntity";

        public TimetableImportTimetableSlotRelatedEntity ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetableImportTimetableSlotRelatedEntity (string resourceType = "TimetableImportTimetableSlotRelatedEntity", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetableImportTimetableSlotRelatedEntity> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetableImportTimetableSlotRelatedEntity");
        	RestGateway gateway = (RestGateway) TimetableImportTimetableSlotRelatedEntity.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetableImportTimetableSlotRelatedEntity> timetableimporttimetableslotrelatedentityCollection = new ModelCollection<TimetableImportTimetableSlotRelatedEntity> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetableimporttimetableslotrelatedentityCollection.add((TimetableImportTimetableSlotRelatedEntity) model);
        	}
        
        	return timetableimporttimetableslotrelatedentityCollection;
        }

        public static TimetableImportTimetableSlotRelatedEntity retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetableImportTimetableSlotRelatedEntity.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetableImportTimetableSlotRelatedEntity) gateway.retrieve(ResourceType.TIMETABLE_IMPORT_TIMETABLE_SLOT_RELATED_ENTITY, id);
        }

        public TimetableImportTimetableSlot getTimetableImportTimetableSlot ()
        {
            return (TimetableImportTimetableSlot) this.getProperty("timetableImportTimetableSlot");
        }

        public void setTimetableImportTimetableSlot (TimetableImportTimetableSlot timetableImportTimetableSlot)
        {
            this.setProperty("timetableImportTimetableSlot", timetableImportTimetableSlot);
        }

        public ModelBase getRelatedEntity ()
        {
            return (ModelBase) this.getProperty("relatedEntity");
        }

        public void setRelatedEntity (ModelBase relatedEntity)
        {
            this.setProperty("relatedEntity", relatedEntity);
        }


    }
}

