using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SessionStreamEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.SESSION_STREAM_ENROLMENT;
        public const string SESSION_STREAM = "sessionStream";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string ENROLMENT_STATUS = "enrolmentStatus";
        public const string SESSION_STREAM_AUTOMATIC_ENROLMENT = "sessionStreamAutomaticEnrolment";
        public const string ENROLMENT_DEPENDENCY = "enrolmentDependency";

        public SessionStreamEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SessionStreamEnrolment (string resourceType = "SessionStreamEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SessionStreamEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SessionStreamEnrolment");
        	RestGateway gateway = (RestGateway) SessionStreamEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SessionStreamEnrolment> sessionstreamenrolmentCollection = new ModelCollection<SessionStreamEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sessionstreamenrolmentCollection.add((SessionStreamEnrolment) model);
        	}
        
        	return sessionstreamenrolmentCollection;
        }

        public static SessionStreamEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SessionStreamEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SessionStreamEnrolment) gateway.retrieve(ResourceType.SESSION_STREAM_ENROLMENT, id);
        }

        public SessionStream getSessionStream ()
        {
            return (SessionStream) this.getProperty("sessionStream");
        }

        public void setSessionStream (SessionStream sessionStream)
        {
            this.setProperty("sessionStream", sessionStream);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
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

        public string getEnrolmentStatus ()
        {
            return this.getProperty("enrolmentStatus").ToString();
        }

        public void setEnrolmentStatus (string enrolmentStatus)
        {
            this.setProperty("enrolmentStatus", enrolmentStatus);
        }

        public SessionStreamAutomaticEnrolment getSessionStreamAutomaticEnrolment ()
        {
            return (SessionStreamAutomaticEnrolment) this.getProperty("sessionStreamAutomaticEnrolment");
        }

        public void setSessionStreamAutomaticEnrolment (SessionStreamAutomaticEnrolment sessionStreamAutomaticEnrolment)
        {
            this.setProperty("sessionStreamAutomaticEnrolment", sessionStreamAutomaticEnrolment);
        }

        public ModelBase getEnrolmentDependency ()
        {
            return (ModelBase) this.getProperty("enrolmentDependency");
        }

        public void setEnrolmentDependency (ModelBase enrolmentDependency)
        {
            this.setProperty("enrolmentDependency", enrolmentDependency);
        }


    }
}

