using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SessionCurriculumGoal : ModelBase
    {
        protected string resourceType = ResourceType.SESSION_CURRICULUM_GOAL;
        public const string SESSION = "session";
        public const string CURRICULUM_GOAL = "curriculumGoal";

        public SessionCurriculumGoal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SessionCurriculumGoal (string resourceType = "SessionCurriculumGoal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SessionCurriculumGoal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SessionCurriculumGoal");
        	RestGateway gateway = (RestGateway) SessionCurriculumGoal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SessionCurriculumGoal> sessioncurriculumgoalCollection = new ModelCollection<SessionCurriculumGoal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sessioncurriculumgoalCollection.add((SessionCurriculumGoal) model);
        	}
        
        	return sessioncurriculumgoalCollection;
        }

        public static SessionCurriculumGoal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SessionCurriculumGoal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SessionCurriculumGoal) gateway.retrieve(ResourceType.SESSION_CURRICULUM_GOAL, id);
        }

        public Session getSession ()
        {
            return (Session) this.getProperty("session");
        }

        public void setSession (Session session)
        {
            this.setProperty("session", session);
        }

        public CurriculumGoal getCurriculumGoal ()
        {
            return (CurriculumGoal) this.getProperty("curriculumGoal");
        }

        public void setCurriculumGoal (CurriculumGoal curriculumGoal)
        {
            this.setProperty("curriculumGoal", curriculumGoal);
        }


    }
}

