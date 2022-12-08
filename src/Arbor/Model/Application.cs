using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Application : ModelBase
    {
        protected string resourceType = ResourceType.APPLICATION;
        public const string STUDENT = "student";
        public const string APPLICATION_DATETIME = "applicationDatetime";
        public const string APPLICATION_REFERENCE_NUMBER = "applicationReferenceNumber";
        public const string INTAKE_SEASON = "intakeSeason";
        public const string APPLICANT_BUCKET = "applicantBucket";
        public const string BUCKET_SCORE = "bucketScore";
        public const string WITHDRAWN_DATETIME = "withdrawnDatetime";
        public const string WITHDRAWAL_REASON = "withdrawalReason";
        public const string REJECTED_DATETIME = "rejectedDatetime";
        public const string INTAKE_SEASON_GROUP = "intakeSeasonGroup";
        public const string OFFERED_DATETIME = "offeredDatetime";
        public const string ACCEPTED_DATETIME = "acceptedDatetime";
        public const string EXPECTED_ADMISSION_DATE = "expectedAdmissionDate";
        public const string EXPECTED_ACADEMIC_LEVEL = "expectedAcademicLevel";
        public const string EXPECTED_REGISTRATION_FORM = "expectedRegistrationForm";
        public const string EXPECTED_HOUSE = "expectedHouse";
        public const string ENROLLED_DATETIME = "enrolledDatetime";

        public Application()
        {
            base.resourceType = this.resourceType;
        }

        public Application(string resourceType = "Application", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Application> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Application");
            RestGateway gateway = (RestGateway)Application.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Application> applicationCollection = new ModelCollection<Application>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                applicationCollection.add((Application)model);
            }

            return applicationCollection;
        }

        public static Application retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Application.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Application)gateway.retrieve(ResourceType.APPLICATION, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getApplicationDatetime()
        {
            return Convert.ToDateTime(this.getProperty("applicationDatetime"));
        }

        public void setApplicationDatetime(DateTime applicationDatetime)
        {
            this.setProperty("applicationDatetime", applicationDatetime);
        }

        public string getApplicationReferenceNumber()
        {
            return this.getProperty("applicationReferenceNumber").ToString();
        }

        public void setApplicationReferenceNumber(string applicationReferenceNumber)
        {
            this.setProperty("applicationReferenceNumber", applicationReferenceNumber);
        }

        public IntakeSeason getIntakeSeason()
        {
            return (IntakeSeason)this.getProperty("intakeSeason");
        }

        public void setIntakeSeason(IntakeSeason intakeSeason)
        {
            this.setProperty("intakeSeason", intakeSeason);
        }

        public IntakeSeasonApplicantBucket getApplicantBucket()
        {
            return (IntakeSeasonApplicantBucket)this.getProperty("applicantBucket");
        }

        public void setApplicantBucket(IntakeSeasonApplicantBucket applicantBucket)
        {
            this.setProperty("applicantBucket", applicantBucket);
        }

        public float getBucketScore()
        {
            return (float)this.getProperty("bucketScore");
        }

        public void setBucketScore(float bucketScore)
        {
            this.setProperty("bucketScore", bucketScore);
        }

        public DateTime getWithdrawnDatetime()
        {
            return Convert.ToDateTime(this.getProperty("withdrawnDatetime"));
        }

        public void setWithdrawnDatetime(DateTime withdrawnDatetime)
        {
            this.setProperty("withdrawnDatetime", withdrawnDatetime);
        }

        public ApplicationWithdrawalReason getWithdrawalReason()
        {
            return (ApplicationWithdrawalReason)this.getProperty("withdrawalReason");
        }

        public void setWithdrawalReason(ApplicationWithdrawalReason withdrawalReason)
        {
            this.setProperty("withdrawalReason", withdrawalReason);
        }

        public DateTime getRejectedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("rejectedDatetime"));
        }

        public void setRejectedDatetime(DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }

        public IntakeSeasonGroup getIntakeSeasonGroup()
        {
            return (IntakeSeasonGroup)this.getProperty("intakeSeasonGroup");
        }

        public void setIntakeSeasonGroup(IntakeSeasonGroup intakeSeasonGroup)
        {
            this.setProperty("intakeSeasonGroup", intakeSeasonGroup);
        }

        public DateTime getOfferedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("offeredDatetime"));
        }

        public void setOfferedDatetime(DateTime offeredDatetime)
        {
            this.setProperty("offeredDatetime", offeredDatetime);
        }

        public DateTime getAcceptedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("acceptedDatetime"));
        }

        public void setAcceptedDatetime(DateTime acceptedDatetime)
        {
            this.setProperty("acceptedDatetime", acceptedDatetime);
        }

        public DateTime getExpectedAdmissionDate()
        {
            return Convert.ToDateTime(this.getProperty("expectedAdmissionDate"));
        }

        public void setExpectedAdmissionDate(DateTime expectedAdmissionDate)
        {
            this.setProperty("expectedAdmissionDate", expectedAdmissionDate);
        }

        public AcademicLevel getExpectedAcademicLevel()
        {
            return (AcademicLevel)this.getProperty("expectedAcademicLevel");
        }

        public void setExpectedAcademicLevel(AcademicLevel expectedAcademicLevel)
        {
            this.setProperty("expectedAcademicLevel", expectedAcademicLevel);
        }

        public RegistrationForm getExpectedRegistrationForm()
        {
            return (RegistrationForm)this.getProperty("expectedRegistrationForm");
        }

        public void setExpectedRegistrationForm(RegistrationForm expectedRegistrationForm)
        {
            this.setProperty("expectedRegistrationForm", expectedRegistrationForm);
        }

        public House getExpectedHouse()
        {
            return (House)this.getProperty("expectedHouse");
        }

        public void setExpectedHouse(House expectedHouse)
        {
            this.setProperty("expectedHouse", expectedHouse);
        }

        public DateTime getEnrolledDatetime()
        {
            return Convert.ToDateTime(this.getProperty("enrolledDatetime"));
        }

        public void setEnrolledDatetime(DateTime enrolledDatetime)
        {
            this.setProperty("enrolledDatetime", enrolledDatetime);
        }


    }
}

