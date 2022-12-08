using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SuperannuationSchemeValue : ModelBase
    {
        protected string resourceType = ResourceType.SUPERANNUATION_SCHEME_VALUE;
        public const string SUPERANNUATION_SCHEME = "superannuationScheme";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string VALUE = "value";

        public SuperannuationSchemeValue()
        {
            base.resourceType = this.resourceType;
        }

        public SuperannuationSchemeValue(string resourceType = "SuperannuationSchemeValue", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SuperannuationSchemeValue> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SuperannuationSchemeValue");
            RestGateway gateway = (RestGateway)SuperannuationSchemeValue.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SuperannuationSchemeValue> superannuationschemevalueCollection = new ModelCollection<SuperannuationSchemeValue>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                superannuationschemevalueCollection.add((SuperannuationSchemeValue)model);
            }

            return superannuationschemevalueCollection;
        }

        public static SuperannuationSchemeValue retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SuperannuationSchemeValue.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SuperannuationSchemeValue)gateway.retrieve(ResourceType.SUPERANNUATION_SCHEME_VALUE, id);
        }

        public SuperannuationScheme getSuperannuationScheme()
        {
            return (SuperannuationScheme)this.getProperty("superannuationScheme");
        }

        public void setSuperannuationScheme(SuperannuationScheme superannuationScheme)
        {
            this.setProperty("superannuationScheme", superannuationScheme);
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

        public float getValue()
        {
            return (float)this.getProperty("value");
        }

        public void setValue(float value)
        {
            this.setProperty("value", value);
        }


    }
}

