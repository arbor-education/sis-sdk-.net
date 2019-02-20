using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentStandardizedAssessment : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_STANDARDIZED_ASSESSMENT;
        public const string STUDENT = "student";
        public const string STANDARDIZED_ASSESSMENT_TEMPLATE = "standardizedAssessmentTemplate";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string COMPLETED_DATE = "completedDate";

        public StudentStandardizedAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentStandardizedAssessment (string resourceType = "StudentStandardizedAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentStandardizedAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentStandardizedAssessment");
        	RestGateway gateway = (RestGateway) StudentStandardizedAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentStandardizedAssessment> studentstandardizedassessmentCollection = new ModelCollection<StudentStandardizedAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentstandardizedassessmentCollection.add((StudentStandardizedAssessment) model);
        	}
        
        	return studentstandardizedassessmentCollection;
        }

        public static StudentStandardizedAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentStandardizedAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentStandardizedAssessment) gateway.retrieve(ResourceType.STUDENT_STANDARDIZED_ASSESSMENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public StandardizedAssessmentTemplate getStandardizedAssessmentTemplate ()
        {
            return (StandardizedAssessmentTemplate) this.getProperty("standardizedAssessmentTemplate");
        }

        public void setStandardizedAssessmentTemplate (StandardizedAssessmentTemplate standardizedAssessmentTemplate)
        {
            this.setProperty("standardizedAssessmentTemplate", standardizedAssessmentTemplate);
        }

        public DateTime getAssessmentDate ()
        {
            return Convert.ToDateTime(this.getProperty("assessmentDate"));
        }

        public void setAssessmentDate (DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public DateTime getCompletedDate ()
        {
            return Convert.ToDateTime(this.getProperty("completedDate"));
        }

        public void setCompletedDate (DateTime completedDate)
        {
            this.setProperty("completedDate", completedDate);
        }


    }
}

