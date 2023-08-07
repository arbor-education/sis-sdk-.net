using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InternalExclusionReason : ModelBase
    {
        protected new string resourceType = ResourceType.INTERNAL_EXCLUSION_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public InternalExclusionReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InternalExclusionReason (string resourceType = "InternalExclusionReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InternalExclusionReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InternalExclusionReason");
        	RestGateway gateway = (RestGateway) InternalExclusionReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InternalExclusionReason> internalexclusionreasonCollection = new ModelCollection<InternalExclusionReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    internalexclusionreasonCollection.add((InternalExclusionReason) model);
        	}
        
        	return internalexclusionreasonCollection;
        }

        public static InternalExclusionReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InternalExclusionReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InternalExclusionReason) gateway.retrieve(ResourceType.INTERNAL_EXCLUSION_REASON, id);
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

