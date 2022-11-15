using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealRotationMenuChoice : ModelBase
    {
        protected new string resourceType = ResourceType.MEAL_ROTATION_MENU_CHOICE;
        public const string ATTENDEE = "attendee";
        public const string MEAL_PROVISION = "mealProvision";
        public const string MEAL_CHOICE_DATE = "mealChoiceDate";

        public MealRotationMenuChoice()
        {
            base.resourceType = this.resourceType;
        }

        public MealRotationMenuChoice(string resourceType = "MealRotationMenuChoice", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MealRotationMenuChoice> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MealRotationMenuChoice");
            RestGateway gateway = (RestGateway)MealRotationMenuChoice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MealRotationMenuChoice> mealrotationmenuchoiceCollection = new ModelCollection<MealRotationMenuChoice>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                mealrotationmenuchoiceCollection.add((MealRotationMenuChoice)model);
            }

            return mealrotationmenuchoiceCollection;
        }

        public static MealRotationMenuChoice retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MealRotationMenuChoice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MealRotationMenuChoice)gateway.retrieve(ResourceType.MEAL_ROTATION_MENU_CHOICE, id);
        }

        public ModelBase getAttendee()
        {
            return (ModelBase)this.getProperty("attendee");
        }

        public void setAttendee(ModelBase attendee)
        {
            this.setProperty("attendee", attendee);
        }

        public MealProvision getMealProvision()
        {
            return (MealProvision)this.getProperty("mealProvision");
        }

        public void setMealProvision(MealProvision mealProvision)
        {
            this.setProperty("mealProvision", mealProvision);
        }

        public DateTime getMealChoiceDate()
        {
            return Convert.ToDateTime(this.getProperty("mealChoiceDate"));
        }

        public void setMealChoiceDate(DateTime mealChoiceDate)
        {
            this.setProperty("mealChoiceDate", mealChoiceDate);
        }


    }
}

