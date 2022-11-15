using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AlternativeProvisionPlacement : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_ALTERNATIVE_PROVISION_PLACEMENT;
        public const string STUDENT = "student";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string COMPANY = "company";
        public const string ALTERNATIVE_PROVISION_PLACEMENT_REASON = "alternativeProvisionPlacementReason";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string SETTING_TYPE = "settingType";
        public const string ATTENDANCE_PATTERN = "attendancePattern";
        public const string SESSIONS_PER_WEEK = "sessionsPerWeek";

        public AlternativeProvisionPlacement()
        {
            base.resourceType = this.resourceType;
        }

        public AlternativeProvisionPlacement(string resourceType = "AlternativeProvisionPlacement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AlternativeProvisionPlacement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_AlternativeProvisionPlacement");
            RestGateway gateway = (RestGateway)AlternativeProvisionPlacement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AlternativeProvisionPlacement> alternativeprovisionplacementCollection = new ModelCollection<AlternativeProvisionPlacement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                alternativeprovisionplacementCollection.add((AlternativeProvisionPlacement)model);
            }

            return alternativeprovisionplacementCollection;
        }

        public static AlternativeProvisionPlacement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AlternativeProvisionPlacement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AlternativeProvisionPlacement)gateway.retrieve(ResourceType.UK_DFE_ALTERNATIVE_PROVISION_PLACEMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public EducationalInstitution getEducationalInstitution()
        {
            return (EducationalInstitution)this.getProperty("educationalInstitution");
        }

        public void setEducationalInstitution(EducationalInstitution educationalInstitution)
        {
            this.setProperty("educationalInstitution", educationalInstitution);
        }

        public Company getCompany()
        {
            return (Company)this.getProperty("company");
        }

        public void setCompany(Company company)
        {
            this.setProperty("company", company);
        }

        public AlternativeProvisionPlacementReason getAlternativeProvisionPlacementReason()
        {
            return (AlternativeProvisionPlacementReason)this.getProperty("alternativeProvisionPlacementReason");
        }

        public void setAlternativeProvisionPlacementReason(AlternativeProvisionPlacementReason alternativeProvisionPlacementReason)
        {
            this.setProperty("alternativeProvisionPlacementReason", alternativeProvisionPlacementReason);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getSettingType()
        {
            return this.getProperty("settingType").ToString();
        }

        public void setSettingType(string settingType)
        {
            this.setProperty("settingType", settingType);
        }

        public string getAttendancePattern()
        {
            return this.getProperty("attendancePattern").ToString();
        }

        public void setAttendancePattern(string attendancePattern)
        {
            this.setProperty("attendancePattern", attendancePattern);
        }

        public int getSessionsPerWeek()
        {
            return Convert.ToInt32(this.getProperty("sessionsPerWeek"));
        }

        public void setSessionsPerWeek(int sessionsPerWeek)
        {
            this.setProperty("sessionsPerWeek", sessionsPerWeek);
        }


    }
}

