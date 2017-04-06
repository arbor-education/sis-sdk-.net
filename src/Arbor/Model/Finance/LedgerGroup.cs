using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class LedgerGroup : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_LEDGER_GROUP;
        public const string FINANCIAL_YEAR = "financialYear";
        public const string LEDGER_GROUP_NAME = "ledgerGroupName";

        public LedgerGroup ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LedgerGroup (string resourceType = "LedgerGroup", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LedgerGroup> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_LedgerGroup");
        	RestGateway gateway = (RestGateway) LedgerGroup.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LedgerGroup> ledgergroupCollection = new ModelCollection<LedgerGroup> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ledgergroupCollection.add((LedgerGroup) model);
        	}
        
        	return ledgergroupCollection;
        }

        public static LedgerGroup retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LedgerGroup.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LedgerGroup) gateway.retrieve(ResourceType.FINANCE_LEDGER_GROUP, id);
        }

        public ModelBase getFinancialYear ()
        {
            return (ModelBase) this.getProperty("financialYear");
        }

        public void setFinancialYear (ModelBase financialYear)
        {
            this.setProperty("financialYear", financialYear);
        }

        public string getLedgerGroupName ()
        {
            return this.getProperty("ledgerGroupName").ToString();
        }

        public void setLedgerGroupName (string ledgerGroupName)
        {
            this.setProperty("ledgerGroupName", ledgerGroupName);
        }


    }
}

