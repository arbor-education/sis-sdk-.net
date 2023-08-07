using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationTypeGradeSet : ModelBase
    {
        protected new string resourceType = ResourceType.OBSERVATION_TYPE_GRADE_SET;
        public const string OBSERVATION_TYPE = "observationType";
        public const string OBSERVATION_GRADE_SET = "observationGradeSet";

        public ObservationTypeGradeSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ObservationTypeGradeSet (string resourceType = "ObservationTypeGradeSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ObservationTypeGradeSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ObservationTypeGradeSet");
        	RestGateway gateway = (RestGateway) ObservationTypeGradeSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ObservationTypeGradeSet> observationtypegradesetCollection = new ModelCollection<ObservationTypeGradeSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    observationtypegradesetCollection.add((ObservationTypeGradeSet) model);
        	}
        
        	return observationtypegradesetCollection;
        }

        public static ObservationTypeGradeSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ObservationTypeGradeSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ObservationTypeGradeSet) gateway.retrieve(ResourceType.OBSERVATION_TYPE_GRADE_SET, id);
        }

        public ObservationType getObservationType ()
        {
            return (ObservationType) this.getProperty("observationType");
        }

        public void setObservationType (ObservationType observationType)
        {
            this.setProperty("observationType", observationType);
        }

        public ObservationGradeSet getObservationGradeSet ()
        {
            return (ObservationGradeSet) this.getProperty("observationGradeSet");
        }

        public void setObservationGradeSet (ObservationGradeSet observationGradeSet)
        {
            this.setProperty("observationGradeSet", observationGradeSet);
        }


    }
}

