using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralContractParty : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_CONTRACT_PARTY;
        public const string BEHAVIOURAL_CONTRACT = "behaviouralContract";
        public const string PARTY = "party";
        public const string RESPONSIBLE = "responsible";

        public BehaviouralContractParty ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralContractParty (string resourceType = "BehaviouralContractParty", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralContractParty> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralContractParty");
        	RestGateway gateway = (RestGateway) BehaviouralContractParty.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralContractParty> behaviouralcontractpartyCollection = new ModelCollection<BehaviouralContractParty> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralcontractpartyCollection.add((BehaviouralContractParty) model);
        	}
        
        	return behaviouralcontractpartyCollection;
        }

        public static BehaviouralContractParty retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralContractParty.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralContractParty) gateway.retrieve(ResourceType.BEHAVIOURAL_CONTRACT_PARTY, id);
        }

        public BehaviouralContract getBehaviouralContract ()
        {
            return (BehaviouralContract) this.getProperty("behaviouralContract");
        }

        public void setBehaviouralContract (BehaviouralContract behaviouralContract)
        {
            this.setProperty("behaviouralContract", behaviouralContract);
        }

        public ModelBase getParty ()
        {
            return (ModelBase) this.getProperty("party");
        }

        public void setParty (ModelBase party)
        {
            this.setProperty("party", party);
        }

        public bool getResponsible ()
        {
            return Convert.ToBoolean(this.getProperty("responsible"))
        }

        public void setResponsible (bool responsible)
        {
            this.setProperty("responsible", responsible);
        }


    }
}

