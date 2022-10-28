using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;
using System.Collections;

namespace Arbor.Model
{
    public class AcademicProgramme : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_PROGRAMME;
        public const string ACADEMIC_PROGRAMME_NAME = "academicProgrammeName";

        public AcademicProgramme ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicProgramme (string resourceType = "AcademicProgramme", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicProgramme> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicProgramme");
        	RestGateway gateway = (RestGateway) AcademicProgramme.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicProgramme> academicprogrammeCollection = new ModelCollection<AcademicProgramme> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicprogrammeCollection.add((AcademicProgramme) model);
        	}
        
        	return academicprogrammeCollection;
        }

        public static AcademicProgramme retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicProgramme.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicProgramme) gateway.retrieve(ResourceType.ACADEMIC_PROGRAMME, id);
        }

        public string getAcademicProgrammeName ()
        {
            return this.getProperty("academicProgrammeName").ToString();
        }

        public void setAcademicProgrammeName (string academicProgrammeName)
        {
            this.setProperty("academicProgrammeName", academicProgrammeName);
        }

        public ModelCollection<AcademicProgrammeInstance> getInstances ()
        {
            ModelCollection<ModelBase> collection = (ModelCollection<ModelBase>) this.getCollectionProperty("instances");
        	return (ModelCollection<AcademicProgrammeInstance>) this.getApiGateway().castCollection<AcademicProgrammeInstance>(collection);
        }


    }
}

