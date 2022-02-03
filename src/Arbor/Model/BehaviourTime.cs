using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviourTime : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOUR_TIME;
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";
        public const string NAME = "name";

        public BehaviourTime ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviourTime (string resourceType = "BehaviourTime", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviourTime> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviourTime");
        	RestGateway gateway = (RestGateway) BehaviourTime.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviourTime> behaviourtimeCollection = new ModelCollection<BehaviourTime> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviourtimeCollection.add((BehaviourTime) model);
        	}
        
        	return behaviourtimeCollection;
        }

        public static BehaviourTime retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviourTime.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviourTime) gateway.retrieve(ResourceType.BEHAVIOUR_TIME, id);
        }

        public string getStartTime ()
        {
            return this.getProperty("startTime").ToString();
        }

        public void setStartTime (string startTime)
        {
            this.setProperty("startTime", startTime);
        }

        public string getEndTime ()
        {
            return this.getProperty("endTime").ToString();
        }

        public void setEndTime (string endTime)
        {
            this.setProperty("endTime", endTime);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }


    }
}

