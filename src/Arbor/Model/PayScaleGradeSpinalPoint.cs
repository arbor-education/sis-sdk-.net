using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PayScaleGradeSpinalPoint : ModelBase
    {
        protected string resourceType = ResourceType.PAY_SCALE_GRADE_SPINAL_POINT;
        public const string PAY_SCALE_GRADE = "payScaleGrade";
        public const string PAY_SCALE_SPINAL_POINT = "payScaleSpinalPoint";

        public PayScaleGradeSpinalPoint()
        {
            base.resourceType = this.resourceType;
        }

        public PayScaleGradeSpinalPoint(string resourceType = "PayScaleGradeSpinalPoint", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PayScaleGradeSpinalPoint> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PayScaleGradeSpinalPoint");
            RestGateway gateway = (RestGateway)PayScaleGradeSpinalPoint.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PayScaleGradeSpinalPoint> payscalegradespinalpointCollection = new ModelCollection<PayScaleGradeSpinalPoint>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                payscalegradespinalpointCollection.add((PayScaleGradeSpinalPoint)model);
            }

            return payscalegradespinalpointCollection;
        }

        public static PayScaleGradeSpinalPoint retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PayScaleGradeSpinalPoint.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PayScaleGradeSpinalPoint)gateway.retrieve(ResourceType.PAY_SCALE_GRADE_SPINAL_POINT, id);
        }

        public PayScaleGrade getPayScaleGrade()
        {
            return (PayScaleGrade)this.getProperty("payScaleGrade");
        }

        public void setPayScaleGrade(PayScaleGrade payScaleGrade)
        {
            this.setProperty("payScaleGrade", payScaleGrade);
        }

        public PayScaleSpinalPoint getPayScaleSpinalPoint()
        {
            return (PayScaleSpinalPoint)this.getProperty("payScaleSpinalPoint");
        }

        public void setPayScaleSpinalPoint(PayScaleSpinalPoint payScaleSpinalPoint)
        {
            this.setProperty("payScaleSpinalPoint", payScaleSpinalPoint);
        }


    }
}

