using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MessageDraftRecipient : ModelBase
    {
        protected string resourceType = ResourceType.MESSAGE_DRAFT_RECIPIENT;
        public const string MESSAGE_DRAFT = "messageDraft";
        public const string RECIPIENT = "recipient";
        public const string RESOLVER = "resolver";

        public MessageDraftRecipient()
        {
            base.resourceType = this.resourceType;
        }

        public MessageDraftRecipient(string resourceType = "MessageDraftRecipient", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MessageDraftRecipient> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MessageDraftRecipient");
            RestGateway gateway = (RestGateway)MessageDraftRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MessageDraftRecipient> messagedraftrecipientCollection = new ModelCollection<MessageDraftRecipient>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                messagedraftrecipientCollection.add((MessageDraftRecipient)model);
            }

            return messagedraftrecipientCollection;
        }

        public static MessageDraftRecipient retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MessageDraftRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MessageDraftRecipient)gateway.retrieve(ResourceType.MESSAGE_DRAFT_RECIPIENT, id);
        }

        public ModelBase getMessageDraft()
        {
            return (ModelBase)this.getProperty("messageDraft");
        }

        public void setMessageDraft(ModelBase messageDraft)
        {
            this.setProperty("messageDraft", messageDraft);
        }

        public ModelBase getRecipient()
        {
            return (ModelBase)this.getProperty("recipient");
        }

        public void setRecipient(ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public string getResolver()
        {
            return this.getProperty("resolver").ToString();
        }

        public void setResolver(string resolver)
        {
            this.setProperty("resolver", resolver);
        }


    }
}

