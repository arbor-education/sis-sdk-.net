using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LearningMaterialFolder : ModelBase
    {
        protected string resourceType = ResourceType.LEARNING_MATERIAL_FOLDER;
        public const string PARENT_LEARNING_MATERIAL_FOLDER = "parentLearningMaterialFolder";
        public const string NAME = "name";

        public LearningMaterialFolder ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LearningMaterialFolder (string resourceType = "LearningMaterialFolder", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LearningMaterialFolder> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("LearningMaterialFolder");
        	RestGateway gateway = (RestGateway) LearningMaterialFolder.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LearningMaterialFolder> learningmaterialfolderCollection = new ModelCollection<LearningMaterialFolder> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    learningmaterialfolderCollection.add((LearningMaterialFolder) model);
        	}
        
        	return learningmaterialfolderCollection;
        }

        public static LearningMaterialFolder retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LearningMaterialFolder.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LearningMaterialFolder) gateway.retrieve(ResourceType.LEARNING_MATERIAL_FOLDER, id);
        }

        public LearningMaterialFolder getParentLearningMaterialFolder ()
        {
            return (LearningMaterialFolder) this.getProperty("parentLearningMaterialFolder");
        }

        public void setParentLearningMaterialFolder (LearningMaterialFolder parentLearningMaterialFolder)
        {
            this.setProperty("parentLearningMaterialFolder", parentLearningMaterialFolder);
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

