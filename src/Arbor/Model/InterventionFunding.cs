using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionFunding : ModelBase
    {
        protected new string resourceType = ResourceType.INTERVENTION_FUNDING;
        public const string INTERVENTION = "intervention";
        public const string STUDENT = "student";
        public const string INTERVENTION_FUNDING_SOURCE = "interventionFundingSource";
        public const string FUNDING_AMOUNT = "fundingAmount";
        public const string FUNDING_PERCENTAGE = "fundingPercentage";

        public InterventionFunding ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionFunding (string resourceType = "InterventionFunding", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionFunding> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionFunding");
        	RestGateway gateway = (RestGateway) InterventionFunding.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionFunding> interventionfundingCollection = new ModelCollection<InterventionFunding> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventionfundingCollection.add((InterventionFunding) model);
        	}
        
        	return interventionfundingCollection;
        }

        public static InterventionFunding retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionFunding.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionFunding) gateway.retrieve(ResourceType.INTERVENTION_FUNDING, id);
        }

        public Intervention getIntervention ()
        {
            return (Intervention) this.getProperty("intervention");
        }

        public void setIntervention (Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public InterventionFundingSource getInterventionFundingSource ()
        {
            return (InterventionFundingSource) this.getProperty("interventionFundingSource");
        }

        public void setInterventionFundingSource (InterventionFundingSource interventionFundingSource)
        {
            this.setProperty("interventionFundingSource", interventionFundingSource);
        }

        public string getFundingAmount ()
        {
            return this.getProperty("fundingAmount").ToString();
        }

        public void setFundingAmount (string fundingAmount)
        {
            this.setProperty("fundingAmount", fundingAmount);
        }

        public float getFundingPercentage ()
        {
            return (float) this.getProperty("fundingPercentage");
        }

        public void setFundingPercentage (float fundingPercentage)
        {
            this.setProperty("fundingPercentage", fundingPercentage);
        }


    }
}

