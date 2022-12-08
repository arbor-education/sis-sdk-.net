using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ApplicationSetting : ModelBase
    {
        protected string resourceType = ResourceType.APPLICATION_SETTING;
        public const string SETTING_NAME = "settingName";
        public const string SETTING_VALUE = "settingValue";
        public const string SETTING_CLASS = "settingClass";

        public ApplicationSetting()
        {
            base.resourceType = this.resourceType;
        }

        public ApplicationSetting(string resourceType = "ApplicationSetting", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ApplicationSetting> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ApplicationSetting");
            RestGateway gateway = (RestGateway)ApplicationSetting.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ApplicationSetting> applicationsettingCollection = new ModelCollection<ApplicationSetting>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                applicationsettingCollection.add((ApplicationSetting)model);
            }

            return applicationsettingCollection;
        }

        public static ApplicationSetting retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ApplicationSetting.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ApplicationSetting)gateway.retrieve(ResourceType.APPLICATION_SETTING, id);
        }

        public string getSettingName()
        {
            return this.getProperty("settingName").ToString();
        }

        public void setSettingName(string settingName)
        {
            this.setProperty("settingName", settingName);
        }

        public string getSettingValue()
        {
            return this.getProperty("settingValue").ToString();
        }

        public void setSettingValue(string settingValue)
        {
            this.setProperty("settingValue", settingValue);
        }

        public string getSettingClass()
        {
            return this.getProperty("settingClass").ToString();
        }

        public void setSettingClass(string settingClass)
        {
            this.setProperty("settingClass", settingClass);
        }


    }
}

