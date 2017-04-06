using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TrainingEvent : ModelBase
    {
        protected string resourceType = ResourceType.TRAINING_EVENT;
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string LOCATION_TEXT = "locationText";
        public const string LOCATION = "location";
        public const string SCHEDULED_BY = "scheduledBy";
        public const string TRAINING_EVENT_TITLE = "trainingEventTitle";
        public const string TRAINING_COURSE = "trainingCourse";

        public TrainingEvent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TrainingEvent (string resourceType = "TrainingEvent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TrainingEvent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TrainingEvent");
        	RestGateway gateway = (RestGateway) TrainingEvent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TrainingEvent> trainingeventCollection = new ModelCollection<TrainingEvent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    trainingeventCollection.add((TrainingEvent) model);
        	}
        
        	return trainingeventCollection;
        }

        public static TrainingEvent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TrainingEvent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TrainingEvent) gateway.retrieve(ResourceType.TRAINING_EVENT, id);
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

        public string getTrainingEventTitle ()
        {
            return this.getProperty("trainingEventTitle").ToString();
        }

        public void setTrainingEventTitle (string trainingEventTitle)
        {
            this.setProperty("trainingEventTitle", trainingEventTitle);
        }

        public TrainingCourse getTrainingCourse ()
        {
            return (TrainingCourse) this.getProperty("trainingCourse");
        }

        public void setTrainingCourse (TrainingCourse trainingCourse)
        {
            this.setProperty("trainingCourse", trainingCourse);
        }


    }
}

