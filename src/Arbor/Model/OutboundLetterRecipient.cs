using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OutboundLetterRecipient : ModelBase
    {
        protected new string resourceType = ResourceType.OUTBOUND_LETTER_RECIPIENT;
        public const string OUTBOUND_LETTER = "outboundLetter";
        public const string RECIPIENT_NAME = "recipientName";
        public const string RECIPIENT = "recipient";
        public const string DRAFT_RECIPIENT = "draftRecipient";
        public const string RECIPIENT_INDEX = "recipientIndex";

        public OutboundLetterRecipient()
        {
            base.resourceType = this.resourceType;
        }

        public OutboundLetterRecipient(string resourceType = "OutboundLetterRecipient", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<OutboundLetterRecipient> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("OutboundLetterRecipient");
            RestGateway gateway = (RestGateway)OutboundLetterRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<OutboundLetterRecipient> outboundletterrecipientCollection = new ModelCollection<OutboundLetterRecipient>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                outboundletterrecipientCollection.add((OutboundLetterRecipient)model);
            }

            return outboundletterrecipientCollection;
        }

        public static OutboundLetterRecipient retrieve(string id)
        {
            RestGateway gateway = (RestGateway)OutboundLetterRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (OutboundLetterRecipient)gateway.retrieve(ResourceType.OUTBOUND_LETTER_RECIPIENT, id);
        }

        public OutboundLetter getOutboundLetter()
        {
            return (OutboundLetter)this.getProperty("outboundLetter");
        }

        public void setOutboundLetter(OutboundLetter outboundLetter)
        {
            this.setProperty("outboundLetter", outboundLetter);
        }

        public string getRecipientName()
        {
            return this.getProperty("recipientName").ToString();
        }

        public void setRecipientName(string recipientName)
        {
            this.setProperty("recipientName", recipientName);
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


    }
}

