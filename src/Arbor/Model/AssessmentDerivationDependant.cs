using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDerivationDependant : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DERIVATION_DEPENDANT;
        public const string ASSESSMENT_DERIVATION = "assessmentDerivation";
        public const string DEPENDANT_ASSESSMENT = "dependantAssessment";
        public const string WEIGHTING = "weighting";

        public AssessmentDerivationDependant ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentDerivationDependant (string resourceType = "AssessmentDerivationDependant", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentDerivationDependant> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentDerivationDependant");
        	RestGateway gateway = (RestGateway) AssessmentDerivationDependant.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentDerivationDependant> assessmentderivationdependantCollection = new ModelCollection<AssessmentDerivationDependant> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentderivationdependantCollection.add((AssessmentDerivationDependant) model);
        	}
        
        	return assessmentderivationdependantCollection;
        }

        public static AssessmentDerivationDependant retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentDerivationDependant.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentDerivationDependant) gateway.retrieve(ResourceType.ASSESSMENT_DERIVATION_DEPENDANT, id);
        }

        public AssessmentDerivation getAssessmentDerivation ()
        {
            return (AssessmentDerivation) this.getProperty("assessmentDerivation");
        }

        public void setAssessmentDerivation (AssessmentDerivation assessmentDerivation)
        {
            this.setProperty("assessmentDerivation", assessmentDerivation);
        }

        public Assessment getDependantAssessment ()
        {
            return (Assessment) this.getProperty("dependantAssessment");
        }

        public void setDependantAssessment (Assessment dependantAssessment)
        {
            this.setProperty("dependantAssessment", dependantAssessment);
        }

        public int getWeighting ()
        {
            return Convert.ToInt32(this.getProperty("weighting"));
        }

        public void setWeighting (int weighting)
        {
            this.setProperty("weighting", weighting);
        }


    }
}

