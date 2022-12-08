using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InAppMessageNotification : ModelBase
    {
        protected string resourceType = ResourceType.IN_APP_MESSAGE_NOTIFICATION;
        public const string IN_APP_MESSAGE = "inAppMessage";
        public const string NOTIFICATION_CHANNEL = "notificationChannel";

        public InAppMessageNotification()
        {
            base.resourceType = this.resourceType;
        }

        public InAppMessageNotification(string resourceType = "InAppMessageNotification", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InAppMessageNotification> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InAppMessageNotification");
            RestGateway gateway = (RestGateway)InAppMessageNotification.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InAppMessageNotification> inappmessagenotificationCollection = new ModelCollection<InAppMessageNotification>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inappmessagenotificationCollection.add((InAppMessageNotification)model);
            }

            return inappmessagenotificationCollection;
        }

        public static InAppMessageNotification retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InAppMessageNotification.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InAppMessageNotification)gateway.retrieve(ResourceType.IN_APP_MESSAGE_NOTIFICATION, id);
        }

        public ModelBase getInAppMessage()
        {
            return (ModelBase)this.getProperty("inAppMessage");
        }

        public void setInAppMessage(ModelBase inAppMessage)
        {
            this.setProperty("inAppMessage", inAppMessage);
        }

        public ModelBase getNotificationChannel()
        {
            return (ModelBase)this.getProperty("notificationChannel");
        }

        public void setNotificationChannel(ModelBase notificationChannel)
        {
            this.setProperty("notificationChannel", notificationChannel);
        }


    }
}

