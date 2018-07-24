using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncident : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_INCIDENT;
        public const string BEHAVIOUR = "behaviour";
        public const string INCIDENT_NAME = "incidentName";
        public const string NARRATIVE = "narrative";
        public const string INCIDENT_DATETIME = "incidentDatetime";
        public const string SEVERITY = "severity";
        public const string EVENT = "event";
        public const string LOCATION = "location";
        public const string RESOLVED_DATETIME = "resolvedDatetime";

        public BehaviouralIncident ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralIncident (string resourceType = "BehaviouralIncident", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralIncident> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralIncident");
        	RestGateway gateway = (RestGateway) BehaviouralIncident.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralIncident> behaviouralincidentCollection = new ModelCollection<BehaviouralIncident> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralincidentCollection.add((BehaviouralIncident) model);
        	}
        
        	return behaviouralincidentCollection;
        }

        public static BehaviouralIncident retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralIncident.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralIncident) gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT, id);
        }

        public Behaviour getBehaviour ()
        {
            return (Behaviour) this.getProperty("behaviour");
        }

        public void setBehaviour (Behaviour behaviour)
        {
            this.setProperty("behaviour", behaviour);
        }

        public string getIncidentName ()
        {
            return this.getProperty("incidentName").ToString();
        }

        public void setIncidentName (string incidentName)
        {
            this.setProperty("incidentName", incidentName);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getIncidentDatetime (){
            return Convert.ToDateTime(this.getProperty("incidentDatetime"));
        }

        public void setIncidentDatetime (DateTime incidentDatetime)
        {
            this.setProperty("incidentDatetime", incidentDatetime);
        }

        public string getSeverity ()
        {
            return this.getProperty("severity").ToString();
        }

        public void setSeverity (string severity)
        {
            this.setProperty("severity", severity);
        }

        public ModelBase getEvent ()
        {
            return (ModelBase) this.getProperty("event");
        }

        public void setEvent (ModelBase _event)
        {
            this.setProperty("event", _event);
        }

        public ModelBase getLocation ()
        {
            return (ModelBase) this.getProperty("location");
        }

        public void setLocation (ModelBase location)
        {
            this.setProperty("location", location);
        }

        public DateTime getResolvedDatetime (){
            return Convert.ToDateTime(this.getProperty("resolvedDatetime"));
        }

        public void setResolvedDatetime (DateTime resolvedDatetime)
        {
            this.setProperty("resolvedDatetime", resolvedDatetime);
        }


    }
}

