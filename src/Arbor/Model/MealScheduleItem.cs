using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealScheduleItem : ModelBase
    {
        protected string resourceType = ResourceType.MEAL_SCHEDULE_ITEM;
        public const string MEAL_SCHEDULE = "mealSchedule";
        public const string MON_PROVISION = "monProvision";
        public const string MON_LABEL = "monLabel";
        public const string TUE_PROVISION = "tueProvision";
        public const string TUE_LABEL = "tueLabel";
        public const string WED_PROVISION = "wedProvision";
        public const string WED_LABEL = "wedLabel";
        public const string THU_PROVISION = "thuProvision";
        public const string THU_LABEL = "thuLabel";
        public const string FRI_PROVISION = "friProvision";
        public const string FRI_LABEL = "friLabel";
        public const string SAT_PROVISION = "satProvision";
        public const string SAT_LABEL = "satLabel";
        public const string SUN_PROVISION = "sunProvision";
        public const string SUN_LABEL = "sunLabel";

        public MealScheduleItem()
        {
            base.resourceType = this.resourceType;
        }

        public MealScheduleItem(string resourceType = "MealScheduleItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealScheduleItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealScheduleItem");
            RestGateway gateway = (RestGateway)MealScheduleItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealScheduleItem> mealscheduleitemCollection = new ModelCollection<MealScheduleItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealscheduleitemCollection.add((MealScheduleItem)model);
            }

            return mealscheduleitemCollection;
        }

        public static MealScheduleItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealScheduleItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealScheduleItem)gateway.retrieve(ResourceType.MEAL_SCHEDULE_ITEM, id);
        }

        public MealSchedule getMealSchedule()
        {
            return (MealSchedule)this.getProperty("mealSchedule");
        }

        public void setMealSchedule(MealSchedule mealSchedule)
        {
            this.setProperty("mealSchedule", mealSchedule);
        }

        public MealProvision getMonProvision()
        {
            return (MealProvision)this.getProperty("monProvision");
        }

        public void setMonProvision(MealProvision monProvision)
        {
            this.setProperty("monProvision", monProvision);
        }

        public string getMonLabel()
        {
            return this.getProperty("monLabel").ToString();
        }

        public void setMonLabel(string monLabel)
        {
            this.setProperty("monLabel", monLabel);
        }

        public MealProvision getTueProvision()
        {
            return (MealProvision)this.getProperty("tueProvision");
        }

        public void setTueProvision(MealProvision tueProvision)
        {
            this.setProperty("tueProvision", tueProvision);
        }

        public string getTueLabel()
        {
            return this.getProperty("tueLabel").ToString();
        }

        public void setTueLabel(string tueLabel)
        {
            this.setProperty("tueLabel", tueLabel);
        }

        public MealProvision getWedProvision()
        {
            return (MealProvision)this.getProperty("wedProvision");
        }

        public void setWedProvision(MealProvision wedProvision)
        {
            this.setProperty("wedProvision", wedProvision);
        }

        public string getWedLabel()
        {
            return this.getProperty("wedLabel").ToString();
        }

        public void setWedLabel(string wedLabel)
        {
            this.setProperty("wedLabel", wedLabel);
        }

        public MealProvision getThuProvision()
        {
            return (MealProvision)this.getProperty("thuProvision");
        }

        public void setThuProvision(MealProvision thuProvision)
        {
            this.setProperty("thuProvision", thuProvision);
        }

        public string getThuLabel()
        {
            return this.getProperty("thuLabel").ToString();
        }

        public void setThuLabel(string thuLabel)
        {
            this.setProperty("thuLabel", thuLabel);
        }

        public MealProvision getFriProvision()
        {
            return (MealProvision)this.getProperty("friProvision");
        }

        public void setFriProvision(MealProvision friProvision)
        {
            this.setProperty("friProvision", friProvision);
        }

        public string getFriLabel()
        {
            return this.getProperty("friLabel").ToString();
        }

        public void setFriLabel(string friLabel)
        {
            this.setProperty("friLabel", friLabel);
        }

        public MealProvision getSatProvision()
        {
            return (MealProvision)this.getProperty("satProvision");
        }

        public void setSatProvision(MealProvision satProvision)
        {
            this.setProperty("satProvision", satProvision);
        }

        public string getSatLabel()
        {
            return this.getProperty("satLabel").ToString();
        }

        public void setSatLabel(string satLabel)
        {
            this.setProperty("satLabel", satLabel);
        }

        public MealProvision getSunProvision()
        {
            return (MealProvision)this.getProperty("sunProvision");
        }

        public void setSunProvision(MealProvision sunProvision)
        {
            this.setProperty("sunProvision", sunProvision);
        }

        public string getSunLabel()
        {
            return this.getProperty("sunLabel").ToString();
        }

        public void setSunLabel(string sunLabel)
        {
            this.setProperty("sunLabel", sunLabel);
        }


    }
}

