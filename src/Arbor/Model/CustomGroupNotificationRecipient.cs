using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomGroupNotificationRecipient : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_GROUP_NOTIFICATION_RECIPIENT;
        public const string CUSTOM_GROUP_NOTIFICATION_SETTING = "customGroupNotificationSetting";
        public const string STAFF = "staff";
        public const string STAFF_TYPE = "staffType";

        public CustomGroupNotificationRecipient()
        {
            base.resourceType = this.resourceType;
        }

        public CustomGroupNotificationRecipient(string resourceType = "CustomGroupNotificationRecipient", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomGroupNotificationRecipient> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomGroupNotificationRecipient");
            RestGateway gateway = (RestGateway)CustomGroupNotificationRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomGroupNotificationRecipient> customgroupnotificationrecipientCollection = new ModelCollection<CustomGroupNotificationRecipient>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customgroupnotificationrecipientCollection.add((CustomGroupNotificationRecipient)model);
            }

            return customgroupnotificationrecipientCollection;
        }

        public static CustomGroupNotificationRecipient retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomGroupNotificationRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomGroupNotificationRecipient)gateway.retrieve(ResourceType.CUSTOM_GROUP_NOTIFICATION_RECIPIENT, id);
        }

        public CustomGroupNotificationSetting getCustomGroupNotificationSetting()
        {
            return (CustomGroupNotificationSetting)this.getProperty("customGroupNotificationSetting");
        }

        public void setCustomGroupNotificationSetting(CustomGroupNotificationSetting customGroupNotificationSetting)
        {
            this.setProperty("customGroupNotificationSetting", customGroupNotificationSetting);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public string getStaffType()
        {
            return this.getProperty("staffType").ToString();
        }

        public void setStaffType(string staffType)
        {
            this.setProperty("staffType", staffType);
        }


    }
}

