using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentBatchTarget : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_BATCH_TARGET;
        public const string ASSESSMENT_BATCH = "assessmentBatch";
        public const string TARGET = "target";

        public AssessmentBatchTarget ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentBatchTarget (string resourceType = "AssessmentBatchTarget", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentBatchTarget> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentBatchTarget");
        	RestGateway gateway = (RestGateway) AssessmentBatchTarget.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentBatchTarget> assessmentbatchtargetCollection = new ModelCollection<AssessmentBatchTarget> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentbatchtargetCollection.add((AssessmentBatchTarget) model);
        	}
        
        	return assessmentbatchtargetCollection;
        }

        public static AssessmentBatchTarget retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentBatchTarget.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentBatchTarget) gateway.retrieve(ResourceType.ASSESSMENT_BATCH_TARGET, id);
        }

        public AssessmentBatch getAssessmentBatch ()
        {
            return (AssessmentBatch) this.getProperty("assessmentBatch");
        }

        public void setAssessmentBatch (AssessmentBatch assessmentBatch)
        {
            this.setProperty("assessmentBatch", assessmentBatch);
        }

        public ModelBase getTarget ()
        {
            return (ModelBase) this.getProperty("target");
        }

        public void setTarget (ModelBase target)
        {
            this.setProperty("target", target);
        }


    }
}

