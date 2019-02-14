using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SmsMessagePermittedSender : ModelBase
    {
        protected string resourceType = ResourceType.SMS_MESSAGE_PERMITTED_SENDER;
        public const string ACTION_TAKER = "actionTaker";
        public const string SENDER = "sender";
        public const string ALLOW = "allow";

        public SmsMessagePermittedSender ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SmsMessagePermittedSender (string resourceType = "SmsMessagePermittedSender", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SmsMessagePermittedSender> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SmsMessagePermittedSender");
        	RestGateway gateway = (RestGateway) SmsMessagePermittedSender.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SmsMessagePermittedSender> smsmessagepermittedsenderCollection = new ModelCollection<SmsMessagePermittedSender> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    smsmessagepermittedsenderCollection.add((SmsMessagePermittedSender) model);
        	}
        
        	return smsmessagepermittedsenderCollection;
        }

        public static SmsMessagePermittedSender retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SmsMessagePermittedSender.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SmsMessagePermittedSender) gateway.retrieve(ResourceType.SMS_MESSAGE_PERMITTED_SENDER, id);
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
            return Convert.ToBoolean(this.getProperty("allow"))
        }

        public void setAllow (bool allow)
        {
            this.setProperty("allow", allow);
        }


    }
}

