using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class PayScale : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_PAY_SCALE;
        public const string REGIONAL_PAY_SPINE = "regionalPaySpine";
        public const string PAY_SCALE_CATEGORY = "payScaleCategory";

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
            query.setResourceType("UkDfe_PayScale");
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
            return (PayScale)gateway.retrieve(ResourceType.UK_DFE_PAY_SCALE, id);
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


    }
}

