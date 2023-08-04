using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InAppMessagePermittedSender : ModelBase
    {
        protected new string resourceType = ResourceType.IN_APP_MESSAGE_PERMITTED_SENDER;
        public const string ACTION_TAKER = "actionTaker";
        public const string SENDER = "sender";
        public const string ALLOW = "allow";

        public InAppMessagePermittedSender ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InAppMessagePermittedSender (string resourceType = "InAppMessagePermittedSender", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InAppMessagePermittedSender> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InAppMessagePermittedSender");
        	RestGateway gateway = (RestGateway) InAppMessagePermittedSender.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InAppMessagePermittedSender> inappmessagepermittedsenderCollection = new ModelCollection<InAppMessagePermittedSender> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    inappmessagepermittedsenderCollection.add((InAppMessagePermittedSender) model);
        	}
        
        	return inappmessagepermittedsenderCollection;
        }

        public static InAppMessagePermittedSender retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InAppMessagePermittedSender.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InAppMessagePermittedSender) gateway.retrieve(ResourceType.IN_APP_MESSAGE_PERMITTED_SENDER, id);
        }

        public Staff getActionTaker ()
        {
            return (Staff) this.getProperty("actionTaker");
        }

        public void setActionTaker (Staff actionTaker)
        {
            this.setProperty("actionTaker", actionTaker);
        }

        public ModelBase getSender ()
        {
            return (ModelBase) this.getProperty("sender");
        }

        public void setSender (ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public bool getAllow ()
        {
            return Convert.ToBoolean(this.getProperty("allow"));
        }

        public void setAllow (bool allow)
        {
            this.setProperty("allow", allow);
        }


    }
}

