using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentCurriculumAchievement : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_CURRICULUM_ACHIEVEMENT;
        public const string STUDENT = "student";
        public const string CURRICULUM_STATEMENT = "curriculumStatement";
        public const string ACHIEVEMENT_LEVEL = "achievementLevel";
        public const string ACHIEVEMENT_VALUE = "achievementValue";
        public const string ASSESSMENT_TYPE = "assessmentType";
        public const string ACHIEVEMENT_DATE = "achievementDate";

        public StudentCurriculumAchievement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentCurriculumAchievement (string resourceType = "StudentCurriculumAchievement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentCurriculumAchievement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentCurriculumAchievement");
        	RestGateway gateway = (RestGateway) StudentCurriculumAchievement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentCurriculumAchievement> studentcurriculumachievementCollection = new ModelCollection<StudentCurriculumAchievement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentcurriculumachievementCollection.add((StudentCurriculumAchievement) model);
        	}
        
        	return studentcurriculumachievementCollection;
        }

        public static StudentCurriculumAchievement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentCurriculumAchievement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentCurriculumAchievement) gateway.retrieve(ResourceType.STUDENT_CURRICULUM_ACHIEVEMENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public CurriculumStatement getCurriculumStatement ()
        {
            return (CurriculumStatement) this.getProperty("curriculumStatement");
        }

        public void setCurriculumStatement (CurriculumStatement curriculumStatement)
        {
            this.setProperty("curriculumStatement", curriculumStatement);
        }

        public AchievementLevel getAchievementLevel ()
        {
            return (AchievementLevel) this.getProperty("achievementLevel");
        }

        public void setAchievementLevel (AchievementLevel achievementLevel)
        {
            this.setProperty("achievementLevel", achievementLevel);
        }

        public float getAchievementValue ()
        {
            return (float) this.getProperty("achievementValue");
        }

        public void setAchievementValue (float achievementValue)
        {
            this.setProperty("achievementValue", achievementValue);
        }

        public string getAssessmentType ()
        {
            return this.getProperty("assessmentType").ToString();
        }

        public void setAssessmentType (string assessmentType)
        {
            this.setProperty("assessmentType", assessmentType);
        }

        public DateTime getAchievementDate ()
        {
            return Convert.ToDateTime(this.getProperty("achievementDate"));
        }

        public void setAchievementDate (DateTime achievementDate)
        {
            this.setProperty("achievementDate", achievementDate);
        }


    }
}

