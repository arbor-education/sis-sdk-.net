using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_EarlyYearsPupilPremiumEligibility : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_EARLY_YEARS_PUPIL_PREMIUM_ELIGIBILITY;
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string ELIGIBLE_FOR_ECONOMIC_REASONS = "eligibleForEconomicReasons";
        public const string ELIGIBLE_FOR_OTHER_REASONS = "eligibleForOtherReasons";

        public UkDfe_EarlyYearsPupilPremiumEligibility ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_EarlyYearsPupilPremiumEligibility (string resourceType = "UkDfe_EarlyYearsPupilPremiumEligibility", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_EarlyYearsPupilPremiumEligibility> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_EarlyYearsPupilPremiumEligibility");
        	RestGateway gateway = (RestGateway) UkDfe_EarlyYearsPupilPremiumEligibility.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_EarlyYearsPupilPremiumEligibility> ukdfe_earlyyearspupilpremiumeligibilityCollection = new ModelCollection<UkDfe_EarlyYearsPupilPremiumEligibility> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_earlyyearspupilpremiumeligibilityCollection.add((UkDfe_EarlyYearsPupilPremiumEligibility) model);
        	}
        
        	return ukdfe_earlyyearspupilpremiumeligibilityCollection;
        }

        public static UkDfe_EarlyYearsPupilPremiumEligibility retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_EarlyYearsPupilPremiumEligibility.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_EarlyYearsPupilPremiumEligibility) gateway.retrieve(ResourceType.UK_DFE_EARLY_YEARS_PUPIL_PREMIUM_ELIGIBILITY, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public bool getEligibleForEconomicReasons ()
        {
            return Convert.ToBoolean(this.getProperty("eligibleForEconomicReasons"))
        }

        public void setEligibleForEconomicReasons (bool eligibleForEconomicReasons)
        {
            this.setProperty("eligibleForEconomicReasons", eligibleForEconomicReasons);
        }

        public bool getEligibleForOtherReasons ()
        {
            return Convert.ToBoolean(this.getProperty("eligibleForOtherReasons"))
        }

        public void setEligibleForOtherReasons (bool eligibleForOtherReasons)
        {
            this.setProperty("eligibleForOtherReasons", eligibleForOtherReasons);
        }


    }
}

