using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class FinancialYear : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_FINANCIAL_YEAR;
        public const string FINANCIAL_YEAR_NAME = "financialYearName";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public FinancialYear ()
        {
            base.resourceType = this.resourceType;
        }
        
        public FinancialYear (string resourceType = "FinancialYear", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<FinancialYear> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_FinancialYear");
        	RestGateway gateway = (RestGateway) FinancialYear.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<FinancialYear> financialyearCollection = new ModelCollection<FinancialYear> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    financialyearCollection.add((FinancialYear) model);
        	}
        
        	return financialyearCollection;
        }

        public static FinancialYear retrieve (string id)
        {
            RestGateway gateway = (RestGateway) FinancialYear.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (FinancialYear) gateway.retrieve(ResourceType.FINANCE_FINANCIAL_YEAR, id);
        }

        public string getFinancialYearName ()
        {
            return this.getProperty("financialYearName").ToString();
        }

        public void setFinancialYearName (string financialYearName)
        {
            this.setProperty("financialYearName", financialYearName);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

