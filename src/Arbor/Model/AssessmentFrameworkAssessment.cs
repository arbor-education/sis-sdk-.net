using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentFrameworkAssessment : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_FRAMEWORK_ASSESSMENT;
        public const string ASSESSMENT = "assessment";
        public const string STEPS_COMPLETED = "stepsCompleted";
        public const string SETUP_COMPLETED = "setupCompleted";

        public AssessmentFrameworkAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentFrameworkAssessment (string resourceType = "AssessmentFrameworkAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentFrameworkAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentFrameworkAssessment");
        	RestGateway gateway = (RestGateway) AssessmentFrameworkAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentFrameworkAssessment> assessmentframeworkassessmentCollection = new ModelCollection<AssessmentFrameworkAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentframeworkassessmentCollection.add((AssessmentFrameworkAssessment) model);
        	}
        
        	return assessmentframeworkassessmentCollection;
        }

        public static AssessmentFrameworkAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentFrameworkAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentFrameworkAssessment) gateway.retrieve(ResourceType.ASSESSMENT_FRAMEWORK_ASSESSMENT, id);
        }

        public ModelBase getAssessment ()
        {
            return (ModelBase) this.getProperty("assessment");
        }

        public void setAssessment (ModelBase assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public int getStepsCompleted ()
        {
            return Convert.ToInt32(this.getProperty("stepsCompleted"));
        }

        public void setStepsCompleted (int stepsCompleted)
        {
            this.setProperty("stepsCompleted", stepsCompleted);
        }

        public bool getSetupCompleted ()
        {
            return Convert.ToBoolean(this.getProperty("setupCompleted"));
        }

        public void setSetupCompleted (bool setupCompleted)
        {
            this.setProperty("setupCompleted", setupCompleted);
        }


    }
}

