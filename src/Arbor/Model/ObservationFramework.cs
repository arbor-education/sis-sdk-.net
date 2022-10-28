using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationFramework : ModelBase
    {
        protected new string resourceType = ResourceType.OBSERVATION_FRAMEWORK;
        public const string OBSERVATION_TYPE = "observationType";
        public const string NAME = "name";

        public ObservationFramework ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ObservationFramework (string resourceType = "ObservationFramework", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ObservationFramework> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ObservationFramework");
        	RestGateway gateway = (RestGateway) ObservationFramework.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ObservationFramework> observationframeworkCollection = new ModelCollection<ObservationFramework> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    observationframeworkCollection.add((ObservationFramework) model);
        	}
        
        	return observationframeworkCollection;
        }

        public static ObservationFramework retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ObservationFramework.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ObservationFramework) gateway.retrieve(ResourceType.OBSERVATION_FRAMEWORK, id);
        }

        public ObservationType getObservationType ()
        {
            return (ObservationType) this.getProperty("observationType");
        }

        public void setObservationType (ObservationType observationType)
        {
            this.setProperty("observationType", observationType);
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

