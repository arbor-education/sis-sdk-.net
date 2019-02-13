using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitEnrolmentImport : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_UNIT_ENROLMENT_IMPORT;
        public const string NAME = "name";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string IMPORT_STARTED_DATETIME = "importStartedDatetime";
        public const string IMPORT_COMPLETED_DATETIME = "importCompletedDatetime";
        public const string ENROLMENT_START_DATE = "enrolmentStartDate";
        public const string ENROLMENT_END_DATE = "enrolmentEndDate";

        public AcademicUnitEnrolmentImport ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitEnrolmentImport (string resourceType = "AcademicUnitEnrolmentImport", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitEnrolmentImport> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicUnitEnrolmentImport");
        	RestGateway gateway = (RestGateway) AcademicUnitEnrolmentImport.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitEnrolmentImport> academicunitenrolmentimportCollection = new ModelCollection<AcademicUnitEnrolmentImport> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunitenrolmentimportCollection.add((AcademicUnitEnrolmentImport) model);
        	}
        
        	return academicunitenrolmentimportCollection;
        }

        public static AcademicUnitEnrolmentImport retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitEnrolmentImport.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitEnrolmentImport) gateway.retrieve(ResourceType.ACADEMIC_UNIT_ENROLMENT_IMPORT, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public DateTime getImportStartedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("importStartedDatetime"))
        }

        public void setImportStartedDatetime (DateTime importStartedDatetime)
        {
            this.setProperty("importStartedDatetime", importStartedDatetime);
        }

        public DateTime getImportCompletedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("importCompletedDatetime"))
        }

        public void setImportCompletedDatetime (DateTime importCompletedDatetime)
        {
            this.setProperty("importCompletedDatetime", importCompletedDatetime);
        }

        public DateTime getEnrolmentStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("enrolmentStartDate"))
        }

        public void setEnrolmentStartDate (DateTime enrolmentStartDate)
        {
            this.setProperty("enrolmentStartDate", enrolmentStartDate);
        }

        public DateTime getEnrolmentEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("enrolmentEndDate"))
        }

        public void setEnrolmentEndDate (DateTime enrolmentEndDate)
        {
            this.setProperty("enrolmentEndDate", enrolmentEndDate);
        }


    }
}

