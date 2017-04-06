using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SchoolProduct : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SCHOOL_PRODUCT;
        public const string PRODUCT_NAME = "productName";
        public const string PRODUCT_NUMBER = "productNumber";
        public const string PRODUCT_UNIT_COST = "productUnitCost";
        public const string ITEM_UNIT = "itemUnit";
        public const string PRODUCT_UNIT_QUANTITY = "productUnitQuantity";

        public SchoolProduct ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolProduct (string resourceType = "SchoolProduct", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolProduct> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SchoolProduct");
        	RestGateway gateway = (RestGateway) SchoolProduct.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolProduct> schoolproductCollection = new ModelCollection<SchoolProduct> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolproductCollection.add((SchoolProduct) model);
        	}
        
        	return schoolproductCollection;
        }

        public static SchoolProduct retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolProduct.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolProduct) gateway.retrieve(ResourceType.FINANCE_SCHOOL_PRODUCT, id);
        }

        public string getProductName ()
        {
            return this.getProperty("productName").ToString();
        }

        public void setProductName (string productName)
        {
            this.setProperty("productName", productName);
        }

        public string getProductNumber ()
        {
            return this.getProperty("productNumber").ToString();
        }

        public void setProductNumber (string productNumber)
        {
            this.setProperty("productNumber", productNumber);
        }

        public string getProductUnitCost ()
        {
            return this.getProperty("productUnitCost").ToString();
        }

        public void setProductUnitCost (string productUnitCost)
        {
            this.setProperty("productUnitCost", productUnitCost);
        }

        public ItemUnit getItemUnit ()
        {
            return (ItemUnit) this.getProperty("itemUnit");
        }

        public void setItemUnit (ItemUnit itemUnit)
        {
            this.setProperty("itemUnit", itemUnit);
        }

        public float getProductUnitQuantity ()
        {
            return (float) this.getProperty("productUnitQuantity");
        }

        public void setProductUnitQuantity (float productUnitQuantity)
        {
            this.setProperty("productUnitQuantity", productUnitQuantity);
        }


    }
}

