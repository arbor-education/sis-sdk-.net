using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AspectSet : ModelBase
    {
        protected string resourceType = ResourceType.ASPECT_SET;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASPECT_SET_NAME = "aspectSetName";

        public AspectSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AspectSet (string resourceType = "AspectSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AspectSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AspectSet");
        	RestGateway gateway = (RestGateway) AspectSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AspectSet> aspectsetCollection = new ModelCollection<AspectSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    aspectsetCollection.add((AspectSet) model);
        	}
        
        	return aspectsetCollection;
        }

        public static AspectSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AspectSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AspectSet) gateway.retrieve(ResourceType.ASPECT_SET, id);
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

        public string getAspectSetName ()
        {
            return this.getProperty("aspectSetName").ToString();
        }

        public void setAspectSetName (string aspectSetName)
        {
            this.setProperty("aspectSetName", aspectSetName);
        }


    }
}

