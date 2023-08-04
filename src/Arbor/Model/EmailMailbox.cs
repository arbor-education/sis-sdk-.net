using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailMailbox : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_MAILBOX;
        public const string EMAIL_ACCOUNT = "emailAccount";
        public const string MAILBOX_TYPE = "mailboxType";
        public const string MAILBOX_FOLDER = "mailboxFolder";
        public const string LAST_RETRIEVED_DATETIME = "lastRetrievedDatetime";
        public const string LAST_SEEN_UID = "lastSeenUid";
        public const string UID_VALIDITY = "uidValidity";
        public const string DEFAULT_ACTION_REQUIRED_BY_TIME = "defaultActionRequiredByTime";
        public const string SHARED_BY_DEFAULT = "sharedByDefault";
        public const string FIRST_ERROR_DATETIME = "firstErrorDatetime";
        public const string LAST_ERROR_DATETIME = "lastErrorDatetime";
        public const string DISABLED = "disabled";

        public EmailMailbox()
        {
            base.resourceType = this.resourceType;
        }

        public EmailMailbox(string resourceType = "EmailMailbox", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailMailbox> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailMailbox");
            RestGateway gateway = (RestGateway)EmailMailbox.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailMailbox> emailmailboxCollection = new ModelCollection<EmailMailbox>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailmailboxCollection.add((EmailMailbox)model);
            }

            return emailmailboxCollection;
        }

        public static EmailMailbox retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailMailbox.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailMailbox)gateway.retrieve(ResourceType.EMAIL_MAILBOX, id);
        }

        public EmailAccount getEmailAccount()
        {
            return (EmailAccount)this.getProperty("emailAccount");
        }

        public void setEmailAccount(EmailAccount emailAccount)
        {
            this.setProperty("emailAccount", emailAccount);
        }

        public string getMailboxType()
        {
            return this.getProperty("mailboxType").ToString();
        }

        public void setMailboxType(string mailboxType)
        {
            this.setProperty("mailboxType", mailboxType);
        }

        public string getMailboxFolder()
        {
            return this.getProperty("mailboxFolder").ToString();
        }

        public void setMailboxFolder(string mailboxFolder)
        {
            this.setProperty("mailboxFolder", mailboxFolder);
        }

        public DateTime getLastRetrievedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastRetrievedDatetime"));
        }

        public void setLastRetrievedDatetime(DateTime lastRetrievedDatetime)
        {
            this.setProperty("lastRetrievedDatetime", lastRetrievedDatetime);
        }

        public int getLastSeenUid()
        {
            return Convert.ToInt32(this.getProperty("lastSeenUid"));
        }

        public void setLastSeenUid(int lastSeenUid)
        {
            this.setProperty("lastSeenUid", lastSeenUid);
        }

        public int getUidValidity()
        {
            return Convert.ToInt32(this.getProperty("uidValidity"));
        }

        public void setUidValidity(int uidValidity)
        {
            this.setProperty("uidValidity", uidValidity);
        }

        public string getDefaultActionRequiredByTime()
        {
            return this.getProperty("defaultActionRequiredByTime").ToString();
        }

        public void setDefaultActionRequiredByTime(string defaultActionRequiredByTime)
        {
            this.setProperty("defaultActionRequiredByTime", defaultActionRequiredByTime);
        }

        public bool getSharedByDefault()
        {
            return (bool)this.getProperty("sharedByDefault");
        }

        public void setSharedByDefault(bool sharedByDefault)
        {
            this.setProperty("sharedByDefault", sharedByDefault);
        }

        public DateTime getFirstErrorDatetime()
        {
            return Convert.ToDateTime(this.getProperty("firstErrorDatetime"));
        }

        public void setFirstErrorDatetime(DateTime firstErrorDatetime)
        {
            this.setProperty("firstErrorDatetime", firstErrorDatetime);
        }

        public DateTime getLastErrorDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastErrorDatetime"));
        }

        public void setLastErrorDatetime(DateTime lastErrorDatetime)
        {
            this.setProperty("lastErrorDatetime", lastErrorDatetime);
        }

        public bool getDisabled()
        {
            return (bool)this.getProperty("disabled");
        }

        public void setDisabled(bool disabled)
        {
            this.setProperty("disabled", disabled);
        }


    }
}

