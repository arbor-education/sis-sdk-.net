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
        public const string ASSESSMENT = "assessment";
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

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
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

