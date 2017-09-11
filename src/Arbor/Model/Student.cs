using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Student : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT;
        public const string UNIQUE_LEARNER_NUMBER = "uniqueLearnerNumber";
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";
        public const string HOME_LOCAL_AUTHORITY = "homeLocalAuthority";
        public const string TRAVELLER_STATUS = "travellerStatus";
        public const string YOUTH_SUPPORT_SERVICES_AGREEMENT = "youthSupportServicesAgreement";
        public const string HOURS_AT_SETTING = "hoursAtSetting";
        public const string FUNDED_HOURS = "fundedHours";
        public const string ETHNICITY_SOURCE = "ethnicitySource";
        public const string EXTENDED_HOURS = "extendedHours";
        public const string THIRTY_HOUR_CODE = "thirtyHourCode";
        public const string PERSON = "person";
        public const string RELIGION = "religion";
        public const string ETHNICITY = "ethnicity";
        public const string BLOOD_GROUP = "bloodGroup";
        public const string PREGNANCY_LENGTH = "pregnancyLength";
        public const string BIRTH_DELIVERY = "birthDelivery";
        public const string HANDEDNESS = "handedness";
        public const string STUDENT_NUMBER = "studentNumber";
        public const string PRIMARY_GUARDIANS_SALUTATION = "primaryGuardiansSalutation";
        public const string PRIMARY_GUARDIANS_ADDRESSEE = "primaryGuardiansAddressee";
        public const string LEGACY_SYSTEM_ID = "legacySystemId";

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
        	query.setResourceType ("Student");
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
        	return (Student) gateway.retrieve(ResourceType.STUDENT, id);
        }

        public int getUniqueLearnerNumber ()
        {
            return Convert.ToInt32(this.getProperty("uniqueLearnerNumber"));
        }

        public void setUniqueLearnerNumber (int uniqueLearnerNumber)
        {
            this.setProperty("uniqueLearnerNumber", uniqueLearnerNumber);
        }

        public LocalAuthority getResponsibleLocalAuthority ()
        {
            return (LocalAuthority) this.getProperty("responsibleLocalAuthority");
        }

        public void setResponsibleLocalAuthority (LocalAuthority responsibleLocalAuthority)
        {
            this.setProperty("responsibleLocalAuthority", responsibleLocalAuthority);
        }

        public LocalAuthority getHomeLocalAuthority ()
        {
            return (LocalAuthority) this.getProperty("homeLocalAuthority");
        }

        public void setHomeLocalAuthority (LocalAuthority homeLocalAuthority)
        {
            this.setProperty("homeLocalAuthority", homeLocalAuthority);
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

        public Person getPerson ()
        {
            return (Person) this.getProperty("person");
        }

        public void setPerson (Person person)
        {
            this.setProperty("person", person);
        }

        public Religion getReligion ()
        {
            return (Religion) this.getProperty("religion");
        }

        public void setReligion (Religion religion)
        {
            this.setProperty("religion", religion);
        }

        public Ethnicity getEthnicity ()
        {
            return (Ethnicity) this.getProperty("ethnicity");
        }

        public void setEthnicity (Ethnicity ethnicity)
        {
            this.setProperty("ethnicity", ethnicity);
        }

        public string getBloodGroup ()
        {
            return this.getProperty("bloodGroup").ToString();
        }

        public void setBloodGroup (string bloodGroup)
        {
            this.setProperty("bloodGroup", bloodGroup);
        }

        public string getPregnancyLength ()
        {
            return this.getProperty("pregnancyLength").ToString();
        }

        public void setPregnancyLength (string pregnancyLength)
        {
            this.setProperty("pregnancyLength", pregnancyLength);
        }

        public string getBirthDelivery ()
        {
            return this.getProperty("birthDelivery").ToString();
        }

        public void setBirthDelivery (string birthDelivery)
        {
            this.setProperty("birthDelivery", birthDelivery);
        }

        public string getHandedness ()
        {
            return this.getProperty("handedness").ToString();
        }

        public void setHandedness (string handedness)
        {
            this.setProperty("handedness", handedness);
        }

        public string getStudentNumber ()
        {
            return this.getProperty("studentNumber").ToString();
        }

        public void setStudentNumber (string studentNumber)
        {
            this.setProperty("studentNumber", studentNumber);
        }

        public string getPrimaryGuardiansSalutation ()
        {
            return this.getProperty("primaryGuardiansSalutation").ToString();
        }

        public void setPrimaryGuardiansSalutation (string primaryGuardiansSalutation)
        {
            this.setProperty("primaryGuardiansSalutation", primaryGuardiansSalutation);
        }

        public string getPrimaryGuardiansAddressee ()
        {
            return this.getProperty("primaryGuardiansAddressee").ToString();
        }

        public void setPrimaryGuardiansAddressee (string primaryGuardiansAddressee)
        {
            this.setProperty("primaryGuardiansAddressee", primaryGuardiansAddressee);
        }

        public string getLegacySystemId ()
        {
            return this.getProperty("legacySystemId").ToString();
        }

        public void setLegacySystemId (string legacySystemId)
        {
            this.setProperty("legacySystemId", legacySystemId);
        }


    }
}

