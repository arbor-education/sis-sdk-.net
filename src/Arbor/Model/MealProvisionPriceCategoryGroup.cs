using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealProvisionPriceCategoryGroup : ModelBase
    {
        protected string resourceType = ResourceType.MEAL_PROVISION_PRICE_CATEGORY_GROUP;
        public const string MEAL_PROVISION_PRICE_CATEGORY = "mealProvisionPriceCategory";
        public const string GROUP = "group";

        public MealProvisionPriceCategoryGroup ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MealProvisionPriceCategoryGroup (string resourceType = "MealProvisionPriceCategoryGroup", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MealProvisionPriceCategoryGroup> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MealProvisionPriceCategoryGroup");
        	RestGateway gateway = (RestGateway) MealProvisionPriceCategoryGroup.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MealProvisionPriceCategoryGroup> mealprovisionpricecategorygroupCollection = new ModelCollection<MealProvisionPriceCategoryGroup> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    mealprovisionpricecategorygroupCollection.add((MealProvisionPriceCategoryGroup) model);
        	}
        
        	return mealprovisionpricecategorygroupCollection;
        }

        public static MealProvisionPriceCategoryGroup retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MealProvisionPriceCategoryGroup.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MealProvisionPriceCategoryGroup) gateway.retrieve(ResourceType.MEAL_PROVISION_PRICE_CATEGORY_GROUP, id);
        }

        public MealProvisionPriceCategory getMealProvisionPriceCategory ()
        {
            return (MealProvisionPriceCategory) this.getProperty("mealProvisionPriceCategory");
        }

        public void setMealProvisionPriceCategory (MealProvisionPriceCategory mealProvisionPriceCategory)
        {
            this.setProperty("mealProvisionPriceCategory", mealProvisionPriceCategory);
        }

        public ModelBase getGroup ()
        {
            return (ModelBase) this.getProperty("group");
        }

        public void setGroup (ModelBase group)
        {
            this.setProperty("group", group);
        }


    }
}

