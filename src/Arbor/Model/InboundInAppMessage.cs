using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InboundInAppMessage : ModelBase
    {
        protected string resourceType = ResourceType.INBOUND_IN_APP_MESSAGE;
        public const string SENDER = "sender";
        public const string RECIPIENT = "recipient";
        public const string MESSAGE = "message";
        public const string READ_DATETIME = "readDatetime";
        public const string RECEIVED_DATETIME = "receivedDatetime";
        public const string FIRST_READ_BY = "firstReadBy";
        public const string OUTBOUND_IN_APP_MESSAGE_REPLIED_TO = "outboundInAppMessageRepliedTo";

        public InboundInAppMessage()
        {
            base.resourceType = this.resourceType;
        }

        public InboundInAppMessage(string resourceType = "InboundInAppMessage", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InboundInAppMessage> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InboundInAppMessage");
            RestGateway gateway = (RestGateway)InboundInAppMessage.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InboundInAppMessage> inboundinappmessageCollection = new ModelCollection<InboundInAppMessage>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inboundinappmessageCollection.add((InboundInAppMessage)model);
            }

            return inboundinappmessageCollection;
        }

        public static InboundInAppMessage retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InboundInAppMessage.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InboundInAppMessage)gateway.retrieve(ResourceType.INBOUND_IN_APP_MESSAGE, id);
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

        public DateTime getReceivedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("receivedDatetime"));
        }

        public void setReceivedDatetime(DateTime receivedDatetime)
        {
            this.setProperty("receivedDatetime", receivedDatetime);
        }

        public Staff getFirstReadBy()
        {
            return (Staff)this.getProperty("firstReadBy");
        }

        public void setFirstReadBy(Staff firstReadBy)
        {
            this.setProperty("firstReadBy", firstReadBy);
        }

        public OutboundInAppMessage getOutboundInAppMessageRepliedTo()
        {
            return (OutboundInAppMessage)this.getProperty("outboundInAppMessageRepliedTo");
        }

        public void setOutboundInAppMessageRepliedTo(OutboundInAppMessage outboundInAppMessageRepliedTo)
        {
            this.setProperty("outboundInAppMessageRepliedTo", outboundInAppMessageRepliedTo);
        }


    }
}

