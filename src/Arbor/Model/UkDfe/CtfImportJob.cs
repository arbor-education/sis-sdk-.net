using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class CtfImportJob : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CTF_IMPORT_JOB;
        public const string SOURCE_LOCAL_AUTHORITY_CODE = "sourceLocalAuthorityCode";
        public const string SOURCE_LOCAL_AUTHORITY = "sourceLocalAuthority";
        public const string SOURCE_ESTABLISHMENT_NUMBER = "sourceEstablishmentNumber";
        public const string SOURCE_EDUCATIONAL_INSTITUTION_NAME = "sourceEducationalInstitutionName";
        public const string SOURCE_EDUCATIONAL_INSTITUTION = "sourceEducationalInstitution";
        public const string DESTINATION_LOCAL_AUTHORITY_CODE = "destinationLocalAuthorityCode";
        public const string DESTINATION_LOCAL_AUTHORITY = "destinationLocalAuthority";
        public const string DESTINATION_ESTABLISHMENT_NUMBER = "destinationEstablishmentNumber";
        public const string DESTINATION_EDUCATIONAL_INSTITUTION = "destinationEducationalInstitution";
        public const string DEFAULT_INTAKE_SEASON = "defaultIntakeSeason";
        public const string LAST_IMPORT_DATETIME = "lastImportDatetime";
        public const string IS_QUEUED_FOR_ALL_STUDENT_IMPORT = "isQueuedForAllStudentImport";

        public CtfImportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CtfImportJob (string resourceType = "CtfImportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CtfImportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_CtfImportJob");
        	RestGateway gateway = (RestGateway) CtfImportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CtfImportJob> ctfimportjobCollection = new ModelCollection<CtfImportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ctfimportjobCollection.add((CtfImportJob) model);
        	}
        
        	return ctfimportjobCollection;
        }

        public static CtfImportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CtfImportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CtfImportJob) gateway.retrieve(ResourceType.UK_DFE_CTF_IMPORT_JOB, id);
        }

        public string getSourceLocalAuthorityCode ()
        {
            return this.getProperty("sourceLocalAuthorityCode").ToString();
        }

        public void setSourceLocalAuthorityCode (string sourceLocalAuthorityCode)
        {
            this.setProperty("sourceLocalAuthorityCode", sourceLocalAuthorityCode);
        }

        public LocalAuthority getSourceLocalAuthority ()
        {
            return (LocalAuthority) this.getProperty("sourceLocalAuthority");
        }

        public void setSourceLocalAuthority (LocalAuthority sourceLocalAuthority)
        {
            this.setProperty("sourceLocalAuthority", sourceLocalAuthority);
        }

        public string getSourceEstablishmentNumber ()
        {
            return this.getProperty("sourceEstablishmentNumber").ToString();
        }

        public void setSourceEstablishmentNumber (string sourceEstablishmentNumber)
        {
            this.setProperty("sourceEstablishmentNumber", sourceEstablishmentNumber);
        }

        public string getSourceEducationalInstitutionName ()
        {
            return this.getProperty("sourceEducationalInstitutionName").ToString();
        }

        public void setSourceEducationalInstitutionName (string sourceEducationalInstitutionName)
        {
            this.setProperty("sourceEducationalInstitutionName", sourceEducationalInstitutionName);
        }

        public EducationalInstitution getSourceEducationalInstitution ()
        {
            return (EducationalInstitution) this.getProperty("sourceEducationalInstitution");
        }

        public void setSourceEducationalInstitution (EducationalInstitution sourceEducationalInstitution)
        {
            this.setProperty("sourceEducationalInstitution", sourceEducationalInstitution);
        }

        public string getDestinationLocalAuthorityCode ()
        {
            return this.getProperty("destinationLocalAuthorityCode").ToString();
        }

        public void setDestinationLocalAuthorityCode (string destinationLocalAuthorityCode)
        {
            this.setProperty("destinationLocalAuthorityCode", destinationLocalAuthorityCode);
        }

        public LocalAuthority getDestinationLocalAuthority ()
        {
            return (LocalAuthority) this.getProperty("destinationLocalAuthority");
        }

        public void setDestinationLocalAuthority (LocalAuthority destinationLocalAuthority)
        {
            this.setProperty("destinationLocalAuthority", destinationLocalAuthority);
        }

        public string getDestinationEstablishmentNumber ()
        {
            return this.getProperty("destinationEstablishmentNumber").ToString();
        }

        public void setDestinationEstablishmentNumber (string destinationEstablishmentNumber)
        {
            this.setProperty("destinationEstablishmentNumber", destinationEstablishmentNumber);
        }

        public EducationalInstitution getDestinationEducationalInstitution ()
        {
            return (EducationalInstitution) this.getProperty("destinationEducationalInstitution");
        }

        public void setDestinationEducationalInstitution (EducationalInstitution destinationEducationalInstitution)
        {
            this.setProperty("destinationEducationalInstitution", destinationEducationalInstitution);
        }

        public IntakeSeason getDefaultIntakeSeason ()
        {
            return (IntakeSeason) this.getProperty("defaultIntakeSeason");
        }

        public void setDefaultIntakeSeason (IntakeSeason defaultIntakeSeason)
        {
            this.setProperty("defaultIntakeSeason", defaultIntakeSeason);
        }

        public DateTime getLastImportDatetime (){
            return Convert.ToDateTime(this.getProperty("lastImportDatetime"));
        }

        public void setLastImportDatetime (DateTime lastImportDatetime)
        {
            this.setProperty("lastImportDatetime", lastImportDatetime);
        }

        public bool getIsQueuedForAllStudentImport ()
        {
            return Convert.ToBoolean( this.getProperty("isQueuedForAllStudentImport"));
        }

        public void setIsQueuedForAllStudentImport (bool isQueuedForAllStudentImport)
        {
            this.setProperty("isQueuedForAllStudentImport", isQueuedForAllStudentImport);
        }


    }
}

