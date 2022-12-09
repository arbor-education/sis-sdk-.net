using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryPaymentManualCriterion : ModelBase
    {
        protected new string resourceType = ResourceType.BURSARY_PAYMENT_MANUAL_CRITERION;
        public const string BURSARY_TYPE = "bursaryType";
        public const string NAME = "name";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public BursaryPaymentManualCriterion()
        {
            base.resourceType = this.resourceType;
        }

        public BursaryPaymentManualCriterion(string resourceType = "BursaryPaymentManualCriterion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BursaryPaymentManualCriterion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BursaryPaymentManualCriterion");
            RestGateway gateway = (RestGateway)BursaryPaymentManualCriterion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BursaryPaymentManualCriterion> bursarypaymentmanualcriterionCollection = new ModelCollection<BursaryPaymentManualCriterion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                bursarypaymentmanualcriterionCollection.add((BursaryPaymentManualCriterion)model);
            }

            return bursarypaymentmanualcriterionCollection;
        }

        public static BursaryPaymentManualCriterion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BursaryPaymentManualCriterion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BursaryPaymentManualCriterion)gateway.retrieve(ResourceType.BURSARY_PAYMENT_MANUAL_CRITERION, id);
        }

        public BursaryType getBursaryType()
        {
            return (BursaryType)this.getProperty("bursaryType");
        }

        public void setBursaryType(BursaryType bursaryType)
        {
            this.setProperty("bursaryType", bursaryType);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

