using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolShopProductPrice : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOL_SHOP_PRODUCT_PRICE;
        public const string SCHOOL_SHOP_PRODUCT = "schoolShopProduct";
        public const string ELIGIBLE = "eligible";
        public const string PRICE_EX_VAT = "priceExVat";
        public const string VAT_RATE = "vatRate";

        public SchoolShopProductPrice()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolShopProductPrice(string resourceType = "SchoolShopProductPrice", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolShopProductPrice> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SchoolShopProductPrice");
            RestGateway gateway = (RestGateway)SchoolShopProductPrice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolShopProductPrice> schoolshopproductpriceCollection = new ModelCollection<SchoolShopProductPrice>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schoolshopproductpriceCollection.add((SchoolShopProductPrice)model);
            }

            return schoolshopproductpriceCollection;
        }

        public static SchoolShopProductPrice retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolShopProductPrice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolShopProductPrice)gateway.retrieve(ResourceType.SCHOOL_SHOP_PRODUCT_PRICE, id);
        }

        public SchoolShopProduct getSchoolShopProduct()
        {
            return (SchoolShopProduct)this.getProperty("schoolShopProduct");
        }

        public void setSchoolShopProduct(SchoolShopProduct schoolShopProduct)
        {
            this.setProperty("schoolShopProduct", schoolShopProduct);
        }

        public ModelBase getEligible()
        {
            return (ModelBase)this.getProperty("eligible");
        }

        public void setEligible(ModelBase eligible)
        {
            this.setProperty("eligible", eligible);
        }

        public string getPriceExVat()
        {
            return this.getProperty("priceExVat").ToString();
        }

        public void setPriceExVat(string priceExVat)
        {
            this.setProperty("priceExVat", priceExVat);
        }

        public VatRate getVatRate()
        {
            return (VatRate)this.getProperty("vatRate");
        }

        public void setVatRate(VatRate vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }


    }
}

