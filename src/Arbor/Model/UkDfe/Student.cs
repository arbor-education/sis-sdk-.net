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
        protected new string resourceType = ResourceType.UK_DFE_STUDENT;
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

        public Student()
        {
            base.resourceType = this.resourceType;
        }

        public Student(string resourceType = "Student", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Student> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_Student");
            RestGateway gateway = (RestGateway)Student.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Student> studentCollection = new ModelCollection<Student>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studentCollection.add((Student)model);
            }

            return studentCollection;
        }

        public static Student retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Student.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Student)gateway.retrieve(ResourceType.UK_DFE_STUDENT, id);
        }

        public int getUniqueLearnerNumber()
        {
            return Convert.ToInt32(this.getProperty("uniqueLearnerNumber"));
        }

        public void setUniqueLearnerNumber(int uniqueLearnerNumber)
        {
            this.setProperty("uniqueLearnerNumber", uniqueLearnerNumber);
        }

        public LocalAuthority getHomeLocalAuthority()
        {
            return (LocalAuthority)this.getProperty("homeLocalAuthority");
        }

        public void setHomeLocalAuthority(LocalAuthority homeLocalAuthority)
        {
            this.setProperty("homeLocalAuthority", homeLocalAuthority);
        }

        public string getYouthSupportServicesAgreement()
        {
            return this.getProperty("youthSupportServicesAgreement").ToString();
        }

        public void setYouthSupportServicesAgreement(string youthSupportServicesAgreement)
        {
            this.setProperty("youthSupportServicesAgreement", youthSupportServicesAgreement);
        }

        public string getHoursAtSetting()
        {
            return this.getProperty("hoursAtSetting").ToString();
        }

        public void setHoursAtSetting(string hoursAtSetting)
        {
            this.setProperty("hoursAtSetting", hoursAtSetting);
        }

        public string getFundedHours()
        {
            return this.getProperty("fundedHours").ToString();
        }

        public void setFundedHours(string fundedHours)
        {
            this.setProperty("fundedHours", fundedHours);
        }

        public string getEthnicitySource()
        {
            return this.getProperty("ethnicitySource").ToString();
        }

        public void setEthnicitySource(string ethnicitySource)
        {
            this.setProperty("ethnicitySource", ethnicitySource);
        }

        public string getNhsNumber()
        {
            return this.getProperty("nhsNumber").ToString();
        }

        public void setNhsNumber(string nhsNumber)
        {
            this.setProperty("nhsNumber", nhsNumber);
        }

        public string getUcasPersonalIdentifier()
        {
            return this.getProperty("ucasPersonalIdentifier").ToString();
        }

        public void setUcasPersonalIdentifier(string ucasPersonalIdentifier)
        {
            this.setProperty("ucasPersonalIdentifier", ucasPersonalIdentifier);
        }

        public string getExtendedHours()
        {
            return this.getProperty("extendedHours").ToString();
        }

        public void setExtendedHours(string extendedHours)
        {
            this.setProperty("extendedHours", extendedHours);
        }

        public string getThirtyHourCode()
        {
            return this.getProperty("thirtyHourCode").ToString();
        }

        public void setThirtyHourCode(string thirtyHourCode)
        {
            this.setProperty("thirtyHourCode", thirtyHourCode);
        }

        public string getGcseEnglishGrade()
        {
            return this.getProperty("gcseEnglishGrade").ToString();
        }

        public void setGcseEnglishGrade(string gcseEnglishGrade)
        {
            this.setProperty("gcseEnglishGrade", gcseEnglishGrade);
        }

        public string getGcseEnglishGradePrior()
        {
            return this.getProperty("gcseEnglishGradePrior").ToString();
        }

        public void setGcseEnglishGradePrior(string gcseEnglishGradePrior)
        {
            this.setProperty("gcseEnglishGradePrior", gcseEnglishGradePrior);
        }

        public GcseEnglishAchievementType getGcseEnglishAchievementType()
        {
            return (GcseEnglishAchievementType)this.getProperty("gcseEnglishAchievementType");
        }

        public void setGcseEnglishAchievementType(GcseEnglishAchievementType gcseEnglishAchievementType)
        {
            this.setProperty("gcseEnglishAchievementType", gcseEnglishAchievementType);
        }

        public GcseEnglishFundingExemptionType getGcseEnglishFundingExemptionType()
        {
            return (GcseEnglishFundingExemptionType)this.getProperty("gcseEnglishFundingExemptionType");
        }

        public void setGcseEnglishFundingExemptionType(GcseEnglishFundingExemptionType gcseEnglishFundingExemptionType)
        {
            this.setProperty("gcseEnglishFundingExemptionType", gcseEnglishFundingExemptionType);
        }

        public string getGcseMathsGrade()
        {
            return this.getProperty("gcseMathsGrade").ToString();
        }

        public void setGcseMathsGrade(string gcseMathsGrade)
        {
            this.setProperty("gcseMathsGrade", gcseMathsGrade);
        }

        public string getGcseMathsGradePrior()
        {
            return this.getProperty("gcseMathsGradePrior").ToString();
        }

        public void setGcseMathsGradePrior(string gcseMathsGradePrior)
        {
            this.setProperty("gcseMathsGradePrior", gcseMathsGradePrior);
        }

        public GcseMathsAchievementType getGcseMathsAchievementType()
        {
            return (GcseMathsAchievementType)this.getProperty("gcseMathsAchievementType");
        }

        public void setGcseMathsAchievementType(GcseMathsAchievementType gcseMathsAchievementType)
        {
            this.setProperty("gcseMathsAchievementType", gcseMathsAchievementType);
        }

        public GcseMathsFundingExemptionType getGcseMathsFundingExemptionType()
        {
            return (GcseMathsFundingExemptionType)this.getProperty("gcseMathsFundingExemptionType");
        }

        public void setGcseMathsFundingExemptionType(GcseMathsFundingExemptionType gcseMathsFundingExemptionType)
        {
            this.setProperty("gcseMathsFundingExemptionType", gcseMathsFundingExemptionType);
        }

        public int getTLevelPlannedEepHours()
        {
            return Convert.ToInt32(this.getProperty("tLevelPlannedEepHours"));
        }

        public void setTLevelPlannedEepHours(int tLevelPlannedEepHours)
        {
            this.setProperty("tLevelPlannedEepHours", tLevelPlannedEepHours);
        }


    }
}

