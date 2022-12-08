using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PayScaleSpinalPoint : ModelBase
    {
        protected string resourceType = ResourceType.PAY_SCALE_SPINAL_POINT;
        public const string PAY_SCALE = "payScale";
        public const string SPINAL_POINT_CODE = "spinalPointCode";
        public const string SPINAL_POINT_NAME = "spinalPointName";
        public const string DATA_ORDER = "dataOrder";

        public PayScaleSpinalPoint()
        {
            base.resourceType = this.resourceType;
        }

        public PayScaleSpinalPoint(string resourceType = "PayScaleSpinalPoint", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PayScaleSpinalPoint> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PayScaleSpinalPoint");
            RestGateway gateway = (RestGateway)PayScaleSpinalPoint.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PayScaleSpinalPoint> payscalespinalpointCollection = new ModelCollection<PayScaleSpinalPoint>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                payscalespinalpointCollection.add((PayScaleSpinalPoint)model);
            }

            return payscalespinalpointCollection;
        }

        public static PayScaleSpinalPoint retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PayScaleSpinalPoint.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PayScaleSpinalPoint)gateway.retrieve(ResourceType.PAY_SCALE_SPINAL_POINT, id);
        }

        public PayScale getPayScale()
        {
            return (PayScale)this.getProperty("payScale");
        }

        public void setPayScale(PayScale payScale)
        {
            this.setProperty("payScale", payScale);
        }

        public string getSpinalPointCode()
        {
            return this.getProperty("spinalPointCode").ToString();
        }

        public void setSpinalPointCode(string spinalPointCode)
        {
            this.setProperty("spinalPointCode", spinalPointCode);
        }

        public string getSpinalPointName()
        {
            return this.getProperty("spinalPointName").ToString();
        }

        public void setSpinalPointName(string spinalPointName)
        {
            this.setProperty("spinalPointName", spinalPointName);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }


    }
}

