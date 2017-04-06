using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumEvidence : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_EVIDENCE;
        public const string CURRICULUM_GOAL = "curriculumGoal";
        public const string STUDENT = "student";
        public const string ACHIEVEMENT_LEVEL = "achievementLevel";
        public const string EVIDENCE_DATE = "evidenceDate";
        public const string SCHOOLWORK = "schoolwork";
        public const string NARRATIVE = "narrative";

        public CurriculumEvidence ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CurriculumEvidence (string resourceType = "CurriculumEvidence", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CurriculumEvidence> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CurriculumEvidence");
        	RestGateway gateway = (RestGateway) CurriculumEvidence.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CurriculumEvidence> curriculumevidenceCollection = new ModelCollection<CurriculumEvidence> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    curriculumevidenceCollection.add((CurriculumEvidence) model);
        	}
        
        	return curriculumevidenceCollection;
        }

        public static CurriculumEvidence retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CurriculumEvidence.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CurriculumEvidence) gateway.retrieve(ResourceType.CURRICULUM_EVIDENCE, id);
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

        public DateTime getEvidenceDate ()
        {
            return (DateTime) this.getProperty("evidenceDate");
        }

        public void setEvidenceDate (DateTime evidenceDate)
        {
            this.setProperty("evidenceDate", evidenceDate);
        }

        public Schoolwork getSchoolwork ()
        {
            return (Schoolwork) this.getProperty("schoolwork");
        }

        public void setSchoolwork (Schoolwork schoolwork)
        {
            this.setProperty("schoolwork", schoolwork);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

