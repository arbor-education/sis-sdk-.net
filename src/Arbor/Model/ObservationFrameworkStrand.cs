using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationFrameworkStrand : ModelBase
    {
        protected new string resourceType = ResourceType.OBSERVATION_FRAMEWORK_STRAND;
        public const string OBSERVATION_FRAMEWORK = "observationFramework";
        public const string OBSERVATION_STRAND = "observationStrand";

        public ObservationFrameworkStrand ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ObservationFrameworkStrand (string resourceType = "ObservationFrameworkStrand", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ObservationFrameworkStrand> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ObservationFrameworkStrand");
        	RestGateway gateway = (RestGateway) ObservationFrameworkStrand.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ObservationFrameworkStrand> observationframeworkstrandCollection = new ModelCollection<ObservationFrameworkStrand> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    observationframeworkstrandCollection.add((ObservationFrameworkStrand) model);
        	}
        
        	return observationframeworkstrandCollection;
        }

        public static ObservationFrameworkStrand retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ObservationFrameworkStrand.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ObservationFrameworkStrand) gateway.retrieve(ResourceType.OBSERVATION_FRAMEWORK_STRAND, id);
        }

        public ObservationFramework getObservationFramework ()
        {
            return (ObservationFramework) this.getProperty("observationFramework");
        }

        public void setObservationFramework (ObservationFramework observationFramework)
        {
            this.setProperty("observationFramework", observationFramework);
        }

        public ObservationStrand getObservationStrand ()
        {
            return (ObservationStrand) this.getProperty("observationStrand");
        }

        public void setObservationStrand (ObservationStrand observationStrand)
        {
            this.setProperty("observationStrand", observationStrand);
        }


    }
}

