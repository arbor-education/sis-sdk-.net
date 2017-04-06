using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class Fund : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_FUND;
        public const string FINANCIAL_YEAR = "financialYear";
        public const string FUND_CODE = "fundCode";
        public const string FUND_NAME = "fundName";
        public const string SHORT_NAME = "shortName";

        public Fund ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Fund (string resourceType = "Fund", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Fund> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_Fund");
        	RestGateway gateway = (RestGateway) Fund.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Fund> fundCollection = new ModelCollection<Fund> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    fundCollection.add((Fund) model);
        	}
        
        	return fundCollection;
        }

        public static Fund retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Fund.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Fund) gateway.retrieve(ResourceType.FINANCE_FUND, id);
        }

        public ModelBase getFinancialYear ()
        {
            return (ModelBase) this.getProperty("financialYear");
        }

        public void setFinancialYear (ModelBase financialYear)
        {
            this.setProperty("financialYear", financialYear);
        }

        public string getFundCode ()
        {
            return this.getProperty("fundCode").ToString();
        }

        public void setFundCode (string fundCode)
        {
            this.setProperty("fundCode", fundCode);
        }

        public string getFundName ()
        {
            return this.getProperty("fundName").ToString();
        }

        public void setFundName (string fundName)
        {
            this.setProperty("fundName", fundName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }


    }
}

