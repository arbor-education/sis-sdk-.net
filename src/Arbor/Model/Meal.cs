using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Meal : ModelBase
    {
        protected string resourceType = ResourceType.MEAL;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string MEAL_NAME = "mealName";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string CUSTOMER_ACCOUNT_TYPE = "customerAccountType";
        public const string COPIED_TO_MEAL = "copiedToMeal";

        public Meal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Meal (string resourceType = "Meal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Meal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Meal");
        	RestGateway gateway = (RestGateway) Meal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Meal> mealCollection = new ModelCollection<Meal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    mealCollection.add((Meal) model);
        	}
        
        	return mealCollection;
        }

        public static Meal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Meal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Meal) gateway.retrieve(ResourceType.MEAL, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getMealName ()
        {
            return this.getProperty("mealName").ToString();
        }

        public void setMealName (string mealName)
        {
            this.setProperty("mealName", mealName);
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

        public CustomerAccountType getCustomerAccountType ()
        {
            return (CustomerAccountType) this.getProperty("customerAccountType");
        }

        public void setCustomerAccountType (CustomerAccountType customerAccountType)
        {
            this.setProperty("customerAccountType", customerAccountType);
        }

        public Meal getCopiedToMeal ()
        {
            return (Meal) this.getProperty("copiedToMeal");
        }

        public void setCopiedToMeal (Meal copiedToMeal)
        {
            this.setProperty("copiedToMeal", copiedToMeal);
        }


    }
}

