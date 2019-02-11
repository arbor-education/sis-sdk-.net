using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentProgressGoal : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_PROGRESS_GOAL;
        public const string STUDENT = "student";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string ASSESSMENT = "assessment";
        public const string GOAL_TYPE = "goalType";
        public const string GRADE = "grade";
        public const string PROGRESS_MEASUREMENT_PERIOD = "progressMeasurementPeriod";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string STATISTICAL_GRADE_POINT_SCALE_VALUE = "statisticalGradePointScaleValue";
        public const string IS_CALCULATED_GRADE = "isCalculatedGrade";

        public StudentProgressGoal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentProgressGoal (string resourceType = "StudentProgressGoal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentProgressGoal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentProgressGoal");
        	RestGateway gateway = (RestGateway) StudentProgressGoal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentProgressGoal> studentprogressgoalCollection = new ModelCollection<StudentProgressGoal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentprogressgoalCollection.add((StudentProgressGoal) model);
        	}
        
        	return studentprogressgoalCollection;
        }

        public static StudentProgressGoal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentProgressGoal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentProgressGoal) gateway.retrieve(ResourceType.STUDENT_PROGRESS_GOAL, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public string getGoalType ()
        {
            return this.getProperty("goalType").ToString();
        }

        public void setGoalType (string goalType)
        {
            this.setProperty("goalType", goalType);
        }

        public Grade getGrade ()
        {
            return (Grade) this.getProperty("grade");
        }

        public void setGrade (Grade grade)
        {
            this.setProperty("grade", grade);
        }

        public ProgressMeasurementPeriod getProgressMeasurementPeriod ()
        {
            return (ProgressMeasurementPeriod) this.getProperty("progressMeasurementPeriod");
        }

        public void setProgressMeasurementPeriod (ProgressMeasurementPeriod progressMeasurementPeriod)
        {
            this.setProperty("progressMeasurementPeriod", progressMeasurementPeriod);
        }

        public float getLowerGradePointScaleValue ()
        {
            return (float) this.getProperty("lowerGradePointScaleValue");
        }

        public void setLowerGradePointScaleValue (float lowerGradePointScaleValue)
        {
            this.setProperty("lowerGradePointScaleValue", lowerGradePointScaleValue);
        }

        public float getUpperGradePointScaleValue ()
        {
            return (float) this.getProperty("upperGradePointScaleValue");
        }

        public void setUpperGradePointScaleValue (float upperGradePointScaleValue)
        {
            this.setProperty("upperGradePointScaleValue", upperGradePointScaleValue);
        }

        public float getStatisticalGradePointScaleValue ()
        {
            return (float) this.getProperty("statisticalGradePointScaleValue");
        }

        public void setStatisticalGradePointScaleValue (float statisticalGradePointScaleValue)
        {
            this.setProperty("statisticalGradePointScaleValue", statisticalGradePointScaleValue);
        }

        public bool getIsCalculatedGrade ()
        {
            return Convert.ToBoolean( this.getProperty("isCalculatedGrade"));
        }

        public void setIsCalculatedGrade (bool isCalculatedGrade)
        {
            this.setProperty("isCalculatedGrade", isCalculatedGrade);
        }


    }
}

