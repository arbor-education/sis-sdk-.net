using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentFunding : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_FUNDING;
        public const string STUDENT = "student";
        public const string STUDENT_FUNDING_TYPE = "studentFundingType";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string NOTE = "note";

        public StudentFunding ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentFunding (string resourceType = "StudentFunding", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentFunding> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentFunding");
        	RestGateway gateway = (RestGateway) StudentFunding.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentFunding> studentfundingCollection = new ModelCollection<StudentFunding> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentfundingCollection.add((StudentFunding) model);
        	}
        
        	return studentfundingCollection;
        }

        public static StudentFunding retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentFunding.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentFunding) gateway.retrieve(ResourceType.STUDENT_FUNDING, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public StudentFundingType getStudentFundingType ()
        {
            return (StudentFundingType) this.getProperty("studentFundingType");
        }

        public void setStudentFundingType (StudentFundingType studentFundingType)
        {
            this.setProperty("studentFundingType", studentFundingType);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getNote ()
        {
            return this.getProperty("note").ToString();
        }

        public void setNote (string note)
        {
            this.setProperty("note", note);
        }


    }
}

