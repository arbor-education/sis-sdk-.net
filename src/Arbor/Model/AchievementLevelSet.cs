using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AchievementLevelSet : ModelBase
    {
        protected new string resourceType = ResourceType.ACHIEVEMENT_LEVEL_SET;
        public const string CODE = "code";
        public const string NAME = "name";
        public const string ACHIEVED_THRESHOLD = "achievedThreshold";
        public const string TYPE = "type";
        public const string CURRICULUM = "curriculum";

        public AchievementLevelSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AchievementLevelSet (string resourceType = "AchievementLevelSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AchievementLevelSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AchievementLevelSet");
        	RestGateway gateway = (RestGateway) AchievementLevelSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AchievementLevelSet> achievementlevelsetCollection = new ModelCollection<AchievementLevelSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    achievementlevelsetCollection.add((AchievementLevelSet) model);
        	}
        
        	return achievementlevelsetCollection;
        }

        public static AchievementLevelSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AchievementLevelSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AchievementLevelSet) gateway.retrieve(ResourceType.ACHIEVEMENT_LEVEL_SET, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public float getAchievedThreshold ()
        {
            return (float) this.getProperty("achievedThreshold");
        }

        public void setAchievedThreshold (float achievedThreshold)
        {
            this.setProperty("achievedThreshold", achievedThreshold);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public Curriculum getCurriculum ()
        {
            return (Curriculum) this.getProperty("curriculum");
        }

        public void setCurriculum (Curriculum curriculum)
        {
            this.setProperty("curriculum", curriculum);
        }


    }
}

