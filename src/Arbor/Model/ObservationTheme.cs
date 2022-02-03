using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationTheme : ModelBase
    {
        protected string resourceType = ResourceType.OBSERVATION_THEME;
        public const string OBSERVATION_TYPE = "observationType";
        public const string NAME = "name";

        public ObservationTheme ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ObservationTheme (string resourceType = "ObservationTheme", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ObservationTheme> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ObservationTheme");
        	RestGateway gateway = (RestGateway) ObservationTheme.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ObservationTheme> observationthemeCollection = new ModelCollection<ObservationTheme> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    observationthemeCollection.add((ObservationTheme) model);
        	}
        
        	return observationthemeCollection;
        }

        public static ObservationTheme retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ObservationTheme.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ObservationTheme) gateway.retrieve(ResourceType.OBSERVATION_THEME, id);
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

