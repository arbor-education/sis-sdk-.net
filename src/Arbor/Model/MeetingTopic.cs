using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MeetingTopic : ModelBase
    {
        protected new string resourceType = ResourceType.MEETING_TOPIC;
        public const string MEETING = "meeting";
        public const string TOPIC = "topic";

        public MeetingTopic ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MeetingTopic (string resourceType = "MeetingTopic", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MeetingTopic> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MeetingTopic");
        	RestGateway gateway = (RestGateway) MeetingTopic.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MeetingTopic> meetingtopicCollection = new ModelCollection<MeetingTopic> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    meetingtopicCollection.add((MeetingTopic) model);
        	}
        
        	return meetingtopicCollection;
        }

        public static MeetingTopic retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MeetingTopic.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MeetingTopic) gateway.retrieve(ResourceType.MEETING_TOPIC, id);
        }

        public Meeting getMeeting ()
        {
            return (Meeting) this.getProperty("meeting");
        }

        public void setMeeting (Meeting meeting)
        {
            this.setProperty("meeting", meeting);
        }

        public ModelBase getTopic ()
        {
            return (ModelBase) this.getProperty("topic");
        }

        public void setTopic (ModelBase topic)
        {
            this.setProperty("topic", topic);
        }


    }
}

