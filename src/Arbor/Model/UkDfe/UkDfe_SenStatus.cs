using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SenStatus : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SEN_STATUS;
        public const string D00229 = "d00229";

        public UkDfe_SenStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SenStatus (string resourceType = "UkDfe_SenStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SenStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SenStatus");
        	RestGateway gateway = (RestGateway) UkDfe_SenStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SenStatus> ukdfe_senstatusCollection = new ModelCollection<UkDfe_SenStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_senstatusCollection.add((UkDfe_SenStatus) model);
        	}
        
        	return ukdfe_senstatusCollection;
        }

        public static UkDfe_SenStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SenStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SenStatus) gateway.retrieve(ResourceType.UK_DFE_SEN_STATUS, id);
        }

        public string getD00229 ()
        {
            return this.getProperty("d00229").ToString();
        }

        public void setD00229 (string d00229)
        {
            this.setProperty("d00229", d00229);
        }


    }
}

