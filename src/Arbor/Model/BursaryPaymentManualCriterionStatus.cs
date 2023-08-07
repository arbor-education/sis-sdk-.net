using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryPaymentManualCriterionStatus : ModelBase
    {
        protected new string resourceType = ResourceType.BURSARY_PAYMENT_MANUAL_CRITERION_STATUS;
        public const string BURSARY_PAYMENT = "bursaryPayment";
        public const string BURSARY_PAYMENT_MANUAL_CRITERION = "bursaryPaymentManualCriterion";
        public const string IS_MET = "isMet";

        public BursaryPaymentManualCriterionStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BursaryPaymentManualCriterionStatus (string resourceType = "BursaryPaymentManualCriterionStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BursaryPaymentManualCriterionStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BursaryPaymentManualCriterionStatus");
        	RestGateway gateway = (RestGateway) BursaryPaymentManualCriterionStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BursaryPaymentManualCriterionStatus> bursarypaymentmanualcriterionstatusCollection = new ModelCollection<BursaryPaymentManualCriterionStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bursarypaymentmanualcriterionstatusCollection.add((BursaryPaymentManualCriterionStatus) model);
        	}
        
        	return bursarypaymentmanualcriterionstatusCollection;
        }

        public static BursaryPaymentManualCriterionStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BursaryPaymentManualCriterionStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BursaryPaymentManualCriterionStatus) gateway.retrieve(ResourceType.BURSARY_PAYMENT_MANUAL_CRITERION_STATUS, id);
        }

        public BursaryPayment getBursaryPayment ()
        {
            return (BursaryPayment) this.getProperty("bursaryPayment");
        }

        public void setBursaryPayment (BursaryPayment bursaryPayment)
        {
            this.setProperty("bursaryPayment", bursaryPayment);
        }

        public BursaryPaymentManualCriterion getBursaryPaymentManualCriterion ()
        {
            return (BursaryPaymentManualCriterion) this.getProperty("bursaryPaymentManualCriterion");
        }

        public void setBursaryPaymentManualCriterion (BursaryPaymentManualCriterion bursaryPaymentManualCriterion)
        {
            this.setProperty("bursaryPaymentManualCriterion", bursaryPaymentManualCriterion);
        }

        public bool getIsMet ()
        {
            return Convert.ToBoolean(this.getProperty("isMet"));
        }

        public void setIsMet (bool isMet)
        {
            this.setProperty("isMet", isMet);
        }


    }
}

