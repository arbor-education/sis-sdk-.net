using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OutboundInAppMessageDraft : ModelBase
    {
        protected new string resourceType = ResourceType.OUTBOUND_IN_APP_MESSAGE_DRAFT;
        public const string SENDER = "sender";
        public const string MESSAGE = "message";
        public const string COMBINE_MESSAGES_TO_SAME_RECIPIENT = "combineMessagesToSameRecipient";
        public const string COMBINE_MESSAGES_TO_SAME_HOUSEHOLD = "combineMessagesToSameHousehold";
        public const string GENERATED_DATETIME = "generatedDatetime";
        public const string CONTEXT = "context";

        public OutboundInAppMessageDraft()
        {
            base.resourceType = this.resourceType;
        }

        public OutboundInAppMessageDraft(string resourceType = "OutboundInAppMessageDraft", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<OutboundInAppMessageDraft> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("OutboundInAppMessageDraft");
            RestGateway gateway = (RestGateway)OutboundInAppMessageDraft.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<OutboundInAppMessageDraft> outboundinappmessagedraftCollection = new ModelCollection<OutboundInAppMessageDraft>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                outboundinappmessagedraftCollection.add((OutboundInAppMessageDraft)model);
            }

            return outboundinappmessagedraftCollection;
        }

        public static OutboundInAppMessageDraft retrieve(string id)
        {
            RestGateway gateway = (RestGateway)OutboundInAppMessageDraft.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (OutboundInAppMessageDraft)gateway.retrieve(ResourceType.OUTBOUND_IN_APP_MESSAGE_DRAFT, id);
        }

        public ModelBase getSender()
        {
            return (ModelBase)this.getProperty("sender");
        }

        public void setSender(ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public string getMessage()
        {
            return this.getProperty("message").ToString();
        }

        public void setMessage(string message)
        {
            this.setProperty("message", message);
        }

        public bool getCombineMessagesToSameRecipient()
        {
            return Convert.ToBoolean(this.getProperty("combineMessagesToSameRecipient"));
        }

        public void setCombineMessagesToSameRecipient(bool combineMessagesToSameRecipient)
        {
            this.setProperty("combineMessagesToSameRecipient", combineMessagesToSameRecipient);
        }

        public bool getCombineMessagesToSameHousehold()
        {
            return Convert.ToBoolean(this.getProperty("combineMessagesToSameHousehold"));
        }

        public void setCombineMessagesToSameHousehold(bool combineMessagesToSameHousehold)
        {
            this.setProperty("combineMessagesToSameHousehold", combineMessagesToSameHousehold);
        }

        public DateTime getGeneratedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("generatedDatetime"));
        }

        public void setGeneratedDatetime(DateTime generatedDatetime)
        {
            this.setProperty("generatedDatetime", generatedDatetime);
        }

        public ModelBase getContext()
        {
            return (ModelBase)this.getProperty("context");
        }

        public void setContext(ModelBase context)
        {
            this.setProperty("context", context);
        }


    }
}

