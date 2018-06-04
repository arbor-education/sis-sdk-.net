using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ApplicationApplicantImportJob : ModelBase
    {
        protected string resourceType = ResourceType.APPLICATION_APPLICANT_IMPORT_JOB;
        public const string INTAKE_SEASON = "intakeSeason";
        public const string INTAKE_SEASON_APPLICANT_BUCKET = "intakeSeasonApplicantBucket";
        public const string INTAKE_SEASON_GROUP = "intakeSeasonGroup";
        public const string GENDER = "gender";
        public const string ACADEMIC_LEVEL = "academicLevel";
        public const string REGISTRATION_FORM = "registrationForm";
        public const string HOUSE = "house";
        public const string APPLICATION_DATE = "applicationDate";
        public const string EXPECTED_ADMISSION_DATE = "expectedAdmissionDate";
        public const string BUCKET_SCORE = "bucketScore";
        public const string START_DATETIME = "startDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";

        public ApplicationApplicantImportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ApplicationApplicantImportJob (string resourceType = "ApplicationApplicantImportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ApplicationApplicantImportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ApplicationApplicantImportJob");
        	RestGateway gateway = (RestGateway) ApplicationApplicantImportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ApplicationApplicantImportJob> applicationapplicantimportjobCollection = new ModelCollection<ApplicationApplicantImportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    applicationapplicantimportjobCollection.add((ApplicationApplicantImportJob) model);
        	}
        
        	return applicationapplicantimportjobCollection;
        }

        public static ApplicationApplicantImportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ApplicationApplicantImportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ApplicationApplicantImportJob) gateway.retrieve(ResourceType.APPLICATION_APPLICANT_IMPORT_JOB, id);
        }

        public IntakeSeason getIntakeSeason ()
        {
            return (IntakeSeason) this.getProperty("intakeSeason");
        }

        public void setIntakeSeason (IntakeSeason intakeSeason)
        {
            this.setProperty("intakeSeason", intakeSeason);
        }

        public IntakeSeasonApplicantBucket getIntakeSeasonApplicantBucket ()
        {
            return (IntakeSeasonApplicantBucket) this.getProperty("intakeSeasonApplicantBucket");
        }

        public void setIntakeSeasonApplicantBucket (IntakeSeasonApplicantBucket intakeSeasonApplicantBucket)
        {
            this.setProperty("intakeSeasonApplicantBucket", intakeSeasonApplicantBucket);
        }

        public IntakeSeasonGroup getIntakeSeasonGroup ()
        {
            return (IntakeSeasonGroup) this.getProperty("intakeSeasonGroup");
        }

        public void setIntakeSeasonGroup (IntakeSeasonGroup intakeSeasonGroup)
        {
            this.setProperty("intakeSeasonGroup", intakeSeasonGroup);
        }

        public Gender getGender ()
        {
            return (Gender) this.getProperty("gender");
        }

        public void setGender (Gender gender)
        {
            this.setProperty("gender", gender);
        }

        public AcademicLevel getAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("academicLevel");
        }

        public void setAcademicLevel (AcademicLevel academicLevel)
        {
            this.setProperty("academicLevel", academicLevel);
        }

        public RegistrationForm getRegistrationForm ()
        {
            return (RegistrationForm) this.getProperty("registrationForm");
        }

        public void setRegistrationForm (RegistrationForm registrationForm)
        {
            this.setProperty("registrationForm", registrationForm);
        }

        public House getHouse ()
        {
            return (House) this.getProperty("house");
        }

        public void setHouse (House house)
        {
            this.setProperty("house", house);
        }

        public DateTime getApplicationDate ()
        {
            return (DateTime) this.getProperty("applicationDate");
        }

        public void setApplicationDate (DateTime applicationDate)
        {
            this.setProperty("applicationDate", applicationDate);
        }

        public DateTime getExpectedAdmissionDate ()
        {
            return (DateTime) this.getProperty("expectedAdmissionDate");
        }

        public void setExpectedAdmissionDate (DateTime expectedAdmissionDate)
        {
            this.setProperty("expectedAdmissionDate", expectedAdmissionDate);
        }

        public int getBucketScore ()
        {
            return Convert.ToInt32(this.getProperty("bucketScore"));
        }

        public void setBucketScore (int bucketScore)
        {
            this.setProperty("bucketScore", bucketScore);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getCompletedDatetime ()
        {
            return (DateTime) this.getProperty("completedDatetime");
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }


    }
}

