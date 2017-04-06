using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionCost : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_COST;
        public const string INTERVENTION = "intervention";
        public const string AMOUNT = "amount";
        public const string DESCRIPTION = "description";

        public InterventionCost ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionCost (string resourceType = "InterventionCost", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionCost> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionCost");
        	RestGateway gateway = (RestGateway) InterventionCost.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionCost> interventioncostCollection = new ModelCollection<InterventionCost> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventioncostCollection.add((InterventionCost) model);
        	}
        
        	return interventioncostCollection;
        }

        public static InterventionCost retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionCost.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionCost) gateway.retrieve(ResourceType.INTERVENTION_COST, id);
        }

        public Intervention getIntervention ()
        {
            return (Intervention) this.getProperty("intervention");
        }

        public void setIntervention (Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public string getAmount ()
        {
            return this.getProperty("amount").ToString();
        }

        public void setAmount (string amount)
        {
            this.setProperty("amount", amount);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

