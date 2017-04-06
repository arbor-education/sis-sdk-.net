using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EventParticipant : ModelBase
    {
        protected string resourceType = ResourceType.EVENT_PARTICIPANT;
        public const string EVENT = "event";
        public const string PARTICIPANT = "participant";
        public const string ATTENDANCE_REQUIREMENT = "attendanceRequirement";

        public EventParticipant ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EventParticipant (string resourceType = "EventParticipant", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EventParticipant> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EventParticipant");
        	RestGateway gateway = (RestGateway) EventParticipant.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EventParticipant> eventparticipantCollection = new ModelCollection<EventParticipant> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    eventparticipantCollection.add((EventParticipant) model);
        	}
        
        	return eventparticipantCollection;
        }

        public static EventParticipant retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EventParticipant.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EventParticipant) gateway.retrieve(ResourceType.EVENT_PARTICIPANT, id);
        }

        public ModelBase getEvent ()
        {
            return (ModelBase) this.getProperty("event");
        }

        public void setEvent (ModelBase _event)
        {
            this.setProperty("event", _event);
        }

        public ModelBase getParticipant ()
        {
            return (ModelBase) this.getProperty("participant");
        }

        public void setParticipant (ModelBase participant)
        {
            this.setProperty("participant", participant);
        }

        public string getAttendanceRequirement ()
        {
            return this.getProperty("attendanceRequirement").ToString();
        }

        public void setAttendanceRequirement (string attendanceRequirement)
        {
            this.setProperty("attendanceRequirement", attendanceRequirement);
        }


    }
}

