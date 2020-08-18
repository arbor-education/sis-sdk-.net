using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolCensusReturn : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_CENSUS_RETURN;
        public const string SCHOOL_CENSUS = "schoolCensus";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string CURRENT_RETURN_NUMBER = "currentReturnNumber";
        public const string RETURN_FILENAME = "returnFilename";
        public const string RETURN_FILENAME_SEQUENCE_NUMBER = "returnFilenameSequenceNumber";
        public const string DATA_ERROR = "dataError";
        public const string XSD_ERROR = "xsdError";
        public const string XSLT_ERROR = "xsltError";
        public const string SUMMARY_ERROR = "summaryError";
        public const string SUMMARY_ERROR_DESCRIPTION = "summaryErrorDescription";
        public const string STATUS_DESCRIPTION = "statusDescription";
        public const string DATA_EXPORT_STARTED_DATETIME = "dataExportStartedDatetime";
        public const string DATA_EXPORT_COMPLETED_DATETIME = "dataExportCompletedDatetime";
        public const string IS_DRY_RUN = "isDryRun";

        public SchoolCensusReturn ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolCensusReturn (string resourceType = "SchoolCensusReturn", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolCensusReturn> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolCensusReturn");
        	RestGateway gateway = (RestGateway) SchoolCensusReturn.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolCensusReturn> schoolcensusreturnCollection = new ModelCollection<SchoolCensusReturn> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolcensusreturnCollection.add((SchoolCensusReturn) model);
        	}
        
        	return schoolcensusreturnCollection;
        }

        public static SchoolCensusReturn retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolCensusReturn.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolCensusReturn) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_CENSUS_RETURN, id);
        }

        public SchoolCensus getSchoolCensus ()
        {
            return (SchoolCensus) this.getProperty("schoolCensus");
        }

        public void setSchoolCensus (SchoolCensus schoolCensus)
        {
            this.setProperty("schoolCensus", schoolCensus);
        }

        public EducationalInstitution getEducationalInstitution ()
        {
            return (EducationalInstitution) this.getProperty("educationalInstitution");
        }

        public void setEducationalInstitution (EducationalInstitution educationalInstitution)
        {
            this.setProperty("educationalInstitution", educationalInstitution);
        }

        public int getCurrentReturnNumber ()
        {
            return Convert.ToInt32(this.getProperty("currentReturnNumber"));
        }

        public void setCurrentReturnNumber (int currentReturnNumber)
        {
            this.setProperty("currentReturnNumber", currentReturnNumber);
        }

        public string getReturnFilename ()
        {
            return this.getProperty("returnFilename").ToString();
        }

        public void setReturnFilename (string returnFilename)
        {
            this.setProperty("returnFilename", returnFilename);
        }

        public int getReturnFilenameSequenceNumber ()
        {
            return Convert.ToInt32(this.getProperty("returnFilenameSequenceNumber"));
        }

        public void setReturnFilenameSequenceNumber (int returnFilenameSequenceNumber)
        {
            this.setProperty("returnFilenameSequenceNumber", returnFilenameSequenceNumber);
        }

        public bool getDataError ()
        {
            return (bool) this.getProperty("dataError");
        }

        public void setDataError (bool dataError)
        {
            this.setProperty("dataError", dataError);
        }

        public bool getXsdError ()
        {
            return (bool) this.getProperty("xsdError");
        }

        public void setXsdError (bool xsdError)
        {
            this.setProperty("xsdError", xsdError);
        }

        public bool getXsltError ()
        {
            return (bool) this.getProperty("xsltError");
        }

        public void setXsltError (bool xsltError)
        {
            this.setProperty("xsltError", xsltError);
        }

        public bool getSummaryError ()
        {
            return (bool) this.getProperty("summaryError");
        }

        public void setSummaryError (bool summaryError)
        {
            this.setProperty("summaryError", summaryError);
        }

        public string getSummaryErrorDescription ()
        {
            return this.getProperty("summaryErrorDescription").ToString();
        }

        public void setSummaryErrorDescription (string summaryErrorDescription)
        {
            this.setProperty("summaryErrorDescription", summaryErrorDescription);
        }

        public string getStatusDescription ()
        {
            return this.getProperty("statusDescription").ToString();
        }

        public void setStatusDescription (string statusDescription)
        {
            this.setProperty("statusDescription", statusDescription);
        }

        public DateTime getDataExportStartedDatetime (){
            return Convert.ToDateTime(this.getProperty("dataExportStartedDatetime"));
        }

        public void setDataExportStartedDatetime (DateTime dataExportStartedDatetime)
        {
            this.setProperty("dataExportStartedDatetime", dataExportStartedDatetime);
        }

        public DateTime getDataExportCompletedDatetime (){
            return Convert.ToDateTime(this.getProperty("dataExportCompletedDatetime"));
        }

        public void setDataExportCompletedDatetime (DateTime dataExportCompletedDatetime)
        {
            this.setProperty("dataExportCompletedDatetime", dataExportCompletedDatetime);
        }

        public bool getIsDryRun ()
        {
            return (bool) this.getProperty("isDryRun");
        }

        public void setIsDryRun (bool isDryRun)
        {
            this.setProperty("isDryRun", isDryRun);
        }


    }
}

