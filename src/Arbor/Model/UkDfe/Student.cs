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
        public const string HOME_LOCAL_AUTHORITY = "homeLocalAuthority";
        public const string YOUTH_SUPPORT_SERVICES_AGREEMENT = "youthSupportServicesAgreement";
        public const string HOURS_AT_SETTING = "hoursAtSetting";
        public const string FUNDED_HOURS = "fundedHours";
        public const string ETHNICITY_SOURCE = "ethnicitySource";
        public const string NHS_NUMBER = "nhsNumber";
        public const string EXTENDED_HOURS = "extendedHours";
        public const string THIRTY_HOUR_CODE = "thirtyHourCode";

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

        public LocalAuthority getHomeLocalAuthority ()
        {
            return (LocalAuthority) this.getProperty("homeLocalAuthority");
        }

        public void setHomeLocalAuthority (LocalAuthority homeLocalAuthority)
        {
            this.setProperty("homeLocalAuthority", homeLocalAuthority);
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

        public string getNhsNumber ()
        {
            return this.getProperty("nhsNumber").ToString();
        }

        public void setNhsNumber (string nhsNumber)
        {
            this.setProperty("nhsNumber", nhsNumber);
        }

        public string getExtendedHours ()
        {
            return this.getProperty("extendedHours").ToString();
        }

        public void setExtendedHours (string extendedHours)
        {
            this.setProperty("extendedHours", extendedHours);
        }

        public string getThirtyHourCode ()
        {
            return this.getProperty("thirtyHourCode").ToString();
        }

        public void setThirtyHourCode (string thirtyHourCode)
        {
            this.setProperty("thirtyHourCode", thirtyHourCode);
        }


    }
}

