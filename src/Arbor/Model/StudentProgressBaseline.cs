using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentProgressBaseline : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_PROGRESS_BASELINE;
        public const string STUDENT = "student";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string ASSESSMENT = "assessment";
        public const string GRADE = "grade";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string STATISTICAL_GRADE_POINT_SCALE_VALUE = "statisticalGradePointScaleValue";
        public const string IS_CALCULATED_GRADE = "isCalculatedGrade";

        public StudentProgressBaseline ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentProgressBaseline (string resourceType = "StudentProgressBaseline", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentProgressBaseline> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentProgressBaseline");
        	RestGateway gateway = (RestGateway) StudentProgressBaseline.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentProgressBaseline> studentprogressbaselineCollection = new ModelCollection<StudentProgressBaseline> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentprogressbaselineCollection.add((StudentProgressBaseline) model);
        	}
        
        	return studentprogressbaselineCollection;
        }

        public static StudentProgressBaseline retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentProgressBaseline.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentProgressBaseline) gateway.retrieve(ResourceType.STUDENT_PROGRESS_BASELINE, id);
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

        public Grade getGrade ()
        {
            return (Grade) this.getProperty("grade");
        }

        public void setGrade (Grade grade)
        {
            this.setProperty("grade", grade);
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

