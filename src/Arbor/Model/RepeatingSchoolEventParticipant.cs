using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RepeatingSchoolEventParticipant : ModelBase
    {
        protected new string resourceType = ResourceType.REPEATING_SCHOOL_EVENT_PARTICIPANT;
        public const string REPEATING_SCHOOL_EVENT = "repeatingSchoolEvent";
        public const string PARTICIPANT = "participant";

        public RepeatingSchoolEventParticipant ()
        {
            base.resourceType = this.resourceType;
        }
        
        public RepeatingSchoolEventParticipant (string resourceType = "RepeatingSchoolEventParticipant", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<RepeatingSchoolEventParticipant> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("RepeatingSchoolEventParticipant");
        	RestGateway gateway = (RestGateway) RepeatingSchoolEventParticipant.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<RepeatingSchoolEventParticipant> repeatingschooleventparticipantCollection = new ModelCollection<RepeatingSchoolEventParticipant> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    repeatingschooleventparticipantCollection.add((RepeatingSchoolEventParticipant) model);
        	}
        
        	return repeatingschooleventparticipantCollection;
        }

        public static RepeatingSchoolEventParticipant retrieve (string id)
        {
            RestGateway gateway = (RestGateway) RepeatingSchoolEventParticipant.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (RepeatingSchoolEventParticipant) gateway.retrieve(ResourceType.REPEATING_SCHOOL_EVENT_PARTICIPANT, id);
        }

        public RepeatingSchoolEvent getRepeatingSchoolEvent ()
        {
            return (RepeatingSchoolEvent) this.getProperty("repeatingSchoolEvent");
        }

        public void setRepeatingSchoolEvent (RepeatingSchoolEvent repeatingSchoolEvent)
        {
            this.setProperty("repeatingSchoolEvent", repeatingSchoolEvent);
        }

        public ModelBase getParticipant ()
        {
            return (ModelBase) this.getProperty("participant");
        }

        public void setParticipant (ModelBase participant)
        {
            this.setProperty("participant", participant);
        }


    }
}

