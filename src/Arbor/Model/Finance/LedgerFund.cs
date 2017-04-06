using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class LedgerFund : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_LEDGER_FUND;
        public const string LEDGER = "ledger";
        public const string FUND = "fund";

        public LedgerFund ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LedgerFund (string resourceType = "LedgerFund", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LedgerFund> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_LedgerFund");
        	RestGateway gateway = (RestGateway) LedgerFund.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LedgerFund> ledgerfundCollection = new ModelCollection<LedgerFund> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ledgerfundCollection.add((LedgerFund) model);
        	}
        
        	return ledgerfundCollection;
        }

        public static LedgerFund retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LedgerFund.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LedgerFund) gateway.retrieve(ResourceType.FINANCE_LEDGER_FUND, id);
        }

        public ModelBase getLedger ()
        {
            return (ModelBase) this.getProperty("ledger");
        }

        public void setLedger (ModelBase ledger)
        {
            this.setProperty("ledger", ledger);
        }

        public ModelBase getFund ()
        {
            return (ModelBase) this.getProperty("fund");
        }

        public void setFund (ModelBase fund)
        {
            this.setProperty("fund", fund);
        }


    }
}

