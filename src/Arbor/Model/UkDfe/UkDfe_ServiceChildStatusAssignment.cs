using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_ServiceChildStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SERVICE_CHILD_STATUS_ASSIGNMENT;
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public UkDfe_ServiceChildStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_ServiceChildStatusAssignment (string resourceType = "UkDfe_ServiceChildStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_ServiceChildStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ServiceChildStatusAssignment");
        	RestGateway gateway = (RestGateway) UkDfe_ServiceChildStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_ServiceChildStatusAssignment> ukdfe_servicechildstatusassignmentCollection = new ModelCollection<UkDfe_ServiceChildStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_servicechildstatusassignmentCollection.add((UkDfe_ServiceChildStatusAssignment) model);
        	}
        
        	return ukdfe_servicechildstatusassignmentCollection;
        }

        public static UkDfe_ServiceChildStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_ServiceChildStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_ServiceChildStatusAssignment) gateway.retrieve(ResourceType.UK_DFE_SERVICE_CHILD_STATUS_ASSIGNMENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
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

