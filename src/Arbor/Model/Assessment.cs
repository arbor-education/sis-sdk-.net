using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Assessment : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT;
        public const string ASSESSMENT_NAME = "assessmentName";
        public const string ASSESSMENT_SHORT_NAME = "assessmentShortName";
        public const string PARENT_ASSESSMENT = "parentAssessment";
        public const string ASSESSMENT_CODE = "assessmentCode";
        public const string STUDENT_PROGRESS_BASELINE_CALCULATOR_CLASS_NAME = "studentProgressBaselineCalculatorClassName";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string MARK_TYPE = "markType";
        public const string SUBJECT = "subject";
        public const string GRADE_POINT_SCALE = "gradePointScale";
        public const string MARK_MIN_VALUE = "markMinValue";
        public const string MARK_MAX_VALUE = "markMaxValue";

        public Assessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Assessment (string resourceType = "Assessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Assessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Assessment");
        	RestGateway gateway = (RestGateway) Assessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Assessment> assessmentCollection = new ModelCollection<Assessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentCollection.add((Assessment) model);
        	}
        
        	return assessmentCollection;
        }

        public static Assessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Assessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Assessment) gateway.retrieve(ResourceType.ASSESSMENT, id);
        }

        public string getAssessmentName ()
        {
            return this.getProperty("assessmentName").ToString();
        }

        public void setAssessmentName (string assessmentName)
        {
            this.setProperty("assessmentName", assessmentName);
        }

        public string getAssessmentShortName ()
        {
            return this.getProperty("assessmentShortName").ToString();
        }

        public void setAssessmentShortName (string assessmentShortName)
        {
            this.setProperty("assessmentShortName", assessmentShortName);
        }

        public Assessment getParentAssessment ()
        {
            return (Assessment) this.getProperty("parentAssessment");
        }

        public void setParentAssessment (Assessment parentAssessment)
        {
            this.setProperty("parentAssessment", parentAssessment);
        }

        public string getAssessmentCode ()
        {
            return this.getProperty("assessmentCode").ToString();
        }

        public void setAssessmentCode (string assessmentCode)
        {
            this.setProperty("assessmentCode", assessmentCode);
        }

        public string getStudentProgressBaselineCalculatorClassName ()
        {
            return this.getProperty("studentProgressBaselineCalculatorClassName").ToString();
        }

        public void setStudentProgressBaselineCalculatorClassName (string studentProgressBaselineCalculatorClassName)
        {
            this.setProperty("studentProgressBaselineCalculatorClassName", studentProgressBaselineCalculatorClassName);
        }

        public DateTime getEffectiveDate ()
        {
            return (DateTime) this.getProperty("effectiveDate");
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getMarkType ()
        {
            return this.getProperty("markType").ToString();
        }

        public void setMarkType (string markType)
        {
            this.setProperty("markType", markType);
        }

        public Subject getSubject ()
        {
            return (Subject) this.getProperty("subject");
        }

        public void setSubject (Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public GradePointScale getGradePointScale ()
        {
            return (GradePointScale) this.getProperty("gradePointScale");
        }

        public void setGradePointScale (GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
        }

        public float getMarkMinValue ()
        {
            return (float) this.getProperty("markMinValue");
        }

        public void setMarkMinValue (float markMinValue)
        {
            this.setProperty("markMinValue", markMinValue);
        }

        public float getMarkMaxValue ()
        {
            return (float) this.getProperty("markMaxValue");
        }

        public void setMarkMaxValue (float markMaxValue)
        {
            this.setProperty("markMaxValue", markMaxValue);
        }


    }
}

