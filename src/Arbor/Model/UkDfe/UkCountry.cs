using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkCountry : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_UK_COUNTRY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string COUNTRY_NAME = "countryName";

        public UkCountry ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkCountry (string resourceType = "UkCountry", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkCountry> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_UkCountry");
        	RestGateway gateway = (RestGateway) UkCountry.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkCountry> ukcountryCollection = new ModelCollection<UkCountry> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukcountryCollection.add((UkCountry) model);
        	}
        
        	return ukcountryCollection;
        }

        public static UkCountry retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkCountry.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkCountry) gateway.retrieve(ResourceType.UK_DFE_UK_COUNTRY, id);
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
            return Convert.ToBoolean( this.getProperty("active"));
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

        public string getCountryName ()
        {
            return this.getProperty("countryName").ToString();
        }

        public void setCountryName (string countryName)
        {
            this.setProperty("countryName", countryName);
        }


    }
}

