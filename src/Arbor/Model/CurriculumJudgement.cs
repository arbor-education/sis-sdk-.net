using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumJudgement : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_JUDGEMENT;
        public const string CURRICULUM_GOAL = "curriculumGoal";
        public const string STUDENT = "student";
        public const string ACHIEVEMENT_LEVEL = "achievementLevel";
        public const string OBSERVATION_DATE = "observationDate";
        public const string STARTED_DATETIME = "startedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";

        public CurriculumJudgement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CurriculumJudgement (string resourceType = "CurriculumJudgement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CurriculumJudgement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CurriculumJudgement");
        	RestGateway gateway = (RestGateway) CurriculumJudgement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CurriculumJudgement> curriculumjudgementCollection = new ModelCollection<CurriculumJudgement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    curriculumjudgementCollection.add((CurriculumJudgement) model);
        	}
        
        	return curriculumjudgementCollection;
        }

        public static CurriculumJudgement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CurriculumJudgement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CurriculumJudgement) gateway.retrieve(ResourceType.CURRICULUM_JUDGEMENT, id);
        }

        public CurriculumGoal getCurriculumGoal ()
        {
            return (CurriculumGoal) this.getProperty("curriculumGoal");
        }

        public void setCurriculumGoal (CurriculumGoal curriculumGoal)
        {
            this.setProperty("curriculumGoal", curriculumGoal);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public AchievementLevel getAchievementLevel ()
        {
            return (AchievementLevel) this.getProperty("achievementLevel");
        }

        public void setAchievementLevel (AchievementLevel achievementLevel)
        {
            this.setProperty("achievementLevel", achievementLevel);
        }

        public DateTime getObservationDate ()
        {
            return (DateTime) this.getProperty("observationDate");
        }

        public void setObservationDate (DateTime observationDate)
        {
            this.setProperty("observationDate", observationDate);
        }

        public DateTime getStartedDatetime ()
        {
            return (DateTime) this.getProperty("startedDatetime");
        }

        public void setStartedDatetime (DateTime startedDatetime)
        {
            this.setProperty("startedDatetime", startedDatetime);
        }

        public DateTime getCompletedDatetime ()
        {
            return (DateTime) this.getProperty("completedDatetime");
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }


    }
}

