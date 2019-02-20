using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EventParticipantInvitation : ModelBase
    {
        protected string resourceType = ResourceType.EVENT_PARTICIPANT_INVITATION;
        public const string EVENT_PARTICIPANT = "eventParticipant";
        public const string INVITEE = "invitee";
        public const string INVITATION_DATETIME = "invitationDatetime";
        public const string INVITATION_STATUS = "invitationStatus";
        public const string STATUS_CHANGED_DATETIME = "statusChangedDatetime";
        public const string INVITATION_MESSAGE = "invitationMessage";
        public const string INVITATION_REPLY = "invitationReply";

        public EventParticipantInvitation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EventParticipantInvitation (string resourceType = "EventParticipantInvitation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EventParticipantInvitation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EventParticipantInvitation");
        	RestGateway gateway = (RestGateway) EventParticipantInvitation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EventParticipantInvitation> eventparticipantinvitationCollection = new ModelCollection<EventParticipantInvitation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    eventparticipantinvitationCollection.add((EventParticipantInvitation) model);
        	}
        
        	return eventparticipantinvitationCollection;
        }

        public static EventParticipantInvitation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EventParticipantInvitation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EventParticipantInvitation) gateway.retrieve(ResourceType.EVENT_PARTICIPANT_INVITATION, id);
        }

        public EventParticipant getEventParticipant ()
        {
            return (EventParticipant) this.getProperty("eventParticipant");
        }

        public void setEventParticipant (EventParticipant eventParticipant)
        {
            this.setProperty("eventParticipant", eventParticipant);
        }

        public ModelBase getInvitee ()
        {
            return (ModelBase) this.getProperty("invitee");
        }

        public void setInvitee (ModelBase invitee)
        {
            this.setProperty("invitee", invitee);
        }

        public DateTime getInvitationDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("invitationDatetime"));
        }

        public void setInvitationDatetime (DateTime invitationDatetime)
        {
            this.setProperty("invitationDatetime", invitationDatetime);
        }

        public string getInvitationStatus ()
        {
            return this.getProperty("invitationStatus").ToString();
        }

        public void setInvitationStatus (string invitationStatus)
        {
            this.setProperty("invitationStatus", invitationStatus);
        }

        public DateTime getStatusChangedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("statusChangedDatetime"));
        }

        public void setStatusChangedDatetime (DateTime statusChangedDatetime)
        {
            this.setProperty("statusChangedDatetime", statusChangedDatetime);
        }

        public string getInvitationMessage ()
        {
            return this.getProperty("invitationMessage").ToString();
        }

        public void setInvitationMessage (string invitationMessage)
        {
            this.setProperty("invitationMessage", invitationMessage);
        }

        public string getInvitationReply ()
        {
            return this.getProperty("invitationReply").ToString();
        }

        public void setInvitationReply (string invitationReply)
        {
            this.setProperty("invitationReply", invitationReply);
        }


    }
}

