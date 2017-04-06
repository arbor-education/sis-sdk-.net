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
        public const string ALLOWANCE = "allowance";
        public const string REASON = "reason";

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

        public string getAllowance ()
        {
            return this.getProperty("allowance").ToString();
        }

        public void setAllowance (string allowance)
        {
            this.setProperty("allowance", allowance);
        }

        public string getReason ()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason (string reason)
        {
            this.setProperty("reason", reason);
        }


    }
}

