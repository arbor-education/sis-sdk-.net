using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SmsMessageDraft : ModelBase
    {
        protected new string resourceType = ResourceType.SMS_MESSAGE_DRAFT;
        public const string SENDER = "sender";
        public const string MESSAGE_TEXT = "messageText";
        public const string CUSTOM_REPORT = "customReport";
        public const string COMBINE_MESSAGES_TO_SAME_RECIPIENT = "combineMessagesToSameRecipient";
        public const string COMBINE_MESSAGES_TO_SAME_HOUSEHOLD = "combineMessagesToSameHousehold";
        public const string SENDING_QUEUED_DATETIME = "sendingQueuedDatetime";
        public const string SENDING_STARTED_DATETIME = "sendingStartedDatetime";
        public const string RECIPIENTS_RESOLVED_DATETIME = "recipientsResolvedDatetime";
        public const string SENDING_COMPLETED_DATETIME = "sendingCompletedDatetime";
        public const string CONTEXT = "context";

        public SmsMessageDraft()
        {
            base.resourceType = this.resourceType;
        }

        public SmsMessageDraft(string resourceType = "SmsMessageDraft", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SmsMessageDraft> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SmsMessageDraft");
            RestGateway gateway = (RestGateway)SmsMessageDraft.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SmsMessageDraft> smsmessagedraftCollection = new ModelCollection<SmsMessageDraft>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                smsmessagedraftCollection.add((SmsMessageDraft)model);
            }

            return smsmessagedraftCollection;
        }

        public static SmsMessageDraft retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SmsMessageDraft.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SmsMessageDraft)gateway.retrieve(ResourceType.SMS_MESSAGE_DRAFT, id);
        }

        public ModelBase getSender()
        {
            return (ModelBase)this.getProperty("sender");
        }

        public void setSender(ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public string getMessageText()
        {
            return this.getProperty("messageText").ToString();
        }

        public void setMessageText(string messageText)
        {
            this.setProperty("messageText", messageText);
        }

        public CustomReport getCustomReport()
        {
            return (CustomReport)this.getProperty("customReport");
        }

        public void setCustomReport(CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public bool getCombineMessagesToSameRecipient()
        {
            return Convert.ToBoolean(this.getProperty("combineMessagesToSameRecipient"));
        }

        public void setCombineMessagesToSameRecipient(bool combineMessagesToSameRecipient)
        {
            this.setProperty("combineMessagesToSameRecipient", combineMessagesToSameRecipient);
        }

        public bool getCombineMessagesToSameHousehold()
        {
            return Convert.ToBoolean(this.getProperty("combineMessagesToSameHousehold"));
        }

        public void setCombineMessagesToSameHousehold(bool combineMessagesToSameHousehold)
        {
            this.setProperty("combineMessagesToSameHousehold", combineMessagesToSameHousehold);
        }

        public DateTime getSendingQueuedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("sendingQueuedDatetime"));
        }

        public void setSendingQueuedDatetime(DateTime sendingQueuedDatetime)
        {
            this.setProperty("sendingQueuedDatetime", sendingQueuedDatetime);
        }

        public DateTime getSendingStartedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("sendingStartedDatetime"));
        }

        public void setSendingStartedDatetime(DateTime sendingStartedDatetime)
        {
            this.setProperty("sendingStartedDatetime", sendingStartedDatetime);
        }

        public DateTime getRecipientsResolvedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("recipientsResolvedDatetime"));
        }

        public void setRecipientsResolvedDatetime(DateTime recipientsResolvedDatetime)
        {
            this.setProperty("recipientsResolvedDatetime", recipientsResolvedDatetime);
        }

        public DateTime getSendingCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("sendingCompletedDatetime"));
        }

        public void setSendingCompletedDatetime(DateTime sendingCompletedDatetime)
        {
            this.setProperty("sendingCompletedDatetime", sendingCompletedDatetime);
        }

        public ModelBase getContext()
        {
            return (ModelBase)this.getProperty("context");
        }

        public void setContext(ModelBase context)
        {
            this.setProperty("context", context);
        }


    }
}

