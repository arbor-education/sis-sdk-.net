using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ImpairmentCategory : ModelBase
    {
        protected string resourceType = ResourceType.IMPAIRMENT_CATEGORY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";

        public ImpairmentCategory ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ImpairmentCategory (string resourceType = "ImpairmentCategory", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ImpairmentCategory> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ImpairmentCategory");
        	RestGateway gateway = (RestGateway) ImpairmentCategory.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ImpairmentCategory> impairmentcategoryCollection = new ModelCollection<ImpairmentCategory> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    impairmentcategoryCollection.add((ImpairmentCategory) model);
        	}
        
        	return impairmentcategoryCollection;
        }

        public static ImpairmentCategory retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ImpairmentCategory.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ImpairmentCategory) gateway.retrieve(ResourceType.IMPAIRMENT_CATEGORY, id);
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

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

