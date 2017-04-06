using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumStage : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_STAGE;
        public const string CURRICULUM = "curriculum";
        public const string CURRICULUM_STAGE_NAME = "curriculumStageName";

        public CurriculumStage ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CurriculumStage (string resourceType = "CurriculumStage", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CurriculumStage> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CurriculumStage");
        	RestGateway gateway = (RestGateway) CurriculumStage.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CurriculumStage> curriculumstageCollection = new ModelCollection<CurriculumStage> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    curriculumstageCollection.add((CurriculumStage) model);
        	}
        
        	return curriculumstageCollection;
        }

        public static CurriculumStage retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CurriculumStage.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CurriculumStage) gateway.retrieve(ResourceType.CURRICULUM_STAGE, id);
        }

        public Curriculum getCurriculum ()
        {
            return (Curriculum) this.getProperty("curriculum");
        }

        public void setCurriculum (Curriculum curriculum)
        {
            this.setProperty("curriculum", curriculum);
        }

        public string getCurriculumStageName ()
        {
            return this.getProperty("curriculumStageName").ToString();
        }

        public void setCurriculumStageName (string curriculumStageName)
        {
            this.setProperty("curriculumStageName", curriculumStageName);
        }


    }
}

