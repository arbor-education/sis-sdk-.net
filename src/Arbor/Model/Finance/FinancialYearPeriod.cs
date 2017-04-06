using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class FinancialYearPeriod : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_FINANCIAL_YEAR_PERIOD;
        public const string FINANCIAL_YEAR = "financialYear";
        public const string PERIOD_NUMBER = "periodNumber";
        public const string PERIOD_START_DATE = "periodStartDate";
        public const string PERIOD_END_DATE = "periodEndDate";
        public const string PERIOD_NAME = "periodName";

        public FinancialYearPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public FinancialYearPeriod (string resourceType = "FinancialYearPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<FinancialYearPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_FinancialYearPeriod");
        	RestGateway gateway = (RestGateway) FinancialYearPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<FinancialYearPeriod> financialyearperiodCollection = new ModelCollection<FinancialYearPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    financialyearperiodCollection.add((FinancialYearPeriod) model);
        	}
        
        	return financialyearperiodCollection;
        }

        public static FinancialYearPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) FinancialYearPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (FinancialYearPeriod) gateway.retrieve(ResourceType.FINANCE_FINANCIAL_YEAR_PERIOD, id);
        }

        public ModelBase getFinancialYear ()
        {
            return (ModelBase) this.getProperty("financialYear");
        }

        public void setFinancialYear (ModelBase financialYear)
        {
            this.setProperty("financialYear", financialYear);
        }

        public int getPeriodNumber ()
        {
            return Convert.ToInt32(this.getProperty("periodNumber"));
        }

        public void setPeriodNumber (int periodNumber)
        {
            this.setProperty("periodNumber", periodNumber);
        }

        public DateTime getPeriodStartDate ()
        {
            return (DateTime) this.getProperty("periodStartDate");
        }

        public void setPeriodStartDate (DateTime periodStartDate)
        {
            this.setProperty("periodStartDate", periodStartDate);
        }

        public DateTime getPeriodEndDate ()
        {
            return (DateTime) this.getProperty("periodEndDate");
        }

        public void setPeriodEndDate (DateTime periodEndDate)
        {
            this.setProperty("periodEndDate", periodEndDate);
        }

        public string getPeriodName ()
        {
            return this.getProperty("periodName").ToString();
        }

        public void setPeriodName (string periodName)
        {
            this.setProperty("periodName", periodName);
        }


    }
}

