using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentWatcher : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_WATCHER;
        public const string BEHAVIOURAL_INCIDENT = "behaviouralIncident";
        public const string STAFF = "staff";

        public BehaviouralIncidentWatcher ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralIncidentWatcher (string resourceType = "BehaviouralIncidentWatcher", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralIncidentWatcher> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralIncidentWatcher");
        	RestGateway gateway = (RestGateway) BehaviouralIncidentWatcher.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralIncidentWatcher> behaviouralincidentwatcherCollection = new ModelCollection<BehaviouralIncidentWatcher> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralincidentwatcherCollection.add((BehaviouralIncidentWatcher) model);
        	}
        
        	return behaviouralincidentwatcherCollection;
        }

        public static BehaviouralIncidentWatcher retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralIncidentWatcher.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralIncidentWatcher) gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_WATCHER, id);
        }

        public BehaviouralIncident getBehaviouralIncident ()
        {
            return (BehaviouralIncident) this.getProperty("behaviouralIncident");
        }

        public void setBehaviouralIncident (BehaviouralIncident behaviouralIncident)
        {
            this.setProperty("behaviouralIncident", behaviouralIncident);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }


    }
}

