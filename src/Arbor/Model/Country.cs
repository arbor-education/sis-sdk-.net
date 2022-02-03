using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Country : ModelBase
    {
        protected string resourceType = ResourceType.COUNTRY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SHORT_NAME = "shortName";
        public const string LONG_NAME = "longName";
        public const string ISO31661_ALPHA2 = "iso31661Alpha2";
        public const string ISO31661_ALPHA3 = "iso31661Alpha3";
        public const string ISO31661_NUMERIC = "iso31661Numeric";
        public const string NOTE = "note";
        public const string APPLIES_TO_POSTAL_ADDRESS = "appliesToPostalAddress";

        public Country ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Country (string resourceType = "Country", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Country> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Country");
        	RestGateway gateway = (RestGateway) Country.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Country> countryCollection = new ModelCollection<Country> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    countryCollection.add((Country) model);
        	}
        
        	return countryCollection;
        }

        public static Country retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Country.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Country) gateway.retrieve(ResourceType.COUNTRY, id);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getLongName ()
        {
            return this.getProperty("longName").ToString();
        }

        public void setLongName (string longName)
        {
            this.setProperty("longName", longName);
        }

        public string getIso31661Alpha2 ()
        {
            return this.getProperty("iso31661Alpha2").ToString();
        }

        public void setIso31661Alpha2 (string iso31661Alpha2)
        {
            this.setProperty("iso31661Alpha2", iso31661Alpha2);
        }

        public string getIso31661Alpha3 ()
        {
            return this.getProperty("iso31661Alpha3").ToString();
        }

        public void setIso31661Alpha3 (string iso31661Alpha3)
        {
            this.setProperty("iso31661Alpha3", iso31661Alpha3);
        }

        public string getIso31661Numeric ()
        {
            return this.getProperty("iso31661Numeric").ToString();
        }

        public void setIso31661Numeric (string iso31661Numeric)
        {
            this.setProperty("iso31661Numeric", iso31661Numeric);
        }

        public string getNote ()
        {
            return this.getProperty("note").ToString();
        }

        public void setNote (string note)
        {
            this.setProperty("note", note);
        }

        public bool getAppliesToPostalAddress ()
        {
            return Convert.ToBoolean(this.getProperty("appliesToPostalAddress"));
        }

        public void setAppliesToPostalAddress (bool appliesToPostalAddress)
        {
            this.setProperty("appliesToPostalAddress", appliesToPostalAddress);
        }


    }
}

