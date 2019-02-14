using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContractPostAllowance : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT_POST_ALLOWANCE;
        public const string STAFF_CONTRACT_POST = "staffContractPost";
        public const string LINKED_ALLOWANCE = "linkedAllowance";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string GROSS_ALLOWANCE = "grossAllowance";
        public const string REASON = "reason";
        public const string ALLOWANCE_TYPE = "allowanceType";
        public const string PAY_FACTOR = "payFactor";
        public const string SUPERANNUATION = "superannuation";
        public const string NI_STATUS = "niStatus";
        public const string BENEFIT_IN_KIND = "benefitInKind";

        public StaffContractPostAllowance ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffContractPostAllowance (string resourceType = "StaffContractPostAllowance", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffContractPostAllowance> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffContractPostAllowance");
        	RestGateway gateway = (RestGateway) StaffContractPostAllowance.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffContractPostAllowance> staffcontractpostallowanceCollection = new ModelCollection<StaffContractPostAllowance> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffcontractpostallowanceCollection.add((StaffContractPostAllowance) model);
        	}
        
        	return staffcontractpostallowanceCollection;
        }

        public static StaffContractPostAllowance retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffContractPostAllowance.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffContractPostAllowance) gateway.retrieve(ResourceType.STAFF_CONTRACT_POST_ALLOWANCE, id);
        }

        public StaffContractPost getStaffContractPost ()
        {
            return (StaffContractPost) this.getProperty("staffContractPost");
        }

        public void setStaffContractPost (StaffContractPost staffContractPost)
        {
            this.setProperty("staffContractPost", staffContractPost);
        }

        public Allowance getLinkedAllowance ()
        {
            return (Allowance) this.getProperty("linkedAllowance");
        }

        public void setLinkedAllowance (Allowance linkedAllowance)
        {
            this.setProperty("linkedAllowance", linkedAllowance);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getGrossAllowance ()
        {
            return this.getProperty("grossAllowance").ToString();
        }

        public void setGrossAllowance (string grossAllowance)
        {
            this.setProperty("grossAllowance", grossAllowance);
        }

        public string getReason ()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason (string reason)
        {
            this.setProperty("reason", reason);
        }

        public string getAllowanceType ()
        {
            return this.getProperty("allowanceType").ToString();
        }

        public void setAllowanceType (string allowanceType)
        {
            this.setProperty("allowanceType", allowanceType);
        }

        public float getPayFactor ()
        {
            return (float) this.getProperty("payFactor");
        }

        public void setPayFactor (float payFactor)
        {
            this.setProperty("payFactor", payFactor);
        }

        public bool getSuperannuation ()
        {
            return Convert.ToBoolean(this.getProperty("superannuation"))
        }

        public void setSuperannuation (bool superannuation)
        {
            this.setProperty("superannuation", superannuation);
        }

        public bool getNiStatus ()
        {
            return Convert.ToBoolean(this.getProperty("niStatus"))
        }

        public void setNiStatus (bool niStatus)
        {
            this.setProperty("niStatus", niStatus);
        }

        public bool getBenefitInKind ()
        {
            return Convert.ToBoolean(this.getProperty("benefitInKind"))
        }

        public void setBenefitInKind (bool benefitInKind)
        {
            this.setProperty("benefitInKind", benefitInKind);
        }


    }
}

