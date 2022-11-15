using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OutboundInAppMessage : ModelBase
    {
        protected new string resourceType = ResourceType.OUTBOUND_IN_APP_MESSAGE;
        public const string SENDER = "sender";
        public const string RECIPIENT = "recipient";
        public const string MESSAGE = "message";
        public const string READ_DATETIME = "readDatetime";
        public const string OUTBOUND_IN_APP_MESSAGE_DRAFT = "outboundInAppMessageDraft";
        public const string SENT_DATETIME = "sentDatetime";
        public const string ACTION_REQUIRED_BY_DATETIME = "actionRequiredByDatetime";
        public const string INBOUND_IN_APP_MESSAGE_REPLIED_TO = "inboundInAppMessageRepliedTo";

        public OutboundInAppMessage()
        {
            base.resourceType = this.resourceType;
        }

        public OutboundInAppMessage(string resourceType = "OutboundInAppMessage", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<OutboundInAppMessage> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("OutboundInAppMessage");
            RestGateway gateway = (RestGateway)OutboundInAppMessage.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<OutboundInAppMessage> outboundinappmessageCollection = new ModelCollection<OutboundInAppMessage>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                outboundinappmessageCollection.add((OutboundInAppMessage)model);
            }

            return outboundinappmessageCollection;
        }

        public static OutboundInAppMessage retrieve(string id)
        {
            RestGateway gateway = (RestGateway)OutboundInAppMessage.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (OutboundInAppMessage)gateway.retrieve(ResourceType.OUTBOUND_IN_APP_MESSAGE, id);
        }

        public ModelBase getSender()
        {
            return (ModelBase)this.getProperty("sender");
        }

        public void setSender(ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public ModelBase getRecipient()
        {
            return (ModelBase)this.getProperty("recipient");
        }

        public void setRecipient(ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public string getMessage()
        {
            return this.getProperty("message").ToString();
        }

        public void setMessage(string message)
        {
            this.setProperty("message", message);
        }

        public DateTime getReadDatetime()
        {
            return Convert.ToDateTime(this.getProperty("readDatetime"));
        }

        public void setReadDatetime(DateTime readDatetime)
        {
            this.setProperty("readDatetime", readDatetime);
        }

        public OutboundInAppMessageDraft getOutboundInAppMessageDraft()
        {
            return (OutboundInAppMessageDraft)this.getProperty("outboundInAppMessageDraft");
        }

        public void setOutboundInAppMessageDraft(OutboundInAppMessageDraft outboundInAppMessageDraft)
        {
            this.setProperty("outboundInAppMessageDraft", outboundInAppMessageDraft);
        }

        public DateTime getSentDatetime()
        {
            return Convert.ToDateTime(this.getProperty("sentDatetime"));
        }

        public void setSentDatetime(DateTime sentDatetime)
        {
            this.setProperty("sentDatetime", sentDatetime);
        }

        public DateTime getActionRequiredByDatetime()
        {
            return Convert.ToDateTime(this.getProperty("actionRequiredByDatetime"));
        }

        public void setActionRequiredByDatetime(DateTime actionRequiredByDatetime)
        {
            this.setProperty("actionRequiredByDatetime", actionRequiredByDatetime);
        }

        public InboundInAppMessage getInboundInAppMessageRepliedTo()
        {
            return (InboundInAppMessage)this.getProperty("inboundInAppMessageRepliedTo");
        }

        public void setInboundInAppMessageRepliedTo(InboundInAppMessage inboundInAppMessageRepliedTo)
        {
            this.setProperty("inboundInAppMessageRepliedTo", inboundInAppMessageRepliedTo);
        }


    }
}

