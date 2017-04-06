using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class Ledger : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_LEDGER;
        public const string LEDGER_CODE = "ledgerCode";
        public const string LEDGER_NAME = "ledgerName";
        public const string LEDGER_SHORT_NAME = "ledgerShortName";
        public const string FINANCIAL_YEAR = "financialYear";
        public const string LEDGER_TYPE = "ledgerType";
        public const string LEDGER_GROUP = "ledgerGroup";
        public const string VAT_RATE = "vatRate";

        public Ledger ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Ledger (string resourceType = "Ledger", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Ledger> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_Ledger");
        	RestGateway gateway = (RestGateway) Ledger.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Ledger> ledgerCollection = new ModelCollection<Ledger> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ledgerCollection.add((Ledger) model);
        	}
        
        	return ledgerCollection;
        }

        public static Ledger retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Ledger.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Ledger) gateway.retrieve(ResourceType.FINANCE_LEDGER, id);
        }

        public string getLedgerCode ()
        {
            return this.getProperty("ledgerCode").ToString();
        }

        public void setLedgerCode (string ledgerCode)
        {
            this.setProperty("ledgerCode", ledgerCode);
        }

        public string getLedgerName ()
        {
            return this.getProperty("ledgerName").ToString();
        }

        public void setLedgerName (string ledgerName)
        {
            this.setProperty("ledgerName", ledgerName);
        }

        public string getLedgerShortName ()
        {
            return this.getProperty("ledgerShortName").ToString();
        }

        public void setLedgerShortName (string ledgerShortName)
        {
            this.setProperty("ledgerShortName", ledgerShortName);
        }

        public ModelBase getFinancialYear ()
        {
            return (ModelBase) this.getProperty("financialYear");
        }

        public void setFinancialYear (ModelBase financialYear)
        {
            this.setProperty("financialYear", financialYear);
        }

        public ModelBase getLedgerType ()
        {
            return (ModelBase) this.getProperty("ledgerType");
        }

        public void setLedgerType (ModelBase ledgerType)
        {
            this.setProperty("ledgerType", ledgerType);
        }

        public ModelBase getLedgerGroup ()
        {
            return (ModelBase) this.getProperty("ledgerGroup");
        }

        public void setLedgerGroup (ModelBase ledgerGroup)
        {
            this.setProperty("ledgerGroup", ledgerGroup);
        }

        public ModelBase getVatRate ()
        {
            return (ModelBase) this.getProperty("vatRate");
        }

        public void setVatRate (ModelBase vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }


    }
}

