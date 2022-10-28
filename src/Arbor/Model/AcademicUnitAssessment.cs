using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitAssessment : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_ASSESSMENT;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string ASSESSMENT = "assessment";

        public AcademicUnitAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitAssessment (string resourceType = "AcademicUnitAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicUnitAssessment");
        	RestGateway gateway = (RestGateway) AcademicUnitAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitAssessment> academicunitassessmentCollection = new ModelCollection<AcademicUnitAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunitassessmentCollection.add((AcademicUnitAssessment) model);
        	}
        
        	return academicunitassessmentCollection;
        }

        public static AcademicUnitAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitAssessment) gateway.retrieve(ResourceType.ACADEMIC_UNIT_ASSESSMENT, id);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }


    }
}

