using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OutboundLetterPermittedSender : ModelBase
    {
        protected string resourceType = ResourceType.OUTBOUND_LETTER_PERMITTED_SENDER;
        public const string ACTION_TAKER = "actionTaker";
        public const string SENDER = "sender";
        public const string ALLOW = "allow";

        public OutboundLetterPermittedSender()
        {
            base.resourceType = this.resourceType;
        }

        public OutboundLetterPermittedSender(string resourceType = "OutboundLetterPermittedSender", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<OutboundLetterPermittedSender> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("OutboundLetterPermittedSender");
            RestGateway gateway = (RestGateway)OutboundLetterPermittedSender.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<OutboundLetterPermittedSender> outboundletterpermittedsenderCollection = new ModelCollection<OutboundLetterPermittedSender>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                outboundletterpermittedsenderCollection.add((OutboundLetterPermittedSender)model);
            }

            return outboundletterpermittedsenderCollection;
        }

        public static OutboundLetterPermittedSender retrieve(string id)
        {
            RestGateway gateway = (RestGateway)OutboundLetterPermittedSender.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (OutboundLetterPermittedSender)gateway.retrieve(ResourceType.OUTBOUND_LETTER_PERMITTED_SENDER, id);
        }

        public Staff getActionTaker()
        {
            return (Staff)this.getProperty("actionTaker");
        }

        public void setActionTaker(Staff actionTaker)
        {
            this.setProperty("actionTaker", actionTaker);
        }

        public ModelBase getSender()
        {
            return (ModelBase)this.getProperty("sender");
        }

        public void setSender(ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public bool getAllow()
        {
            return Convert.ToBoolean(this.getProperty("allow"));
        }

        public void setAllow(bool allow)
        {
            this.setProperty("allow", allow);
        }


    }
}

