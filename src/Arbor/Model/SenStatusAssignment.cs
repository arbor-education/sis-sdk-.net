using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.SEN_STATUS_ASSIGNMENT;
        public const string SEN_STATUS = "senStatus";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public SenStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SenStatusAssignment (string resourceType = "SenStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SenStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SenStatusAssignment");
        	RestGateway gateway = (RestGateway) SenStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SenStatusAssignment> senstatusassignmentCollection = new ModelCollection<SenStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    senstatusassignmentCollection.add((SenStatusAssignment) model);
        	}
        
        	return senstatusassignmentCollection;
        }

        public static SenStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SenStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SenStatusAssignment) gateway.retrieve(ResourceType.SEN_STATUS_ASSIGNMENT, id);
        }

        public SenStatus getSenStatus ()
        {
            return (SenStatus) this.getProperty("senStatus");
        }

        public void setSenStatus (SenStatus senStatus)
        {
            this.setProperty("senStatus", senStatus);
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
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

