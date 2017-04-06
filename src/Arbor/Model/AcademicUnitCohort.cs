using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitCohort : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_UNIT_COHORT;
        public const string COHORT_NAME = "cohortName";
        public const string COHORT_CODE = "cohortCode";
        public const string ACADEMIC_UNIT = "academicUnit";

        public AcademicUnitCohort ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitCohort (string resourceType = "AcademicUnitCohort", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitCohort> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicUnitCohort");
        	RestGateway gateway = (RestGateway) AcademicUnitCohort.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitCohort> academicunitcohortCollection = new ModelCollection<AcademicUnitCohort> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunitcohortCollection.add((AcademicUnitCohort) model);
        	}
        
        	return academicunitcohortCollection;
        }

        public static AcademicUnitCohort retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitCohort.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitCohort) gateway.retrieve(ResourceType.ACADEMIC_UNIT_COHORT, id);
        }

        public string getCohortName ()
        {
            return this.getProperty("cohortName").ToString();
        }

        public void setCohortName (string cohortName)
        {
            this.setProperty("cohortName", cohortName);
        }

        public string getCohortCode ()
        {
            return this.getProperty("cohortCode").ToString();
        }

        public void setCohortCode (string cohortCode)
        {
            this.setProperty("cohortCode", cohortCode);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }


    }
}

