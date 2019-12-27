using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InboundNotificationAutomaticRecipient : ModelBase
    {
        protected string resourceType = ResourceType.INBOUND_NOTIFICATION_AUTOMATIC_RECIPIENT;
        public const string AUTOMATIC_RECIPIENT = "automaticRecipient";

        public InboundNotificationAutomaticRecipient ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InboundNotificationAutomaticRecipient (string resourceType = "InboundNotificationAutomaticRecipient", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InboundNotificationAutomaticRecipient> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InboundNotificationAutomaticRecipient");
        	RestGateway gateway = (RestGateway) InboundNotificationAutomaticRecipient.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InboundNotificationAutomaticRecipient> inboundnotificationautomaticrecipientCollection = new ModelCollection<InboundNotificationAutomaticRecipient> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    inboundnotificationautomaticrecipientCollection.add((InboundNotificationAutomaticRecipient) model);
        	}
        
        	return inboundnotificationautomaticrecipientCollection;
        }

        public static InboundNotificationAutomaticRecipient retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InboundNotificationAutomaticRecipient.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InboundNotificationAutomaticRecipient) gateway.retrieve(ResourceType.INBOUND_NOTIFICATION_AUTOMATIC_RECIPIENT, id);
        }

        public ModelBase getAutomaticRecipient ()
        {
            return (ModelBase) this.getProperty("automaticRecipient");
        }

        public void setAutomaticRecipient (ModelBase automaticRecipient)
        {
            this.setProperty("automaticRecipient", automaticRecipient);
        }


    }
}

