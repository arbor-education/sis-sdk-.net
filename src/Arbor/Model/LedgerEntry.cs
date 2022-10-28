using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LedgerEntry : ModelBase
    {
        protected new string resourceType = ResourceType.LEDGER_ENTRY;
        public const string AMOUNT = "amount";
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string TRANSACTION = "transaction";

        public LedgerEntry ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LedgerEntry (string resourceType = "LedgerEntry", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LedgerEntry> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("LedgerEntry");
        	RestGateway gateway = (RestGateway) LedgerEntry.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LedgerEntry> ledgerentryCollection = new ModelCollection<LedgerEntry> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ledgerentryCollection.add((LedgerEntry) model);
        	}
        
        	return ledgerentryCollection;
        }

        public static LedgerEntry retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LedgerEntry.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LedgerEntry) gateway.retrieve(ResourceType.LEDGER_ENTRY, id);
        }

        public string getAmount ()
        {
            return this.getProperty("amount").ToString();
        }

        public void setAmount (string amount)
        {
            this.setProperty("amount", amount);
        }

        public CustomerAccount getCustomerAccount ()
        {
            return (CustomerAccount) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public ModelBase getTransaction ()
        {
            return (ModelBase) this.getProperty("transaction");
        }

        public void setTransaction (ModelBase transaction)
        {
            this.setProperty("transaction", transaction);
        }


    }
}

