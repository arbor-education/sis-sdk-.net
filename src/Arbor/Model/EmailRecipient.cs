using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailRecipient : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_RECIPIENT;
        public const string EMAIL = "email";
        public const string RECIPIENT_TYPE = "recipientType";
        public const string RECIPIENT_NAME = "recipientName";
        public const string RECIPIENT_RAW_EMAIL = "recipientRawEmail";
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string RECIPIENT = "recipient";
        public const string DRAFT_RECIPIENT = "draftRecipient";
        public const string RECIPIENT_INDEX = "recipientIndex";
        public const string RECEIVED_DATETIME = "receivedDatetime";
        public const string FAILED_DATETIME = "failedDatetime";

        public EmailRecipient()
        {
            base.resourceType = this.resourceType;
        }

        public EmailRecipient(string resourceType = "EmailRecipient", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailRecipient> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailRecipient");
            RestGateway gateway = (RestGateway)EmailRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailRecipient> emailrecipientCollection = new ModelCollection<EmailRecipient>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailrecipientCollection.add((EmailRecipient)model);
            }

            return emailrecipientCollection;
        }

        public static EmailRecipient retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailRecipient)gateway.retrieve(ResourceType.EMAIL_RECIPIENT, id);
        }

        public Email getEmail()
        {
            return (Email)this.getProperty("email");
        }

        public void setEmail(Email email)
        {
            this.setProperty("email", email);
        }

        public string getRecipientType()
        {
            return this.getProperty("recipientType").ToString();
        }

        public void setRecipientType(string recipientType)
        {
            this.setProperty("recipientType", recipientType);
        }

        public string getRecipientName()
        {
            return this.getProperty("recipientName").ToString();
        }

        public void setRecipientName(string recipientName)
        {
            this.setProperty("recipientName", recipientName);
        }

        public string getRecipientRawEmail()
        {
            return this.getProperty("recipientRawEmail").ToString();
        }

        public void setRecipientRawEmail(string recipientRawEmail)
        {
            this.setProperty("recipientRawEmail", recipientRawEmail);
        }

        public EmailAddress getEmailAddress()
        {
            return (EmailAddress)this.getProperty("emailAddress");
        }

        public void setEmailAddress(EmailAddress emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public ModelBase getRecipient()
        {
            return (ModelBase)this.getProperty("recipient");
        }

        public void setRecipient(ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public MessageDraftRecipient getDraftRecipient()
        {
            return (MessageDraftRecipient)this.getProperty("draftRecipient");
        }

        public void setDraftRecipient(MessageDraftRecipient draftRecipient)
        {
            this.setProperty("draftRecipient", draftRecipient);
        }

        public int getRecipientIndex()
        {
            return Convert.ToInt32(this.getProperty("recipientIndex"));
        }

        public void setRecipientIndex(int recipientIndex)
        {
            this.setProperty("recipientIndex", recipientIndex);
        }

        public DateTime getReceivedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("receivedDatetime"));
        }

        public void setReceivedDatetime(DateTime receivedDatetime)
        {
            this.setProperty("receivedDatetime", receivedDatetime);
        }

        public DateTime getFailedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("failedDatetime"));
        }

        public void setFailedDatetime(DateTime failedDatetime)
        {
            this.setProperty("failedDatetime", failedDatetime);
        }


    }
}

