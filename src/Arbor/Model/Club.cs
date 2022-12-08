using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Club : ModelBase
    {
        protected string resourceType = ResourceType.CLUB;
        public const string NAME = "name";
        public const string DESCRIPTION = "description";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string MAX_MEMBERS_PER_SESSION = "maxMembersPerSession";
        public const string REQUIRE_CONSENT = "requireConsent";
        public const string COPIED_TO_CLUB = "copiedToClub";
        public const string FREE = "free";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string ATTENDANCE_REGISTER_EFFECTIVE_DATE = "attendanceRegisterEffectiveDate";
        public const string ACCOUNTING_CODE = "accountingCode";
        public const string CUSTOMER_ACCOUNT_TYPE = "customerAccountType";
        public const string HAS_MEALS = "hasMeals";
        public const string IS_WRAPAROUND_CHILDCARE_CLUB = "isWraparoundChildcareClub";
        public const string CHARGE_STUDENTS_BASED_ON_ATTENDANCE_MARK = "chargeStudentsBasedOnAttendanceMark";

        public Club()
        {
            base.resourceType = this.resourceType;
        }

        public Club(string resourceType = "Club", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Club> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Club");
            RestGateway gateway = (RestGateway)Club.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Club> clubCollection = new ModelCollection<Club>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                clubCollection.add((Club)model);
            }

            return clubCollection;
        }

        public static Club retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Club.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Club)gateway.retrieve(ResourceType.CLUB, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public int getMaxMembersPerSession()
        {
            return Convert.ToInt32(this.getProperty("maxMembersPerSession"));
        }

        public void setMaxMembersPerSession(int maxMembersPerSession)
        {
            this.setProperty("maxMembersPerSession", maxMembersPerSession);
        }

        public bool getRequireConsent()
        {
            return Convert.ToBoolean(this.getProperty("requireConsent"));
        }

        public void setRequireConsent(bool requireConsent)
        {
            this.setProperty("requireConsent", requireConsent);
        }

        public Club getCopiedToClub()
        {
            return (Club)this.getProperty("copiedToClub");
        }

        public void setCopiedToClub(Club copiedToClub)
        {
            this.setProperty("copiedToClub", copiedToClub);
        }

        public bool getFree()
        {
            return Convert.ToBoolean(this.getProperty("free"));
        }

        public void setFree(bool free)
        {
            this.setProperty("free", free);
        }

        public AttendanceRegisterType getAttendanceRegisterType()
        {
            return (AttendanceRegisterType)this.getProperty("attendanceRegisterType");
        }

        public void setAttendanceRegisterType(AttendanceRegisterType attendanceRegisterType)
        {
            this.setProperty("attendanceRegisterType", attendanceRegisterType);
        }

        public DateTime getAttendanceRegisterEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("attendanceRegisterEffectiveDate"));
        }

        public void setAttendanceRegisterEffectiveDate(DateTime attendanceRegisterEffectiveDate)
        {
            this.setProperty("attendanceRegisterEffectiveDate", attendanceRegisterEffectiveDate);
        }

        public string getAccountingCode()
        {
            return this.getProperty("accountingCode").ToString();
        }

        public void setAccountingCode(string accountingCode)
        {
            this.setProperty("accountingCode", accountingCode);
        }

        public CustomerAccountType getCustomerAccountType()
        {
            return (CustomerAccountType)this.getProperty("customerAccountType");
        }

        public void setCustomerAccountType(CustomerAccountType customerAccountType)
        {
            this.setProperty("customerAccountType", customerAccountType);
        }

        public bool getHasMeals()
        {
            return Convert.ToBoolean(this.getProperty("hasMeals"));
        }

        public void setHasMeals(bool hasMeals)
        {
            this.setProperty("hasMeals", hasMeals);
        }

        public bool getIsWraparoundChildcareClub()
        {
            return Convert.ToBoolean(this.getProperty("isWraparoundChildcareClub"));
        }

        public void setIsWraparoundChildcareClub(bool isWraparoundChildcareClub)
        {
            this.setProperty("isWraparoundChildcareClub", isWraparoundChildcareClub);
        }

        public bool getChargeStudentsBasedOnAttendanceMark()
        {
            return Convert.ToBoolean(this.getProperty("chargeStudentsBasedOnAttendanceMark"));
        }

        public void setChargeStudentsBasedOnAttendanceMark(bool chargeStudentsBasedOnAttendanceMark)
        {
            this.setProperty("chargeStudentsBasedOnAttendanceMark", chargeStudentsBasedOnAttendanceMark);
        }


    }
}

