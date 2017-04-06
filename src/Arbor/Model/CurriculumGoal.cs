using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumGoal : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_GOAL;
        public const string CURRICULUM_SECTION = "curriculumSection";
        public const string CURRICULUM_STAGE = "curriculumStage";
        public const string CURRICULUM_GOAL_NAME = "curriculumGoalName";
        public const string PARENT_CURRICULUM_GOAL = "parentCurriculumGoal";
        public const string ACHIEVEMENT_LEVEL_SET = "achievementLevelSet";

        public CurriculumGoal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CurriculumGoal (string resourceType = "CurriculumGoal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CurriculumGoal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CurriculumGoal");
        	RestGateway gateway = (RestGateway) CurriculumGoal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CurriculumGoal> curriculumgoalCollection = new ModelCollection<CurriculumGoal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    curriculumgoalCollection.add((CurriculumGoal) model);
        	}
        
        	return curriculumgoalCollection;
        }

        public static CurriculumGoal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CurriculumGoal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CurriculumGoal) gateway.retrieve(ResourceType.CURRICULUM_GOAL, id);
        }

        public CurriculumSection getCurriculumSection ()
        {
            return (CurriculumSection) this.getProperty("curriculumSection");
        }

        public void setCurriculumSection (CurriculumSection curriculumSection)
        {
            this.setProperty("curriculumSection", curriculumSection);
        }

        public CurriculumStage getCurriculumStage ()
        {
            return (CurriculumStage) this.getProperty("curriculumStage");
        }

        public void setCurriculumStage (CurriculumStage curriculumStage)
        {
            this.setProperty("curriculumStage", curriculumStage);
        }

        public string getCurriculumGoalName ()
        {
            return this.getProperty("curriculumGoalName").ToString();
        }

        public void setCurriculumGoalName (string curriculumGoalName)
        {
            this.setProperty("curriculumGoalName", curriculumGoalName);
        }

        public CurriculumGoal getParentCurriculumGoal ()
        {
            return (CurriculumGoal) this.getProperty("parentCurriculumGoal");
        }

        public void setParentCurriculumGoal (CurriculumGoal parentCurriculumGoal)
        {
            this.setProperty("parentCurriculumGoal", parentCurriculumGoal);
        }

        public AchievementLevelSet getAchievementLevelSet ()
        {
            return (AchievementLevelSet) this.getProperty("achievementLevelSet");
        }

        public void setAchievementLevelSet (AchievementLevelSet achievementLevelSet)
        {
            this.setProperty("achievementLevelSet", achievementLevelSet);
        }


    }
}

