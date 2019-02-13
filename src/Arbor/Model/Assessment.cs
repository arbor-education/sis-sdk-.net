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
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASSESSMENT_NAME = "assessmentName";
        public const string ASSESSMENT_SHORT_NAME = "assessmentShortName";
        public const string USER_DEFINED_NAME = "userDefinedName";
        public const string USER_DEFINED_SHORT_NAME = "userDefinedShortName";
        public const string SUBJECT = "subject";
        public const string CURRICULUM_TIER = "curriculumTier";
        public const string GRADE_POINT_SCALE = "gradePointScale";
        public const string STUDENT_PROGRESS_BASELINE_CALCULATOR_CLASS_NAME = "studentProgressBaselineCalculatorClassName";

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

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"))
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
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

        public string getUserDefinedName ()
        {
            return this.getProperty("userDefinedName").ToString();
        }

        public void setUserDefinedName (string userDefinedName)
        {
            this.setProperty("userDefinedName", userDefinedName);
        }

        public string getUserDefinedShortName ()
        {
            return this.getProperty("userDefinedShortName").ToString();
        }

        public void setUserDefinedShortName (string userDefinedShortName)
        {
            this.setProperty("userDefinedShortName", userDefinedShortName);
        }

        public Subject getSubject ()
        {
            return (Subject) this.getProperty("subject");
        }

        public void setSubject (Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public CurriculumTier getCurriculumTier ()
        {
            return (CurriculumTier) this.getProperty("curriculumTier");
        }

        public void setCurriculumTier (CurriculumTier curriculumTier)
        {
            this.setProperty("curriculumTier", curriculumTier);
        }

        public GradePointScale getGradePointScale ()
        {
            return (GradePointScale) this.getProperty("gradePointScale");
        }

        public void setGradePointScale (GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
        }

        public string getStudentProgressBaselineCalculatorClassName ()
        {
            return this.getProperty("studentProgressBaselineCalculatorClassName").ToString();
        }

        public void setStudentProgressBaselineCalculatorClassName (string studentProgressBaselineCalculatorClassName)
        {
            this.setProperty("studentProgressBaselineCalculatorClassName", studentProgressBaselineCalculatorClassName);
        }


    }
}

