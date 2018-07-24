using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class VatRate : ModelBase
    {
        protected string resourceType = ResourceType.VAT_RATE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string IS_DEFAULT_VAT_RATE = "isDefaultVatRate";
        public const string VAT_RATE_NAME = "vatRateName";
        public const string VAT_RATE_SHORT_NAME = "vatRateShortName";
        public const string RATE = "rate";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public VatRate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public VatRate (string resourceType = "VatRate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<VatRate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("VatRate");
        	RestGateway gateway = (RestGateway) VatRate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<VatRate> vatrateCollection = new ModelCollection<VatRate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    vatrateCollection.add((VatRate) model);
        	}
        
        	return vatrateCollection;
        }

        public static VatRate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) VatRate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (VatRate) gateway.retrieve(ResourceType.VAT_RATE, id);
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

        public bool getIsDefaultVatRate ()
        {
            return (bool) this.getProperty("isDefaultVatRate");
        }

        public void setIsDefaultVatRate (bool isDefaultVatRate)
        {
            this.setProperty("isDefaultVatRate", isDefaultVatRate);
        }

        public string getVatRateName ()
        {
            return this.getProperty("vatRateName").ToString();
        }

        public void setVatRateName (string vatRateName)
        {
            this.setProperty("vatRateName", vatRateName);
        }

        public string getVatRateShortName ()
        {
            return this.getProperty("vatRateShortName").ToString();
        }

        public void setVatRateShortName (string vatRateShortName)
        {
            this.setProperty("vatRateShortName", vatRateShortName);
        }

        public float getRate ()
        {
            return (float) this.getProperty("rate");
        }

        public void setRate (float rate)
        {
            this.setProperty("rate", rate);
        }

        public DateTime getEffectiveDate (){
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

