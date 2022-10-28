using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitTag : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_TAG;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string RELATED_OBJECT = "relatedObject";

        public AcademicUnitTag ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitTag (string resourceType = "AcademicUnitTag", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitTag> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicUnitTag");
        	RestGateway gateway = (RestGateway) AcademicUnitTag.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitTag> academicunittagCollection = new ModelCollection<AcademicUnitTag> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunittagCollection.add((AcademicUnitTag) model);
        	}
        
        	return academicunittagCollection;
        }

        public static AcademicUnitTag retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitTag.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitTag) gateway.retrieve(ResourceType.ACADEMIC_UNIT_TAG, id);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public ModelBase getRelatedObject ()
        {
            return (ModelBase) this.getProperty("relatedObject");
        }

        public void setRelatedObject (ModelBase relatedObject)
        {
            this.setProperty("relatedObject", relatedObject);
        }


    }
}

