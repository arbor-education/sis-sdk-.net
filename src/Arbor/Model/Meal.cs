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
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string MEAL_NAME = "mealName";

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

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getMealName ()
        {
            return this.getProperty("mealName").ToString();
        }

        public void setMealName (string mealName)
        {
            this.setProperty("mealName", mealName);
        }


    }
}

