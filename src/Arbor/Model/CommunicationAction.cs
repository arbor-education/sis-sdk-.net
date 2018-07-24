using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CommunicationAction : ModelBase
    {
        protected string resourceType = ResourceType.COMMUNICATION_ACTION;
        public const string COMMUNICATION = "communication";
        public const string ACTION_TAKEN = "actionTaken";
        public const string REPLY = "reply";
        public const string ACTION_DATETIME = "actionDatetime";

        public CommunicationAction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CommunicationAction (string resourceType = "CommunicationAction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CommunicationAction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CommunicationAction");
        	RestGateway gateway = (RestGateway) CommunicationAction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CommunicationAction> communicationactionCollection = new ModelCollection<CommunicationAction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    communicationactionCollection.add((CommunicationAction) model);
        	}
        
        	return communicationactionCollection;
        }

        public static CommunicationAction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CommunicationAction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CommunicationAction) gateway.retrieve(ResourceType.COMMUNICATION_ACTION, id);
        }

        public ModelBase getCommunication ()
        {
            return (ModelBase) this.getProperty("communication");
        }

        public void setCommunication (ModelBase communication)
        {
            this.setProperty("communication", communication);
        }

        public string getActionTaken ()
        {
            return this.getProperty("actionTaken").ToString();
        }

        public void setActionTaken (string actionTaken)
        {
            this.setProperty("actionTaken", actionTaken);
        }

        public ModelBase getReply ()
        {
            return (ModelBase) this.getProperty("reply");
        }

        public void setReply (ModelBase reply)
        {
            this.setProperty("reply", reply);
        }

        public DateTime getActionDatetime (){
            return Convert.ToDateTime(this.getProperty("actionDatetime"));
        }

        public void setActionDatetime (DateTime actionDatetime)
        {
            this.setProperty("actionDatetime", actionDatetime);
        }


    }
}

