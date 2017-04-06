using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentStaffInvolvement : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_STAFF_INVOLVEMENT;
        public const string BEHAVIOURAL_INCIDENT = "behaviouralIncident";
        public const string STAFF = "staff";

        public BehaviouralIncidentStaffInvolvement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralIncidentStaffInvolvement (string resourceType = "BehaviouralIncidentStaffInvolvement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralIncidentStaffInvolvement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralIncidentStaffInvolvement");
        	RestGateway gateway = (RestGateway) BehaviouralIncidentStaffInvolvement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralIncidentStaffInvolvement> behaviouralincidentstaffinvolvementCollection = new ModelCollection<BehaviouralIncidentStaffInvolvement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralincidentstaffinvolvementCollection.add((BehaviouralIncidentStaffInvolvement) model);
        	}
        
        	return behaviouralincidentstaffinvolvementCollection;
        }

        public static BehaviouralIncidentStaffInvolvement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralIncidentStaffInvolvement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralIncidentStaffInvolvement) gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_STAFF_INVOLVEMENT, id);
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

