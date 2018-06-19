using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentAspect : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_ASPECT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASSESSMENT = "assessment";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string MARK_TYPE = "markType";
        public const string MARK_MIN_VALUE = "markMinValue";
        public const string MARK_MAX_VALUE = "markMaxValue";
        public const string GRADE_SET = "gradeSet";
        public const string DEFAULT_GRADE_SET = "defaultGradeSet";

        public AssessmentAspect ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentAspect (string resourceType = "AssessmentAspect", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentAspect> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentAspect");
        	RestGateway gateway = (RestGateway) AssessmentAspect.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentAspect> assessmentaspectCollection = new ModelCollection<AssessmentAspect> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentaspectCollection.add((AssessmentAspect) model);
        	}
        
        	return assessmentaspectCollection;
        }

        public static AssessmentAspect retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentAspect.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentAspect) gateway.retrieve(ResourceType.ASSESSMENT_ASPECT, id);
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
            return (bool) this.getProperty("active");
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

        public ModelBase getAssessment ()
        {
            return (ModelBase) this.getProperty("assessment");
        }

        public void setAssessment (ModelBase assessment)
        {
            this.setProperty("assessment", assessment);
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

        public GradeSet getGradeSet ()
        {
            return (GradeSet) this.getProperty("gradeSet");
        }

        public void setGradeSet (GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public GradeSet getDefaultGradeSet ()
        {
            return (GradeSet) this.getProperty("defaultGradeSet");
        }

        public void setDefaultGradeSet (GradeSet defaultGradeSet)
        {
            this.setProperty("defaultGradeSet", defaultGradeSet);
        }


    }
}

