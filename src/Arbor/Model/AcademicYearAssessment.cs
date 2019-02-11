using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicYearAssessment : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_YEAR_ASSESSMENT;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string ASSESSMENT_NAME = "assessmentName";
        public const string CURRICULUM_TIER = "curriculumTier";
        public const string ASSESSMENT_ENTITY = "assessmentEntity";
        public const string PROGRESS_MEASUREMENT_PERIOD_SET = "progressMeasurementPeriodSet";
        public const string IS_LINKED_TO_SUMMATIVE_TRACKING = "isLinkedToSummativeTracking";
        public const string SETUP_COMPLETED_DATETIME = "setupCompletedDatetime";
        public const string SETUP_COMPLETION_STARTED_DATETIME = "setupCompletionStartedDatetime";
        public const string ALLOW_COMMENTS = "allowComments";

        public AcademicYearAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicYearAssessment (string resourceType = "AcademicYearAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicYearAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicYearAssessment");
        	RestGateway gateway = (RestGateway) AcademicYearAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicYearAssessment> academicyearassessmentCollection = new ModelCollection<AcademicYearAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicyearassessmentCollection.add((AcademicYearAssessment) model);
        	}
        
        	return academicyearassessmentCollection;
        }

        public static AcademicYearAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicYearAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicYearAssessment) gateway.retrieve(ResourceType.ACADEMIC_YEAR_ASSESSMENT, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getAssessmentName ()
        {
            return this.getProperty("assessmentName").ToString();
        }

        public void setAssessmentName (string assessmentName)
        {
            this.setProperty("assessmentName", assessmentName);
        }

        public CurriculumTier getCurriculumTier ()
        {
            return (CurriculumTier) this.getProperty("curriculumTier");
        }

        public void setCurriculumTier (CurriculumTier curriculumTier)
        {
            this.setProperty("curriculumTier", curriculumTier);
        }

        public ModelBase getAssessmentEntity ()
        {
            return (ModelBase) this.getProperty("assessmentEntity");
        }

        public void setAssessmentEntity (ModelBase assessmentEntity)
        {
            this.setProperty("assessmentEntity", assessmentEntity);
        }

        public ProgressMeasurementPeriodSet getProgressMeasurementPeriodSet ()
        {
            return (ProgressMeasurementPeriodSet) this.getProperty("progressMeasurementPeriodSet");
        }

        public void setProgressMeasurementPeriodSet (ProgressMeasurementPeriodSet progressMeasurementPeriodSet)
        {
            this.setProperty("progressMeasurementPeriodSet", progressMeasurementPeriodSet);
        }

        public bool getIsLinkedToSummativeTracking ()
        {
            return Convert.ToBoolean( this.getProperty("isLinkedToSummativeTracking"));
        }

        public void setIsLinkedToSummativeTracking (bool isLinkedToSummativeTracking)
        {
            this.setProperty("isLinkedToSummativeTracking", isLinkedToSummativeTracking);
        }

        public DateTime getSetupCompletedDatetime (){
            return Convert.ToDateTime(this.getProperty("setupCompletedDatetime"));
        }

        public void setSetupCompletedDatetime (DateTime setupCompletedDatetime)
        {
            this.setProperty("setupCompletedDatetime", setupCompletedDatetime);
        }

        public DateTime getSetupCompletionStartedDatetime (){
            return Convert.ToDateTime(this.getProperty("setupCompletionStartedDatetime"));
        }

        public void setSetupCompletionStartedDatetime (DateTime setupCompletionStartedDatetime)
        {
            this.setProperty("setupCompletionStartedDatetime", setupCompletionStartedDatetime);
        }

        public bool getAllowComments ()
        {
            return Convert.ToBoolean( this.getProperty("allowComments"));
        }

        public void setAllowComments (bool allowComments)
        {
            this.setProperty("allowComments", allowComments);
        }


    }
}

