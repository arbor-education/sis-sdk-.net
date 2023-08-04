using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationType : ModelBase
    {
        protected new string resourceType = ResourceType.OBSERVATION_TYPE;
        public const string NAME = "name";

        public ObservationType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ObservationType (string resourceType = "ObservationType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ObservationType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ObservationType");
        	RestGateway gateway = (RestGateway) ObservationType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ObservationType> observationtypeCollection = new ModelCollection<ObservationType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    observationtypeCollection.add((ObservationType) model);
        	}
        
        	return observationtypeCollection;
        }

        public static ObservationType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ObservationType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ObservationType) gateway.retrieve(ResourceType.OBSERVATION_TYPE, id);
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

