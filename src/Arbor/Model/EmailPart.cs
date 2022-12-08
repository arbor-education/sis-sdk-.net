using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailPart : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_PART;
        public const string EMAIL = "email";
        public const string MIME_CONTENT_ID = "mimeContentId";
        public const string DISPOSITION = "disposition";
        public const string FILENAME = "filename";
        public const string TYPE_MAJOR = "typeMajor";
        public const string TYPE_MINOR = "typeMinor";
        public const string DESCRIPTION = "description";
        public const string SUBJECT = "subject";
        public const string PARENT_EMAIL_PART = "parentEmailPart";

        public EmailPart()
        {
            base.resourceType = this.resourceType;
        }

        public EmailPart(string resourceType = "EmailPart", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailPart> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailPart");
            RestGateway gateway = (RestGateway)EmailPart.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailPart> emailpartCollection = new ModelCollection<EmailPart>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailpartCollection.add((EmailPart)model);
            }

            return emailpartCollection;
        }

        public static EmailPart retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailPart.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailPart)gateway.retrieve(ResourceType.EMAIL_PART, id);
        }

        public Email getEmail()
        {
            return (Email)this.getProperty("email");
        }

        public void setEmail(Email email)
        {
            this.setProperty("email", email);
        }

        public string getMimeContentId()
        {
            return this.getProperty("mimeContentId").ToString();
        }

        public void setMimeContentId(string mimeContentId)
        {
            this.setProperty("mimeContentId", mimeContentId);
        }

        public string getDisposition()
        {
            return this.getProperty("disposition").ToString();
        }

        public void setDisposition(string disposition)
        {
            this.setProperty("disposition", disposition);
        }

        public string getFilename()
        {
            return this.getProperty("filename").ToString();
        }

        public void setFilename(string filename)
        {
            this.setProperty("filename", filename);
        }

        public string getTypeMajor()
        {
            return this.getProperty("typeMajor").ToString();
        }

        public void setTypeMajor(string typeMajor)
        {
            this.setProperty("typeMajor", typeMajor);
        }

        public string getTypeMinor()
        {
            return this.getProperty("typeMinor").ToString();
        }

        public void setTypeMinor(string typeMinor)
        {
            this.setProperty("typeMinor", typeMinor);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public string getSubject()
        {
            return this.getProperty("subject").ToString();
        }

        public void setSubject(string subject)
        {
            this.setProperty("subject", subject);
        }

        public EmailPart getParentEmailPart()
        {
            return (EmailPart)this.getProperty("parentEmailPart");
        }

        public void setParentEmailPart(EmailPart parentEmailPart)
        {
            this.setProperty("parentEmailPart", parentEmailPart);
        }


    }
}

