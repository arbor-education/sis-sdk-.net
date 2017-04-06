using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenProvisionType : ModelBase
    {
        protected string resourceType = ResourceType.SEN_PROVISION_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SEN_PROVISION_TYPE = "senProvisionType";

        public SenProvisionType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SenProvisionType (string resourceType = "SenProvisionType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SenProvisionType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SenProvisionType");
        	RestGateway gateway = (RestGateway) SenProvisionType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SenProvisionType> senprovisiontypeCollection = new ModelCollection<SenProvisionType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    senprovisiontypeCollection.add((SenProvisionType) model);
        	}
        
        	return senprovisiontypeCollection;
        }

        public static SenProvisionType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SenProvisionType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SenProvisionType) gateway.retrieve(ResourceType.SEN_PROVISION_TYPE, id);
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

        public string getSenProvisionType ()
        {
            return this.getProperty("senProvisionType").ToString();
        }

        public void setSenProvisionType (string senProvisionType)
        {
            this.setProperty("senProvisionType", senProvisionType);
        }


    }
}

