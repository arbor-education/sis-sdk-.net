using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PayScaleGrade : ModelBase
    {
        protected string resourceType = ResourceType.PAY_SCALE_GRADE;
        public const string PAY_SCALE = "payScale";
        public const string GRADE_NAME = "gradeName";
        public const string DATA_ORDER = "dataOrder";

        public PayScaleGrade ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PayScaleGrade (string resourceType = "PayScaleGrade", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PayScaleGrade> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PayScaleGrade");
        	RestGateway gateway = (RestGateway) PayScaleGrade.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PayScaleGrade> payscalegradeCollection = new ModelCollection<PayScaleGrade> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    payscalegradeCollection.add((PayScaleGrade) model);
        	}
        
        	return payscalegradeCollection;
        }

        public static PayScaleGrade retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PayScaleGrade.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PayScaleGrade) gateway.retrieve(ResourceType.PAY_SCALE_GRADE, id);
        }

        public PayScale getPayScale ()
        {
            return (PayScale) this.getProperty("payScale");
        }

        public void setPayScale (PayScale payScale)
        {
            this.setProperty("payScale", payScale);
        }

        public string getGradeName ()
        {
            return this.getProperty("gradeName").ToString();
        }

        public void setGradeName (string gradeName)
        {
            this.setProperty("gradeName", gradeName);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }


    }
}

