using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentAssessment : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_ASSESSMENT;
        public const string STUDENT = "student";
        public const string ASSESSMENT = "assessment";
        public const string ASSESSMENT_TEMPLATE = "assessmentTemplate";
        public const string ASSESSMENT_BATCH_TARGET = "assessmentBatchTarget";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string COMPLETED_DATE = "completedDate";

        public StudentAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentAssessment (string resourceType = "StudentAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentAssessment");
        	RestGateway gateway = (RestGateway) StudentAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentAssessment> studentassessmentCollection = new ModelCollection<StudentAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentassessmentCollection.add((StudentAssessment) model);
        	}
        
        	return studentassessmentCollection;
        }

        public static StudentAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentAssessment) gateway.retrieve(ResourceType.STUDENT_ASSESSMENT, id);
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

        public AssessmentTemplate getAssessmentTemplate ()
        {
            return (AssessmentTemplate) this.getProperty("assessmentTemplate");
        }

        public void setAssessmentTemplate (AssessmentTemplate assessmentTemplate)
        {
            this.setProperty("assessmentTemplate", assessmentTemplate);
        }

        public AssessmentBatchTarget getAssessmentBatchTarget ()
        {
            return (AssessmentBatchTarget) this.getProperty("assessmentBatchTarget");
        }

        public void setAssessmentBatchTarget (AssessmentBatchTarget assessmentBatchTarget)
        {
            this.setProperty("assessmentBatchTarget", assessmentBatchTarget);
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

