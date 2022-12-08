using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealProvision : ModelBase
    {
        protected string resourceType = ResourceType.MEAL_PROVISION;
        public const string MEAL = "meal";
        public const string MEAL_PROVISION_NAME = "mealProvisionName";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string IS_ABSENT = "isAbsent";
        public const string IS_SCHOOL_HOT_MEAL = "isSchoolHotMeal";
        public const string IS_SCHOOL_LIGHT_MEAL = "isSchoolLightMeal";
        public const string IS_SCHOOL_PACKED_MEAL = "isSchoolPackedMeal";
        public const string IS_STUDENT_PACKED_MEAL = "isStudentPackedMeal";
        public const string REQUIRES_MEAL = "requiresMeal";
        public const string COPIED_TO_MEAL_PROVISION = "copiedToMealProvision";

        public MealProvision()
        {
            base.resourceType = this.resourceType;
        }

        public MealProvision(string resourceType = "MealProvision", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealProvision> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealProvision");
            RestGateway gateway = (RestGateway)MealProvision.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealProvision> mealprovisionCollection = new ModelCollection<MealProvision>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealprovisionCollection.add((MealProvision)model);
            }

            return mealprovisionCollection;
        }

        public static MealProvision retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealProvision.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealProvision)gateway.retrieve(ResourceType.MEAL_PROVISION, id);
        }

        public Meal getMeal()
        {
            return (Meal)this.getProperty("meal");
        }

        public void setMeal(Meal meal)
        {
            this.setProperty("meal", meal);
        }

        public string getMealProvisionName()
        {
            return this.getProperty("mealProvisionName").ToString();
        }

        public void setMealProvisionName(string mealProvisionName)
        {
            this.setProperty("mealProvisionName", mealProvisionName);
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

        public bool getIsAbsent()
        {
            return Convert.ToBoolean(this.getProperty("isAbsent"));
        }

        public void setIsAbsent(bool isAbsent)
        {
            this.setProperty("isAbsent", isAbsent);
        }

        public bool getIsSchoolHotMeal()
        {
            return Convert.ToBoolean(this.getProperty("isSchoolHotMeal"));
        }

        public void setIsSchoolHotMeal(bool isSchoolHotMeal)
        {
            this.setProperty("isSchoolHotMeal", isSchoolHotMeal);
        }

        public bool getIsSchoolLightMeal()
        {
            return Convert.ToBoolean(this.getProperty("isSchoolLightMeal"));
        }

        public void setIsSchoolLightMeal(bool isSchoolLightMeal)
        {
            this.setProperty("isSchoolLightMeal", isSchoolLightMeal);
        }

        public bool getIsSchoolPackedMeal()
        {
            return Convert.ToBoolean(this.getProperty("isSchoolPackedMeal"));
        }

        public void setIsSchoolPackedMeal(bool isSchoolPackedMeal)
        {
            this.setProperty("isSchoolPackedMeal", isSchoolPackedMeal);
        }

        public bool getIsStudentPackedMeal()
        {
            return Convert.ToBoolean(this.getProperty("isStudentPackedMeal"));
        }

        public void setIsStudentPackedMeal(bool isStudentPackedMeal)
        {
            this.setProperty("isStudentPackedMeal", isStudentPackedMeal);
        }

        public bool getRequiresMeal()
        {
            return Convert.ToBoolean(this.getProperty("requiresMeal"));
        }

        public void setRequiresMeal(bool requiresMeal)
        {
            this.setProperty("requiresMeal", requiresMeal);
        }

        public MealProvision getCopiedToMealProvision()
        {
            return (MealProvision)this.getProperty("copiedToMealProvision");
        }

        public void setCopiedToMealProvision(MealProvision copiedToMealProvision)
        {
            this.setProperty("copiedToMealProvision", copiedToMealProvision);
        }


    }
}

