using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolWorkforceCensusVacancy : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_VACANCY;
        public const string SCHOOL_WORKFORCE_CENSUS = "schoolWorkforceCensus";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string SCHOOL_WORKFORCE_VACANCY_POST = "schoolWorkforceVacancyPost";
        public const string SUBJECT = "subject";
        public const string TENURE = "tenure";
        public const string VACANCY_TEMPORARILY_FILLED = "vacancyTemporarilyFilled";
        public const string VACANCY_ADVERTISED = "vacancyAdvertised";

        public SchoolWorkforceCensusVacancy ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolWorkforceCensusVacancy (string resourceType = "SchoolWorkforceCensusVacancy", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolWorkforceCensusVacancy> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolWorkforceCensusVacancy");
        	RestGateway gateway = (RestGateway) SchoolWorkforceCensusVacancy.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolWorkforceCensusVacancy> schoolworkforcecensusvacancyCollection = new ModelCollection<SchoolWorkforceCensusVacancy> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkforcecensusvacancyCollection.add((SchoolWorkforceCensusVacancy) model);
        	}
        
        	return schoolworkforcecensusvacancyCollection;
        }

        public static SchoolWorkforceCensusVacancy retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolWorkforceCensusVacancy.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolWorkforceCensusVacancy) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_VACANCY, id);
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

        public SchoolWorkforceVacancyPost getSchoolWorkforceVacancyPost ()
        {
            return (SchoolWorkforceVacancyPost) this.getProperty("schoolWorkforceVacancyPost");
        }

        public void setSchoolWorkforceVacancyPost (SchoolWorkforceVacancyPost schoolWorkforceVacancyPost)
        {
            this.setProperty("schoolWorkforceVacancyPost", schoolWorkforceVacancyPost);
        }

        public Subject getSubject ()
        {
            return (Subject) this.getProperty("subject");
        }

        public void setSubject (Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public string getTenure ()
        {
            return this.getProperty("tenure").ToString();
        }

        public void setTenure (string tenure)
        {
            this.setProperty("tenure", tenure);
        }

        public string getVacancyTemporarilyFilled ()
        {
            return this.getProperty("vacancyTemporarilyFilled").ToString();
        }

        public void setVacancyTemporarilyFilled (string vacancyTemporarilyFilled)
        {
            this.setProperty("vacancyTemporarilyFilled", vacancyTemporarilyFilled);
        }

        public string getVacancyAdvertised ()
        {
            return this.getProperty("vacancyAdvertised").ToString();
        }

        public void setVacancyAdvertised (string vacancyAdvertised)
        {
            this.setProperty("vacancyAdvertised", vacancyAdvertised);
        }


    }
}

