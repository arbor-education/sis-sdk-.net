using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentGift : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_GIFT;
        public const string STUDENT = "student";
        public const string SUBJECT = "subject";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string NARRATIVE = "narrative";

        public StudentGift ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentGift (string resourceType = "StudentGift", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentGift> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentGift");
        	RestGateway gateway = (RestGateway) StudentGift.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentGift> studentgiftCollection = new ModelCollection<StudentGift> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentgiftCollection.add((StudentGift) model);
        	}
        
        	return studentgiftCollection;
        }

        public static StudentGift retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentGift.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentGift) gateway.retrieve(ResourceType.STUDENT_GIFT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Subject getSubject ()
        {
            return (Subject) this.getProperty("subject");
        }

        public void setSubject (Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public DateTime getStartDate (){
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

