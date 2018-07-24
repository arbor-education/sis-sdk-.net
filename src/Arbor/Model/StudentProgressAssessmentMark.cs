using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentProgressAssessmentMark : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_PROGRESS_ASSESSMENT_MARK;
        public const string STUDENT = "student";
        public const string ASSESSMENT = "assessment";
        public const string PROGRESS_MEASUREMENT_PERIOD = "progressMeasurementPeriod";
        public const string STUDENT_PROGRESS_ASSESSMENT = "studentProgressAssessment";
        public const string GRADE = "grade";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string STATISTICAL_GRADE_POINT_SCALE_VALUE = "statisticalGradePointScaleValue";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string MARKING_STAFF = "markingStaff";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string COMPLETED_STAFF = "completedStaff";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string APPROVED_STAFF = "approvedStaff";

        public StudentProgressAssessmentMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentProgressAssessmentMark (string resourceType = "StudentProgressAssessmentMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentProgressAssessmentMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentProgressAssessmentMark");
        	RestGateway gateway = (RestGateway) StudentProgressAssessmentMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentProgressAssessmentMark> studentprogressassessmentmarkCollection = new ModelCollection<StudentProgressAssessmentMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentprogressassessmentmarkCollection.add((StudentProgressAssessmentMark) model);
        	}
        
        	return studentprogressassessmentmarkCollection;
        }

        public static StudentProgressAssessmentMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentProgressAssessmentMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentProgressAssessmentMark) gateway.retrieve(ResourceType.STUDENT_PROGRESS_ASSESSMENT_MARK, id);
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

        public ProgressMeasurementPeriod getProgressMeasurementPeriod ()
        {
            return (ProgressMeasurementPeriod) this.getProperty("progressMeasurementPeriod");
        }

        public void setProgressMeasurementPeriod (ProgressMeasurementPeriod progressMeasurementPeriod)
        {
            this.setProperty("progressMeasurementPeriod", progressMeasurementPeriod);
        }

        public StudentProgressAssessment getStudentProgressAssessment ()
        {
            return (StudentProgressAssessment) this.getProperty("studentProgressAssessment");
        }

        public void setStudentProgressAssessment (StudentProgressAssessment studentProgressAssessment)
        {
            this.setProperty("studentProgressAssessment", studentProgressAssessment);
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

        public DateTime getAssessmentDate (){
            return Convert.ToDateTime(this.getProperty("assessmentDate"));
        }

        public void setAssessmentDate (DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public Staff getMarkingStaff ()
        {
            return (Staff) this.getProperty("markingStaff");
        }

        public void setMarkingStaff (Staff markingStaff)
        {
            this.setProperty("markingStaff", markingStaff);
        }

        public DateTime getCompletedDatetime (){
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public Staff getCompletedStaff ()
        {
            return (Staff) this.getProperty("completedStaff");
        }

        public void setCompletedStaff (Staff completedStaff)
        {
            this.setProperty("completedStaff", completedStaff);
        }

        public DateTime getApprovedDatetime (){
            return Convert.ToDateTime(this.getProperty("approvedDatetime"));
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }

        public Staff getApprovedStaff ()
        {
            return (Staff) this.getProperty("approvedStaff");
        }

        public void setApprovedStaff (Staff approvedStaff)
        {
            this.setProperty("approvedStaff", approvedStaff);
        }


    }
}

