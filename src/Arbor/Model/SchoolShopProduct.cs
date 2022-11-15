using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolShopProduct : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOL_SHOP_PRODUCT;
        public const string NAME = "name";
        public const string DESCRIPTION = "description";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string QUANTITY = "quantity";
        public const string MAX_ITEMS_PER_STUDENT = "maxItemsPerStudent";
        public const string IS_PUBLISHED = "isPublished";
        public const string CUSTOMER_ACCOUNT_TYPE = "customerAccountType";
        public const string ACCOUNTING_CODE = "accountingCode";

        public SchoolShopProduct()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolShopProduct(string resourceType = "SchoolShopProduct", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolShopProduct> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SchoolShopProduct");
            RestGateway gateway = (RestGateway)SchoolShopProduct.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolShopProduct> schoolshopproductCollection = new ModelCollection<SchoolShopProduct>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schoolshopproductCollection.add((SchoolShopProduct)model);
            }

            return schoolshopproductCollection;
        }

        public static SchoolShopProduct retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolShopProduct.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolShopProduct)gateway.retrieve(ResourceType.SCHOOL_SHOP_PRODUCT, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
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

        public int getQuantity()
        {
            return Convert.ToInt32(this.getProperty("quantity"));
        }

        public void setQuantity(int quantity)
        {
            this.setProperty("quantity", quantity);
        }

        public int getMaxItemsPerStudent()
        {
            return Convert.ToInt32(this.getProperty("maxItemsPerStudent"));
        }

        public void setMaxItemsPerStudent(int maxItemsPerStudent)
        {
            this.setProperty("maxItemsPerStudent", maxItemsPerStudent);
        }

        public bool getIsPublished()
        {
            return Convert.ToBoolean(this.getProperty("isPublished"));
        }

        public void setIsPublished(bool isPublished)
        {
            this.setProperty("isPublished", isPublished);
        }

        public CustomerAccountType getCustomerAccountType()
        {
            return (CustomerAccountType)this.getProperty("customerAccountType");
        }

        public void setCustomerAccountType(CustomerAccountType customerAccountType)
        {
            this.setProperty("customerAccountType", customerAccountType);
        }

        public string getAccountingCode()
        {
            return this.getProperty("accountingCode").ToString();
        }

        public void setAccountingCode(string accountingCode)
        {
            this.setProperty("accountingCode", accountingCode);
        }


    }
}

