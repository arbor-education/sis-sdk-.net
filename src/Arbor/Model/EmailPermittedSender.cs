using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailPermittedSender : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_PERMITTED_SENDER;
        public const string ACTION_TAKER = "actionTaker";
        public const string SENDER = "sender";
        public const string ALLOW = "allow";

        public EmailPermittedSender()
        {
            base.resourceType = this.resourceType;
        }

        public EmailPermittedSender(string resourceType = "EmailPermittedSender", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailPermittedSender> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailPermittedSender");
            RestGateway gateway = (RestGateway)EmailPermittedSender.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailPermittedSender> emailpermittedsenderCollection = new ModelCollection<EmailPermittedSender>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailpermittedsenderCollection.add((EmailPermittedSender)model);
            }

            return emailpermittedsenderCollection;
        }

        public static EmailPermittedSender retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailPermittedSender.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailPermittedSender)gateway.retrieve(ResourceType.EMAIL_PERMITTED_SENDER, id);
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

