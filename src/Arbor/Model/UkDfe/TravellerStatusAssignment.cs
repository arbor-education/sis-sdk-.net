using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class TravellerStatusAssignment : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_TRAVELLER_STATUS_ASSIGNMENT;
        public const string TRAVELLER_STATUS = "travellerStatus";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string INFORMATION_SOURCE = "informationSource";

        public TravellerStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TravellerStatusAssignment (string resourceType = "TravellerStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TravellerStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_TravellerStatusAssignment");
        	RestGateway gateway = (RestGateway) TravellerStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TravellerStatusAssignment> travellerstatusassignmentCollection = new ModelCollection<TravellerStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    travellerstatusassignmentCollection.add((TravellerStatusAssignment) model);
        	}
        
        	return travellerstatusassignmentCollection;
        }

        public static TravellerStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TravellerStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TravellerStatusAssignment) gateway.retrieve(ResourceType.UK_DFE_TRAVELLER_STATUS_ASSIGNMENT, id);
        }

        public TravellerStatus getTravellerStatus ()
        {
            return (TravellerStatus) this.getProperty("travellerStatus");
        }

        public void setTravellerStatus (TravellerStatus travellerStatus)
        {
            this.setProperty("travellerStatus", travellerStatus);
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

        public string getInformationSource ()
        {
            return this.getProperty("informationSource").ToString();
        }

        public void setInformationSource (string informationSource)
        {
            this.setProperty("informationSource", informationSource);
        }


    }
}

