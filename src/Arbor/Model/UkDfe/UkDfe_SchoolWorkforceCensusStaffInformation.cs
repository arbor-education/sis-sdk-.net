using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SchoolWorkforceCensusStaffInformation : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_STAFF_INFORMATION;
        public const string SCHOOL_WORKFORCE_CENSUS = "schoolWorkforceCensus";
        public const string OCCASIONALS_QTS = "occasionalsQts";
        public const string OCCASIONALS_NOT_QTS = "occasionalsNotQts";
        public const string OCCASIONALS_NOT_KNOWN = "occasionalsNotKnown";

        public UkDfe_SchoolWorkforceCensusStaffInformation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SchoolWorkforceCensusStaffInformation (string resourceType = "UkDfe_SchoolWorkforceCensusStaffInformation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SchoolWorkforceCensusStaffInformation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolWorkforceCensusStaffInformation");
        	RestGateway gateway = (RestGateway) UkDfe_SchoolWorkforceCensusStaffInformation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SchoolWorkforceCensusStaffInformation> ukdfe_schoolworkforcecensusstaffinformationCollection = new ModelCollection<UkDfe_SchoolWorkforceCensusStaffInformation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_schoolworkforcecensusstaffinformationCollection.add((UkDfe_SchoolWorkforceCensusStaffInformation) model);
        	}
        
        	return ukdfe_schoolworkforcecensusstaffinformationCollection;
        }

        public static UkDfe_SchoolWorkforceCensusStaffInformation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SchoolWorkforceCensusStaffInformation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SchoolWorkforceCensusStaffInformation) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS_STAFF_INFORMATION, id);
        }

        public SchoolWorkforceCensus getSchoolWorkforceCensus ()
        {
            return (SchoolWorkforceCensus) this.getProperty("schoolWorkforceCensus");
        }

        public void setSchoolWorkforceCensus (SchoolWorkforceCensus schoolWorkforceCensus)
        {
            this.setProperty("schoolWorkforceCensus", schoolWorkforceCensus);
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

        public int getOccasionalsNotKnown ()
        {
            return Convert.ToInt32(this.getProperty("occasionalsNotKnown"));
        }

        public void setOccasionalsNotKnown (int occasionalsNotKnown)
        {
            this.setProperty("occasionalsNotKnown", occasionalsNotKnown);
        }


    }
}

