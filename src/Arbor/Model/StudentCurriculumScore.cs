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
        public const string CURRICULUM_COMPLETION = "curriculumCompletion";
        public const string PREDICTED_MASTERY = "predictedMastery";
        public const string CURRENT_MASTERY = "currentMastery";
        public const string PREDICTED_GRADE_POINT_VALUE = "predictedGradePointValue";
        public const string CURRENT_GRADE_POINT_VALUE = "currentGradePointValue";
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

        public float getCurriculumCompletion ()
        {
            return (float) this.getProperty("curriculumCompletion");
        }

        public void setCurriculumCompletion (float curriculumCompletion)
        {
            this.setProperty("curriculumCompletion", curriculumCompletion);
        }

        public float getPredictedMastery ()
        {
            return (float) this.getProperty("predictedMastery");
        }

        public void setPredictedMastery (float predictedMastery)
        {
            this.setProperty("predictedMastery", predictedMastery);
        }

        public float getCurrentMastery ()
        {
            return (float) this.getProperty("currentMastery");
        }

        public void setCurrentMastery (float currentMastery)
        {
            this.setProperty("currentMastery", currentMastery);
        }

        public float getPredictedGradePointValue ()
        {
            return (float) this.getProperty("predictedGradePointValue");
        }

        public void setPredictedGradePointValue (float predictedGradePointValue)
        {
            this.setProperty("predictedGradePointValue", predictedGradePointValue);
        }

        public float getCurrentGradePointValue ()
        {
            return (float) this.getProperty("currentGradePointValue");
        }

        public void setCurrentGradePointValue (float currentGradePointValue)
        {
            this.setProperty("currentGradePointValue", currentGradePointValue);
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
            return Convert.ToDateTime(this.getProperty("date"))
        }

        public void setDate (DateTime date)
        {
            this.setProperty("date", date);
        }


    }
}

