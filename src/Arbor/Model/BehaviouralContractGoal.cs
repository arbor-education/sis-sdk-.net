using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralContractGoal : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_CONTRACT_GOAL;
        public const string BEHAVIOURAL_CONTRACT = "behaviouralContract";
        public const string DESCRIPTION = "description";
        public const string FREQUENCY = "frequency";
        public const string BEHAVIOUR = "behaviour";

        public BehaviouralContractGoal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralContractGoal (string resourceType = "BehaviouralContractGoal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralContractGoal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralContractGoal");
        	RestGateway gateway = (RestGateway) BehaviouralContractGoal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralContractGoal> behaviouralcontractgoalCollection = new ModelCollection<BehaviouralContractGoal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralcontractgoalCollection.add((BehaviouralContractGoal) model);
        	}
        
        	return behaviouralcontractgoalCollection;
        }

        public static BehaviouralContractGoal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralContractGoal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralContractGoal) gateway.retrieve(ResourceType.BEHAVIOURAL_CONTRACT_GOAL, id);
        }

        public BehaviouralContract getBehaviouralContract ()
        {
            return (BehaviouralContract) this.getProperty("behaviouralContract");
        }

        public void setBehaviouralContract (BehaviouralContract behaviouralContract)
        {
            this.setProperty("behaviouralContract", behaviouralContract);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public string getFrequency ()
        {
            return this.getProperty("frequency").ToString();
        }

        public void setFrequency (string frequency)
        {
            this.setProperty("frequency", frequency);
        }

        public Behaviour getBehaviour ()
        {
            return (Behaviour) this.getProperty("behaviour");
        }

        public void setBehaviour (Behaviour behaviour)
        {
            this.setProperty("behaviour", behaviour);
        }


    }
}

