using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PredictedFinalAssessmentMark : ModelBase
    {
        protected string resourceType = ResourceType.PREDICTED_FINAL_ASSESSMENT_MARK;
        public const string STUDENT = "student";
        public const string ASSESSMENT = "assessment";
        public const string GRADE = "grade";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string STATISTICAL_GRADE_POINT_SCALE_VALUE = "statisticalGradePointScaleValue";
        public const string RECORDED_DATE = "recordedDate";

        public PredictedFinalAssessmentMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PredictedFinalAssessmentMark (string resourceType = "PredictedFinalAssessmentMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PredictedFinalAssessmentMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PredictedFinalAssessmentMark");
        	RestGateway gateway = (RestGateway) PredictedFinalAssessmentMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PredictedFinalAssessmentMark> predictedfinalassessmentmarkCollection = new ModelCollection<PredictedFinalAssessmentMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    predictedfinalassessmentmarkCollection.add((PredictedFinalAssessmentMark) model);
        	}
        
        	return predictedfinalassessmentmarkCollection;
        }

        public static PredictedFinalAssessmentMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PredictedFinalAssessmentMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PredictedFinalAssessmentMark) gateway.retrieve(ResourceType.PREDICTED_FINAL_ASSESSMENT_MARK, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
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

        public DateTime getRecordedDate ()
        {
            return (DateTime) this.getProperty("recordedDate");
        }

        public void setRecordedDate (DateTime recordedDate)
        {
            this.setProperty("recordedDate", recordedDate);
        }


    }
}

