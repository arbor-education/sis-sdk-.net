using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_Programme : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PROGRAMME;
        public const string IS_TRAINEESHIP = "isTraineeship";

        public UkDfe_Programme ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_Programme (string resourceType = "UkDfe_Programme", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_Programme> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Programme");
        	RestGateway gateway = (RestGateway) UkDfe_Programme.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_Programme> ukdfe_programmeCollection = new ModelCollection<UkDfe_Programme> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_programmeCollection.add((UkDfe_Programme) model);
        	}
        
        	return ukdfe_programmeCollection;
        }

        public static UkDfe_Programme retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_Programme.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_Programme) gateway.retrieve(ResourceType.UK_DFE_PROGRAMME, id);
        }

        public bool getIsTraineeship ()
        {
            return Convert.ToBoolean(this.getProperty("isTraineeship"))
        }

        public void setIsTraineeship (bool isTraineeship)
        {
            this.setProperty("isTraineeship", isTraineeship);
        }


    }
}

