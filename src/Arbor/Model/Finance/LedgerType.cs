using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class LedgerType : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_LEDGER_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LEDGER_TYPE_NAME = "ledgerTypeName";
        public const string DEBIT_CREDIT = "debitCredit";

        public LedgerType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LedgerType (string resourceType = "LedgerType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LedgerType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_LedgerType");
        	RestGateway gateway = (RestGateway) LedgerType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LedgerType> ledgertypeCollection = new ModelCollection<LedgerType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ledgertypeCollection.add((LedgerType) model);
        	}
        
        	return ledgertypeCollection;
        }

        public static LedgerType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LedgerType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LedgerType) gateway.retrieve(ResourceType.FINANCE_LEDGER_TYPE, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getLedgerTypeName ()
        {
            return this.getProperty("ledgerTypeName").ToString();
        }

        public void setLedgerTypeName (string ledgerTypeName)
        {
            this.setProperty("ledgerTypeName", ledgerTypeName);
        }

        public string getDebitCredit ()
        {
            return this.getProperty("debitCredit").ToString();
        }

        public void setDebitCredit (string debitCredit)
        {
            this.setProperty("debitCredit", debitCredit);
        }


    }
}

