using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AdHocBursaryPayment : ModelBase
    {
        protected new string resourceType = ResourceType.AD_HOC_BURSARY_PAYMENT;
        public const string STUDENT = "student";
        public const string BURSARY_TYPE = "bursaryType";
        public const string AMOUNT = "amount";
        public const string PAID_DATE = "paidDate";
        public const string APPROVED_DATE = "approvedDate";
        public const string APPROVED_BY_STAFF = "approvedByStaff";

        public AdHocBursaryPayment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AdHocBursaryPayment (string resourceType = "AdHocBursaryPayment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AdHocBursaryPayment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AdHocBursaryPayment");
        	RestGateway gateway = (RestGateway) AdHocBursaryPayment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AdHocBursaryPayment> adhocbursarypaymentCollection = new ModelCollection<AdHocBursaryPayment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    adhocbursarypaymentCollection.add((AdHocBursaryPayment) model);
        	}
        
        	return adhocbursarypaymentCollection;
        }

        public static AdHocBursaryPayment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AdHocBursaryPayment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AdHocBursaryPayment) gateway.retrieve(ResourceType.AD_HOC_BURSARY_PAYMENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public BursaryType getBursaryType ()
        {
            return (BursaryType) this.getProperty("bursaryType");
        }

        public void setBursaryType (BursaryType bursaryType)
        {
            this.setProperty("bursaryType", bursaryType);
        }

        public string getAmount ()
        {
            return this.getProperty("amount").ToString();
        }

        public void setAmount (string amount)
        {
            this.setProperty("amount", amount);
        }

        public DateTime getPaidDate ()
        {
            return Convert.ToDateTime(this.getProperty("paidDate"));
        }

        public void setPaidDate (DateTime paidDate)
        {
            this.setProperty("paidDate", paidDate);
        }

        public DateTime getApprovedDate ()
        {
            return Convert.ToDateTime(this.getProperty("approvedDate"));
        }

        public void setApprovedDate (DateTime approvedDate)
        {
            this.setProperty("approvedDate", approvedDate);
        }

        public Staff getApprovedByStaff ()
        {
            return (Staff) this.getProperty("approvedByStaff");
        }

        public void setApprovedByStaff (Staff approvedByStaff)
        {
            this.setProperty("approvedByStaff", approvedByStaff);
        }


    }
}

