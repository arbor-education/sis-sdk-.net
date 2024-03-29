using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealPattern : ModelBase
    {
        protected new string resourceType = ResourceType.MEAL_PATTERN;
        public const string ATTENDEE = "attendee";
        public const string MEAL = "meal";
        public const string MEAL_SITTING = "mealSitting";
        public const string APPLIES_MONDAY = "appliesMonday";
        public const string APPLIES_TUESDAY = "appliesTuesday";
        public const string APPLIES_WEDNESDAY = "appliesWednesday";
        public const string APPLIES_THURSDAY = "appliesThursday";
        public const string APPLIES_FRIDAY = "appliesFriday";
        public const string APPLIES_SATURDAY = "appliesSaturday";
        public const string APPLIES_SUNDAY = "appliesSunday";
        public const string DAY_OF_CYCLE = "dayOfCycle";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string MEAL_SITTING_AUTOMATIC_ATTENDEE_TARGET = "mealSittingAutomaticAttendeeTarget";
        public const string GROUP_MEMBERSHIP = "groupMembership";

        public MealPattern()
        {
            base.resourceType = this.resourceType;
        }

        public MealPattern(string resourceType = "MealPattern", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealPattern> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealPattern");
            RestGateway gateway = (RestGateway)MealPattern.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealPattern> mealpatternCollection = new ModelCollection<MealPattern>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealpatternCollection.add((MealPattern)model);
            }

            return mealpatternCollection;
        }

        public static MealPattern retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealPattern.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealPattern)gateway.retrieve(ResourceType.MEAL_PATTERN, id);
        }

        public ModelBase getAttendee()
        {
            return (ModelBase)this.getProperty("attendee");
        }

        public void setAttendee(ModelBase attendee)
        {
            this.setProperty("attendee", attendee);
        }

        public Meal getMeal()
        {
            return (Meal)this.getProperty("meal");
        }

        public void setMeal(Meal meal)
        {
            this.setProperty("meal", meal);
        }

        public MealSitting getMealSitting()
        {
            return (MealSitting)this.getProperty("mealSitting");
        }

        public void setMealSitting(MealSitting mealSitting)
        {
            this.setProperty("mealSitting", mealSitting);
        }

        public bool getAppliesMonday()
        {
            return Convert.ToBoolean(this.getProperty("appliesMonday"));
        }

        public void setAppliesMonday(bool appliesMonday)
        {
            this.setProperty("appliesMonday", appliesMonday);
        }

        public bool getAppliesTuesday()
        {
            return Convert.ToBoolean(this.getProperty("appliesTuesday"));
        }

        public void setAppliesTuesday(bool appliesTuesday)
        {
            this.setProperty("appliesTuesday", appliesTuesday);
        }

        public bool getAppliesWednesday()
        {
            return Convert.ToBoolean(this.getProperty("appliesWednesday"));
        }

        public void setAppliesWednesday(bool appliesWednesday)
        {
            this.setProperty("appliesWednesday", appliesWednesday);
        }

        public bool getAppliesThursday()
        {
            return Convert.ToBoolean(this.getProperty("appliesThursday"));
        }

        public void setAppliesThursday(bool appliesThursday)
        {
            this.setProperty("appliesThursday", appliesThursday);
        }

        public bool getAppliesFriday()
        {
            return Convert.ToBoolean(this.getProperty("appliesFriday"));
        }

        public void setAppliesFriday(bool appliesFriday)
        {
            this.setProperty("appliesFriday", appliesFriday);
        }

        public bool getAppliesSaturday()
        {
            return Convert.ToBoolean(this.getProperty("appliesSaturday"));
        }

        public void setAppliesSaturday(bool appliesSaturday)
        {
            this.setProperty("appliesSaturday", appliesSaturday);
        }

        public bool getAppliesSunday()
        {
            return Convert.ToBoolean(this.getProperty("appliesSunday"));
        }

        public void setAppliesSunday(bool appliesSunday)
        {
            this.setProperty("appliesSunday", appliesSunday);
        }

        public int getDayOfCycle()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle(int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
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

        public MealSittingAutomaticAttendeeTarget getMealSittingAutomaticAttendeeTarget()
        {
            return (MealSittingAutomaticAttendeeTarget)this.getProperty("mealSittingAutomaticAttendeeTarget");
        }

        public void setMealSittingAutomaticAttendeeTarget(MealSittingAutomaticAttendeeTarget mealSittingAutomaticAttendeeTarget)
        {
            this.setProperty("mealSittingAutomaticAttendeeTarget", mealSittingAutomaticAttendeeTarget);
        }

        public ModelBase getGroupMembership()
        {
            return (ModelBase)this.getProperty("groupMembership");
        }

        public void setGroupMembership(ModelBase groupMembership)
        {
            this.setProperty("groupMembership", groupMembership);
        }


    }
}

