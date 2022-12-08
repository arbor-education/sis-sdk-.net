using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PredictedAssessmentMark : ModelBase
    {
        protected string resourceType = ResourceType.PREDICTED_ASSESSMENT_MARK;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string STUDENT = "student";
        public const string ASSESSMENT = "assessment";
        public const string PROGRESS_MEASUREMENT_PERIOD = "progressMeasurementPeriod";
        public const string GRADE = "grade";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string STATISTICAL_GRADE_POINT_SCALE_VALUE = "statisticalGradePointScaleValue";
        public const string ASSESSMENT_MARK_NON_SUBMISSION_REASON = "assessmentMarkNonSubmissionReason";
        public const string IS_CALCULATED_GRADE = "isCalculatedGrade";

        public PredictedAssessmentMark()
        {
            base.resourceType = this.resourceType;
        }

        public PredictedAssessmentMark(string resourceType = "PredictedAssessmentMark", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PredictedAssessmentMark> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PredictedAssessmentMark");
            RestGateway gateway = (RestGateway)PredictedAssessmentMark.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PredictedAssessmentMark> predictedassessmentmarkCollection = new ModelCollection<PredictedAssessmentMark>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                predictedassessmentmarkCollection.add((PredictedAssessmentMark)model);
            }

            return predictedassessmentmarkCollection;
        }

        public static PredictedAssessmentMark retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PredictedAssessmentMark.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PredictedAssessmentMark)gateway.retrieve(ResourceType.PREDICTED_ASSESSMENT_MARK, id);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public Assessment getAssessment()
        {
            return (Assessment)this.getProperty("assessment");
        }

        public void setAssessment(Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public ProgressMeasurementPeriod getProgressMeasurementPeriod()
        {
            return (ProgressMeasurementPeriod)this.getProperty("progressMeasurementPeriod");
        }

        public void setProgressMeasurementPeriod(ProgressMeasurementPeriod progressMeasurementPeriod)
        {
            this.setProperty("progressMeasurementPeriod", progressMeasurementPeriod);
        }

        public Grade getGrade()
        {
            return (Grade)this.getProperty("grade");
        }

        public void setGrade(Grade grade)
        {
            this.setProperty("grade", grade);
        }

        public float getLowerGradePointScaleValue()
        {
            return (float)this.getProperty("lowerGradePointScaleValue");
        }

        public void setLowerGradePointScaleValue(float lowerGradePointScaleValue)
        {
            this.setProperty("lowerGradePointScaleValue", lowerGradePointScaleValue);
        }

        public float getUpperGradePointScaleValue()
        {
            return (float)this.getProperty("upperGradePointScaleValue");
        }

        public void setUpperGradePointScaleValue(float upperGradePointScaleValue)
        {
            this.setProperty("upperGradePointScaleValue", upperGradePointScaleValue);
        }

        public float getStatisticalGradePointScaleValue()
        {
            return (float)this.getProperty("statisticalGradePointScaleValue");
        }

        public void setStatisticalGradePointScaleValue(float statisticalGradePointScaleValue)
        {
            this.setProperty("statisticalGradePointScaleValue", statisticalGradePointScaleValue);
        }

        public AssessmentMarkNonSubmissionReason getAssessmentMarkNonSubmissionReason()
        {
            return (AssessmentMarkNonSubmissionReason)this.getProperty("assessmentMarkNonSubmissionReason");
        }

        public void setAssessmentMarkNonSubmissionReason(AssessmentMarkNonSubmissionReason assessmentMarkNonSubmissionReason)
        {
            this.setProperty("assessmentMarkNonSubmissionReason", assessmentMarkNonSubmissionReason);
        }

        public bool getIsCalculatedGrade()
        {
            return Convert.ToBoolean(this.getProperty("isCalculatedGrade"));
        }

        public void setIsCalculatedGrade(bool isCalculatedGrade)
        {
            this.setProperty("isCalculatedGrade", isCalculatedGrade);
        }


    }
}

