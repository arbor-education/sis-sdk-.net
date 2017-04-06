using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionPlannedStaff : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_PLANNED_STAFF;
        public const string INTERVENTION = "intervention";
        public const string STAFF = "staff";
        public const string PLANNED_HOURS = "plannedHours";

        public InterventionPlannedStaff ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionPlannedStaff (string resourceType = "InterventionPlannedStaff", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionPlannedStaff> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionPlannedStaff");
        	RestGateway gateway = (RestGateway) InterventionPlannedStaff.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionPlannedStaff> interventionplannedstaffCollection = new ModelCollection<InterventionPlannedStaff> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventionplannedstaffCollection.add((InterventionPlannedStaff) model);
        	}
        
        	return interventionplannedstaffCollection;
        }

        public static InterventionPlannedStaff retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionPlannedStaff.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionPlannedStaff) gateway.retrieve(ResourceType.INTERVENTION_PLANNED_STAFF, id);
        }

        public Intervention getIntervention ()
        {
            return (Intervention) this.getProperty("intervention");
        }

        public void setIntervention (Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public ModelBase getStaff ()
        {
            return (ModelBase) this.getProperty("staff");
        }

        public void setStaff (ModelBase staff)
        {
            this.setProperty("staff", staff);
        }

        public string getPlannedHours ()
        {
            return this.getProperty("plannedHours").ToString();
        }

        public void setPlannedHours (string plannedHours)
        {
            this.setProperty("plannedHours", plannedHours);
        }


    }
}

