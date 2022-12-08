using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SendingProfile : ModelBase
    {
        protected string resourceType = ResourceType.SENDING_PROFILE;
        public const string OWNER = "owner";
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string MOBILE_TELEPHONE_NUMBER = "mobileTelephoneNumber";
        public const string PERMITTED_SENDER = "permittedSender";

        public SendingProfile()
        {
            base.resourceType = this.resourceType;
        }

        public SendingProfile(string resourceType = "SendingProfile", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SendingProfile> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SendingProfile");
            RestGateway gateway = (RestGateway)SendingProfile.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SendingProfile> sendingprofileCollection = new ModelCollection<SendingProfile>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                sendingprofileCollection.add((SendingProfile)model);
            }

            return sendingprofileCollection;
        }

        public static SendingProfile retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SendingProfile.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SendingProfile)gateway.retrieve(ResourceType.SENDING_PROFILE, id);
        }

        public ModelBase getOwner()
        {
            return (ModelBase)this.getProperty("owner");
        }

        public void setOwner(ModelBase owner)
        {
            this.setProperty("owner", owner);
        }

        public EmailAddress getEmailAddress()
        {
            return (EmailAddress)this.getProperty("emailAddress");
        }

        public void setEmailAddress(EmailAddress emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public TelephoneNumber getMobileTelephoneNumber()
        {
            return (TelephoneNumber)this.getProperty("mobileTelephoneNumber");
        }

        public void setMobileTelephoneNumber(TelephoneNumber mobileTelephoneNumber)
        {
            this.setProperty("mobileTelephoneNumber", mobileTelephoneNumber);
        }

        public Staff getPermittedSender()
        {
            return (Staff)this.getProperty("permittedSender");
        }

        public void setPermittedSender(Staff permittedSender)
        {
            this.setProperty("permittedSender", permittedSender);
        }


    }
}

