using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CostCenter : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_COST_CENTER;
        public const string FINANCIAL_YEAR = "financialYear";
        public const string COST_CENTER_CODE = "costCenterCode";
        public const string COST_CENTER_NAME = "costCenterName";
        public const string SHORT_NAME = "shortName";

        public CostCenter ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CostCenter (string resourceType = "CostCenter", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CostCenter> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_CostCenter");
        	RestGateway gateway = (RestGateway) CostCenter.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CostCenter> costcenterCollection = new ModelCollection<CostCenter> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    costcenterCollection.add((CostCenter) model);
        	}
        
        	return costcenterCollection;
        }

        public static CostCenter retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CostCenter.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CostCenter) gateway.retrieve(ResourceType.FINANCE_COST_CENTER, id);
        }

        public ModelBase getFinancialYear ()
        {
            return (ModelBase) this.getProperty("financialYear");
        }

        public void setFinancialYear (ModelBase financialYear)
        {
            this.setProperty("financialYear", financialYear);
        }

        public string getCostCenterCode ()
        {
            return this.getProperty("costCenterCode").ToString();
        }

        public void setCostCenterCode (string costCenterCode)
        {
            this.setProperty("costCenterCode", costCenterCode);
        }

        public string getCostCenterName ()
        {
            return this.getProperty("costCenterName").ToString();
        }

        public void setCostCenterName (string costCenterName)
        {
            this.setProperty("costCenterName", costCenterName);
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

