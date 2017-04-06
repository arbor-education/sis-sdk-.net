using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class Bank : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_BANK;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string BANK_NAME = "bankName";
        public const string COUNTRY_CODE = "countryCode";

        public Bank ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Bank (string resourceType = "Bank", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Bank> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_Bank");
        	RestGateway gateway = (RestGateway) Bank.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Bank> bankCollection = new ModelCollection<Bank> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bankCollection.add((Bank) model);
        	}
        
        	return bankCollection;
        }

        public static Bank retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Bank.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Bank) gateway.retrieve(ResourceType.FINANCE_BANK, id);
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

        public string getBankName ()
        {
            return this.getProperty("bankName").ToString();
        }

        public void setBankName (string bankName)
        {
            this.setProperty("bankName", bankName);
        }

        public string getCountryCode ()
        {
            return this.getProperty("countryCode").ToString();
        }

        public void setCountryCode (string countryCode)
        {
            this.setProperty("countryCode", countryCode);
        }


    }
}

