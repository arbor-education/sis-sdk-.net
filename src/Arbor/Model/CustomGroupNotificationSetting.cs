using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomGroupNotificationSetting : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_GROUP_NOTIFICATION_SETTING;
        public const string CUSTOM_GROUP = "customGroup";
        public const string TRIGGER_EVENT_TYPE = "triggerEventType";
        public const string CREATE_PERSON_ALERT = "createPersonAlert";
        public const string SEND_EMAIL = "sendEmail";

        public CustomGroupNotificationSetting()
        {
            base.resourceType = this.resourceType;
        }

        public CustomGroupNotificationSetting(string resourceType = "CustomGroupNotificationSetting", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomGroupNotificationSetting> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomGroupNotificationSetting");
            RestGateway gateway = (RestGateway)CustomGroupNotificationSetting.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomGroupNotificationSetting> customgroupnotificationsettingCollection = new ModelCollection<CustomGroupNotificationSetting>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customgroupnotificationsettingCollection.add((CustomGroupNotificationSetting)model);
            }

            return customgroupnotificationsettingCollection;
        }

        public static CustomGroupNotificationSetting retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomGroupNotificationSetting.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomGroupNotificationSetting)gateway.retrieve(ResourceType.CUSTOM_GROUP_NOTIFICATION_SETTING, id);
        }

        public CustomGroup getCustomGroup()
        {
            return (CustomGroup)this.getProperty("customGroup");
        }

        public void setCustomGroup(CustomGroup customGroup)
        {
            this.setProperty("customGroup", customGroup);
        }

        public string getTriggerEventType()
        {
            return this.getProperty("triggerEventType").ToString();
        }

        public void setTriggerEventType(string triggerEventType)
        {
            this.setProperty("triggerEventType", triggerEventType);
        }

        public bool getCreatePersonAlert()
        {
            return Convert.ToBoolean(this.getProperty("createPersonAlert"));
        }

        public void setCreatePersonAlert(bool createPersonAlert)
        {
            this.setProperty("createPersonAlert", createPersonAlert);
        }

        public bool getSendEmail()
        {
            return Convert.ToBoolean(this.getProperty("sendEmail"));
        }

        public void setSendEmail(bool sendEmail)
        {
            this.setProperty("sendEmail", sendEmail);
        }


    }
}

