using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailDraft : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_DRAFT;
        public const string SENDER = "sender";
        public const string SUBJECT = "subject";
        public const string BODY = "body";
        public const string CUSTOM_REPORT = "customReport";
        public const string COMBINE_MESSAGES_TO_SAME_RECIPIENT = "combineMessagesToSameRecipient";
        public const string COMBINE_MESSAGES_TO_SAME_HOUSEHOLD = "combineMessagesToSameHousehold";
        public const string SENDING_QUEUED_DATETIME = "sendingQueuedDatetime";
        public const string SENDING_STARTED_DATETIME = "sendingStartedDatetime";
        public const string RECIPIENTS_RESOLVED_DATETIME = "recipientsResolvedDatetime";
        public const string SENDING_COMPLETED_DATETIME = "sendingCompletedDatetime";
        public const string CONTEXT = "context";

        public EmailDraft ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EmailDraft (string resourceType = "EmailDraft", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EmailDraft> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EmailDraft");
        	RestGateway gateway = (RestGateway) EmailDraft.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EmailDraft> emaildraftCollection = new ModelCollection<EmailDraft> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    emaildraftCollection.add((EmailDraft) model);
        	}
        
        	return emaildraftCollection;
        }

        public static EmailDraft retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EmailDraft.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EmailDraft) gateway.retrieve(ResourceType.EMAIL_DRAFT, id);
        }

        public ModelBase getSender ()
        {
            return (ModelBase) this.getProperty("sender");
        }

        public void setSender (ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public string getSubject ()
        {
            return this.getProperty("subject").ToString();
        }

        public void setSubject (string subject)
        {
            this.setProperty("subject", subject);
        }

        public string getBody ()
        {
            return this.getProperty("body").ToString();
        }

        public void setBody (string body)
        {
            this.setProperty("body", body);
        }

        public CustomReport getCustomReport ()
        {
            return (CustomReport) this.getProperty("customReport");
        }

        public void setCustomReport (CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public bool getCombineMessagesToSameRecipient ()
        {
            return Convert.ToBoolean(this.getProperty("combineMessagesToSameRecipient"))
        }

        public void setCombineMessagesToSameRecipient (bool combineMessagesToSameRecipient)
        {
            this.setProperty("combineMessagesToSameRecipient", combineMessagesToSameRecipient);
        }

        public bool getCombineMessagesToSameHousehold ()
        {
            return Convert.ToBoolean(this.getProperty("combineMessagesToSameHousehold"))
        }

        public void setCombineMessagesToSameHousehold (bool combineMessagesToSameHousehold)
        {
            this.setProperty("combineMessagesToSameHousehold", combineMessagesToSameHousehold);
        }

        public DateTime getSendingQueuedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("sendingQueuedDatetime"))
        }

        public void setSendingQueuedDatetime (DateTime sendingQueuedDatetime)
        {
            this.setProperty("sendingQueuedDatetime", sendingQueuedDatetime);
        }

        public DateTime getSendingStartedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("sendingStartedDatetime"))
        }

        public void setSendingStartedDatetime (DateTime sendingStartedDatetime)
        {
            this.setProperty("sendingStartedDatetime", sendingStartedDatetime);
        }

        public DateTime getRecipientsResolvedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("recipientsResolvedDatetime"))
        }

        public void setRecipientsResolvedDatetime (DateTime recipientsResolvedDatetime)
        {
            this.setProperty("recipientsResolvedDatetime", recipientsResolvedDatetime);
        }

        public DateTime getSendingCompletedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("sendingCompletedDatetime"))
        }

        public void setSendingCompletedDatetime (DateTime sendingCompletedDatetime)
        {
            this.setProperty("sendingCompletedDatetime", sendingCompletedDatetime);
        }

        public ModelBase getContext ()
        {
            return (ModelBase) this.getProperty("context");
        }

        public void setContext (ModelBase context)
        {
            this.setProperty("context", context);
        }


    }
}

