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
        protected new string resourceType = ResourceType.STUDENT;
        public const string UNIQUE_LEARNER_NUMBER = "uniqueLearnerNumber";
        public const string HOME_LOCAL_AUTHORITY = "homeLocalAuthority";
        public const string YOUTH_SUPPORT_SERVICES_AGREEMENT = "youthSupportServicesAgreement";
        public const string HOURS_AT_SETTING = "hoursAtSetting";
        public const string FUNDED_HOURS = "fundedHours";
        public const string ETHNICITY_SOURCE = "ethnicitySource";
        public const string NHS_NUMBER = "nhsNumber";
        public const string UCAS_PERSONAL_IDENTIFIER = "ucasPersonalIdentifier";
        public const string EXTENDED_HOURS = "extendedHours";
        public const string THIRTY_HOUR_CODE = "thirtyHourCode";
        public const string GCSE_ENGLISH_GRADE = "gcseEnglishGrade";
        public const string GCSE_ENGLISH_GRADE_PRIOR = "gcseEnglishGradePrior";
        public const string GCSE_ENGLISH_ACHIEVEMENT_TYPE = "gcseEnglishAchievementType";
        public const string GCSE_ENGLISH_FUNDING_EXEMPTION_TYPE = "gcseEnglishFundingExemptionType";
        public const string GCSE_MATHS_GRADE = "gcseMathsGrade";
        public const string GCSE_MATHS_GRADE_PRIOR = "gcseMathsGradePrior";
        public const string GCSE_MATHS_ACHIEVEMENT_TYPE = "gcseMathsAchievementType";
        public const string GCSE_MATHS_FUNDING_EXEMPTION_TYPE = "gcseMathsFundingExemptionType";
        public const string T_LEVEL_PLANNED_EEP_HOURS = "tLevelPlannedEepHours";
        public const string PERSON = "person";
        public const string RELIGION = "religion";
        public const string ETHNICITY = "ethnicity";
        public const string BLOOD_GROUP = "bloodGroup";
        public const string PREGNANCY_LENGTH = "pregnancyLength";
        public const string BIRTH_DELIVERY = "birthDelivery";
        public const string HANDEDNESS = "handedness";
        public const string STUDENT_NUMBER = "studentNumber";
        public const string LEGACY_SYSTEM_ID = "legacySystemId";
        public const string MINIMUM_DATA_RETENTION_DATE = "minimumDataRetentionDate";
        public const string SUSPEND_CALENDAR_ENTRY_MAPPINGS = "suspendCalendarEntryMappings";
        public const string IS_ACTIVE_OUTGOING_SYNC = "isActiveOutgoingSync";
        public const string IS_ACTIVE_INCOMING_SYNC = "isActiveIncomingSync";

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

        public string getUcasPersonalIdentifier ()
        {
            return this.getProperty("ucasPersonalIdentifier").ToString();
        }

        public void setUcasPersonalIdentifier (string ucasPersonalIdentifier)
        {
            this.setProperty("ucasPersonalIdentifier", ucasPersonalIdentifier);
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

        public string getGcseEnglishGrade ()
        {
            return this.getProperty("gcseEnglishGrade").ToString();
        }

        public void setGcseEnglishGrade (string gcseEnglishGrade)
        {
            this.setProperty("gcseEnglishGrade", gcseEnglishGrade);
        }

        public string getGcseEnglishGradePrior ()
        {
            return this.getProperty("gcseEnglishGradePrior").ToString();
        }

        public void setGcseEnglishGradePrior (string gcseEnglishGradePrior)
        {
            this.setProperty("gcseEnglishGradePrior", gcseEnglishGradePrior);
        }

        public GcseEnglishAchievementType getGcseEnglishAchievementType ()
        {
            return (GcseEnglishAchievementType) this.getProperty("gcseEnglishAchievementType");
        }

        public void setGcseEnglishAchievementType (GcseEnglishAchievementType gcseEnglishAchievementType)
        {
            this.setProperty("gcseEnglishAchievementType", gcseEnglishAchievementType);
        }

        public GcseEnglishFundingExemptionType getGcseEnglishFundingExemptionType ()
        {
            return (GcseEnglishFundingExemptionType) this.getProperty("gcseEnglishFundingExemptionType");
        }

        public void setGcseEnglishFundingExemptionType (GcseEnglishFundingExemptionType gcseEnglishFundingExemptionType)
        {
            this.setProperty("gcseEnglishFundingExemptionType", gcseEnglishFundingExemptionType);
        }

        public string getGcseMathsGrade ()
        {
            return this.getProperty("gcseMathsGrade").ToString();
        }

        public void setGcseMathsGrade (string gcseMathsGrade)
        {
            this.setProperty("gcseMathsGrade", gcseMathsGrade);
        }

        public string getGcseMathsGradePrior ()
        {
            return this.getProperty("gcseMathsGradePrior").ToString();
        }

        public void setGcseMathsGradePrior (string gcseMathsGradePrior)
        {
            this.setProperty("gcseMathsGradePrior", gcseMathsGradePrior);
        }

        public GcseMathsAchievementType getGcseMathsAchievementType ()
        {
            return (GcseMathsAchievementType) this.getProperty("gcseMathsAchievementType");
        }

        public void setGcseMathsAchievementType (GcseMathsAchievementType gcseMathsAchievementType)
        {
            this.setProperty("gcseMathsAchievementType", gcseMathsAchievementType);
        }

        public GcseMathsFundingExemptionType getGcseMathsFundingExemptionType ()
        {
            return (GcseMathsFundingExemptionType) this.getProperty("gcseMathsFundingExemptionType");
        }

        public void setGcseMathsFundingExemptionType (GcseMathsFundingExemptionType gcseMathsFundingExemptionType)
        {
            this.setProperty("gcseMathsFundingExemptionType", gcseMathsFundingExemptionType);
        }

        public int getTLevelPlannedEepHours ()
        {
            return Convert.ToInt32(this.getProperty("tLevelPlannedEepHours"));
        }

        public void setTLevelPlannedEepHours (int tLevelPlannedEepHours)
        {
            this.setProperty("tLevelPlannedEepHours", tLevelPlannedEepHours);
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

        public string getLegacySystemId ()
        {
            return this.getProperty("legacySystemId").ToString();
        }

        public void setLegacySystemId (string legacySystemId)
        {
            this.setProperty("legacySystemId", legacySystemId);
        }

        public DateTime getMinimumDataRetentionDate ()
        {
            return Convert.ToDateTime(this.getProperty("minimumDataRetentionDate"));
        }

        public void setMinimumDataRetentionDate (DateTime minimumDataRetentionDate)
        {
            this.setProperty("minimumDataRetentionDate", minimumDataRetentionDate);
        }

        public bool getSuspendCalendarEntryMappings ()
        {
            return Convert.ToBoolean(this.getProperty("suspendCalendarEntryMappings"));
        }

        public void setSuspendCalendarEntryMappings (bool suspendCalendarEntryMappings)
        {
            this.setProperty("suspendCalendarEntryMappings", suspendCalendarEntryMappings);
        }

        public bool getIsActiveOutgoingSync ()
        {
            return Convert.ToBoolean(this.getProperty("isActiveOutgoingSync"));
        }

        public void setIsActiveOutgoingSync (bool isActiveOutgoingSync)
        {
            this.setProperty("isActiveOutgoingSync", isActiveOutgoingSync);
        }

        public bool getIsActiveIncomingSync ()
        {
            return Convert.ToBoolean(this.getProperty("isActiveIncomingSync"));
        }

        public void setIsActiveIncomingSync (bool isActiveIncomingSync)
        {
            this.setProperty("isActiveIncomingSync", isActiveIncomingSync);
        }


    }
}

