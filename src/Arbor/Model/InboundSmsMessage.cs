using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InboundSmsMessage : ModelBase
    {
        protected string resourceType = ResourceType.INBOUND_SMS_MESSAGE;
        public const string MESSAGE_TYPE = "messageType";
        public const string SENDER_NUMBER = "senderNumber";
        public const string SENDER = "sender";
        public const string RECIPIENT_NUMBER = "recipientNumber";
        public const string RECIPIENT = "recipient";
        public const string MESSAGE_TEXT = "messageText";
        public const string MESSAGE_IDENTIFIER = "messageIdentifier";
        public const string RECEIVED_DATETIME = "receivedDatetime";
        public const string READ_DATETIME = "readDatetime";
        public const string ACTION_REQUIRED_BY_DATETIME = "actionRequiredByDatetime";

        public InboundSmsMessage ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InboundSmsMessage (string resourceType = "InboundSmsMessage", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InboundSmsMessage> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InboundSmsMessage");
        	RestGateway gateway = (RestGateway) InboundSmsMessage.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InboundSmsMessage> inboundsmsmessageCollection = new ModelCollection<InboundSmsMessage> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    inboundsmsmessageCollection.add((InboundSmsMessage) model);
        	}
        
        	return inboundsmsmessageCollection;
        }

        public static InboundSmsMessage retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InboundSmsMessage.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InboundSmsMessage) gateway.retrieve(ResourceType.INBOUND_SMS_MESSAGE, id);
        }

        public string getMessageType ()
        {
            return this.getProperty("messageType").ToString();
        }

        public void setMessageType (string messageType)
        {
            this.setProperty("messageType", messageType);
        }

        public string getSenderNumber ()
        {
            return this.getProperty("senderNumber").ToString();
        }

        public void setSenderNumber (string senderNumber)
        {
            this.setProperty("senderNumber", senderNumber);
        }

        public ModelBase getSender ()
        {
            return (ModelBase) this.getProperty("sender");
        }

        public void setSender (ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public string getRecipientNumber ()
        {
            return this.getProperty("recipientNumber").ToString();
        }

        public void setRecipientNumber (string recipientNumber)
        {
            this.setProperty("recipientNumber", recipientNumber);
        }

        public EducationalInstitution getRecipient ()
        {
            return (EducationalInstitution) this.getProperty("recipient");
        }

        public void setRecipient (EducationalInstitution recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public string getMessageText ()
        {
            return this.getProperty("messageText").ToString();
        }

        public void setMessageText (string messageText)
        {
            this.setProperty("messageText", messageText);
        }

        public string getMessageIdentifier ()
        {
            return this.getProperty("messageIdentifier").ToString();
        }

        public void setMessageIdentifier (string messageIdentifier)
        {
            this.setProperty("messageIdentifier", messageIdentifier);
        }

        public DateTime getReceivedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("receivedDatetime"));
        }

        public void setReceivedDatetime (DateTime receivedDatetime)
        {
            this.setProperty("receivedDatetime", receivedDatetime);
        }

        public DateTime getReadDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("readDatetime"));
        }

        public void setReadDatetime (DateTime readDatetime)
        {
            this.setProperty("readDatetime", readDatetime);
        }

        public DateTime getActionRequiredByDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("actionRequiredByDatetime"));
        }

        public void setActionRequiredByDatetime (DateTime actionRequiredByDatetime)
        {
            this.setProperty("actionRequiredByDatetime", actionRequiredByDatetime);
        }


    }
}

