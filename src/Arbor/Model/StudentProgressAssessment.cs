using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentProgressAssessment : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_PROGRESS_ASSESSMENT;
        public const string STUDENT = "student";
        public const string ASSESSMENT = "assessment";
        public const string PROGRESS_ASSESSMENT_BATCH_TARGET = "progressAssessmentBatchTarget";
        public const string PROGRESS_MEASUREMENT_PERIOD = "progressMeasurementPeriod";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string COMPLETED_DATE = "completedDate";

        public StudentProgressAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentProgressAssessment (string resourceType = "StudentProgressAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentProgressAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentProgressAssessment");
        	RestGateway gateway = (RestGateway) StudentProgressAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentProgressAssessment> studentprogressassessmentCollection = new ModelCollection<StudentProgressAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentprogressassessmentCollection.add((StudentProgressAssessment) model);
        	}
        
        	return studentprogressassessmentCollection;
        }

        public static StudentProgressAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentProgressAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentProgressAssessment) gateway.retrieve(ResourceType.STUDENT_PROGRESS_ASSESSMENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public ProgressAssessmentBatchTarget getProgressAssessmentBatchTarget ()
        {
            return (ProgressAssessmentBatchTarget) this.getProperty("progressAssessmentBatchTarget");
        }

        public void setProgressAssessmentBatchTarget (ProgressAssessmentBatchTarget progressAssessmentBatchTarget)
        {
            this.setProperty("progressAssessmentBatchTarget", progressAssessmentBatchTarget);
        }

        public ProgressMeasurementPeriod getProgressMeasurementPeriod ()
        {
            return (ProgressMeasurementPeriod) this.getProperty("progressMeasurementPeriod");
        }

        public void setProgressMeasurementPeriod (ProgressMeasurementPeriod progressMeasurementPeriod)
        {
            this.setProperty("progressMeasurementPeriod", progressMeasurementPeriod);
        }

        public DateTime getAssessmentDate ()
        {
            return (DateTime) this.getProperty("assessmentDate");
        }

        public void setAssessmentDate (DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public DateTime getCompletedDate ()
        {
            return (DateTime) this.getProperty("completedDate");
        }

        public void setCompletedDate (DateTime completedDate)
        {
            this.setProperty("completedDate", completedDate);
        }


    }
}

