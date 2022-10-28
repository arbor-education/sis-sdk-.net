using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealRotationMenu : ModelBase
    {
        protected new string resourceType = ResourceType.MEAL_ROTATION_MENU;
        public const string NAME = "name";
        public const string MEAL = "meal";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string IS_ENABLED = "isEnabled";
        public const string CUT_OFF_TIME_PERIOD = "cutOffTimePeriod";
        public const string CUT_OFF_TIME_VALUE = "cutOffTimeValue";
        public const string ALLOW_MEAL_CHARGES_WHEN_NOT_ENOUGH_BALANCE = "allowMealChargesWhenNotEnoughBalance";

        public MealRotationMenu()
        {
            base.resourceType = this.resourceType;
        }

        public MealRotationMenu(string resourceType = "MealRotationMenu", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealRotationMenu> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealRotationMenu");
            RestGateway gateway = (RestGateway)MealRotationMenu.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealRotationMenu> mealrotationmenuCollection = new ModelCollection<MealRotationMenu>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealrotationmenuCollection.add((MealRotationMenu)model);
            }

            return mealrotationmenuCollection;
        }

        public static MealRotationMenu retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealRotationMenu.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealRotationMenu)gateway.retrieve(ResourceType.MEAL_ROTATION_MENU, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public Meal getMeal()
        {
            return (Meal)this.getProperty("meal");
        }

        public void setMeal(Meal meal)
        {
            this.setProperty("meal", meal);
        }

        public DateTime getEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate(DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public bool getIsEnabled()
        {
            return Convert.ToBoolean(this.getProperty("isEnabled"));
        }

        public void setIsEnabled(bool isEnabled)
        {
            this.setProperty("isEnabled", isEnabled);
        }

        public string getCutOffTimePeriod()
        {
            return this.getProperty("cutOffTimePeriod").ToString();
        }

        public void setCutOffTimePeriod(string cutOffTimePeriod)
        {
            this.setProperty("cutOffTimePeriod", cutOffTimePeriod);
        }

        public string getCutOffTimeValue()
        {
            return this.getProperty("cutOffTimeValue").ToString();
        }

        public void setCutOffTimeValue(string cutOffTimeValue)
        {
            this.setProperty("cutOffTimeValue", cutOffTimeValue);
        }

        public bool getAllowMealChargesWhenNotEnoughBalance()
        {
            return Convert.ToBoolean(this.getProperty("allowMealChargesWhenNotEnoughBalance"));
        }

        public void setAllowMealChargesWhenNotEnoughBalance(bool allowMealChargesWhenNotEnoughBalance)
        {
            this.setProperty("allowMealChargesWhenNotEnoughBalance", allowMealChargesWhenNotEnoughBalance);
        }


    }
}

