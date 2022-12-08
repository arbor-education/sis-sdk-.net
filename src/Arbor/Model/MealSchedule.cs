using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealSchedule : ModelBase
    {
        protected string resourceType = ResourceType.MEAL_SCHEDULE;
        public const string NAME = "name";
        public const string WEEK = "week";
        public const string MEAL_ROTATION_MENU = "mealRotationMenu";

        public MealSchedule()
        {
            base.resourceType = this.resourceType;
        }

        public MealSchedule(string resourceType = "MealSchedule", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealSchedule> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealSchedule");
            RestGateway gateway = (RestGateway)MealSchedule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealSchedule> mealscheduleCollection = new ModelCollection<MealSchedule>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealscheduleCollection.add((MealSchedule)model);
            }

            return mealscheduleCollection;
        }

        public static MealSchedule retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealSchedule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealSchedule)gateway.retrieve(ResourceType.MEAL_SCHEDULE, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public int getWeek()
        {
            return Convert.ToInt32(this.getProperty("week"));
        }

        public void setWeek(int week)
        {
            this.setProperty("week", week);
        }

        public MealRotationMenu getMealRotationMenu()
        {
            return (MealRotationMenu)this.getProperty("mealRotationMenu");
        }

        public void setMealRotationMenu(MealRotationMenu mealRotationMenu)
        {
            this.setProperty("mealRotationMenu", mealRotationMenu);
        }


    }
}

