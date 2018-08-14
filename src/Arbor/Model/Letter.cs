using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Letter : ModelBase
    {
        protected string resourceType = ResourceType.LETTER;
        public const string LETTER_DATE = "letterDate";
        public const string RECEIVED_DATE = "receivedDate";
        public const string PREPARED_DATETIME = "preparedDatetime";
        public const string SENT_DATETIME = "sentDatetime";
        public const string SENDER_NAME = "senderName";
        public const string SENDER = "sender";
        public const string DRAFT_RECIPIENT = "draftRecipient";
        public const string RECIPIENT_NAME = "recipientName";
        public const string RECIPIENT = "recipient";
        public const string SUMMARY = "summary";
        public const string ACTION_REQUIRED_BY_DATETIME = "actionRequiredByDatetime";

        public Letter ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Letter (string resourceType = "Letter", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Letter> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Letter");
        	RestGateway gateway = (RestGateway) Letter.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Letter> letterCollection = new ModelCollection<Letter> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    letterCollection.add((Letter) model);
        	}
        
        	return letterCollection;
        }

        public static Letter retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Letter.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Letter) gateway.retrieve(ResourceType.LETTER, id);
        }

        public DateTime getLetterDate (){
            return Convert.ToDateTime(this.getProperty("letterDate"));
        }

        public void setLetterDate (DateTime letterDate)
        {
            this.setProperty("letterDate", letterDate);
        }

        public DateTime getReceivedDate (){
            return Convert.ToDateTime(this.getProperty("receivedDate"));
        }

        public void setReceivedDate (DateTime receivedDate)
        {
            this.setProperty("receivedDate", receivedDate);
        }

        public DateTime getPreparedDatetime (){
            return Convert.ToDateTime(this.getProperty("preparedDatetime"));
        }

        public void setPreparedDatetime (DateTime preparedDatetime)
        {
            this.setProperty("preparedDatetime", preparedDatetime);
        }

        public DateTime getSentDatetime (){
            return Convert.ToDateTime(this.getProperty("sentDatetime"));
        }

        public void setSentDatetime (DateTime sentDatetime)
        {
            this.setProperty("sentDatetime", sentDatetime);
        }

        public string getSenderName ()
        {
            return this.getProperty("senderName").ToString();
        }

        public void setSenderName (string senderName)
        {
            this.setProperty("senderName", senderName);
        }

        public ModelBase getSender ()
        {
            return (ModelBase) this.getProperty("sender");
        }

        public void setSender (ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public MessageDraftRecipient getDraftRecipient ()
        {
            return (MessageDraftRecipient) this.getProperty("draftRecipient");
        }

        public void setDraftRecipient (MessageDraftRecipient draftRecipient)
        {
            this.setProperty("draftRecipient", draftRecipient);
        }

        public string getRecipientName ()
        {
            return this.getProperty("recipientName").ToString();
        }

        public void setRecipientName (string recipientName)
        {
            this.setProperty("recipientName", recipientName);
        }

        public ModelBase getRecipient ()
        {
            return (ModelBase) this.getProperty("recipient");
        }

        public void setRecipient (ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }

        public DateTime getActionRequiredByDatetime (){
            return Convert.ToDateTime(this.getProperty("actionRequiredByDatetime"));
        }

        public void setActionRequiredByDatetime (DateTime actionRequiredByDatetime)
        {
            this.setProperty("actionRequiredByDatetime", actionRequiredByDatetime);
        }


    }
}

