using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentSchoolwork : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_SCHOOLWORK;
        public const string SCHOOLWORK = "schoolwork";
        public const string STUDENT = "student";
        public const string DUE_DATETIME = "dueDatetime";
        public const string SUBMITTED_DATETIME = "submittedDatetime";
        public const string MARKING_COMPLETED_DATETIME = "markingCompletedDatetime";
        public const string REVIEWED_DATETIME = "reviewedDatetime";

        public StudentSchoolwork ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentSchoolwork (string resourceType = "StudentSchoolwork", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentSchoolwork> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentSchoolwork");
        	RestGateway gateway = (RestGateway) StudentSchoolwork.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentSchoolwork> studentschoolworkCollection = new ModelCollection<StudentSchoolwork> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentschoolworkCollection.add((StudentSchoolwork) model);
        	}
        
        	return studentschoolworkCollection;
        }

        public static StudentSchoolwork retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentSchoolwork.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentSchoolwork) gateway.retrieve(ResourceType.STUDENT_SCHOOLWORK, id);
        }

        public Schoolwork getSchoolwork ()
        {
            return (Schoolwork) this.getProperty("schoolwork");
        }

        public void setSchoolwork (Schoolwork schoolwork)
        {
            this.setProperty("schoolwork", schoolwork);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getDueDatetime ()
        {
            return (DateTime) this.getProperty("dueDatetime");
        }

        public void setDueDatetime (DateTime dueDatetime)
        {
            this.setProperty("dueDatetime", dueDatetime);
        }

        public DateTime getSubmittedDatetime ()
        {
            return (DateTime) this.getProperty("submittedDatetime");
        }

        public void setSubmittedDatetime (DateTime submittedDatetime)
        {
            this.setProperty("submittedDatetime", submittedDatetime);
        }

        public DateTime getMarkingCompletedDatetime ()
        {
            return (DateTime) this.getProperty("markingCompletedDatetime");
        }

        public void setMarkingCompletedDatetime (DateTime markingCompletedDatetime)
        {
            this.setProperty("markingCompletedDatetime", markingCompletedDatetime);
        }

        public DateTime getReviewedDatetime ()
        {
            return (DateTime) this.getProperty("reviewedDatetime");
        }

        public void setReviewedDatetime (DateTime reviewedDatetime)
        {
            this.setProperty("reviewedDatetime", reviewedDatetime);
        }


    }
}

