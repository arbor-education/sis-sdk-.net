using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionStaff : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_STAFF;
        public const string INTERVENTION = "intervention";
        public const string BUSINESS_ROLE = "businessRole";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public InterventionStaff ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionStaff (string resourceType = "InterventionStaff", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionStaff> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionStaff");
        	RestGateway gateway = (RestGateway) InterventionStaff.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionStaff> interventionstaffCollection = new ModelCollection<InterventionStaff> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventionstaffCollection.add((InterventionStaff) model);
        	}
        
        	return interventionstaffCollection;
        }

        public static InterventionStaff retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionStaff.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionStaff) gateway.retrieve(ResourceType.INTERVENTION_STAFF, id);
        }

        public Intervention getIntervention ()
        {
            return (Intervention) this.getProperty("intervention");
        }

        public void setIntervention (Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public BusinessRole getBusinessRole ()
        {
            return (BusinessRole) this.getProperty("businessRole");
        }

        public void setBusinessRole (BusinessRole businessRole)
        {
            this.setProperty("businessRole", businessRole);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

