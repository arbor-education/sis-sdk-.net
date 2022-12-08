using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;
using System.Collections;

namespace Arbor.Model
{
    public class AcademicUnit : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_UNIT;
        public const string UNIQUE_IDENTIFIER = "uniqueIdentifier";
        public const string PARENT_ACADEMIC_UNIT = "parentAcademicUnit";
        public const string ACADEMIC_PROGRAMME_INSTANCE = "academicProgrammeInstance";
        public const string ACADEMIC_UNIT_NAME = "academicUnitName";
        public const string LONG_NAME = "longName";
        public const string LONG_NAME_FORMAT = "longNameFormat";
        public const string SHORT_NAME = "shortName";
        public const string SHORT_NAME_FORMAT = "shortNameFormat";
        public const string ACADEMIC_UNIT_CODE = "academicUnitCode";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string PROMOTED_TO_ACADEMIC_UNIT = "promotedToAcademicUnit";
        public const string PROMOTED_DATETIME = "promotedDatetime";
        public const string COPIED_TO_ACADEMIC_UNIT = "copiedToAcademicUnit";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string FACULTY = "faculty";
        public const string SELF_SERVICE_ENROLMENT = "selfServiceEnrolment";
        public const string MAXIMUM_ENROLMENTS = "maximumEnrolments";
        public const string TARGET_ENROLMENTS = "targetEnrolments";
        public const string SUBJECT = "subject";
        public const string ACADEMIC_LEVEL = "academicLevel";
        public const string REGISTRATION_FORM = "registrationForm";
        public const string IS_MAIN_ASSESSABLE_UNIT = "isMainAssessableUnit";
        public const string DISPLAY_ORDER = "displayOrder";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string PROMOTED_ENROLMENT_START_DATE = "promotedEnrolmentStartDate";
        public const string PROMOTED_ENROLMENT_END_DATE = "promotedEnrolmentEndDate";

        public AcademicUnit()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnit(string resourceType = "AcademicUnit", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnit> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnit");
            RestGateway gateway = (RestGateway)AcademicUnit.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnit> academicunitCollection = new ModelCollection<AcademicUnit>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitCollection.add((AcademicUnit)model);
            }

