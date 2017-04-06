using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InvigilationDuty : ModelBase
    {
        protected string resourceType = ResourceType.INVIGILATION_DUTY;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string SCHEDULED_BY = "scheduledBy";
        public const string STAFF = "staff";
        public const string INVIGILATION_SESSION = "invigilationSession";

        public InvigilationDuty ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InvigilationDuty (string resourceType = "InvigilationDuty", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InvigilationDuty> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InvigilationDuty");
        	RestGateway gateway = (RestGateway) InvigilationDuty.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InvigilationDuty> invigilationdutyCollection = new ModelCollection<InvigilationDuty> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    invigilationdutyCollection.add((InvigilationDuty) model);
        	}
        
        	return invigilationdutyCollection;
        }

        public static InvigilationDuty retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InvigilationDuty.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InvigilationDuty) gateway.retrieve(ResourceType.INVIGILATION_DUTY, id);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return (DateTime) this.getProperty("endDatetime");
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public string getLocationText ()
        {
            return this.getProperty("locationText").ToString();
        }

        public void setLocationText (string locationText)
        {
            this.setProperty("locationText", locationText);
        }

        public Room getLocation ()
        {
            return (Room) this.getProperty("location");
        }

        public void setLocation (Room location)
        {
            this.setProperty("location", location);
        }

        public ModelBase getScheduledBy ()
        {
            return (ModelBase) this.getProperty("scheduledBy");
        }

        public void setScheduledBy (ModelBase scheduledBy)
        {
            this.setProperty("scheduledBy", scheduledBy);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public InvigilationSession getInvigilationSession ()
        {
            return (InvigilationSession) this.getProperty("invigilationSession");
        }

        public void setInvigilationSession (InvigilationSession invigilationSession)
        {
            this.setProperty("invigilationSession", invigilationSession);
        }


    }
}

