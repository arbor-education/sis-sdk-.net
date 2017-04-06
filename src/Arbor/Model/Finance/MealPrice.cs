using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class MealPrice : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_MEAL_PRICE;
        public const string MEAL_PROVISION_PRICE_CATEGORY = "mealProvisionPriceCategory";
        public const string AMOUNT = "amount";
        public const string VAT_AMOUNT = "vatAmount";
        public const string VAT_RATE = "vatRate";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public MealPrice ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MealPrice (string resourceType = "MealPrice", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MealPrice> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_MealPrice");
        	RestGateway gateway = (RestGateway) MealPrice.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MealPrice> mealpriceCollection = new ModelCollection<MealPrice> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    mealpriceCollection.add((MealPrice) model);
        	}
        
        	return mealpriceCollection;
        }

        public static MealPrice retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MealPrice.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MealPrice) gateway.retrieve(ResourceType.FINANCE_MEAL_PRICE, id);
        }

        public ModelBase getMealProvisionPriceCategory ()
        {
            return (ModelBase) this.getProperty("mealProvisionPriceCategory");
        }

        public void setMealProvisionPriceCategory (ModelBase mealProvisionPriceCategory)
        {
            this.setProperty("mealProvisionPriceCategory", mealProvisionPriceCategory);
        }

        public string getAmount ()
        {
            return this.getProperty("amount").ToString();
        }

        public void setAmount (string amount)
        {
            this.setProperty("amount", amount);
        }

        public string getVatAmount ()
        {
            return this.getProperty("vatAmount").ToString();
        }

        public void setVatAmount (string vatAmount)
        {
            this.setProperty("vatAmount", vatAmount);
        }

        public ModelBase getVatRate ()
        {
            return (ModelBase) this.getProperty("vatRate");
        }

        public void setVatRate (ModelBase vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }

        public DateTime getEffectiveDate ()
        {
            return (DateTime) this.getProperty("effectiveDate");
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