            return academicunitCollection;
        }

        public static AcademicUnit retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnit.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnit)gateway.retrieve(ResourceType.ACADEMIC_UNIT, id);
        }

        public string getUniqueIdentifier()
        {
            return this.getProperty("uniqueIdentifier").ToString();
        }

        public void setUniqueIdentifier(string uniqueIdentifier)
        {
            this.setProperty("uniqueIdentifier", uniqueIdentifier);
        }

        public AcademicUnit getParentAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("parentAcademicUnit");
        }

        public void setParentAcademicUnit(AcademicUnit parentAcademicUnit)
        {
            this.setProperty("parentAcademicUnit", parentAcademicUnit);
        }

        public AcademicProgrammeInstance getAcademicProgrammeInstance()
        {
            return (AcademicProgrammeInstance)this.getProperty("academicProgrammeInstance");
        }

        public void setAcademicProgrammeInstance(AcademicProgrammeInstance academicProgrammeInstance)
        {
            this.setProperty("academicProgrammeInstance", academicProgrammeInstance);
        }

        public string getAcademicUnitName()
        {
            return this.getProperty("academicUnitName").ToString();
        }

        public void setAcademicUnitName(string academicUnitName)
        {
            this.setProperty("academicUnitName", academicUnitName);
        }

        public string getLongName()
        {
            return this.getProperty("longName").ToString();
        }

        public void setLongName(string longName)
        {
            this.setProperty("longName", longName);
        }

        public string getLongNameFormat()
        {
            return this.getProperty("longNameFormat").ToString();
        }

        public void setLongNameFormat(string longNameFormat)
        {
            this.setProperty("longNameFormat", longNameFormat);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getShortNameFormat()
        {
            return this.getProperty("shortNameFormat").ToString();
        }

        public void setShortNameFormat(string shortNameFormat)
        {
            this.setProperty("shortNameFormat", shortNameFormat);
        }

        public string getAcademicUnitCode()
        {
            return this.getProperty("academicUnitCode").ToString();
        }

        public void setAcademicUnitCode(string academicUnitCode)
        {
            this.setProperty("academicUnitCode", academicUnitCode);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public AcademicUnit getPromotedToAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("promotedToAcademicUnit");
        }

        public void setPromotedToAcademicUnit(AcademicUnit promotedToAcademicUnit)
        {
            this.setProperty("promotedToAcademicUnit", promotedToAcademicUnit);
        }

        public DateTime getPromotedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("promotedDatetime"));
        }

        public void setPromotedDatetime(DateTime promotedDatetime)
        {
            this.setProperty("promotedDatetime", promotedDatetime);
        }

        public AcademicUnit getCopiedToAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("copiedToAcademicUnit");
        }

        public void setCopiedToAcademicUnit(AcademicUnit copiedToAcademicUnit)
        {
            this.setProperty("copiedToAcademicUnit", copiedToAcademicUnit);
        }

        public DateTime getEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate(DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public Faculty getFaculty()
        {
            return (Faculty)this.getProperty("faculty");
        }

        public void setFaculty(Faculty faculty)
        {
            this.setProperty("faculty", faculty);
        }

        public bool getSelfServiceEnrolment()
        {
            return Convert.ToBoolean(this.getProperty("selfServiceEnrolment"));
        }

        public void setSelfServiceEnrolment(bool selfServiceEnrolment)
        {
            this.setProperty("selfServiceEnrolment", selfServiceEnrolment);
        }

        public int getMaximumEnrolments()
        {
            return Convert.ToInt32(this.getProperty("maximumEnrolments"));
        }

        public void setMaximumEnrolments(int maximumEnrolments)
        {
            this.setProperty("maximumEnrolments", maximumEnrolments);
        }

        public int getTargetEnrolments()
        {
            return Convert.ToInt32(this.getProperty("targetEnrolments"));
        }

        public void setTargetEnrolments(int targetEnrolments)
        {
            this.setProperty("targetEnrolments", targetEnrolments);
        }

        public Subject getSubject()
        {
            return (Subject)this.getProperty("subject");
        }

        public void setSubject(Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public AcademicLevel getAcademicLevel()
        {
            return (AcademicLevel)this.getProperty("academicLevel");
        }

        public void setAcademicLevel(AcademicLevel academicLevel)
        {
            this.setProperty("academicLevel", academicLevel);
        }

        public RegistrationForm getRegistrationForm()
        {
            return (RegistrationForm)this.getProperty("registrationForm");
        }

        public void setRegistrationForm(RegistrationForm registrationForm)
        {
            this.setProperty("registrationForm", registrationForm);
        }

        public bool getIsMainAssessableUnit()
        {
            return Convert.ToBoolean(this.getProperty("isMainAssessableUnit"));
        }

        public void setIsMainAssessableUnit(bool isMainAssessableUnit)
        {
            this.setProperty("isMainAssessableUnit", isMainAssessableUnit);
        }

        public int getDisplayOrder()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder(int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }

        public AttendanceRegisterType getAttendanceRegisterType()
        {
            return (AttendanceRegisterType)this.getProperty("attendanceRegisterType");
        }

        public void setAttendanceRegisterType(AttendanceRegisterType attendanceRegisterType)
        {
            this.setProperty("attendanceRegisterType", attendanceRegisterType);
        }

        public DateTime getPromotedEnrolmentStartDate()
        {
            return Convert.ToDateTime(this.getProperty("promotedEnrolmentStartDate"));
        }

        public void setPromotedEnrolmentStartDate(DateTime promotedEnrolmentStartDate)
        {
            this.setProperty("promotedEnrolmentStartDate", promotedEnrolmentStartDate);
        }

        public DateTime getPromotedEnrolmentEndDate()
        {
            return Convert.ToDateTime(this.getProperty("promotedEnrolmentEndDate"));
        }

        public void setPromotedEnrolmentEndDate(DateTime promotedEnrolmentEndDate)
        {
            this.setProperty("promotedEnrolmentEndDate", promotedEnrolmentEndDate);
        }

        public ModelCollection<AcademicUnitCurriculum> getAcademicUnitCurriculums()
        {
            ModelCollection<ModelBase> collection = (ModelCollection<ModelBase>)this.getCollectionProperty("academicUnitCurriculums");
            return (ModelCollection<AcademicUnitCurriculum>)this.getApiGateway().castCollection<AcademicUnitCurriculum>(collection);
        }

        public ModelCollection<TimetableSlot> getTimetableSlots()
        {
            ModelCollection<ModelBase> collection = (ModelCollection<ModelBase>)this.getCollectionProperty("timetableSlots");
            return (ModelCollection<TimetableSlot>)this.getApiGateway().castCollection<TimetableSlot>(collection);
        }


    }
}

