using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContract : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT;
        public const string STAFF = "staff";
        public const string STAFF_EMPLOYMENT_TYPE = "staffEmploymentType";
        public const string CONTRACT_NAME = "contractName";
        public const string CONTRACT_REFERENCE = "contractReference";
        public const string ISSUED_DATE = "issuedDate";
        public const string START_DATE = "startDate";
        public const string EXPECTED_END_DATE = "expectedEndDate";
        public const string END_DATE = "endDate";
        public const string PAYROLL_NUMBER = "payrollNumber";
        public const string STAFF_ORIGIN = "staffOrigin";
        public const string STAFF_DESTINATION = "staffDestination";
        public const string STAFF_LEAVING_REASON = "staffLeavingReason";
        public const string SUPERANNUATION_SCHEME = "superannuationScheme";
        public const string LAST_PAY_REVIEW_DATE = "lastPayReviewDate";

        public StaffContract ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffContract (string resourceType = "StaffContract", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffContract> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffContract");
        	RestGateway gateway = (RestGateway) StaffContract.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffContract> staffcontractCollection = new ModelCollection<StaffContract> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffcontractCollection.add((StaffContract) model);
        	}
        
        	return staffcontractCollection;
        }

        public static StaffContract retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffContract.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffContract) gateway.retrieve(ResourceType.STAFF_CONTRACT, id);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public StaffEmploymentType getStaffEmploymentType ()
        {
            return (StaffEmploymentType) this.getProperty("staffEmploymentType");
        }

        public void setStaffEmploymentType (StaffEmploymentType staffEmploymentType)
        {
            this.setProperty("staffEmploymentType", staffEmploymentType);
        }

        public string getContractName ()
        {
            return this.getProperty("contractName").ToString();
        }

        public void setContractName (string contractName)
        {
            this.setProperty("contractName", contractName);
        }

        public string getContractReference ()
        {
            return this.getProperty("contractReference").ToString();
        }

        public void setContractReference (string contractReference)
        {
            this.setProperty("contractReference", contractReference);
        }

        public DateTime getIssuedDate ()
        {
            return Convert.ToDateTime(this.getProperty("issuedDate"));
        }

        public void setIssuedDate (DateTime issuedDate)
        {
            this.setProperty("issuedDate", issuedDate);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getExpectedEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("expectedEndDate"));
        }

        public void setExpectedEndDate (DateTime expectedEndDate)
        {
            this.setProperty("expectedEndDate", expectedEndDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getPayrollNumber ()
        {
            return this.getProperty("payrollNumber").ToString();
        }

        public void setPayrollNumber (string payrollNumber)
        {
            this.setProperty("payrollNumber", payrollNumber);
        }

        public StaffOrigin getStaffOrigin ()
        {
            return (StaffOrigin) this.getProperty("staffOrigin");
        }

        public void setStaffOrigin (StaffOrigin staffOrigin)
        {
            this.setProperty("staffOrigin", staffOrigin);
        }

        public StaffDestination getStaffDestination ()
        {
            return (StaffDestination) this.getProperty("staffDestination");
        }

        public void setStaffDestination (StaffDestination staffDestination)
        {
            this.setProperty("staffDestination", staffDestination);
        }

        public StaffLeavingReason getStaffLeavingReason ()
        {
            return (StaffLeavingReason) this.getProperty("staffLeavingReason");
        }

        public void setStaffLeavingReason (StaffLeavingReason staffLeavingReason)
        {
            this.setProperty("staffLeavingReason", staffLeavingReason);
        }

        public SuperannuationScheme getSuperannuationScheme ()
        {
            return (SuperannuationScheme) this.getProperty("superannuationScheme");
        }

        public void setSuperannuationScheme (SuperannuationScheme superannuationScheme)
        {
            this.setProperty("superannuationScheme", superannuationScheme);
        }

        public DateTime getLastPayReviewDate ()
        {
            return Convert.ToDateTime(this.getProperty("lastPayReviewDate"));
        }

        public void setLastPayReviewDate (DateTime lastPayReviewDate)
        {
            this.setProperty("lastPayReviewDate", lastPayReviewDate);
        }


    }
}

