using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentBursaryLevel : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_BURSARY_LEVEL;
        public const string STUDENT = "student";
        public const string BURSARY_LEVEL = "bursaryLevel";
        public const string STUDENT_FUNDING = "studentFunding";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public StudentBursaryLevel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentBursaryLevel (string resourceType = "StudentBursaryLevel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentBursaryLevel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentBursaryLevel");
        	RestGateway gateway = (RestGateway) StudentBursaryLevel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentBursaryLevel> studentbursarylevelCollection = new ModelCollection<StudentBursaryLevel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentbursarylevelCollection.add((StudentBursaryLevel) model);
        	}
        
        	return studentbursarylevelCollection;
        }

        public static StudentBursaryLevel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentBursaryLevel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentBursaryLevel) gateway.retrieve(ResourceType.STUDENT_BURSARY_LEVEL, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public BursaryLevel getBursaryLevel ()
        {
            return (BursaryLevel) this.getProperty("bursaryLevel");
        }

        public void setBursaryLevel (BursaryLevel bursaryLevel)
        {
            this.setProperty("bursaryLevel", bursaryLevel);
        }

        public StudentFunding getStudentFunding ()
        {
            return (StudentFunding) this.getProperty("studentFunding");
        }

        public void setStudentFunding (StudentFunding studentFunding)
        {
            this.setProperty("studentFunding", studentFunding);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

