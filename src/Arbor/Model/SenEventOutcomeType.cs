using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenEventOutcomeType : ModelBase
    {
        protected string resourceType = ResourceType.SEN_EVENT_OUTCOME_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SEN_EVENT_OUTCOME_TYPE = "senEventOutcomeType";

        public SenEventOutcomeType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SenEventOutcomeType (string resourceType = "SenEventOutcomeType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SenEventOutcomeType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SenEventOutcomeType");
        	RestGateway gateway = (RestGateway) SenEventOutcomeType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SenEventOutcomeType> seneventoutcometypeCollection = new ModelCollection<SenEventOutcomeType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    seneventoutcometypeCollection.add((SenEventOutcomeType) model);
        	}
        
        	return seneventoutcometypeCollection;
        }

        public static SenEventOutcomeType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SenEventOutcomeType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SenEventOutcomeType) gateway.retrieve(ResourceType.SEN_EVENT_OUTCOME_TYPE, id);
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

        public string getSenEventOutcomeType ()
        {
            return this.getProperty("senEventOutcomeType").ToString();
        }

        public void setSenEventOutcomeType (string senEventOutcomeType)
        {
            this.setProperty("senEventOutcomeType", senEventOutcomeType);
        }


    }
}

