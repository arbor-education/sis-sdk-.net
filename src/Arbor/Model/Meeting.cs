using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Meeting : ModelBase
    {
        protected string resourceType = ResourceType.MEETING;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string MEETING_NAME = "meetingName";
        public const string ALLOW_SELF_SERVICE_SCHEDULING = "allowSelfServiceScheduling";
        public const string SELF_SCHEDULING_OPENS_DATETIME = "selfSchedulingOpensDatetime";
        public const string SELF_SCHEDULING_CLOSES_DATETIME = "selfSchedulingClosesDatetime";
        public const string SCHEDULE_MINIMUM_DURATION = "scheduleMinimumDuration";
        public const string SCHEDULE_MAXIMUM_DURATION = "scheduleMaximumDuration";
        public const string SCHEDULE_SUGGESTED_DURATION = "scheduleSuggestedDuration";
        public const string SCHEDULE_LOCATION = "scheduleLocation";
        public const string ALLOW_DUPLICATE_SCHEDULING = "allowDuplicateScheduling";
        public const string AIMS = "aims";
        public const string AGENDA = "agenda";
        public const string OUTCOMES = "outcomes";

        public Meeting ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Meeting (string resourceType = "Meeting", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Meeting> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Meeting");
        	RestGateway gateway = (RestGateway) Meeting.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Meeting> meetingCollection = new ModelCollection<Meeting> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    meetingCollection.add((Meeting) model);
        	}
        
        	return meetingCollection;
        }

        public static Meeting retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Meeting.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Meeting) gateway.retrieve(ResourceType.MEETING, id);
        }

        public DateTime getStartDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"))
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"))
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

        public string getMeetingName ()
        {
            return this.getProperty("meetingName").ToString();
        }

        public void setMeetingName (string meetingName)
        {
            this.setProperty("meetingName", meetingName);
        }

        public bool getAllowSelfServiceScheduling ()
        {
            return Convert.ToBoolean(this.getProperty("allowSelfServiceScheduling"))
        }

        public void setAllowSelfServiceScheduling (bool allowSelfServiceScheduling)
        {
            this.setProperty("allowSelfServiceScheduling", allowSelfServiceScheduling);
        }

        public DateTime getSelfSchedulingOpensDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("selfSchedulingOpensDatetime"))
        }

        public void setSelfSchedulingOpensDatetime (DateTime selfSchedulingOpensDatetime)
        {
            this.setProperty("selfSchedulingOpensDatetime", selfSchedulingOpensDatetime);
        }

        public DateTime getSelfSchedulingClosesDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("selfSchedulingClosesDatetime"))
        }

        public void setSelfSchedulingClosesDatetime (DateTime selfSchedulingClosesDatetime)
        {
            this.setProperty("selfSchedulingClosesDatetime", selfSchedulingClosesDatetime);
        }

        public string getScheduleMinimumDuration ()
        {
            return this.getProperty("scheduleMinimumDuration").ToString();
        }

        public void setScheduleMinimumDuration (string scheduleMinimumDuration)
        {
            this.setProperty("scheduleMinimumDuration", scheduleMinimumDuration);
        }

        public string getScheduleMaximumDuration ()
        {
            return this.getProperty("scheduleMaximumDuration").ToString();
        }

        public void setScheduleMaximumDuration (string scheduleMaximumDuration)
        {
            this.setProperty("scheduleMaximumDuration", scheduleMaximumDuration);
        }

        public string getScheduleSuggestedDuration ()
        {
            return this.getProperty("scheduleSuggestedDuration").ToString();
        }

        public void setScheduleSuggestedDuration (string scheduleSuggestedDuration)
        {
            this.setProperty("scheduleSuggestedDuration", scheduleSuggestedDuration);
        }

        public Room getScheduleLocation ()
        {
            return (Room) this.getProperty("scheduleLocation");
        }

        public void setScheduleLocation (Room scheduleLocation)
        {
            this.setProperty("scheduleLocation", scheduleLocation);
        }

        public bool getAllowDuplicateScheduling ()
        {
            return Convert.ToBoolean(this.getProperty("allowDuplicateScheduling"))
        }

        public void setAllowDuplicateScheduling (bool allowDuplicateScheduling)
        {
            this.setProperty("allowDuplicateScheduling", allowDuplicateScheduling);
        }

        public string getAims ()
        {
            return this.getProperty("aims").ToString();
        }

        public void setAims (string aims)
        {
            this.setProperty("aims", aims);
        }

        public string getAgenda ()
        {
            return this.getProperty("agenda").ToString();
        }

        public void setAgenda (string agenda)
        {
            this.setProperty("agenda", agenda);
        }

        public string getOutcomes ()
        {
            return this.getProperty("outcomes").ToString();
        }

        public void setOutcomes (string outcomes)
        {
            this.setProperty("outcomes", outcomes);
        }


    }
}

