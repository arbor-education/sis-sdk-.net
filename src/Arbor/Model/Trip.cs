using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Trip : ModelBase
    {
        protected new string resourceType = ResourceType.TRIP;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string NAME = "name";
        public const string DESCRIPTION = "description";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string LINK_TO = "linkTo";
        public const string COPIED_TO_TRIP = "copiedToTrip";
        public const string MAX_PARTICIPANTS = "maxParticipants";
        public const string REQUIRE_CONSENT = "requireConsent";
        public const string GUARDIAN_SIGNUP_START_DATETIME = "guardianSignupStartDatetime";
        public const string GUARDIAN_SIGNUP_END_DATETIME = "guardianSignupEndDatetime";
        public const string FREE = "free";
        public const string ATTENDANCE_REGISTER_TYPE = "attendanceRegisterType";
        public const string ACCOUNTING_CODE = "accountingCode";

        public Trip()
        {
            base.resourceType = this.resourceType;
        }

        public Trip(string resourceType = "Trip", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Trip> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Trip");
            RestGateway gateway = (RestGateway)Trip.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Trip> tripCollection = new ModelCollection<Trip>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                tripCollection.add((Trip)model);
            }

            return tripCollection;
        }

        public static Trip retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Trip.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Trip)gateway.retrieve(ResourceType.TRIP, id);
        }

        public DateTime getStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime(DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime(DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public string getLocationText()
        {
            return this.getProperty("locationText").ToString();
        }

        public void setLocationText(string locationText)
        {
            this.setProperty("locationText", locationText);
        }

        public ModelBase getLocation()
        {
            return (ModelBase)this.getProperty("location");
        }

        public void setLocation(ModelBase location)
        {
            this.setProperty("location", location);
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

        public ModelBase getLinkTo()
        {
            return (ModelBase)this.getProperty("linkTo");
        }

        public void setLinkTo(ModelBase linkTo)
        {
            this.setProperty("linkTo", linkTo);
        }

        public Trip getCopiedToTrip()
        {
            return (Trip)this.getProperty("copiedToTrip");
        }

        public void setCopiedToTrip(Trip copiedToTrip)
        {
            this.setProperty("copiedToTrip", copiedToTrip);
        }

        public int getMaxParticipants()
        {
            return Convert.ToInt32(this.getProperty("maxParticipants"));
        }

        public void setMaxParticipants(int maxParticipants)
        {
            this.setProperty("maxParticipants", maxParticipants);
        }

        public bool getRequireConsent()
        {
            return Convert.ToBoolean(this.getProperty("requireConsent"));
        }

        public void setRequireConsent(bool requireConsent)
        {
            this.setProperty("requireConsent", requireConsent);
        }

        public DateTime getGuardianSignupStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("guardianSignupStartDatetime"));
        }

        public void setGuardianSignupStartDatetime(DateTime guardianSignupStartDatetime)
        {
            this.setProperty("guardianSignupStartDatetime", guardianSignupStartDatetime);
        }

        public DateTime getGuardianSignupEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("guardianSignupEndDatetime"));
        }

        public void setGuardianSignupEndDatetime(DateTime guardianSignupEndDatetime)
        {
            this.setProperty("guardianSignupEndDatetime", guardianSignupEndDatetime);
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

        public string getAccountingCode()
        {
            return this.getProperty("accountingCode").ToString();
        }

        public void setAccountingCode(string accountingCode)
        {
            this.setProperty("accountingCode", accountingCode);
        }


    }
}

