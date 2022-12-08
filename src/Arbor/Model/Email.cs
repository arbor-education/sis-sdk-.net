using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Email : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL;
        public const string EMAIL_DRAFT = "emailDraft";
        public const string UID = "uid";
        public const string UID_VALIDITY = "uidValidity";
        public const string MESSAGE_ID = "messageId";
        public const string SUBJECT = "subject";
        public const string ORIGINATION_DATETIME = "originationDatetime";
        public const string SENDING_STARTED_DATETIME = "sendingStartedDatetime";
        public const string SENT_DATETIME = "sentDatetime";
        public const string RECEIVED_DATETIME = "receivedDatetime";
        public const string FAILED_DATETIME = "failedDatetime";
        public const string TEXT_PART = "textPart";
        public const string HTML_PART = "htmlPart";
        public const string READ_DATETIME = "readDatetime";
        public const string ACTION_REQUIRED_BY_DATETIME = "actionRequiredByDatetime";

        public Email()
        {
            base.resourceType = this.resourceType;
        }

        public Email(string resourceType = "Email", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Email> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Email");
            RestGateway gateway = (RestGateway)Email.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Email> emailCollection = new ModelCollection<Email>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailCollection.add((Email)model);
            }

            return emailCollection;
        }

        public static Email retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Email.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Email)gateway.retrieve(ResourceType.EMAIL, id);
        }

        public EmailDraft getEmailDraft()
        {
            return (EmailDraft)this.getProperty("emailDraft");
        }

        public void setEmailDraft(EmailDraft emailDraft)
        {
            this.setProperty("emailDraft", emailDraft);
        }

        public int getUid()
        {
            return Convert.ToInt32(this.getProperty("uid"));
        }

        public void setUid(int uid)
        {
            this.setProperty("uid", uid);
        }

        public int getUidValidity()
        {
            return Convert.ToInt32(this.getProperty("uidValidity"));
        }

        public void setUidValidity(int uidValidity)
        {
            this.setProperty("uidValidity", uidValidity);
        }

        public string getMessageId()
        {
            return this.getProperty("messageId").ToString();
        }

        public void setMessageId(string messageId)
        {
            this.setProperty("messageId", messageId);
        }

        public string getSubject()
        {
            return this.getProperty("subject").ToString();
        }

        public void setSubject(string subject)
        {
            this.setProperty("subject", subject);
        }

        public DateTime getOriginationDatetime()
        {
            return Convert.ToDateTime(this.getProperty("originationDatetime"));
        }

        public void setOriginationDatetime(DateTime originationDatetime)
        {
            this.setProperty("originationDatetime", originationDatetime);
        }

        public DateTime getSendingStartedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("sendingStartedDatetime"));
        }

        public void setSendingStartedDatetime(DateTime sendingStartedDatetime)
        {
            this.setProperty("sendingStartedDatetime", sendingStartedDatetime);
        }

        public DateTime getSentDatetime()
        {
            return Convert.ToDateTime(this.getProperty("sentDatetime"));
        }

        public void setSentDatetime(DateTime sentDatetime)
        {
            this.setProperty("sentDatetime", sentDatetime);
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

        public EmailPart getTextPart()
        {
            return (EmailPart)this.getProperty("textPart");
        }

        public void setTextPart(EmailPart textPart)
        {
            this.setProperty("textPart", textPart);
        }

        public EmailPart getHtmlPart()
        {
            return (EmailPart)this.getProperty("htmlPart");
        }

        public void setHtmlPart(EmailPart htmlPart)
        {
            this.setProperty("htmlPart", htmlPart);
        }

        public DateTime getReadDatetime()
        {
            return Convert.ToDateTime(this.getProperty("readDatetime"));
        }

        public void setReadDatetime(DateTime readDatetime)
        {
            this.setProperty("readDatetime", readDatetime);
        }

        public DateTime getActionRequiredByDatetime()
        {
            return Convert.ToDateTime(this.getProperty("actionRequiredByDatetime"));
        }

        public void setActionRequiredByDatetime(DateTime actionRequiredByDatetime)
        {
            this.setProperty("actionRequiredByDatetime", actionRequiredByDatetime);
        }


    }
}

