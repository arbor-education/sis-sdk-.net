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
        protected string resourceType = ResourceType.NEW_REPORT_CARD_BATCH;
        public const string REPORT_CARD_TEMPLATE = "reportCardTemplate";
        public const string REPORT_CARD_TITLE = "reportCardTitle";
        public const string REPORT_CARD_DATE = "reportCardDate";
        public const string ASSESSMENT_PERIOD_START_DATE = "assessmentPeriodStartDate";
        public const string ASSESSMENT_PERIOD_END_DATE = "assessmentPeriodEndDate";
        public const string ATTENDANCE_PERIOD_START_DATE = "attendancePeriodStartDate";
        public const string ATTENDANCE_PERIOD_END_DATE = "attendancePeriodEndDate";
        public const string DUE_DATE = "dueDate";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string INCLUDE_TEACHER_INITIALS = "includeTeacherInitials";
        public const string INCLUDE_TEACHER_NAME = "includeTeacherName";
        public const string INCLUDE_BASELINE = "includeBaseline";
        public const string INCLUDE_WORKING_AT_CURRENT_PERIOD = "includeWorkingAtCurrentPeriod";
        public const string INCLUDE_WORKING_AT_PREVIOUS_PERIOD = "includeWorkingAtPreviousPeriod";
        public const string PREVIOUS_PERIOD_MEANING = "previousPeriodMeaning";
        public const string INCLUDE_TEACHER_TARGET = "includeTeacherTarget";
        public const string FINALIZED_DATETIME = "finalizedDatetime";
        public const string FINALIZATION_IN_PROGRESS = "finalizationInProgress";
        public const string SHARED_WITH_GUARDIANS = "sharedWithGuardians";

        public NewReportCardBatch ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NewReportCardBatch (string resourceType = "NewReportCardBatch", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NewReportCardBatch> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NewReportCardBatch");
        	RestGateway gateway = (RestGateway) NewReportCardBatch.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NewReportCardBatch> newreportcardbatchCollection = new ModelCollection<NewReportCardBatch> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    newreportcardbatchCollection.add((NewReportCardBatch) model);
        	}
        
        	return newreportcardbatchCollection;
        }

        public static NewReportCardBatch retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NewReportCardBatch.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NewReportCardBatch) gateway.retrieve(ResourceType.NEW_REPORT_CARD_BATCH, id);
        }

        public NewReportCardTemplate getReportCardTemplate ()
        {
            return (NewReportCardTemplate) this.getProperty("reportCardTemplate");
        }

        public void setReportCardTemplate (NewReportCardTemplate reportCardTemplate)
        {
            this.setProperty("reportCardTemplate", reportCardTemplate);
        }

        public string getReportCardTitle ()
        {
            return this.getProperty("reportCardTitle").ToString();
        }

        public void setReportCardTitle (string reportCardTitle)
        {
            this.setProperty("reportCardTitle", reportCardTitle);
        }

        public DateTime getReportCardDate ()
        {
            return (DateTime) this.getProperty("reportCardDate");
        }

        public void setReportCardDate (DateTime reportCardDate)
        {
            this.setProperty("reportCardDate", reportCardDate);
        }

        public DateTime getAssessmentPeriodStartDate ()
        {
            return (DateTime) this.getProperty("assessmentPeriodStartDate");
        }

        public void setAssessmentPeriodStartDate (DateTime assessmentPeriodStartDate)
        {
            this.setProperty("assessmentPeriodStartDate", assessmentPeriodStartDate);
        }

        public DateTime getAssessmentPeriodEndDate ()
        {
            return (DateTime) this.getProperty("assessmentPeriodEndDate");
        }

        public void setAssessmentPeriodEndDate (DateTime assessmentPeriodEndDate)
        {
            this.setProperty("assessmentPeriodEndDate", assessmentPeriodEndDate);
        }

        public DateTime getAttendancePeriodStartDate ()
        {
            return (DateTime) this.getProperty("attendancePeriodStartDate");
        }

        public void setAttendancePeriodStartDate (DateTime attendancePeriodStartDate)
        {
            this.setProperty("attendancePeriodStartDate", attendancePeriodStartDate);
        }

        public DateTime getAttendancePeriodEndDate ()
        {
            return (DateTime) this.getProperty("attendancePeriodEndDate");
        }

        public void setAttendancePeriodEndDate (DateTime attendancePeriodEndDate)
        {
            this.setProperty("attendancePeriodEndDate", attendancePeriodEndDate);
        }

        public DateTime getDueDate ()
        {
            return (DateTime) this.getProperty("dueDate");
        }

        public void setDueDate (DateTime dueDate)
        {
            this.setProperty("dueDate", dueDate);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public bool getIncludeTeacherInitials ()
        {
            return (bool) this.getProperty("includeTeacherInitials");
        }

        public void setIncludeTeacherInitials (bool includeTeacherInitials)
        {
            this.setProperty("includeTeacherInitials", includeTeacherInitials);
        }

        public bool getIncludeTeacherName ()
        {
            return (bool) this.getProperty("includeTeacherName");
        }

        public void setIncludeTeacherName (bool includeTeacherName)
        {
            this.setProperty("includeTeacherName", includeTeacherName);
        }

        public bool getIncludeBaseline ()
        {
            return (bool) this.getProperty("includeBaseline");
        }

        public void setIncludeBaseline (bool includeBaseline)
        {
            this.setProperty("includeBaseline", includeBaseline);
        }

        public bool getIncludeWorkingAtCurrentPeriod ()
        {
            return (bool) this.getProperty("includeWorkingAtCurrentPeriod");
        }

        public void setIncludeWorkingAtCurrentPeriod (bool includeWorkingAtCurrentPeriod)
        {
            this.setProperty("includeWorkingAtCurrentPeriod", includeWorkingAtCurrentPeriod);
        }

        public bool getIncludeWorkingAtPreviousPeriod ()
        {
            return (bool) this.getProperty("includeWorkingAtPreviousPeriod");
        }

        public void setIncludeWorkingAtPreviousPeriod (bool includeWorkingAtPreviousPeriod)
        {
            this.setProperty("includeWorkingAtPreviousPeriod", includeWorkingAtPreviousPeriod);
        }

        public string getPreviousPeriodMeaning ()
        {
            return this.getProperty("previousPeriodMeaning").ToString();
        }

        public void setPreviousPeriodMeaning (string previousPeriodMeaning)
        {
            this.setProperty("previousPeriodMeaning", previousPeriodMeaning);
        }

        public bool getIncludeTeacherTarget ()
        {
            return (bool) this.getProperty("includeTeacherTarget");
        }

        public void setIncludeTeacherTarget (bool includeTeacherTarget)
        {
            this.setProperty("includeTeacherTarget", includeTeacherTarget);
        }

        public DateTime getFinalizedDatetime ()
        {
            return (DateTime) this.getProperty("finalizedDatetime");
        }

        public void setFinalizedDatetime (DateTime finalizedDatetime)
        {
            this.setProperty("finalizedDatetime", finalizedDatetime);
        }

        public bool getFinalizationInProgress ()
        {
            return (bool) this.getProperty("finalizationInProgress");
        }

        public void setFinalizationInProgress (bool finalizationInProgress)
        {
            this.setProperty("finalizationInProgress", finalizationInProgress);
        }

        public bool getSharedWithGuardians ()
        {
            return (bool) this.getProperty("sharedWithGuardians");
        }

        public void setSharedWithGuardians (bool sharedWithGuardians)
        {
            this.setProperty("sharedWithGuardians", sharedWithGuardians);
        }


    }
}

