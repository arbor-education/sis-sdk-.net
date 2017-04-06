using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MealSessionRegisterRecord : ModelBase
    {
        protected string resourceType = ResourceType.MEAL_SESSION_REGISTER_RECORD;
        public const string MEAL_SESSION = "mealSession";
        public const string PERSON = "person";
        public const string MEAL_PROVISION = "mealProvision";
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string MEAL_PROVISION_PRICE_CATEGORY = "mealProvisionPriceCategory";
        public const string SOURCE = "source";

        public MealSessionRegisterRecord ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MealSessionRegisterRecord (string resourceType = "MealSessionRegisterRecord", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MealSessionRegisterRecord> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MealSessionRegisterRecord");
        	RestGateway gateway = (RestGateway) MealSessionRegisterRecord.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MealSessionRegisterRecord> mealsessionregisterrecordCollection = new ModelCollection<MealSessionRegisterRecord> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    mealsessionregisterrecordCollection.add((MealSessionRegisterRecord) model);
        	}
        
        	return mealsessionregisterrecordCollection;
        }

        public static MealSessionRegisterRecord retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MealSessionRegisterRecord.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MealSessionRegisterRecord) gateway.retrieve(ResourceType.MEAL_SESSION_REGISTER_RECORD, id);
        }

        public MealSession getMealSession ()
        {
            return (MealSession) this.getProperty("mealSession");
        }

        public void setMealSession (MealSession mealSession)
        {
            this.setProperty("mealSession", mealSession);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public MealProvision getMealProvision ()
        {
            return (MealProvision) this.getProperty("mealProvision");
        }

        public void setMealProvision (MealProvision mealProvision)
        {
            this.setProperty("mealProvision", mealProvision);
        }

        public ModelBase getCustomerInvoice ()
        {
            return (ModelBase) this.getProperty("customerInvoice");
        }

        public void setCustomerInvoice (ModelBase customerInvoice)
        {
            this.setProperty("customerInvoice", customerInvoice);
        }

        public ModelBase getMealProvisionPriceCategory ()
        {
            return (ModelBase) this.getProperty("mealProvisionPriceCategory");
        }

        public void setMealProvisionPriceCategory (ModelBase mealProvisionPriceCategory)
        {
            this.setProperty("mealProvisionPriceCategory", mealProvisionPriceCategory);
        }

        public string getSource ()
        {
            return this.getProperty("source").ToString();
        }

        public void setSource (string source)
        {
            this.setProperty("source", source);
        }


    }
}

