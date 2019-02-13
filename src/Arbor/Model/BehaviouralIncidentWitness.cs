using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentWitness : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_WITNESS;
        public const string BEHAVIOURAL_INCIDENT = "behaviouralIncident";
        public const string WITNESS = "witness";
        public const string NARRATIVE = "narrative";
        public const string CONFIRMED_DATETIME = "confirmedDatetime";

        public BehaviouralIncidentWitness ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralIncidentWitness (string resourceType = "BehaviouralIncidentWitness", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralIncidentWitness> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralIncidentWitness");
        	RestGateway gateway = (RestGateway) BehaviouralIncidentWitness.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralIncidentWitness> behaviouralincidentwitnessCollection = new ModelCollection<BehaviouralIncidentWitness> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralincidentwitnessCollection.add((BehaviouralIncidentWitness) model);
        	}
        
        	return behaviouralincidentwitnessCollection;
        }

        public static BehaviouralIncidentWitness retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralIncidentWitness.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralIncidentWitness) gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_WITNESS, id);
        }

        public BehaviouralIncident getBehaviouralIncident ()
        {
            return (BehaviouralIncident) this.getProperty("behaviouralIncident");
        }

        public void setBehaviouralIncident (BehaviouralIncident behaviouralIncident)
        {
            this.setProperty("behaviouralIncident", behaviouralIncident);
        }

        public ModelBase getWitness ()
        {
            return (ModelBase) this.getProperty("witness");
        }

        public void setWitness (ModelBase witness)
        {
            this.setProperty("witness", witness);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getConfirmedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("confirmedDatetime"))
        }

        public void setConfirmedDatetime (DateTime confirmedDatetime)
        {
            this.setProperty("confirmedDatetime", confirmedDatetime);
        }


    }
}

