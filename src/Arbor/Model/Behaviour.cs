using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Behaviour : ModelBase
    {
        protected new string resourceType = ResourceType.BEHAVIOUR;
        public const string BEHAVIOUR_NAME = "behaviourName";
        public const string DESCRIPTION = "description";
        public const string SEVERITY = "severity";
        public const string ACTIVE = "active";
        public const string IS_MY_CLASSROOM_DEFAULT = "isMyClassroomDefault";

        public Behaviour ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Behaviour (string resourceType = "Behaviour", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Behaviour> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Behaviour");
        	RestGateway gateway = (RestGateway) Behaviour.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Behaviour> behaviourCollection = new ModelCollection<Behaviour> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviourCollection.add((Behaviour) model);
        	}
        
        	return behaviourCollection;
        }

        public static Behaviour retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Behaviour.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Behaviour) gateway.retrieve(ResourceType.BEHAVIOUR, id);
        }

        public string getBehaviourName ()
        {
            return this.getProperty("behaviourName").ToString();
        }

        public void setBehaviourName (string behaviourName)
        {
            this.setProperty("behaviourName", behaviourName);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public string getSeverity ()
        {
            return this.getProperty("severity").ToString();
        }

        public void setSeverity (string severity)
        {
            this.setProperty("severity", severity);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public bool getIsMyClassroomDefault ()
        {
            return Convert.ToBoolean(this.getProperty("isMyClassroomDefault"));
        }

        public void setIsMyClassroomDefault (bool isMyClassroomDefault)
        {
            this.setProperty("isMyClassroomDefault", isMyClassroomDefault);
        }


    }
}

