using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealChoice : ModelBase
    {
        protected new string resourceType = ResourceType.MEAL_CHOICE;
        public const string ATTENDEE = "attendee";
        public const string MEAL = "meal";
        public const string MEAL_PROVISION = "mealProvision";
        public const string APPLIES_MONDAY = "appliesMonday";
        public const string APPLIES_TUESDAY = "appliesTuesday";
        public const string APPLIES_WEDNESDAY = "appliesWednesday";
        public const string APPLIES_THURSDAY = "appliesThursday";
        public const string APPLIES_FRIDAY = "appliesFriday";
        public const string APPLIES_SATURDAY = "appliesSaturday";
        public const string APPLIES_SUNDAY = "appliesSunday";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public MealChoice ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MealChoice (string resourceType = "MealChoice", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MealChoice> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MealChoice");
        	RestGateway gateway = (RestGateway) MealChoice.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MealChoice> mealchoiceCollection = new ModelCollection<MealChoice> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    mealchoiceCollection.add((MealChoice) model);
        	}
        
        	return mealchoiceCollection;
        }

        public static MealChoice retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MealChoice.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MealChoice) gateway.retrieve(ResourceType.MEAL_CHOICE, id);
        }

        public ModelBase getAttendee ()
        {
            return (ModelBase) this.getProperty("attendee");
        }

        public void setAttendee (ModelBase attendee)
        {
            this.setProperty("attendee", attendee);
        }

        public Meal getMeal ()
        {
            return (Meal) this.getProperty("meal");
        }

        public void setMeal (Meal meal)
        {
            this.setProperty("meal", meal);
        }

        public MealProvision getMealProvision ()
        {
            return (MealProvision) this.getProperty("mealProvision");
        }

        public void setMealProvision (MealProvision mealProvision)
        {
            this.setProperty("mealProvision", mealProvision);
        }

        public bool getAppliesMonday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesMonday"));
        }

        public void setAppliesMonday (bool appliesMonday)
        {
            this.setProperty("appliesMonday", appliesMonday);
        }

        public bool getAppliesTuesday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesTuesday"));
        }

        public void setAppliesTuesday (bool appliesTuesday)
        {
            this.setProperty("appliesTuesday", appliesTuesday);
        }

        public bool getAppliesWednesday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesWednesday"));
        }

        public void setAppliesWednesday (bool appliesWednesday)
        {
            this.setProperty("appliesWednesday", appliesWednesday);
        }

        public bool getAppliesThursday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesThursday"));
        }

        public void setAppliesThursday (bool appliesThursday)
        {
            this.setProperty("appliesThursday", appliesThursday);
        }

        public bool getAppliesFriday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesFriday"));
        }

        public void setAppliesFriday (bool appliesFriday)
        {
            this.setProperty("appliesFriday", appliesFriday);
        }

        public bool getAppliesSaturday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesSaturday"));
        }

        public void setAppliesSaturday (bool appliesSaturday)
        {
            this.setProperty("appliesSaturday", appliesSaturday);
        }

        public bool getAppliesSunday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesSunday"));
        }

        public void setAppliesSunday (bool appliesSunday)
        {
            this.setProperty("appliesSunday", appliesSunday);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

