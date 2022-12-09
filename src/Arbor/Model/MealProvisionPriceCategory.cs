using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealProvisionPriceCategory : ModelBase
    {
        protected new string resourceType = ResourceType.MEAL_PROVISION_PRICE_CATEGORY;
        public const string CATEGORY_NAME = "categoryName";
        public const string MEAL_PROVISION = "mealProvision";
        public const string APPLIES_TO = "appliesTo";
        public const string GROUP = "group";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public MealProvisionPriceCategory()
        {
            base.resourceType = this.resourceType;
        }

        public MealProvisionPriceCategory(string resourceType = "MealProvisionPriceCategory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealProvisionPriceCategory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealProvisionPriceCategory");
            RestGateway gateway = (RestGateway)MealProvisionPriceCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealProvisionPriceCategory> mealprovisionpricecategoryCollection = new ModelCollection<MealProvisionPriceCategory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealprovisionpricecategoryCollection.add((MealProvisionPriceCategory)model);
            }

            return mealprovisionpricecategoryCollection;
        }

        public static MealProvisionPriceCategory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealProvisionPriceCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealProvisionPriceCategory)gateway.retrieve(ResourceType.MEAL_PROVISION_PRICE_CATEGORY, id);
        }

        public string getCategoryName()
        {
            return this.getProperty("categoryName").ToString();
        }

        public void setCategoryName(string categoryName)
        {
            this.setProperty("categoryName", categoryName);
        }

        public MealProvision getMealProvision()
        {
            return (MealProvision)this.getProperty("mealProvision");
        }

        public void setMealProvision(MealProvision mealProvision)
        {
            this.setProperty("mealProvision", mealProvision);
        }

        public string getAppliesTo()
        {
            return this.getProperty("appliesTo").ToString();
        }

        public void setAppliesTo(string appliesTo)
        {
            this.setProperty("appliesTo", appliesTo);
        }

        public ModelBase getGroup()
        {
            return (ModelBase)this.getProperty("group");
        }

        public void setGroup(ModelBase group)
        {
            this.setProperty("group", group);
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


    }
}

