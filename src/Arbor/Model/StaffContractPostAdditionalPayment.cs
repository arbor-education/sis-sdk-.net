using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContractPostAdditionalPayment : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT_POST_ADDITIONAL_PAYMENT;
        public const string STAFF_CONTRACT_POST = "staffContractPost";
        public const string ADDITIONAL_PAYMENT = "additionalPayment";
        public const string PAYMENT_DATE = "paymentDate";
        public const string ADDITIONAL_PAYMENT_REASON = "additionalPaymentReason";

        public StaffContractPostAdditionalPayment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffContractPostAdditionalPayment (string resourceType = "StaffContractPostAdditionalPayment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffContractPostAdditionalPayment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffContractPostAdditionalPayment");
        	RestGateway gateway = (RestGateway) StaffContractPostAdditionalPayment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffContractPostAdditionalPayment> staffcontractpostadditionalpaymentCollection = new ModelCollection<StaffContractPostAdditionalPayment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffcontractpostadditionalpaymentCollection.add((StaffContractPostAdditionalPayment) model);
        	}
        
        	return staffcontractpostadditionalpaymentCollection;
        }

        public static StaffContractPostAdditionalPayment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffContractPostAdditionalPayment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffContractPostAdditionalPayment) gateway.retrieve(ResourceType.STAFF_CONTRACT_POST_ADDITIONAL_PAYMENT, id);
        }

        public StaffContractPost getStaffContractPost ()
        {
            return (StaffContractPost) this.getProperty("staffContractPost");
        }

        public void setStaffContractPost (StaffContractPost staffContractPost)
        {
            this.setProperty("staffContractPost", staffContractPost);
        }

        public string getAdditionalPayment ()
        {
            return this.getProperty("additionalPayment").ToString();
        }

        public void setAdditionalPayment (string additionalPayment)
        {
            this.setProperty("additionalPayment", additionalPayment);
        }

        public DateTime getPaymentDate ()
        {
            return (DateTime) this.getProperty("paymentDate");
        }

        public void setPaymentDate (DateTime paymentDate)
        {
            this.setProperty("paymentDate", paymentDate);
        }

        public AdditionalPaymentReason getAdditionalPaymentReason ()
        {
            return (AdditionalPaymentReason) this.getProperty("additionalPaymentReason");
        }

        public void setAdditionalPaymentReason (AdditionalPaymentReason additionalPaymentReason)
        {
            this.setProperty("additionalPaymentReason", additionalPaymentReason);
        }


    }
}

