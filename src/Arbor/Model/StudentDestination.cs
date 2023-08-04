using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentDestination : ModelBase
    {
        protected new string resourceType = ResourceType.STUDENT_DESTINATION;
        public const string STUDENT = "student";
        public const string STUDENT_DESTINATION_TYPE = "studentDestinationType";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string VERIFIED_DATE = "verifiedDate";
        public const string LINKED_RECORD = "linkedRecord";

        public StudentDestination ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentDestination (string resourceType = "StudentDestination", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentDestination> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentDestination");
        	RestGateway gateway = (RestGateway) StudentDestination.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentDestination> studentdestinationCollection = new ModelCollection<StudentDestination> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentdestinationCollection.add((StudentDestination) model);
        	}
        
        	return studentdestinationCollection;
        }

        public static StudentDestination retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentDestination.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentDestination) gateway.retrieve(ResourceType.STUDENT_DESTINATION, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public StudentDestinationType getStudentDestinationType ()
        {
            return (StudentDestinationType) this.getProperty("studentDestinationType");
        }

        public void setStudentDestinationType (StudentDestinationType studentDestinationType)
        {
            this.setProperty("studentDestinationType", studentDestinationType);
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

        public DateTime getVerifiedDate ()
        {
            return Convert.ToDateTime(this.getProperty("verifiedDate"));
        }

        public void setVerifiedDate (DateTime verifiedDate)
        {
            this.setProperty("verifiedDate", verifiedDate);
        }

        public ModelBase getLinkedRecord ()
        {
            return (ModelBase) this.getProperty("linkedRecord");
        }

        public void setLinkedRecord (ModelBase linkedRecord)
        {
            this.setProperty("linkedRecord", linkedRecord);
        }


    }
}

