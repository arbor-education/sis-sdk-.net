using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolWorkforceCensusReturn : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_RETURN;
        public const string SCHOOL_WORKFORCE_CENSUS = "schoolWorkforceCensus";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string RETURN_FILENAME = "returnFilename";
        public const string STATUS_DESCRIPTION = "statusDescription";
        public const string RETURN_FILENAME_SEQUENCE_NUMBER = "returnFilenameSequenceNumber";
        public const string XSLT_ERROR = "xsltError";
        public const string DATA_ERROR = "dataError";
        public const string IS_DRY_RUN = "isDryRun";
        public const string DATA_EXPORT_STARTED_DATETIME = "dataExportStartedDatetime";
        public const string DATA_EXPORT_COMPLETED_DATETIME = "dataExportCompletedDatetime";
        public const string SCHOOL_APPROVED_DATETIME = "schoolApprovedDatetime";
        public const string LOCAL_AUTHORITY_REJECTED_DATETIME = "localAuthorityRejectedDatetime";
        public const string LOCAL_AUTHORITY_ACCEPTED_DATETIME = "localAuthorityAcceptedDatetime";
        public const string IS_STAFF_CONTRACT_INFORMATION_EXCLUDED = "isStaffContractInformationExcluded";

        public SchoolWorkforceCensusReturn ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolWorkforceCensusReturn (string resourceType = "SchoolWorkforceCensusReturn", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolWorkforceCensusReturn> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolWorkforceCensusReturn");
        	RestGateway gateway = (RestGateway) SchoolWorkforceCensusReturn.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolWorkforceCensusReturn> schoolworkforcecensusreturnCollection = new ModelCollection<SchoolWorkforceCensusReturn> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkforcecensusreturnCollection.add((SchoolWorkforceCensusReturn) model);
        	}
        
        	return schoolworkforcecensusreturnCollection;
        }

        public static SchoolWorkforceCensusReturn retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolWorkforceCensusReturn.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolWorkforceCensusReturn) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_RETURN, id);
        }

        public SchoolWorkforceCensus getSchoolWorkforceCensus ()
        {
            return (SchoolWorkforceCensus) this.getProperty("schoolWorkforceCensus");
        }

        public void setSchoolWorkforceCensus (SchoolWorkforceCensus schoolWorkforceCensus)
        {
            this.setProperty("schoolWorkforceCensus", schoolWorkforceCensus);
        }

        public EducationalInstitution getEducationalInstitution ()
        {
            return (EducationalInstitution) this.getProperty("educationalInstitution");
        }

        public void setEducationalInstitution (EducationalInstitution educationalInstitution)
        {
            this.setProperty("educationalInstitution", educationalInstitution);
        }

        public string getReturnFilename ()
        {
            return this.getProperty("returnFilename").ToString();
        }

        public void setReturnFilename (string returnFilename)
        {
            this.setProperty("returnFilename", returnFilename);
        }

        public string getStatusDescription ()
        {
            return this.getProperty("statusDescription").ToString();
        }

        public void setStatusDescription (string statusDescription)
        {
            this.setProperty("statusDescription", statusDescription);
        }

        public int getReturnFilenameSequenceNumber ()
        {
            return Convert.ToInt32(this.getProperty("returnFilenameSequenceNumber"));
        }

        public void setReturnFilenameSequenceNumber (int returnFilenameSequenceNumber)
        {
            this.setProperty("returnFilenameSequenceNumber", returnFilenameSequenceNumber);
        }

        public bool getXsltError ()
        {
            return Convert.ToBoolean( this.getProperty("xsltError"));
        }

        public void setXsltError (bool xsltError)
        {
            this.setProperty("xsltError", xsltError);
        }

        public bool getDataError ()
        {
            return Convert.ToBoolean( this.getProperty("dataError"));
        }

        public void setDataError (bool dataError)
        {
            this.setProperty("dataError", dataError);
        }

        public bool getIsDryRun ()
        {
            return Convert.ToBoolean( this.getProperty("isDryRun"));
        }

        public void setIsDryRun (bool isDryRun)
        {
            this.setProperty("isDryRun", isDryRun);
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

        public DateTime getSchoolApprovedDatetime (){
            return Convert.ToDateTime(this.getProperty("schoolApprovedDatetime"));
        }

        public void setSchoolApprovedDatetime (DateTime schoolApprovedDatetime)
        {
            this.setProperty("schoolApprovedDatetime", schoolApprovedDatetime);
        }

        public DateTime getLocalAuthorityRejectedDatetime (){
            return Convert.ToDateTime(this.getProperty("localAuthorityRejectedDatetime"));
        }

        public void setLocalAuthorityRejectedDatetime (DateTime localAuthorityRejectedDatetime)
        {
            this.setProperty("localAuthorityRejectedDatetime", localAuthorityRejectedDatetime);
        }

        public DateTime getLocalAuthorityAcceptedDatetime (){
            return Convert.ToDateTime(this.getProperty("localAuthorityAcceptedDatetime"));
        }

        public void setLocalAuthorityAcceptedDatetime (DateTime localAuthorityAcceptedDatetime)
        {
            this.setProperty("localAuthorityAcceptedDatetime", localAuthorityAcceptedDatetime);
        }

        public bool getIsStaffContractInformationExcluded ()
        {
            return Convert.ToBoolean( this.getProperty("isStaffContractInformationExcluded"));
        }

        public void setIsStaffContractInformationExcluded (bool isStaffContractInformationExcluded)
        {
            this.setProperty("isStaffContractInformationExcluded", isStaffContractInformationExcluded);
        }


    }
}

