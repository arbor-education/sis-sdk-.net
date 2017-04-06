using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentCurriculumScore : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_CURRICULUM_SCORE;
        public const string STUDENT = "student";
        public const string CURRICULUM_ENTITY = "curriculumEntity";
        public const string ASSESSMENT_TYPE = "assessmentType";
        public const string ACHIEVEMENT_VALUE_FOR_CURRICULUM_ENTITY = "achievementValueForCurriculumEntity";
        public const string CURRICULUM_MARKED = "curriculumMarked";
        public const string ACHIEVEMENT_VALUE_FOR_CURRICULUM_MARKED = "achievementValueForCurriculumMarked";
        public const string GRADE_POINT_VALUE_FOR_CURRICULUM_MARKED = "gradePointValueForCurriculumMarked";
        public const string CURRICULUM_CONSIDERED = "curriculumConsidered";
        public const string ACHIEVEMENT_VALUE_FOR_CURRICULUM_CONSIDERED = "achievementValueForCurriculumConsidered";
        public const string GRADE_POINT_VALUE_CAP = "gradePointValueCap";
        public const string DATE = "date";

        public StudentCurriculumScore ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentCurriculumScore (string resourceType = "StudentCurriculumScore", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentCurriculumScore> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentCurriculumScore");
        	RestGateway gateway = (RestGateway) StudentCurriculumScore.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentCurriculumScore> studentcurriculumscoreCollection = new ModelCollection<StudentCurriculumScore> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentcurriculumscoreCollection.add((StudentCurriculumScore) model);
        	}
        
        	return studentcurriculumscoreCollection;
        }

        public static StudentCurriculumScore retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentCurriculumScore.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentCurriculumScore) gateway.retrieve(ResourceType.STUDENT_CURRICULUM_SCORE, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public ModelBase getCurriculumEntity ()
        {
            return (ModelBase) this.getProperty("curriculumEntity");
        }

        public void setCurriculumEntity (ModelBase curriculumEntity)
        {
            this.setProperty("curriculumEntity", curriculumEntity);
        }

        public string getAssessmentType ()
        {
            return this.getProperty("assessmentType").ToString();
        }

        public void setAssessmentType (string assessmentType)
        {
            this.setProperty("assessmentType", assessmentType);
        }

        public float getAchievementValueForCurriculumEntity ()
        {
            return (float) this.getProperty("achievementValueForCurriculumEntity");
        }

        public void setAchievementValueForCurriculumEntity (float achievementValueForCurriculumEntity)
        {
            this.setProperty("achievementValueForCurriculumEntity", achievementValueForCurriculumEntity);
        }

        public float getCurriculumMarked ()
        {
            return (float) this.getProperty("curriculumMarked");
        }

        public void setCurriculumMarked (float curriculumMarked)
        {
            this.setProperty("curriculumMarked", curriculumMarked);
        }

        public float getAchievementValueForCurriculumMarked ()
        {
            return (float) this.getProperty("achievementValueForCurriculumMarked");
        }

        public void setAchievementValueForCurriculumMarked (float achievementValueForCurriculumMarked)
        {
            this.setProperty("achievementValueForCurriculumMarked", achievementValueForCurriculumMarked);
        }

        public float getGradePointValueForCurriculumMarked ()
        {
            return (float) this.getProperty("gradePointValueForCurriculumMarked");
        }

        public void setGradePointValueForCurriculumMarked (float gradePointValueForCurriculumMarked)
        {
            this.setProperty("gradePointValueForCurriculumMarked", gradePointValueForCurriculumMarked);
        }

        public float getCurriculumConsidered ()
        {
            return (float) this.getProperty("curriculumConsidered");
        }

        public void setCurriculumConsidered (float curriculumConsidered)
        {
            this.setProperty("curriculumConsidered", curriculumConsidered);
        }

        public float getAchievementValueForCurriculumConsidered ()
        {
            return (float) this.getProperty("achievementValueForCurriculumConsidered");
        }

        public void setAchievementValueForCurriculumConsidered (float achievementValueForCurriculumConsidered)
        {
            this.setProperty("achievementValueForCurriculumConsidered", achievementValueForCurriculumConsidered);
        }

        public float getGradePointValueCap ()
        {
            return (float) this.getProperty("gradePointValueCap");
        }

        public void setGradePointValueCap (float gradePointValueCap)
        {
            this.setProperty("gradePointValueCap", gradePointValueCap);
        }

        public DateTime getDate ()
        {
            return (DateTime) this.getProperty("date");
        }

        public void setDate (DateTime date)
        {
            this.setProperty("date", date);
        }


    }
}

