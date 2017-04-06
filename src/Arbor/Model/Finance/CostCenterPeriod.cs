using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class CostCenterPeriod : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_COST_CENTER_PERIOD;
        public const string COST_CENTER = "costCenter";
        public const string FINANCIAL_YEAR_PERIOD = "financialYearPeriod";
        public const string ORIGINAL_BUDGET = "originalBudget";
        public const string CURRENT_BUDGET = "currentBudget";
        public const string ACTUAL_VALUE = "actualValue";

        public CostCenterPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CostCenterPeriod (string resourceType = "CostCenterPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CostCenterPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_CostCenterPeriod");
        	RestGateway gateway = (RestGateway) CostCenterPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CostCenterPeriod> costcenterperiodCollection = new ModelCollection<CostCenterPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    costcenterperiodCollection.add((CostCenterPeriod) model);
        	}
        
        	return costcenterperiodCollection;
        }

        public static CostCenterPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CostCenterPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CostCenterPeriod) gateway.retrieve(ResourceType.FINANCE_COST_CENTER_PERIOD, id);
        }

        public ModelBase getCostCenter ()
        {
            return (ModelBase) this.getProperty("costCenter");
        }

        public void setCostCenter (ModelBase costCenter)
        {
            this.setProperty("costCenter", costCenter);
        }

        public ModelBase getFinancialYearPeriod ()
        {
            return (ModelBase) this.getProperty("financialYearPeriod");
        }

        public void setFinancialYearPeriod (ModelBase financialYearPeriod)
        {
            this.setProperty("financialYearPeriod", financialYearPeriod);
        }

        public float getOriginalBudget ()
        {
            return (float) this.getProperty("originalBudget");
        }

        public void setOriginalBudget (float originalBudget)
        {
            this.setProperty("originalBudget", originalBudget);
        }

        public float getCurrentBudget ()
        {
            return (float) this.getProperty("currentBudget");
        }

        public void setCurrentBudget (float currentBudget)
        {
            this.setProperty("currentBudget", currentBudget);
        }

        public float getActualValue ()
        {
            return (float) this.getProperty("actualValue");
        }

        public void setActualValue (float actualValue)
        {
            this.setProperty("actualValue", actualValue);
        }


    }
}

