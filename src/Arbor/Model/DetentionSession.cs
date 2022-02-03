using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DetentionSession : ModelBase
    {
        protected string resourceType = ResourceType.DETENTION_SESSION;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string DETENTION_TYPE = "detentionType";
        public const string TIMETABLE_SLOT = "timetableSlot";

        public DetentionSession ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DetentionSession (string resourceType = "DetentionSession", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DetentionSession> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DetentionSession");
        	RestGateway gateway = (RestGateway) DetentionSession.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DetentionSession> detentionsessionCollection = new ModelCollection<DetentionSession> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    detentionsessionCollection.add((DetentionSession) model);
        	}
        
        	return detentionsessionCollection;
        }

        public static DetentionSession retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DetentionSession.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DetentionSession) gateway.retrieve(ResourceType.DETENTION_SESSION, id);
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

        public DetentionType getDetentionType ()
        {
            return (DetentionType) this.getProperty("detentionType");
        }

        public void setDetentionType (DetentionType detentionType)
        {
            this.setProperty("detentionType", detentionType);
        }

        public TimetableSlot getTimetableSlot ()
        {
            return (TimetableSlot) this.getProperty("timetableSlot");
        }

        public void setTimetableSlot (TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }


    }
}

