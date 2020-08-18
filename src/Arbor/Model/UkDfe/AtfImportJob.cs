using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AtfImportJob : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ATF_IMPORT_JOB;
        public const string ATF_VERSION = "atfVersion";
        public const string SOURCE_LOCAL_AUTHORITY_CODE = "sourceLocalAuthorityCode";
        public const string SOURCE_LOCAL_AUTHORITY = "sourceLocalAuthority";
        public const string SOURCE_ESTABLISHMENT_NUMBER = "sourceEstablishmentNumber";
        public const string SOURCE_EDUCATIONAL_INSTITUTION_NAME = "sourceEducationalInstitutionName";
        public const string SOURCE_EDUCATIONAL_INSTITUTION = "sourceEducationalInstitution";
        public const string DESTINATION_LOCAL_AUTHORITY_CODE = "destinationLocalAuthorityCode";
        public const string DESTINATION_LOCAL_AUTHORITY = "destinationLocalAuthority";
        public const string DESTINATION_ESTABLISHMENT_NUMBER = "destinationEstablishmentNumber";
        public const string DESTINATION_EDUCATIONAL_INSTITUTION = "destinationEducationalInstitution";
        public const string LAST_IMPORT_DATETIME = "lastImportDatetime";
        public const string STATUS = "status";

        public AtfImportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AtfImportJob (string resourceType = "AtfImportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AtfImportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_AtfImportJob");
        	RestGateway gateway = (RestGateway) AtfImportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AtfImportJob> atfimportjobCollection = new ModelCollection<AtfImportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    atfimportjobCollection.add((AtfImportJob) model);
        	}
        
        	return atfimportjobCollection;
        }

        public static AtfImportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AtfImportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AtfImportJob) gateway.retrieve(ResourceType.UK_DFE_ATF_IMPORT_JOB, id);
        }

        public string getAtfVersion ()
        {
            return this.getProperty("atfVersion").ToString();
        }

        public void setAtfVersion (string atfVersion)
        {
            this.setProperty("atfVersion", atfVersion);
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

        public DateTime getLastImportDatetime (){
            return Convert.ToDateTime(this.getProperty("lastImportDatetime"));
        }

        public void setLastImportDatetime (DateTime lastImportDatetime)
        {
            this.setProperty("lastImportDatetime", lastImportDatetime);
        }

        public string getStatus ()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus (string status)
        {
            this.setProperty("status", status);
        }
    }
}

