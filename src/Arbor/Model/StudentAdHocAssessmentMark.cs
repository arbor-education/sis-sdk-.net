using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentAdHocAssessmentMark : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_AD_HOC_ASSESSMENT_MARK;
        public const string AD_HOC_ASSESSMENT_BATCH = "adHocAssessmentBatch";
        public const string STUDENT = "student";
        public const string AD_HOC_ASSESSMENT = "adHocAssessment";
        public const string ASSESSMENT_REFERENCE_DATE = "assessmentReferenceDate";
        public const string SCOPE_ENTITY = "scopeEntity";
        public const string GRADE = "grade";
        public const string NUMBER = "number";
        public const string MARKING_STAFF = "markingStaff";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string COMPLETED_STAFF = "completedStaff";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string APPROVED_STAFF = "approvedStaff";

        public StudentAdHocAssessmentMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentAdHocAssessmentMark (string resourceType = "StudentAdHocAssessmentMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentAdHocAssessmentMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentAdHocAssessmentMark");
        	RestGateway gateway = (RestGateway) StudentAdHocAssessmentMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentAdHocAssessmentMark> studentadhocassessmentmarkCollection = new ModelCollection<StudentAdHocAssessmentMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentadhocassessmentmarkCollection.add((StudentAdHocAssessmentMark) model);
        	}
        
        	return studentadhocassessmentmarkCollection;
        }

        public static StudentAdHocAssessmentMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentAdHocAssessmentMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentAdHocAssessmentMark) gateway.retrieve(ResourceType.STUDENT_AD_HOC_ASSESSMENT_MARK, id);
        }

        public AdHocAssessmentBatch getAdHocAssessmentBatch ()
        {
            return (AdHocAssessmentBatch) this.getProperty("adHocAssessmentBatch");
        }

        public void setAdHocAssessmentBatch (AdHocAssessmentBatch adHocAssessmentBatch)
        {
            this.setProperty("adHocAssessmentBatch", adHocAssessmentBatch);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public AdHocAssessment getAdHocAssessment ()
        {
            return (AdHocAssessment) this.getProperty("adHocAssessment");
        }

        public void setAdHocAssessment (AdHocAssessment adHocAssessment)
        {
            this.setProperty("adHocAssessment", adHocAssessment);
        }

        public DateTime getAssessmentReferenceDate ()
        {
            return Convert.ToDateTime(this.getProperty("assessmentReferenceDate"));
        }

        public void setAssessmentReferenceDate (DateTime assessmentReferenceDate)
        {
            this.setProperty("assessmentReferenceDate", assessmentReferenceDate);
        }

        public ModelBase getScopeEntity ()
        {
            return (ModelBase) this.getProperty("scopeEntity");
        }

        public void setScopeEntity (ModelBase scopeEntity)
        {
            this.setProperty("scopeEntity", scopeEntity);
        }

        public Grade getGrade ()
        {
            return (Grade) this.getProperty("grade");
        }

        public void setGrade (Grade grade)
        {
            this.setProperty("grade", grade);
        }

        public float getNumber ()
        {
            return (float) this.getProperty("number");
        }

        public void setNumber (float number)
        {
            this.setProperty("number", number);
        }

        public Staff getMarkingStaff ()
        {
            return (Staff) this.getProperty("markingStaff");
        }

        public void setMarkingStaff (Staff markingStaff)
        {
            this.setProperty("markingStaff", markingStaff);
        }

        public DateTime getCompletedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public Staff getCompletedStaff ()
        {
            return (Staff) this.getProperty("completedStaff");
        }

        public void setCompletedStaff (Staff completedStaff)
        {
            this.setProperty("completedStaff", completedStaff);
        }

        public DateTime getApprovedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("approvedDatetime"));
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }

        public Staff getApprovedStaff ()
        {
            return (Staff) this.getProperty("approvedStaff");
        }

        public void setApprovedStaff (Staff approvedStaff)
        {
            this.setProperty("approvedStaff", approvedStaff);
        }


    }
}

