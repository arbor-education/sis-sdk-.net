using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ExclusionReason : ModelBase
    {
        protected string resourceType = ResourceType.EXCLUSION_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string EXCLUSION_REASON_NAME = "exclusionReasonName";

        public ExclusionReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ExclusionReason (string resourceType = "ExclusionReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ExclusionReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ExclusionReason");
        	RestGateway gateway = (RestGateway) ExclusionReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ExclusionReason> exclusionreasonCollection = new ModelCollection<ExclusionReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    exclusionreasonCollection.add((ExclusionReason) model);
        	}
        
        	return exclusionreasonCollection;
        }

        public static ExclusionReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ExclusionReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ExclusionReason) gateway.retrieve(ResourceType.EXCLUSION_REASON, id);
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

        public string getExclusionReasonName ()
        {
            return this.getProperty("exclusionReasonName").ToString();
        }

        public void setExclusionReasonName (string exclusionReasonName)
        {
            this.setProperty("exclusionReasonName", exclusionReasonName);
        }


    }
}

