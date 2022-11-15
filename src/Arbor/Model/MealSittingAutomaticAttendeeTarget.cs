using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealSittingAutomaticAttendeeTarget : ModelBase
    {
        protected new string resourceType = ResourceType.MEAL_SITTING_AUTOMATIC_ATTENDEE_TARGET;
        public const string MEAL_SITTING = "mealSitting";
        public const string AUTOMATIC_ATTENDEE_TARGET = "automaticAttendeeTarget";

        public MealSittingAutomaticAttendeeTarget()
        {
            base.resourceType = this.resourceType;
        }

        public MealSittingAutomaticAttendeeTarget(string resourceType = "MealSittingAutomaticAttendeeTarget", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealSittingAutomaticAttendeeTarget> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealSittingAutomaticAttendeeTarget");
            RestGateway gateway = (RestGateway)MealSittingAutomaticAttendeeTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealSittingAutomaticAttendeeTarget> mealsittingautomaticattendeetargetCollection = new ModelCollection<MealSittingAutomaticAttendeeTarget>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealsittingautomaticattendeetargetCollection.add((MealSittingAutomaticAttendeeTarget)model);
            }

            return mealsittingautomaticattendeetargetCollection;
        }

        public static MealSittingAutomaticAttendeeTarget retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealSittingAutomaticAttendeeTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealSittingAutomaticAttendeeTarget)gateway.retrieve(ResourceType.MEAL_SITTING_AUTOMATIC_ATTENDEE_TARGET, id);
        }

        public MealSitting getMealSitting()
        {
            return (MealSitting)this.getProperty("mealSitting");
        }

        public void setMealSitting(MealSitting mealSitting)
        {
            this.setProperty("mealSitting", mealSitting);
        }

        public ModelBase getAutomaticAttendeeTarget()
        {
            return (ModelBase)this.getProperty("automaticAttendeeTarget");
        }

        public void setAutomaticAttendeeTarget(ModelBase automaticAttendeeTarget)
        {
            this.setProperty("automaticAttendeeTarget", automaticAttendeeTarget);
        }


    }
}

