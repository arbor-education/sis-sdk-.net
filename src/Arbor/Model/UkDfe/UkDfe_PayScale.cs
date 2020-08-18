using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_PayScale : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PAY_SCALE;
        public const string REGIONAL_PAY_SPINE = "regionalPaySpine";
        public const string PAY_SCALE_CATEGORY = "payScaleCategory";

        public UkDfe_PayScale ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_PayScale (string resourceType = "UkDfe_PayScale", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_PayScale> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PayScale");
        	RestGateway gateway = (RestGateway) UkDfe_PayScale.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_PayScale> ukdfe_payscaleCollection = new ModelCollection<UkDfe_PayScale> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_payscaleCollection.add((UkDfe_PayScale) model);
        	}
        
        	return ukdfe_payscaleCollection;
        }

        public static UkDfe_PayScale retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_PayScale.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_PayScale) gateway.retrieve(ResourceType.UK_DFE_PAY_SCALE, id);
        }

        public string getRegionalPaySpine ()
        {
            return this.getProperty("regionalPaySpine").ToString();
        }

        public void setRegionalPaySpine (string regionalPaySpine)
        {
            this.setProperty("regionalPaySpine", regionalPaySpine);
        }

        public PayScaleCategory getPayScaleCategory ()
        {
            return (PayScaleCategory) this.getProperty("payScaleCategory");
        }

        public void setPayScaleCategory (PayScaleCategory payScaleCategory)
        {
            this.setProperty("payScaleCategory", payScaleCategory);
        }


    }
}

