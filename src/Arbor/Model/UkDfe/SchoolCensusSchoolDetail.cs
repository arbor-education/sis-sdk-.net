using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolCensusSchoolDetail : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_CENSUS_SCHOOL_DETAIL;
        public const string SCHOOL_CENSUS = "schoolCensus";
        public const string TEEN_MOTHER_PLACES = "teenMotherPlaces";
        public const string FREE_SCHOOL_MEALS_TAKEN = "freeSchoolMealsTaken";
        public const string ADMISSIONS_APPEALS_JSON = "admissionsAppealsJson";
        public const string ADMISSIONS_APPEALS_LODGED = "admissionsAppealsLodged";
        public const string ADMISSIONS_APPEALS_WITHDRAWN = "admissionsAppealsWithdrawn";
        public const string ADMISSIONS_APPEALS_HEARD = "admissionsAppealsHeard";
        public const string ADMISSIONS_APPEALS_UPHELD = "admissionsAppealsUpheld";
        public const string ADMISSIONS_APPEALS_REJECTED = "admissionsAppealsRejected";
        public const string SCHOOL_LUNCH_TAKEN_STUDENT_IDS = "schoolLunchTakenStudentIds";
        public const string PART_TIME_STUDENT_JSON = "partTimeStudentJson";
        public const string QUALIFICATION_RESULTS_JSON = "qualificationResultsJson";

        public SchoolCensusSchoolDetail ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolCensusSchoolDetail (string resourceType = "SchoolCensusSchoolDetail", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolCensusSchoolDetail> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolCensusSchoolDetail");
        	RestGateway gateway = (RestGateway) SchoolCensusSchoolDetail.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolCensusSchoolDetail> schoolcensusschooldetailCollection = new ModelCollection<SchoolCensusSchoolDetail> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolcensusschooldetailCollection.add((SchoolCensusSchoolDetail) model);
        	}
        
        	return schoolcensusschooldetailCollection;
        }

        public static SchoolCensusSchoolDetail retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolCensusSchoolDetail.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolCensusSchoolDetail) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_CENSUS_SCHOOL_DETAIL, id);
        }

        public SchoolCensus getSchoolCensus ()
        {
            return (SchoolCensus) this.getProperty("schoolCensus");
        }

        public void setSchoolCensus (SchoolCensus schoolCensus)
        {
            this.setProperty("schoolCensus", schoolCensus);
        }

        public int getTeenMotherPlaces ()
        {
            return Convert.ToInt32(this.getProperty("teenMotherPlaces"));
        }

        public void setTeenMotherPlaces (int teenMotherPlaces)
        {
            this.setProperty("teenMotherPlaces", teenMotherPlaces);
        }

        public int getFreeSchoolMealsTaken ()
        {
            return Convert.ToInt32(this.getProperty("freeSchoolMealsTaken"));
        }

        public void setFreeSchoolMealsTaken (int freeSchoolMealsTaken)
        {
            this.setProperty("freeSchoolMealsTaken", freeSchoolMealsTaken);
        }

        public string getAdmissionsAppealsJson ()
        {
            return this.getProperty("admissionsAppealsJson").ToString();
        }

        public void setAdmissionsAppealsJson (string admissionsAppealsJson)
        {
            this.setProperty("admissionsAppealsJson", admissionsAppealsJson);
        }

        public int getAdmissionsAppealsLodged ()
        {
            return Convert.ToInt32(this.getProperty("admissionsAppealsLodged"));
        }

        public void setAdmissionsAppealsLodged (int admissionsAppealsLodged)
        {
            this.setProperty("admissionsAppealsLodged", admissionsAppealsLodged);
        }

        public int getAdmissionsAppealsWithdrawn ()
        {
            return Convert.ToInt32(this.getProperty("admissionsAppealsWithdrawn"));
        }

        public void setAdmissionsAppealsWithdrawn (int admissionsAppealsWithdrawn)
        {
            this.setProperty("admissionsAppealsWithdrawn", admissionsAppealsWithdrawn);
        }

        public int getAdmissionsAppealsHeard ()
        {
            return Convert.ToInt32(this.getProperty("admissionsAppealsHeard"));
        }

        public void setAdmissionsAppealsHeard (int admissionsAppealsHeard)
        {
            this.setProperty("admissionsAppealsHeard", admissionsAppealsHeard);
        }

        public int getAdmissionsAppealsUpheld ()
        {
            return Convert.ToInt32(this.getProperty("admissionsAppealsUpheld"));
        }

        public void setAdmissionsAppealsUpheld (int admissionsAppealsUpheld)
        {
            this.setProperty("admissionsAppealsUpheld", admissionsAppealsUpheld);
        }

        public int getAdmissionsAppealsRejected ()
        {
            return Convert.ToInt32(this.getProperty("admissionsAppealsRejected"));
        }

        public void setAdmissionsAppealsRejected (int admissionsAppealsRejected)
        {
            this.setProperty("admissionsAppealsRejected", admissionsAppealsRejected);
        }

        public string getSchoolLunchTakenStudentIds ()
        {
            return this.getProperty("schoolLunchTakenStudentIds").ToString();
        }

        public void setSchoolLunchTakenStudentIds (string schoolLunchTakenStudentIds)
        {
            this.setProperty("schoolLunchTakenStudentIds", schoolLunchTakenStudentIds);
        }

        public string getPartTimeStudentJson ()
        {
            return this.getProperty("partTimeStudentJson").ToString();
        }

        public void setPartTimeStudentJson (string partTimeStudentJson)
        {
            this.setProperty("partTimeStudentJson", partTimeStudentJson);
        }

        public string getQualificationResultsJson ()
        {
            return this.getProperty("qualificationResultsJson").ToString();
        }

        public void setQualificationResultsJson (string qualificationResultsJson)
        {
            this.setProperty("qualificationResultsJson", qualificationResultsJson);
        }


    }
}

