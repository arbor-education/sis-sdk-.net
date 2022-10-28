using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolShopProductEligibility : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOL_SHOP_PRODUCT_ELIGIBILITY;
        public const string SCHOOL_SHOP_PRODUCT = "schoolShopProduct";
        public const string ELIGIBLE = "eligible";

        public SchoolShopProductEligibility ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolShopProductEligibility (string resourceType = "SchoolShopProductEligibility", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolShopProductEligibility> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolShopProductEligibility");
        	RestGateway gateway = (RestGateway) SchoolShopProductEligibility.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolShopProductEligibility> schoolshopproducteligibilityCollection = new ModelCollection<SchoolShopProductEligibility> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolshopproducteligibilityCollection.add((SchoolShopProductEligibility) model);
        	}
        
        	return schoolshopproducteligibilityCollection;
        }

        public static SchoolShopProductEligibility retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolShopProductEligibility.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolShopProductEligibility) gateway.retrieve(ResourceType.SCHOOL_SHOP_PRODUCT_ELIGIBILITY, id);
        }

        public SchoolShopProduct getSchoolShopProduct ()
        {
            return (SchoolShopProduct) this.getProperty("schoolShopProduct");
        }

        public void setSchoolShopProduct (SchoolShopProduct schoolShopProduct)
        {
            this.setProperty("schoolShopProduct", schoolShopProduct);
        }

        public ModelBase getEligible ()
        {
            return (ModelBase) this.getProperty("eligible");
        }

        public void setEligible (ModelBase eligible)
        {
            this.setProperty("eligible", eligible);
        }


    }
}

