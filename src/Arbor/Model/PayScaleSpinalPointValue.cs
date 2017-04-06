using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PayScaleSpinalPointValue : ModelBase
    {
        protected string resourceType = ResourceType.PAY_SCALE_SPINAL_POINT_VALUE;
        public const string PAY_SCALE_SPINAL_POINT = "payScaleSpinalPoint";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string GROSS_SALARY = "grossSalary";

        public PayScaleSpinalPointValue ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PayScaleSpinalPointValue (string resourceType = "PayScaleSpinalPointValue", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PayScaleSpinalPointValue> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PayScaleSpinalPointValue");
        	RestGateway gateway = (RestGateway) PayScaleSpinalPointValue.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PayScaleSpinalPointValue> payscalespinalpointvalueCollection = new ModelCollection<PayScaleSpinalPointValue> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    payscalespinalpointvalueCollection.add((PayScaleSpinalPointValue) model);
        	}
        
        	return payscalespinalpointvalueCollection;
        }

        public static PayScaleSpinalPointValue retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PayScaleSpinalPointValue.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PayScaleSpinalPointValue) gateway.retrieve(ResourceType.PAY_SCALE_SPINAL_POINT_VALUE, id);
        }

        public PayScaleSpinalPoint getPayScaleSpinalPoint ()
        {
            return (PayScaleSpinalPoint) this.getProperty("payScaleSpinalPoint");
        }

        public void setPayScaleSpinalPoint (PayScaleSpinalPoint payScaleSpinalPoint)
        {
            this.setProperty("payScaleSpinalPoint", payScaleSpinalPoint);
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

        public string getGrossSalary ()
        {
            return this.getProperty("grossSalary").ToString();
        }

        public void setGrossSalary (string grossSalary)
        {
            this.setProperty("grossSalary", grossSalary);
        }


    }
}

