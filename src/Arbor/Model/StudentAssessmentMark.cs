using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentAssessmentMark : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_ASSESSMENT_MARK;
        public const string STUDENT = "student";
        public const string ASSESSMENT = "assessment";
        public const string STUDENT_ASSESSMENT = "studentAssessment";
        public const string ASPECT = "aspect";
        public const string MARK_INTEGER = "markInteger";
        public const string MARK_DECIMAL = "markDecimal";
        public const string MARK_COMMENT = "markComment";
        public const string MARK_GRADE = "markGrade";
        public const string ASSESSMENT_DATE = "assessmentDate";

        public StudentAssessmentMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentAssessmentMark (string resourceType = "StudentAssessmentMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentAssessmentMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentAssessmentMark");
        	RestGateway gateway = (RestGateway) StudentAssessmentMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentAssessmentMark> studentassessmentmarkCollection = new ModelCollection<StudentAssessmentMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentassessmentmarkCollection.add((StudentAssessmentMark) model);
        	}
        
        	return studentassessmentmarkCollection;
        }

        public static StudentAssessmentMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentAssessmentMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentAssessmentMark) gateway.retrieve(ResourceType.STUDENT_ASSESSMENT_MARK, id);
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

        public StudentAssessment getStudentAssessment ()
        {
            return (StudentAssessment) this.getProperty("studentAssessment");
        }

        public void setStudentAssessment (StudentAssessment studentAssessment)
        {
            this.setProperty("studentAssessment", studentAssessment);
        }

        public Aspect getAspect ()
        {
            return (Aspect) this.getProperty("aspect");
        }

        public void setAspect (Aspect aspect)
        {
            this.setProperty("aspect", aspect);
        }

        public int getMarkInteger ()
        {
            return Convert.ToInt32(this.getProperty("markInteger"));
        }

        public void setMarkInteger (int markInteger)
        {
            this.setProperty("markInteger", markInteger);
        }

        public float getMarkDecimal ()
        {
            return (float) this.getProperty("markDecimal");
        }

        public void setMarkDecimal (float markDecimal)
        {
            this.setProperty("markDecimal", markDecimal);
        }

        public string getMarkComment ()
        {
            return this.getProperty("markComment").ToString();
        }

        public void setMarkComment (string markComment)
        {
            this.setProperty("markComment", markComment);
        }

        public Grade getMarkGrade ()
        {
            return (Grade) this.getProperty("markGrade");
        }

        public void setMarkGrade (Grade markGrade)
        {
            this.setProperty("markGrade", markGrade);
        }

        public DateTime getAssessmentDate ()
        {
            return (DateTime) this.getProperty("assessmentDate");
        }

        public void setAssessmentDate (DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }


    }
}

