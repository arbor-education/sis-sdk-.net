using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PayScale : ModelBase
    {
        protected new string resourceType = ResourceType.PAY_SCALE;
        public const string REGIONAL_PAY_SPINE = "regionalPaySpine";
        public const string PAY_SCALE_CATEGORY = "payScaleCategory";
        public const string PAY_SCALE_CODE = "payScaleCode";
        public const string PAY_SCALE_NAME = "payScaleName";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string MINIMUM_SALARY = "minimumSalary";
        public const string MAXIMUM_SALARY = "maximumSalary";

        public PayScale()
        {
            base.resourceType = this.resourceType;
        }

        public PayScale(string resourceType = "PayScale", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PayScale> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PayScale");
            RestGateway gateway = (RestGateway)PayScale.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PayScale> payscaleCollection = new ModelCollection<PayScale>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                payscaleCollection.add((PayScale)model);
            }

            return payscaleCollection;
        }

        public static PayScale retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PayScale.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PayScale)gateway.retrieve(ResourceType.PAY_SCALE, id);
        }

        public string getRegionalPaySpine()
        {
            return this.getProperty("regionalPaySpine").ToString();
        }

        public void setRegionalPaySpine(string regionalPaySpine)
        {
            this.setProperty("regionalPaySpine", regionalPaySpine);
        }

        public PayScaleCategory getPayScaleCategory()
        {
            return (PayScaleCategory)this.getProperty("payScaleCategory");
        }

        public void setPayScaleCategory(PayScaleCategory payScaleCategory)
        {
            this.setProperty("payScaleCategory", payScaleCategory);
        }

        public string getPayScaleCode()
        {
            return this.getProperty("payScaleCode").ToString();
        }

        public void setPayScaleCode(string payScaleCode)
        {
            this.setProperty("payScaleCode", payScaleCode);
        }

        public string getPayScaleName()
        {
            return this.getProperty("payScaleName").ToString();
        }

        public void setPayScaleName(string payScaleName)
        {
            this.setProperty("payScaleName", payScaleName);
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

        public string getMinimumSalary()
        {
            return this.getProperty("minimumSalary").ToString();
        }

        public void setMinimumSalary(string minimumSalary)
        {
            this.setProperty("minimumSalary", minimumSalary);
        }

        public string getMaximumSalary()
        {
            return this.getProperty("maximumSalary").ToString();
        }

        public void setMaximumSalary(string maximumSalary)
        {
            this.setProperty("maximumSalary", maximumSalary);
        }


    }
}

