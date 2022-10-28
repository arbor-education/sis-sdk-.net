using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SmsMessage : ModelBase
    {
        protected new string resourceType = ResourceType.SMS_MESSAGE;
        public const string SMS_MESSAGE_DRAFT = "smsMessageDraft";
        public const string MESSAGE_TYPE = "messageType";
        public const string SENDER_NUMBER = "senderNumber";
        public const string SENDER = "sender";
        public const string RECIPIENT_NUMBER = "recipientNumber";
        public const string RECIPIENT = "recipient";
        public const string DRAFT_RECIPIENT = "draftRecipient";
        public const string MESSAGE_TEXT = "messageText";
        public const string SENT_DATETIME = "sentDatetime";
        public const string READ_DATETIME = "readDatetime";
        public const string RECEIVED_DATETIME = "receivedDatetime";
        public const string FAILED_DATETIME = "failedDatetime";
        public const string TOTAL_COST = "totalCost";
        public const string CREDITS_USED = "creditsUsed";
        public const string FREE = "free";
        public const string MESSAGE_PARTS = "messageParts";
        public const string RECIPIENT_NETWORK_CODE = "recipientNetworkCode";
        public const string ACTION_REQUIRED_BY_DATETIME = "actionRequiredByDatetime";

        public SmsMessage ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SmsMessage (string resourceType = "SmsMessage", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SmsMessage> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SmsMessage");
        	RestGateway gateway = (RestGateway) SmsMessage.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SmsMessage> smsmessageCollection = new ModelCollection<SmsMessage> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    smsmessageCollection.add((SmsMessage) model);
        	}
        
        	return smsmessageCollection;
        }

        public static SmsMessage retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SmsMessage.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SmsMessage) gateway.retrieve(ResourceType.SMS_MESSAGE, id);
        }

        public SmsMessageDraft getSmsMessageDraft ()
        {
            return (SmsMessageDraft) this.getProperty("smsMessageDraft");
        }

        public void setSmsMessageDraft (SmsMessageDraft smsMessageDraft)
        {
            this.setProperty("smsMessageDraft", smsMessageDraft);
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

        public ModelBase getRecipient ()
        {
            return (ModelBase) this.getProperty("recipient");
        }

        public void setRecipient (ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public MessageDraftRecipient getDraftRecipient ()
        {
            return (MessageDraftRecipient) this.getProperty("draftRecipient");
        }

        public void setDraftRecipient (MessageDraftRecipient draftRecipient)
        {
            this.setProperty("draftRecipient", draftRecipient);
        }

        public string getMessageText ()
        {
            return this.getProperty("messageText").ToString();
        }

        public void setMessageText (string messageText)
        {
            this.setProperty("messageText", messageText);
        }

        public DateTime getSentDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("sentDatetime"));
        }

        public void setSentDatetime (DateTime sentDatetime)
        {
            this.setProperty("sentDatetime", sentDatetime);
        }

        public DateTime getReadDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("readDatetime"));
        }

        public void setReadDatetime (DateTime readDatetime)
        {
            this.setProperty("readDatetime", readDatetime);
        }

        public DateTime getReceivedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("receivedDatetime"));
        }

        public void setReceivedDatetime (DateTime receivedDatetime)
        {
            this.setProperty("receivedDatetime", receivedDatetime);
        }

        public DateTime getFailedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("failedDatetime"));
        }

        public void setFailedDatetime (DateTime failedDatetime)
        {
            this.setProperty("failedDatetime", failedDatetime);
        }

        public string getTotalCost ()
        {
            return this.getProperty("totalCost").ToString();
        }

        public void setTotalCost (string totalCost)
        {
            this.setProperty("totalCost", totalCost);
        }

        public float getCreditsUsed ()
        {
            return (float) this.getProperty("creditsUsed");
        }

        public void setCreditsUsed (float creditsUsed)
        {
            this.setProperty("creditsUsed", creditsUsed);
        }

        public bool getFree ()
        {
            return Convert.ToBoolean(this.getProperty("free"));
        }

        public void setFree (bool free)
        {
            this.setProperty("free", free);
        }

        public int getMessageParts ()
        {
            return Convert.ToInt32(this.getProperty("messageParts"));
        }

        public void setMessageParts (int messageParts)
        {
            this.setProperty("messageParts", messageParts);
        }

        public string getRecipientNetworkCode ()
        {
            return this.getProperty("recipientNetworkCode").ToString();
        }

        public void setRecipientNetworkCode (string recipientNetworkCode)
        {
            this.setProperty("recipientNetworkCode", recipientNetworkCode);
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

