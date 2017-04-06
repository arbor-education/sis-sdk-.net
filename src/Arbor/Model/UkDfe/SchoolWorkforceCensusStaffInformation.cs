using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolWorkforceCensusStaffInformation : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_STAFF_INFORMATION;
        public const string SCHOOL_WORKFORCE_CENSUS = "schoolWorkforceCensus";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string OCCASIONALS_QTS = "occasionalsQts";
        public const string OCCASIONALS_NOT_QTS = "occasionalsNotQts";
        public const string OCCASIONALS_NOT_KNWN = "occasionalsNotKnwn";

        public SchoolWorkforceCensusStaffInformation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolWorkforceCensusStaffInformation (string resourceType = "SchoolWorkforceCensusStaffInformation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolWorkforceCensusStaffInformation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolWorkforceCensusStaffInformation");
        	RestGateway gateway = (RestGateway) SchoolWorkforceCensusStaffInformation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolWorkforceCensusStaffInformation> schoolworkforcecensusstaffinformationCollection = new ModelCollection<SchoolWorkforceCensusStaffInformation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkforcecensusstaffinformationCollection.add((SchoolWorkforceCensusStaffInformation) model);
        	}
        
        	return schoolworkforcecensusstaffinformationCollection;
        }

        public static SchoolWorkforceCensusStaffInformation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolWorkforceCensusStaffInformation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolWorkforceCensusStaffInformation) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_STAFF_INFORMATION, id);
        }

        public ModelBase getSchoolWorkforceCensus ()
        {
            return (ModelBase) this.getProperty("schoolWorkforceCensus");
        }

        public void setSchoolWorkforceCensus (ModelBase schoolWorkforceCensus)
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

        public int getOccasionalsQts ()
        {
            return Convert.ToInt32(this.getProperty("occasionalsQts"));
        }

        public void setOccasionalsQts (int occasionalsQts)
        {
            this.setProperty("occasionalsQts", occasionalsQts);
        }

        public int getOccasionalsNotQts ()
        {
            return Convert.ToInt32(this.getProperty("occasionalsNotQts"));
        }

        public void setOccasionalsNotQts (int occasionalsNotQts)
        {
            this.setProperty("occasionalsNotQts", occasionalsNotQts);
        }

        public int getOccasionalsNotKnwn ()
        {
            return Convert.ToInt32(this.getProperty("occasionalsNotKnwn"));
        }

        public void setOccasionalsNotKnwn (int occasionalsNotKnwn)
        {
            this.setProperty("occasionalsNotKnwn", occasionalsNotKnwn);
        }


    }
}

