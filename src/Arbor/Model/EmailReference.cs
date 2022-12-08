using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailReference : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_REFERENCE;
        public const string EMAIL = "email";
        public const string REFERENCE_TYPE = "referenceType";
        public const string REFERENCED_MESSAGE_ID = "referencedMessageId";
        public const string REFERENCE_EMAIL = "referenceEmail";
        public const string REFERENCE_INDEX = "referenceIndex";

        public EmailReference()
        {
            base.resourceType = this.resourceType;
        }

        public EmailReference(string resourceType = "EmailReference", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailReference> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailReference");
            RestGateway gateway = (RestGateway)EmailReference.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailReference> emailreferenceCollection = new ModelCollection<EmailReference>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailreferenceCollection.add((EmailReference)model);
            }

            return emailreferenceCollection;
        }

        public static EmailReference retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailReference.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailReference)gateway.retrieve(ResourceType.EMAIL_REFERENCE, id);
        }

        public Email getEmail()
        {
            return (Email)this.getProperty("email");
        }

        public void setEmail(Email email)
        {
            this.setProperty("email", email);
        }

        public string getReferenceType()
        {
            return this.getProperty("referenceType").ToString();
        }

        public void setReferenceType(string referenceType)
        {
            this.setProperty("referenceType", referenceType);
        }

        public string getReferencedMessageId()
        {
            return this.getProperty("referencedMessageId").ToString();
        }

        public void setReferencedMessageId(string referencedMessageId)
        {
            this.setProperty("referencedMessageId", referencedMessageId);
        }

        public Email getReferenceEmail()
        {
            return (Email)this.getProperty("referenceEmail");
        }

        public void setReferenceEmail(Email referenceEmail)
        {
            this.setProperty("referenceEmail", referenceEmail);
        }

        public int getReferenceIndex()
        {
            return Convert.ToInt32(this.getProperty("referenceIndex"));
        }

        public void setReferenceIndex(int referenceIndex)
        {
            this.setProperty("referenceIndex", referenceIndex);
        }


    }
}

