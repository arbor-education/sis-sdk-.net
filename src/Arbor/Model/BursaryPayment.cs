using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryPayment : ModelBase
    {
        protected string resourceType = ResourceType.BURSARY_PAYMENT;
        public const string STUDENT = "student";
        public const string BURSARY_LEVEL_AMOUNT = "bursaryLevelAmount";
        public const string BURSARY_PAYMENT_DATE = "bursaryPaymentDate";
        public const string APPROVED_DATE = "approvedDate";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string REJECTED_DATE = "rejectedDate";
        public const string REJECTED_BY_STAFF = "rejectedByStaff";
        public const string PAID_DATE = "paidDate";

        public BursaryPayment()
        {
            base.resourceType = this.resourceType;
        }

        public BursaryPayment(string resourceType = "BursaryPayment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BursaryPayment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BursaryPayment");
            RestGateway gateway = (RestGateway)BursaryPayment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BursaryPayment> bursarypaymentCollection = new ModelCollection<BursaryPayment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                bursarypaymentCollection.add((BursaryPayment)model);
            }

            return bursarypaymentCollection;
        }

        public static BursaryPayment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BursaryPayment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BursaryPayment)gateway.retrieve(ResourceType.BURSARY_PAYMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public BursaryLevelAmount getBursaryLevelAmount()
        {
            return (BursaryLevelAmount)this.getProperty("bursaryLevelAmount");
        }

        public void setBursaryLevelAmount(BursaryLevelAmount bursaryLevelAmount)
        {
            this.setProperty("bursaryLevelAmount", bursaryLevelAmount);
        }

        public BursaryPaymentDate getBursaryPaymentDate()
        {
            return (BursaryPaymentDate)this.getProperty("bursaryPaymentDate");
        }

        public void setBursaryPaymentDate(BursaryPaymentDate bursaryPaymentDate)
        {
            this.setProperty("bursaryPaymentDate", bursaryPaymentDate);
        }

        public DateTime getApprovedDate()
        {
            return Convert.ToDateTime(this.getProperty("approvedDate"));
        }

        public void setApprovedDate(DateTime approvedDate)
        {
            this.setProperty("approvedDate", approvedDate);
        }

        public Staff getApprovedByStaff()
        {
            return (Staff)this.getProperty("approvedByStaff");
        }

        public void setApprovedByStaff(Staff approvedByStaff)
        {
            this.setProperty("approvedByStaff", approvedByStaff);
        }

        public DateTime getRejectedDate()
        {
            return Convert.ToDateTime(this.getProperty("rejectedDate"));
        }

        public void setRejectedDate(DateTime rejectedDate)
        {
            this.setProperty("rejectedDate", rejectedDate);
        }

        public Staff getRejectedByStaff()
        {
            return (Staff)this.getProperty("rejectedByStaff");
        }

        public void setRejectedByStaff(Staff rejectedByStaff)
        {
            this.setProperty("rejectedByStaff", rejectedByStaff);
        }

        public DateTime getPaidDate()
        {
            return Convert.ToDateTime(this.getProperty("paidDate"));
        }

        public void setPaidDate(DateTime paidDate)
        {
            this.setProperty("paidDate", paidDate);
        }


    }
}

