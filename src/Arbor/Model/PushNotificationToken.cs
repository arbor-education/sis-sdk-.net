using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PushNotificationToken : ModelBase
    {
        protected new string resourceType = ResourceType.PUSH_NOTIFICATION_TOKEN;
        public const string USER = "user";
        public const string TOKEN = "token";
        public const string UNIQUE_IDENTIFIER = "uniqueIdentifier";
        public const string DEVICE_OS = "deviceOs";
        public const string REAL_PUSH_TOKEN = "realPushToken";
        public const string DEVICE_ID = "deviceId";

        public PushNotificationToken()
        {
            base.resourceType = this.resourceType;
        }

        public PushNotificationToken(string resourceType = "PushNotificationToken", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PushNotificationToken> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PushNotificationToken");
            RestGateway gateway = (RestGateway)PushNotificationToken.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PushNotificationToken> pushnotificationtokenCollection = new ModelCollection<PushNotificationToken>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                pushnotificationtokenCollection.add((PushNotificationToken)model);
            }

            return pushnotificationtokenCollection;
        }

        public static PushNotificationToken retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PushNotificationToken.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PushNotificationToken)gateway.retrieve(ResourceType.PUSH_NOTIFICATION_TOKEN, id);
        }

        public User getUser()
        {
            return (User)this.getProperty("user");
        }

        public void setUser(User user)
        {
            this.setProperty("user", user);
        }

        public string getToken()
        {
            return this.getProperty("token").ToString();
        }

        public void setToken(string token)
        {
            this.setProperty("token", token);
        }

        public string getUniqueIdentifier()
        {
            return this.getProperty("uniqueIdentifier").ToString();
        }

        public void setUniqueIdentifier(string uniqueIdentifier)
        {
            this.setProperty("uniqueIdentifier", uniqueIdentifier);
        }

        public string getDeviceOs()
        {
            return this.getProperty("deviceOs").ToString();
        }

        public void setDeviceOs(string deviceOs)
        {
            this.setProperty("deviceOs", deviceOs);
        }

        public string getRealPushToken()
        {
            return this.getProperty("realPushToken").ToString();
        }

        public void setRealPushToken(string realPushToken)
        {
            this.setProperty("realPushToken", realPushToken);
        }

        public string getDeviceId()
        {
            return this.getProperty("deviceId").ToString();
        }

        public void setDeviceId(string deviceId)
        {
            this.setProperty("deviceId", deviceId);
        }


    }
}

