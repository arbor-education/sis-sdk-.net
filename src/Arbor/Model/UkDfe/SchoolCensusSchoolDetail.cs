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
        public const string FREE_SCHOOL_MEALS_TAKES = "freeSchoolMealsTakes";
        public const string ADMISSION_APPEALS_LODGED = "admissionAppealsLodged";
        public const string ADMISSION_APPEALS_WITHDRAWN = "admissionAppealsWithdrawn";
        public const string ADMISSION_APPEALS_HEARD = "admissionAppealsHeard";
        public const string ADMISSION_APPEALS_UPHELD = "admissionAppealsUpheld";
        public const string ADMISSION_APPEALS_REJECTED = "admissionAppealsRejected";
        public const string SCHOOL_LUNCH_TAKEN_STUDENT_IDS = "schoolLunchTakenStudentIds";
        public const string PART_TIME_STUDENT_JSON = "partTimeStudentJson";

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

        public ModelBase getSchoolCensus ()
        {
            return (ModelBase) this.getProperty("schoolCensus");
        }

        public void setSchoolCensus (ModelBase schoolCensus)
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

        public int getFreeSchoolMealsTakes ()
        {
            return Convert.ToInt32(this.getProperty("freeSchoolMealsTakes"));
        }

        public void setFreeSchoolMealsTakes (int freeSchoolMealsTakes)
        {
            this.setProperty("freeSchoolMealsTakes", freeSchoolMealsTakes);
        }

        public int getAdmissionAppealsLodged ()
        {
            return Convert.ToInt32(this.getProperty("admissionAppealsLodged"));
        }

        public void setAdmissionAppealsLodged (int admissionAppealsLodged)
        {
            this.setProperty("admissionAppealsLodged", admissionAppealsLodged);
        }

        public int getAdmissionAppealsWithdrawn ()
        {
            return Convert.ToInt32(this.getProperty("admissionAppealsWithdrawn"));
        }

        public void setAdmissionAppealsWithdrawn (int admissionAppealsWithdrawn)
        {
            this.setProperty("admissionAppealsWithdrawn", admissionAppealsWithdrawn);
        }

        public int getAdmissionAppealsHeard ()
        {
            return Convert.ToInt32(this.getProperty("admissionAppealsHeard"));
        }

        public void setAdmissionAppealsHeard (int admissionAppealsHeard)
        {
            this.setProperty("admissionAppealsHeard", admissionAppealsHeard);
        }

        public int getAdmissionAppealsUpheld ()
        {
            return Convert.ToInt32(this.getProperty("admissionAppealsUpheld"));
        }

        public void setAdmissionAppealsUpheld (int admissionAppealsUpheld)
        {
            this.setProperty("admissionAppealsUpheld", admissionAppealsUpheld);
        }

        public int getAdmissionAppealsRejected ()
        {
            return Convert.ToInt32(this.getProperty("admissionAppealsRejected"));
        }

        public void setAdmissionAppealsRejected (int admissionAppealsRejected)
        {
            this.setProperty("admissionAppealsRejected", admissionAppealsRejected);
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


    }
}

