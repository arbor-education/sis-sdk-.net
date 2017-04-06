using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class Student : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_STUDENT;
        public const string UNIQUE_LEARNER_NUMBER = "uniqueLearnerNumber";
        public const string UNIQUE_CANDIDATE_IDENTIFIER = "uniqueCandidateIdentifier";
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";
        public const string TRAVELLER_STATUS = "travellerStatus";
        public const string YOUTH_SUPPORT_SERVICES_AGREEMENT = "youthSupportServicesAgreement";
        public const string HOURS_AT_SETTING = "hoursAtSetting";
        public const string FUNDED_HOURS = "fundedHours";
        public const string ETHNICITY_SOURCE = "ethnicitySource";

        public Student ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Student (string resourceType = "Student", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Student> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Student");
        	RestGateway gateway = (RestGateway) Student.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Student> studentCollection = new ModelCollection<Student> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentCollection.add((Student) model);
        	}
        
        	return studentCollection;
        }

        public static Student retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Student.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Student) gateway.retrieve(ResourceType.UK_DFE_STUDENT, id);
        }

        public int getUniqueLearnerNumber ()
        {
            return Convert.ToInt32(this.getProperty("uniqueLearnerNumber"));
        }

        public void setUniqueLearnerNumber (int uniqueLearnerNumber)
        {
            this.setProperty("uniqueLearnerNumber", uniqueLearnerNumber);
        }

        public string getUniqueCandidateIdentifier ()
        {
            return this.getProperty("uniqueCandidateIdentifier").ToString();
        }

        public void setUniqueCandidateIdentifier (string uniqueCandidateIdentifier)
        {
            this.setProperty("uniqueCandidateIdentifier", uniqueCandidateIdentifier);
        }

        public ModelBase getResponsibleLocalAuthority ()
        {
            return (ModelBase) this.getProperty("responsibleLocalAuthority");
        }

        public void setResponsibleLocalAuthority (ModelBase responsibleLocalAuthority)
        {
            this.setProperty("responsibleLocalAuthority", responsibleLocalAuthority);
        }

        public bool getTravellerStatus ()
        {
            return (bool) this.getProperty("travellerStatus");
        }

        public void setTravellerStatus (bool travellerStatus)
        {
            this.setProperty("travellerStatus", travellerStatus);
        }

        public string getYouthSupportServicesAgreement ()
        {
            return this.getProperty("youthSupportServicesAgreement").ToString();
        }

        public void setYouthSupportServicesAgreement (string youthSupportServicesAgreement)
        {
            this.setProperty("youthSupportServicesAgreement", youthSupportServicesAgreement);
        }

        public string getHoursAtSetting ()
        {
            return this.getProperty("hoursAtSetting").ToString();
        }

        public void setHoursAtSetting (string hoursAtSetting)
        {
            this.setProperty("hoursAtSetting", hoursAtSetting);
        }

        public string getFundedHours ()
        {
            return this.getProperty("fundedHours").ToString();
        }

        public void setFundedHours (string fundedHours)
        {
            this.setProperty("fundedHours", fundedHours);
        }

        public string getEthnicitySource ()
        {
            return this.getProperty("ethnicitySource").ToString();
        }

        public void setEthnicitySource (string ethnicitySource)
        {
            this.setProperty("ethnicitySource", ethnicitySource);
        }


    }
}

