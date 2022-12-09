using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailSender : ModelBase
    {
        protected new string resourceType = ResourceType.EMAIL_SENDER;
        public const string EMAIL = "email";
        public const string SENDER_TYPE = "senderType";
        public const string SENDER_NAME = "senderName";
        public const string SENDER_RAW_EMAIL = "senderRawEmail";
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string SENDER = "sender";
        public const string SENDER_INDEX = "senderIndex";

        public EmailSender()
        {
            base.resourceType = this.resourceType;
        }

        public EmailSender(string resourceType = "EmailSender", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailSender> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailSender");
            RestGateway gateway = (RestGateway)EmailSender.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailSender> emailsenderCollection = new ModelCollection<EmailSender>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailsenderCollection.add((EmailSender)model);
            }

            return emailsenderCollection;
        }

        public static EmailSender retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailSender.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailSender)gateway.retrieve(ResourceType.EMAIL_SENDER, id);
        }

        public Email getEmail()
        {
            return (Email)this.getProperty("email");
        }

        public void setEmail(Email email)
        {
            this.setProperty("email", email);
        }

        public string getSenderType()
        {
            return this.getProperty("senderType").ToString();
        }

        public void setSenderType(string senderType)
        {
            this.setProperty("senderType", senderType);
        }

        public string getSenderName()
        {
            return this.getProperty("senderName").ToString();
        }

        public void setSenderName(string senderName)
        {
            this.setProperty("senderName", senderName);
        }

        public string getSenderRawEmail()
        {
            return this.getProperty("senderRawEmail").ToString();
        }

        public void setSenderRawEmail(string senderRawEmail)
        {
            this.setProperty("senderRawEmail", senderRawEmail);
        }

        public EmailAddress getEmailAddress()
        {
            return (EmailAddress)this.getProperty("emailAddress");
        }

        public void setEmailAddress(EmailAddress emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public ModelBase getSender()
        {
            return (ModelBase)this.getProperty("sender");
        }

        public void setSender(ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public int getSenderIndex()
        {
            return Convert.ToInt32(this.getProperty("senderIndex"));
        }

        public void setSenderIndex(int senderIndex)
        {
            this.setProperty("senderIndex", senderIndex);
        }


    }
}

