using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AccessArrangement : ModelBase
    {
        protected string resourceType = ResourceType.ACCESS_ARRANGEMENT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string DEFAULT_EXTRA_TIME_PERCENTAGE = "defaultExtraTimePercentage";

        public AccessArrangement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AccessArrangement (string resourceType = "AccessArrangement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AccessArrangement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AccessArrangement");
        	RestGateway gateway = (RestGateway) AccessArrangement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AccessArrangement> accessarrangementCollection = new ModelCollection<AccessArrangement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    accessarrangementCollection.add((AccessArrangement) model);
        	}
        
        	return accessarrangementCollection;
        }

        public static AccessArrangement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AccessArrangement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AccessArrangement) gateway.retrieve(ResourceType.ACCESS_ARRANGEMENT, id);
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

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public float getDefaultExtraTimePercentage ()
        {
            return (float) this.getProperty("defaultExtraTimePercentage");
        }

        public void setDefaultExtraTimePercentage (float defaultExtraTimePercentage)
        {
            this.setProperty("defaultExtraTimePercentage", defaultExtraTimePercentage);
        }


    }
}

