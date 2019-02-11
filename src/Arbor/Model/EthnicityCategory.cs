using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EthnicityCategory : ModelBase
    {
        protected string resourceType = ResourceType.ETHNICITY_CATEGORY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public EthnicityCategory ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EthnicityCategory (string resourceType = "EthnicityCategory", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EthnicityCategory> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EthnicityCategory");
        	RestGateway gateway = (RestGateway) EthnicityCategory.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EthnicityCategory> ethnicitycategoryCollection = new ModelCollection<EthnicityCategory> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ethnicitycategoryCollection.add((EthnicityCategory) model);
        	}
        
        	return ethnicitycategoryCollection;
        }

        public static EthnicityCategory retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EthnicityCategory.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EthnicityCategory) gateway.retrieve(ResourceType.ETHNICITY_CATEGORY, id);
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

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }


    }
}

