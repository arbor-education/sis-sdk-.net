using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenEvent : ModelBase
    {
        protected new string resourceType = ResourceType.SEN_EVENT;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string STUDENT = "student";
        public const string SEN_EVENT_TYPE = "senEventType";
        public const string SEN_EVENT_NAME = "senEventName";
        public const string SEN_EVENT_DESCRIPTION = "senEventDescription";

        public SenEvent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SenEvent (string resourceType = "SenEvent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SenEvent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SenEvent");
        	RestGateway gateway = (RestGateway) SenEvent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SenEvent> seneventCollection = new ModelCollection<SenEvent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    seneventCollection.add((SenEvent) model);
        	}
        
        	return seneventCollection;
        }

        public static SenEvent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SenEvent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SenEvent) gateway.retrieve(ResourceType.SEN_EVENT, id);
        }

        public DateTime getStartDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
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

        public ModelBase getLocation ()
        {
            return (ModelBase) this.getProperty("location");
        }

        public void setLocation (ModelBase location)
        {
            this.setProperty("location", location);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public SenEventType getSenEventType ()
        {
            return (SenEventType) this.getProperty("senEventType");
        }

        public void setSenEventType (SenEventType senEventType)
        {
            this.setProperty("senEventType", senEventType);
        }

        public string getSenEventName ()
        {
            return this.getProperty("senEventName").ToString();
        }

        public void setSenEventName (string senEventName)
        {
            this.setProperty("senEventName", senEventName);
        }

        public string getSenEventDescription ()
        {
            return this.getProperty("senEventDescription").ToString();
        }

        public void setSenEventDescription (string senEventDescription)
        {
            this.setProperty("senEventDescription", senEventDescription);
        }


    }
}

