using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LessonPlanObjective : ModelBase
    {
        protected new string resourceType = ResourceType.LESSON_PLAN_OBJECTIVE;
        public const string OBJECTIVE_TITLE = "objectiveTitle";
        public const string OBJECTIVE_DESCRIPTION = "objectiveDescription";
        public const string CURRICULUM_STATEMENT = "curriculumStatement";

        public LessonPlanObjective ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LessonPlanObjective (string resourceType = "LessonPlanObjective", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LessonPlanObjective> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("LessonPlanObjective");
        	RestGateway gateway = (RestGateway) LessonPlanObjective.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LessonPlanObjective> lessonplanobjectiveCollection = new ModelCollection<LessonPlanObjective> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    lessonplanobjectiveCollection.add((LessonPlanObjective) model);
        	}
        
        	return lessonplanobjectiveCollection;
        }

        public static LessonPlanObjective retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LessonPlanObjective.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LessonPlanObjective) gateway.retrieve(ResourceType.LESSON_PLAN_OBJECTIVE, id);
        }

        public string getObjectiveTitle ()
        {
            return this.getProperty("objectiveTitle").ToString();
        }

        public void setObjectiveTitle (string objectiveTitle)
        {
            this.setProperty("objectiveTitle", objectiveTitle);
        }

        public string getObjectiveDescription ()
        {
            return this.getProperty("objectiveDescription").ToString();
        }

        public void setObjectiveDescription (string objectiveDescription)
        {
            this.setProperty("objectiveDescription", objectiveDescription);
        }

        public CurriculumStatement getCurriculumStatement ()
        {
            return (CurriculumStatement) this.getProperty("curriculumStatement");
        }

        public void setCurriculumStatement (CurriculumStatement curriculumStatement)
        {
            this.setProperty("curriculumStatement", curriculumStatement);
        }


    }
}

