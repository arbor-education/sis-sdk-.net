using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LearningMaterial : ModelBase
    {
        protected string resourceType = ResourceType.LEARNING_MATERIAL;
        public const string LEARNING_MATERIAL_FOLDER = "learningMaterialFolder";
        public const string TITLE = "title";
        public const string SUMMARY = "summary";
        public const string URL = "url";
        public const string EDIT_URL = "editUrl";
        public const string THIRD_PARTY_SITE = "thirdPartySite";
        public const string AUTHORED_DATETIME = "authoredDatetime";

        public LearningMaterial ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LearningMaterial (string resourceType = "LearningMaterial", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LearningMaterial> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("LearningMaterial");
        	RestGateway gateway = (RestGateway) LearningMaterial.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LearningMaterial> learningmaterialCollection = new ModelCollection<LearningMaterial> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    learningmaterialCollection.add((LearningMaterial) model);
        	}
        
        	return learningmaterialCollection;
        }

        public static LearningMaterial retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LearningMaterial.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LearningMaterial) gateway.retrieve(ResourceType.LEARNING_MATERIAL, id);
        }

        public LearningMaterialFolder getLearningMaterialFolder ()
        {
            return (LearningMaterialFolder) this.getProperty("learningMaterialFolder");
        }

        public void setLearningMaterialFolder (LearningMaterialFolder learningMaterialFolder)
        {
            this.setProperty("learningMaterialFolder", learningMaterialFolder);
        }

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }

        public string getUrl ()
        {
            return this.getProperty("url").ToString();
        }

        public void setUrl (string url)
        {
            this.setProperty("url", url);
        }

        public string getEditUrl ()
        {
            return this.getProperty("editUrl").ToString();
        }

        public void setEditUrl (string editUrl)
        {
            this.setProperty("editUrl", editUrl);
        }

        public ThirdPartySite getThirdPartySite ()
        {
            return (ThirdPartySite) this.getProperty("thirdPartySite");
        }

        public void setThirdPartySite (ThirdPartySite thirdPartySite)
        {
            this.setProperty("thirdPartySite", thirdPartySite);
        }

        public DateTime getAuthoredDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("authoredDatetime"))
        }

        public void setAuthoredDatetime (DateTime authoredDatetime)
        {
            this.setProperty("authoredDatetime", authoredDatetime);
        }


    }
}

