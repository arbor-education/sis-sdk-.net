using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDerivation : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DERIVATION;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASSESSMENT = "assessment";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string CALCULATOR_CLASS = "calculatorClass";

        public AssessmentDerivation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentDerivation (string resourceType = "AssessmentDerivation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentDerivation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentDerivation");
        	RestGateway gateway = (RestGateway) AssessmentDerivation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentDerivation> assessmentderivationCollection = new ModelCollection<AssessmentDerivation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentderivationCollection.add((AssessmentDerivation) model);
        	}
        
        	return assessmentderivationCollection;
        }

        public static AssessmentDerivation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentDerivation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentDerivation) gateway.retrieve(ResourceType.ASSESSMENT_DERIVATION, id);
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

        public ModelBase getAssessment ()
        {
            return (ModelBase) this.getProperty("assessment");
        }

        public void setAssessment (ModelBase assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getCalculatorClass ()
        {
            return this.getProperty("calculatorClass").ToString();
        }

        public void setCalculatorClass (string calculatorClass)
        {
            this.setProperty("calculatorClass", calculatorClass);
        }


    }
}

