using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class EarlyYearsPupilPremiumRecipient : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_EARLY_YEARS_PUPIL_PREMIUM_RECIPIENT;
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string RECIPIENT_FOR_ECONOMIC_REASONS = "recipientForEconomicReasons";
        public const string RECIPIENT_FOR_OTHER_REASONS = "recipientForOtherReasons";

        public EarlyYearsPupilPremiumRecipient()
        {
            base.resourceType = this.resourceType;
        }

        public EarlyYearsPupilPremiumRecipient(string resourceType = "EarlyYearsPupilPremiumRecipient", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EarlyYearsPupilPremiumRecipient> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_EarlyYearsPupilPremiumRecipient");
            RestGateway gateway = (RestGateway)EarlyYearsPupilPremiumRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EarlyYearsPupilPremiumRecipient> earlyyearspupilpremiumrecipientCollection = new ModelCollection<EarlyYearsPupilPremiumRecipient>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                earlyyearspupilpremiumrecipientCollection.add((EarlyYearsPupilPremiumRecipient)model);
            }

            return earlyyearspupilpremiumrecipientCollection;
        }

        public static EarlyYearsPupilPremiumRecipient retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EarlyYearsPupilPremiumRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EarlyYearsPupilPremiumRecipient)gateway.retrieve(ResourceType.UK_DFE_EARLY_YEARS_PUPIL_PREMIUM_RECIPIENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
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

        public bool getRecipientForEconomicReasons()
        {
            return Convert.ToBoolean(this.getProperty("recipientForEconomicReasons"));
        }

        public void setRecipientForEconomicReasons(bool recipientForEconomicReasons)
        {
            this.setProperty("recipientForEconomicReasons", recipientForEconomicReasons);
        }

        public bool getRecipientForOtherReasons()
        {
            return Convert.ToBoolean(this.getProperty("recipientForOtherReasons"));
        }

        public void setRecipientForOtherReasons(bool recipientForOtherReasons)
        {
            this.setProperty("recipientForOtherReasons", recipientForOtherReasons);
        }


    }
}

