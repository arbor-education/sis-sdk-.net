using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionDefinition : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_DEFINITION;
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string INTERVENTION_CATEGORY = "interventionCategory";
        public const string LOWEST_CURRICULUM_GRADE = "lowestCurriculumGrade";
        public const string HIGHEST_CURRICULUM_GRADE = "highestCurriculumGrade";

        public InterventionDefinition ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionDefinition (string resourceType = "InterventionDefinition", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionDefinition> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionDefinition");
        	RestGateway gateway = (RestGateway) InterventionDefinition.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionDefinition> interventiondefinitionCollection = new ModelCollection<InterventionDefinition> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventiondefinitionCollection.add((InterventionDefinition) model);
        	}
        
        	return interventiondefinitionCollection;
        }

        public static InterventionDefinition retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionDefinition.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionDefinition) gateway.retrieve(ResourceType.INTERVENTION_DEFINITION, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public InterventionCategory getInterventionCategory ()
        {
            return (InterventionCategory) this.getProperty("interventionCategory");
        }

        public void setInterventionCategory (InterventionCategory interventionCategory)
        {
            this.setProperty("interventionCategory", interventionCategory);
        }

        public CurriculumGrade getLowestCurriculumGrade ()
        {
            return (CurriculumGrade) this.getProperty("lowestCurriculumGrade");
        }

        public void setLowestCurriculumGrade (CurriculumGrade lowestCurriculumGrade)
        {
            this.setProperty("lowestCurriculumGrade", lowestCurriculumGrade);
        }

        public CurriculumGrade getHighestCurriculumGrade ()
        {
            return (CurriculumGrade) this.getProperty("highestCurriculumGrade");
        }

        public void setHighestCurriculumGrade (CurriculumGrade highestCurriculumGrade)
        {
            this.setProperty("highestCurriculumGrade", highestCurriculumGrade);
        }


    }
}

