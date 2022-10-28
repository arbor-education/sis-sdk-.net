using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class FinalAssessmentTarget : ModelBase
    {
        protected new string resourceType = ResourceType.FINAL_ASSESSMENT_TARGET;
        public const string STUDENT = "student";
        public const string ASSESSMENT = "assessment";
        public const string GRADE = "grade";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string STATISTICAL_GRADE_POINT_SCALE_VALUE = "statisticalGradePointScaleValue";
        public const string LOCKED = "locked";

        public FinalAssessmentTarget ()
        {
            base.resourceType = this.resourceType;
        }
        
        public FinalAssessmentTarget (string resourceType = "FinalAssessmentTarget", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<FinalAssessmentTarget> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("FinalAssessmentTarget");
        	RestGateway gateway = (RestGateway) FinalAssessmentTarget.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<FinalAssessmentTarget> finalassessmenttargetCollection = new ModelCollection<FinalAssessmentTarget> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    finalassessmenttargetCollection.add((FinalAssessmentTarget) model);
        	}
        
        	return finalassessmenttargetCollection;
        }

        public static FinalAssessmentTarget retrieve (string id)
        {
            RestGateway gateway = (RestGateway) FinalAssessmentTarget.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (FinalAssessmentTarget) gateway.retrieve(ResourceType.FINAL_ASSESSMENT_TARGET, id);
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

        public bool getLocked ()
        {
            return Convert.ToBoolean(this.getProperty("locked"));
        }

        public void setLocked (bool locked)
        {
            this.setProperty("locked", locked);
        }


    }
}

