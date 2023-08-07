using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryPaymentDate : ModelBase
    {
        protected new string resourceType = ResourceType.BURSARY_PAYMENT_DATE;
        public const string NAME = "name";
        public const string BURSARY_TYPE = "bursaryType";
        public const string PAYMENT_DATE = "paymentDate";

        public BursaryPaymentDate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BursaryPaymentDate (string resourceType = "BursaryPaymentDate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BursaryPaymentDate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BursaryPaymentDate");
        	RestGateway gateway = (RestGateway) BursaryPaymentDate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BursaryPaymentDate> bursarypaymentdateCollection = new ModelCollection<BursaryPaymentDate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bursarypaymentdateCollection.add((BursaryPaymentDate) model);
        	}
        
        	return bursarypaymentdateCollection;
        }

        public static BursaryPaymentDate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BursaryPaymentDate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BursaryPaymentDate) gateway.retrieve(ResourceType.BURSARY_PAYMENT_DATE, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public BursaryType getBursaryType ()
        {
            return (BursaryType) this.getProperty("bursaryType");
        }

        public void setBursaryType (BursaryType bursaryType)
        {
            this.setProperty("bursaryType", bursaryType);
        }

        public DateTime getPaymentDate ()
        {
            return Convert.ToDateTime(this.getProperty("paymentDate"));
        }

        public void setPaymentDate (DateTime paymentDate)
        {
            this.setProperty("paymentDate", paymentDate);
        }


    }
}

