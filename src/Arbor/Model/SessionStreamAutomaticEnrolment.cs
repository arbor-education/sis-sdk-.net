using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SessionStreamAutomaticEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.SESSION_STREAM_AUTOMATIC_ENROLMENT;
        public const string SESSION_STREAM = "sessionStream";
        public const string TRIGGER = "trigger";

        public SessionStreamAutomaticEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SessionStreamAutomaticEnrolment (string resourceType = "SessionStreamAutomaticEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SessionStreamAutomaticEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SessionStreamAutomaticEnrolment");
        	RestGateway gateway = (RestGateway) SessionStreamAutomaticEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SessionStreamAutomaticEnrolment> sessionstreamautomaticenrolmentCollection = new ModelCollection<SessionStreamAutomaticEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sessionstreamautomaticenrolmentCollection.add((SessionStreamAutomaticEnrolment) model);
        	}
        
        	return sessionstreamautomaticenrolmentCollection;
        }

        public static SessionStreamAutomaticEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SessionStreamAutomaticEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SessionStreamAutomaticEnrolment) gateway.retrieve(ResourceType.SESSION_STREAM_AUTOMATIC_ENROLMENT, id);
        }

        public SessionStream getSessionStream ()
        {
            return (SessionStream) this.getProperty("sessionStream");
        }

        public void setSessionStream (SessionStream sessionStream)
        {
            this.setProperty("sessionStream", sessionStream);
        }

        public ModelBase getTrigger ()
        {
            return (ModelBase) this.getProperty("trigger");
        }

        public void setTrigger (ModelBase trigger)
        {
            this.setProperty("trigger", trigger);
        }


    }
}

