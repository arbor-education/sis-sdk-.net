using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationGradeSet : ModelBase
    {
        protected string resourceType = ResourceType.OBSERVATION_GRADE_SET;
        public const string OBSERVATION_TYPE = "observationType";
        public const string NAME = "name";
        public const string SCALE_DIRECTION = "scaleDirection";

        public ObservationGradeSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ObservationGradeSet (string resourceType = "ObservationGradeSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ObservationGradeSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ObservationGradeSet");
        	RestGateway gateway = (RestGateway) ObservationGradeSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ObservationGradeSet> observationgradesetCollection = new ModelCollection<ObservationGradeSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    observationgradesetCollection.add((ObservationGradeSet) model);
        	}
        
        	return observationgradesetCollection;
        }

        public static ObservationGradeSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ObservationGradeSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ObservationGradeSet) gateway.retrieve(ResourceType.OBSERVATION_GRADE_SET, id);
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

        public string getScaleDirection ()
        {
            return this.getProperty("scaleDirection").ToString();
        }

        public void setScaleDirection (string scaleDirection)
        {
            this.setProperty("scaleDirection", scaleDirection);
        }


    }
}

