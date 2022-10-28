using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewReportCardBatch : ModelBase
    {
        protected new string resourceType = ResourceType.NEW_REPORT_CARD_BATCH;
        public const string REPORT_CARD_TEMPLATE = "reportCardTemplate";
        public const string REPORT_CARD_TITLE = "reportCardTitle";
        public const string GENERAL_SETTINGS_JSON = "generalSettingsJson";
        public const string REPORT_CARD_DATE = "reportCardDate";
        public const string ATTAINMENT_SETTINGS_JSON = "attainmentSettingsJson";
        public const string ASSESSMENT_PERIOD_START_DATE = "assessmentPeriodStartDate";
        public const string ASSESSMENT_PERIOD_END_DATE = "assessmentPeriodEndDate";
        public const string DUE_DATE = "dueDate";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string INCLUDE_TEACHER_INITIALS = "includeTeacherInitials";
        public const string INCLUDE_TEACHER_NAME = "includeTeacherName";
        public const string INCLUDE_STUDENT_PHOTO = "includeStudentPhoto";
        public const string INCLUDE_BASELINE = "includeBaseline";
        public const string INCLUDE_WORKING_AT_CURRENT_PERIOD = "includeWorkingAtCurrentPeriod";
        public const string INCLUDE_WORKING_AT_PREVIOUS_PERIOD = "includeWorkingAtPreviousPeriod";
        public const string PREVIOUS_PERIOD_MEANING = "previousPeriodMeaning";
        public const string INCLUDE_TEACHER_TARGET = "includeTeacherTarget";
        public const string FINALIZED_DATETIME = "finalizedDatetime";
        public const string FINALIZATION_IN_PROGRESS = "finalizationInProgress";
        public const string SHARED_WITH_GUARDIANS = "sharedWithGuardians";
        public const string SHARED_WITH_STUDENTS = "sharedWithStudents";
        public const string BEHAVIOUR_FIELDS = "behaviourFields";
        public const string ATTENDANCE_FIELDS = "attendanceFields";
        public const string SHOW_COMMENTS = "showComments";
        public const string CUSTOM_DISPLAY_NAMES_JSON = "customDisplayNamesJson";

        public NewReportCardBatch()
        {
            base.resourceType = this.resourceType;
        }

        public NewReportCardBatch(string resourceType = "NewReportCardBatch", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<NewReportCardBatch> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("NewReportCardBatch");
            RestGateway gateway = (RestGateway)NewReportCardBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<NewReportCardBatch> newreportcardbatchCollection = new ModelCollection<NewReportCardBatch>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                newreportcardbatchCollection.add((NewReportCardBatch)model);
            }

            return newreportcardbatchCollection;
        }

        public static NewReportCardBatch retrieve(string id)
        {
            RestGateway gateway = (RestGateway)NewReportCardBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (NewReportCardBatch)gateway.retrieve(ResourceType.NEW_REPORT_CARD_BATCH, id);
        }

        public NewReportCardTemplate getReportCardTemplate()
        {
            return (NewReportCardTemplate)this.getProperty("reportCardTemplate");
        }

        public void setReportCardTemplate(NewReportCardTemplate reportCardTemplate)
        {
            this.setProperty("reportCardTemplate", reportCardTemplate);
        }

        public string getReportCardTitle()
        {
            return this.getProperty("reportCardTitle").ToString();
        }

        public void setReportCardTitle(string reportCardTitle)
        {
            this.setProperty("reportCardTitle", reportCardTitle);
        }

        public string getGeneralSettingsJson()
        {
            return this.getProperty("generalSettingsJson").ToString();
        }

        public void setGeneralSettingsJson(string generalSettingsJson)
        {
            this.setProperty("generalSettingsJson", generalSettingsJson);
        }

        public DateTime getReportCardDate()
        {
            return Convert.ToDateTime(this.getProperty("reportCardDate"));
        }

        public void setReportCardDate(DateTime reportCardDate)
        {
            this.setProperty("reportCardDate", reportCardDate);
        }

        public string getAttainmentSettingsJson()
        {
            return this.getProperty("attainmentSettingsJson").ToString();
        }

        public void setAttainmentSettingsJson(string attainmentSettingsJson)
        {
            this.setProperty("attainmentSettingsJson", attainmentSettingsJson);
        }

        public DateTime getAssessmentPeriodStartDate()
        {
            return Convert.ToDateTime(this.getProperty("assessmentPeriodStartDate"));
        }

        public void setAssessmentPeriodStartDate(DateTime assessmentPeriodStartDate)
        {
            this.setProperty("assessmentPeriodStartDate", assessmentPeriodStartDate);
        }

        public DateTime getAssessmentPeriodEndDate()
        {
            return Convert.ToDateTime(this.getProperty("assessmentPeriodEndDate"));
        }

        public void setAssessmentPeriodEndDate(DateTime assessmentPeriodEndDate)
        {
            this.setProperty("assessmentPeriodEndDate", assessmentPeriodEndDate);
        }

        public DateTime getDueDate()
        {
            return Convert.ToDateTime(this.getProperty("dueDate"));
        }

        public void setDueDate(DateTime dueDate)
        {
            this.setProperty("dueDate", dueDate);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public bool getIncludeTeacherInitials()
        {
            return Convert.ToBoolean(this.getProperty("includeTeacherInitials"));
        }

        public void setIncludeTeacherInitials(bool includeTeacherInitials)
        {
            this.setProperty("includeTeacherInitials", includeTeacherInitials);
        }

        public bool getIncludeTeacherName()
        {
            return Convert.ToBoolean(this.getProperty("includeTeacherName"));
        }

        public void setIncludeTeacherName(bool includeTeacherName)
        {
            this.setProperty("includeTeacherName", includeTeacherName);
        }

        public bool getIncludeStudentPhoto()
        {
            return Convert.ToBoolean(this.getProperty("includeStudentPhoto"));
        }

        public void setIncludeStudentPhoto(bool includeStudentPhoto)
        {
            this.setProperty("includeStudentPhoto", includeStudentPhoto);
        }

        public bool getIncludeBaseline()
        {
            return Convert.ToBoolean(this.getProperty("includeBaseline"));
        }

        public void setIncludeBaseline(bool includeBaseline)
        {
            this.setProperty("includeBaseline", includeBaseline);
        }

        public bool getIncludeWorkingAtCurrentPeriod()
        {
            return Convert.ToBoolean(this.getProperty("includeWorkingAtCurrentPeriod"));
        }

        public void setIncludeWorkingAtCurrentPeriod(bool includeWorkingAtCurrentPeriod)
        {
            this.setProperty("includeWorkingAtCurrentPeriod", includeWorkingAtCurrentPeriod);
        }

        public bool getIncludeWorkingAtPreviousPeriod()
        {
            return Convert.ToBoolean(this.getProperty("includeWorkingAtPreviousPeriod"));
        }

        public void setIncludeWorkingAtPreviousPeriod(bool includeWorkingAtPreviousPeriod)
        {
            this.setProperty("includeWorkingAtPreviousPeriod", includeWorkingAtPreviousPeriod);
        }

        public string getPreviousPeriodMeaning()
        {
            return this.getProperty("previousPeriodMeaning").ToString();
        }

        public void setPreviousPeriodMeaning(string previousPeriodMeaning)
        {
            this.setProperty("previousPeriodMeaning", previousPeriodMeaning);
        }

        public bool getIncludeTeacherTarget()
        {
            return Convert.ToBoolean(this.getProperty("includeTeacherTarget"));
        }

        public void setIncludeTeacherTarget(bool includeTeacherTarget)
        {
            this.setProperty("includeTeacherTarget", includeTeacherTarget);
        }

        public DateTime getFinalizedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("finalizedDatetime"));
        }

        public void setFinalizedDatetime(DateTime finalizedDatetime)
        {
            this.setProperty("finalizedDatetime", finalizedDatetime);
        }

        public bool getFinalizationInProgress()
        {
            return Convert.ToBoolean(this.getProperty("finalizationInProgress"));
        }

        public void setFinalizationInProgress(bool finalizationInProgress)
        {
            this.setProperty("finalizationInProgress", finalizationInProgress);
        }

        public bool getSharedWithGuardians()
        {
            return Convert.ToBoolean(this.getProperty("sharedWithGuardians"));
        }

        public void setSharedWithGuardians(bool sharedWithGuardians)
        {
            this.setProperty("sharedWithGuardians", sharedWithGuardians);
        }

        public bool getSharedWithStudents()
        {
            return Convert.ToBoolean(this.getProperty("sharedWithStudents"));
        }

        public void setSharedWithStudents(bool sharedWithStudents)
        {
            this.setProperty("sharedWithStudents", sharedWithStudents);
        }

        public string getBehaviourFields()
        {
            return this.getProperty("behaviourFields").ToString();
        }

        public void setBehaviourFields(string behaviourFields)
        {
            this.setProperty("behaviourFields", behaviourFields);
        }

        public string getAttendanceFields()
        {
            return this.getProperty("attendanceFields").ToString();
        }

        public void setAttendanceFields(string attendanceFields)
        {
            this.setProperty("attendanceFields", attendanceFields);
        }

        public bool getShowComments()
        {
            return Convert.ToBoolean(this.getProperty("showComments"));
        }

        public void setShowComments(bool showComments)
        {
            this.setProperty("showComments", showComments);
        }

        public string getCustomDisplayNamesJson()
        {
            return this.getProperty("customDisplayNamesJson").ToString();
        }

        public void setCustomDisplayNamesJson(string customDisplayNamesJson)
        {
            this.setProperty("customDisplayNamesJson", customDisplayNamesJson);
        }


    }
}

