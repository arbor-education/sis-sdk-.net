using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SchoolWorkforceCensusAgencyTpSupportCount : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_AGENCY_TP_SUPPORT_COUNT;
        public const string SCHOOL_WORKFORCE_CENSUS = "schoolWorkforceCensus";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string WORKFORCE_CENSUS_ROLE_IDENTIFIER = "workforceCensusRoleIdentifier";
        public const string AGENCY_TP_SUPPORT_CATEGORY = "agencyTpSupportCategory";
        public const string SUP_HEAD_COUNT = "supHeadCount";

        public UkDfe_SchoolWorkforceCensusAgencyTpSupportCount ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SchoolWorkforceCensusAgencyTpSupportCount (string resourceType = "UkDfe_SchoolWorkforceCensusAgencyTpSupportCount", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SchoolWorkforceCensusAgencyTpSupportCount> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolWorkforceCensusAgencyTpSupportCount");
        	RestGateway gateway = (RestGateway) UkDfe_SchoolWorkforceCensusAgencyTpSupportCount.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SchoolWorkforceCensusAgencyTpSupportCount> ukdfe_schoolworkforcecensusagencytpsupportcountCollection = new ModelCollection<UkDfe_SchoolWorkforceCensusAgencyTpSupportCount> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_schoolworkforcecensusagencytpsupportcountCollection.add((UkDfe_SchoolWorkforceCensusAgencyTpSupportCount) model);
        	}
        
        	return ukdfe_schoolworkforcecensusagencytpsupportcountCollection;
        }

        public static UkDfe_SchoolWorkforceCensusAgencyTpSupportCount retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SchoolWorkforceCensusAgencyTpSupportCount.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SchoolWorkforceCensusAgencyTpSupportCount) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_AGENCY_TP_SUPPORT_COUNT, id);
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

        public string getWorkforceCensusRoleIdentifier ()
        {
            return this.getProperty("workforceCensusRoleIdentifier").ToString();
        }

        public void setWorkforceCensusRoleIdentifier (string workforceCensusRoleIdentifier)
        {
            this.setProperty("workforceCensusRoleIdentifier", workforceCensusRoleIdentifier);
        }

        public string getAgencyTpSupportCategory ()
        {
            return this.getProperty("agencyTpSupportCategory").ToString();
        }

        public void setAgencyTpSupportCategory (string agencyTpSupportCategory)
        {
            this.setProperty("agencyTpSupportCategory", agencyTpSupportCategory);
        }

        public int getSupHeadCount ()
        {
            return Convert.ToInt32(this.getProperty("supHeadCount"));
        }

        public void setSupHeadCount (int supHeadCount)
        {
            this.setProperty("supHeadCount", supHeadCount);
        }


    }
}
