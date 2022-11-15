using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OptionsImportResult : ModelBase
    {
        protected new string resourceType = ResourceType.OPTIONS_IMPORT_RESULT;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string STEPS_COMPLETED = "stepsCompleted";
        public const string STEP_IN_PROGRESS = "stepInProgress";
        public const string STARTED_DATETIME = "startedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string ENROLMENT_START_DATE = "enrolmentStartDate";
        public const string ENROLMENT_END_DATE = "enrolmentEndDate";

        public OptionsImportResult()
        {
            base.resourceType = this.resourceType;
        }

        public OptionsImportResult(string resourceType = "OptionsImportResult", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<OptionsImportResult> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("OptionsImportResult");
            RestGateway gateway = (RestGateway)OptionsImportResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<OptionsImportResult> optionsimportresultCollection = new ModelCollection<OptionsImportResult>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                optionsimportresultCollection.add((OptionsImportResult)model);
            }

            return optionsimportresultCollection;
        }

        public static OptionsImportResult retrieve(string id)
        {
            RestGateway gateway = (RestGateway)OptionsImportResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (OptionsImportResult)gateway.retrieve(ResourceType.OPTIONS_IMPORT_RESULT, id);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public int getStepsCompleted()
        {
            return Convert.ToInt32(this.getProperty("stepsCompleted"));
        }

        public void setStepsCompleted(int stepsCompleted)
        {
            this.setProperty("stepsCompleted", stepsCompleted);
        }

        public int getStepInProgress()
        {
            return Convert.ToInt32(this.getProperty("stepInProgress"));
        }

        public void setStepInProgress(int stepInProgress)
        {
            this.setProperty("stepInProgress", stepInProgress);
        }

        public DateTime getStartedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("startedDatetime"));
        }

        public void setStartedDatetime(DateTime startedDatetime)
        {
            this.setProperty("startedDatetime", startedDatetime);
        }

        public DateTime getCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime(DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public DateTime getEnrolmentStartDate()
        {
            return Convert.ToDateTime(this.getProperty("enrolmentStartDate"));
        }

        public void setEnrolmentStartDate(DateTime enrolmentStartDate)
        {
            this.setProperty("enrolmentStartDate", enrolmentStartDate);
        }

        public DateTime getEnrolmentEndDate()
        {
            return Convert.ToDateTime(this.getProperty("enrolmentEndDate"));
        }

        public void setEnrolmentEndDate(DateTime enrolmentEndDate)
        {
            this.setProperty("enrolmentEndDate", enrolmentEndDate);
        }


    }
}

