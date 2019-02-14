using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_PayScaleCategory : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PAY_SCALE_CATEGORY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";

        public UkDfe_PayScaleCategory ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_PayScaleCategory (string resourceType = "UkDfe_PayScaleCategory", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_PayScaleCategory> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PayScaleCategory");
        	RestGateway gateway = (RestGateway) UkDfe_PayScaleCategory.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_PayScaleCategory> ukdfe_payscalecategoryCollection = new ModelCollection<UkDfe_PayScaleCategory> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_payscalecategoryCollection.add((UkDfe_PayScaleCategory) model);
        	}
        
        	return ukdfe_payscalecategoryCollection;
        }

        public static UkDfe_PayScaleCategory retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_PayScaleCategory.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_PayScaleCategory) gateway.retrieve(ResourceType.UK_DFE_PAY_SCALE_CATEGORY, id);
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
            return Convert.ToBoolean(this.getProperty("active"))
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

        public string getLabel ()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel (string label)
        {
            this.setProperty("label", label);
        }


    }
}

