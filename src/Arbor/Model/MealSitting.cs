using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealSitting : ModelBase
    {
        protected string resourceType = ResourceType.MEAL_SITTING;
        public const string MEAL = "meal";
        public const string MEAL_SITTING_NAME = "mealSittingName";
        public const string ROOM = "room";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public MealSitting ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MealSitting (string resourceType = "MealSitting", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MealSitting> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MealSitting");
        	RestGateway gateway = (RestGateway) MealSitting.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MealSitting> mealsittingCollection = new ModelCollection<MealSitting> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    mealsittingCollection.add((MealSitting) model);
        	}
        
        	return mealsittingCollection;
        }

        public static MealSitting retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MealSitting.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MealSitting) gateway.retrieve(ResourceType.MEAL_SITTING, id);
        }

        public Meal getMeal ()
        {
            return (Meal) this.getProperty("meal");
        }

        public void setMeal (Meal meal)
        {
            this.setProperty("meal", meal);
        }

        public string getMealSittingName ()
        {
            return this.getProperty("mealSittingName").ToString();
        }

        public void setMealSittingName (string mealSittingName)
        {
            this.setProperty("mealSittingName", mealSittingName);
        }

        public Room getRoom ()
        {
            return (Room) this.getProperty("room");
        }

        public void setRoom (Room room)
        {
            this.setProperty("room", room);
        }

        public DateTime getEffectiveDate (){
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

