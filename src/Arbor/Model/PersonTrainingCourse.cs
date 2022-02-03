using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonTrainingCourse : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_TRAINING_COURSE;
        public const string TRAINING_COURSE = "trainingCourse";
        public const string TRAINED_PERSON = "trainedPerson";
        public const string FEE_COSTS = "feeCosts";

        public PersonTrainingCourse ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PersonTrainingCourse (string resourceType = "PersonTrainingCourse", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PersonTrainingCourse> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PersonTrainingCourse");
        	RestGateway gateway = (RestGateway) PersonTrainingCourse.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PersonTrainingCourse> persontrainingcourseCollection = new ModelCollection<PersonTrainingCourse> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    persontrainingcourseCollection.add((PersonTrainingCourse) model);
        	}
        
        	return persontrainingcourseCollection;
        }

        public static PersonTrainingCourse retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PersonTrainingCourse.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PersonTrainingCourse) gateway.retrieve(ResourceType.PERSON_TRAINING_COURSE, id);
        }

        public TrainingCourse getTrainingCourse ()
        {
            return (TrainingCourse) this.getProperty("trainingCourse");
        }

        public void setTrainingCourse (TrainingCourse trainingCourse)
        {
            this.setProperty("trainingCourse", trainingCourse);
        }

        public ModelBase getTrainedPerson ()
        {
            return (ModelBase) this.getProperty("trainedPerson");
        }

        public void setTrainedPerson (ModelBase trainedPerson)
        {
            this.setProperty("trainedPerson", trainedPerson);
        }

        public float getFeeCosts ()
        {
            return (float) this.getProperty("feeCosts");
        }

        public void setFeeCosts (float feeCosts)
        {
            this.setProperty("feeCosts", feeCosts);
        }


    }
}

