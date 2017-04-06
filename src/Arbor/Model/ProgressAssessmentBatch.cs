using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressAssessmentBatch : ModelBase
    {
        protected string resourceType = ResourceType.PROGRESS_ASSESSMENT_BATCH;
        public const string BATCH_NAME = "batchName";
        public const string ASSESSMENT = "assessment";
        public const string PROGRESS_MEASUREMENT_PERIOD_SET = "progressMeasurementPeriodSet";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string ACADEMIC_LEVEL = "academicLevel";
        public const string SEN_STUDENTS_ONLY = "senStudentsOnly";

        public ProgressAssessmentBatch ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgressAssessmentBatch (string resourceType = "ProgressAssessmentBatch", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgressAssessmentBatch> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgressAssessmentBatch");
        	RestGateway gateway = (RestGateway) ProgressAssessmentBatch.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgressAssessmentBatch> progressassessmentbatchCollection = new ModelCollection<ProgressAssessmentBatch> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    progressassessmentbatchCollection.add((ProgressAssessmentBatch) model);
        	}
        
        	return progressassessmentbatchCollection;
        }

        public static ProgressAssessmentBatch retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgressAssessmentBatch.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgressAssessmentBatch) gateway.retrieve(ResourceType.PROGRESS_ASSESSMENT_BATCH, id);
        }

        public string getBatchName ()
        {
            return this.getProperty("batchName").ToString();
        }

        public void setBatchName (string batchName)
        {
            this.setProperty("batchName", batchName);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public ProgressMeasurementPeriodSet getProgressMeasurementPeriodSet ()
        {
            return (ProgressMeasurementPeriodSet) this.getProperty("progressMeasurementPeriodSet");
        }

        public void setProgressMeasurementPeriodSet (ProgressMeasurementPeriodSet progressMeasurementPeriodSet)
        {
            this.setProperty("progressMeasurementPeriodSet", progressMeasurementPeriodSet);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public AcademicLevel getAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("academicLevel");
        }

        public void setAcademicLevel (AcademicLevel academicLevel)
        {
            this.setProperty("academicLevel", academicLevel);
        }

        public bool getSenStudentsOnly ()
        {
            return (bool) this.getProperty("senStudentsOnly");
        }

        public void setSenStudentsOnly (bool senStudentsOnly)
        {
            this.setProperty("senStudentsOnly", senStudentsOnly);
        }


    }
}

