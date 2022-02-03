using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentTalent : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_TALENT;
        public const string STUDENT = "student";
        public const string TALENT = "talent";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string NARRATIVE = "narrative";

        public StudentTalent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentTalent (string resourceType = "StudentTalent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentTalent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentTalent");
        	RestGateway gateway = (RestGateway) StudentTalent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentTalent> studenttalentCollection = new ModelCollection<StudentTalent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studenttalentCollection.add((StudentTalent) model);
        	}
        
        	return studenttalentCollection;
        }

        public static StudentTalent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentTalent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentTalent) gateway.retrieve(ResourceType.STUDENT_TALENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Talent getTalent ()
        {
            return (Talent) this.getProperty("talent");
        }

        public void setTalent (Talent talent)
        {
            this.setProperty("talent", talent);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
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

