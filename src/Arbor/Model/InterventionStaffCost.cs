using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionStaffCost : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_STAFF_COST;
        public const string STAFF = "staff";
        public const string COST_PER_HOUR = "costPerHour";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string ROUND_TO_NEAREST = "roundToNearest";
        public const string MINIMUM_CHARGE = "minimumCharge";

        public InterventionStaffCost ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionStaffCost (string resourceType = "InterventionStaffCost", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionStaffCost> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionStaffCost");
        	RestGateway gateway = (RestGateway) InterventionStaffCost.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionStaffCost> interventionstaffcostCollection = new ModelCollection<InterventionStaffCost> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventionstaffcostCollection.add((InterventionStaffCost) model);
        	}
        
        	return interventionstaffcostCollection;
        }

        public static InterventionStaffCost retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionStaffCost.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionStaffCost) gateway.retrieve(ResourceType.INTERVENTION_STAFF_COST, id);
        }

        public ModelBase getStaff ()
        {
            return (ModelBase) this.getProperty("staff");
        }

        public void setStaff (ModelBase staff)
        {
            this.setProperty("staff", staff);
        }

        public string getCostPerHour ()
        {
            return this.getProperty("costPerHour").ToString();
        }

        public void setCostPerHour (string costPerHour)
        {
            this.setProperty("costPerHour", costPerHour);
        }

        public DateTime getEffectiveDate ()
        {
            return (DateTime) this.getProperty("effectiveDate");
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getRoundToNearest ()
        {
            return this.getProperty("roundToNearest").ToString();
        }

        public void setRoundToNearest (string roundToNearest)
        {
            this.setProperty("roundToNearest", roundToNearest);
        }

        public string getMinimumCharge ()
        {
            return this.getProperty("minimumCharge").ToString();
        }

        public void setMinimumCharge (string minimumCharge)
        {
            this.setProperty("minimumCharge", minimumCharge);
        }


    }
}

