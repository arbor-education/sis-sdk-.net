using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentBatchTarget : ModelBase
    {
        protected new string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_BATCH_TARGET;
        public const string STANDARDIZED_ASSESSMENT_BATCH = "standardizedAssessmentBatch";
        public const string TARGET = "target";

        public StandardizedAssessmentBatchTarget ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StandardizedAssessmentBatchTarget (string resourceType = "StandardizedAssessmentBatchTarget", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StandardizedAssessmentBatchTarget> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StandardizedAssessmentBatchTarget");
        	RestGateway gateway = (RestGateway) StandardizedAssessmentBatchTarget.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StandardizedAssessmentBatchTarget> standardizedassessmentbatchtargetCollection = new ModelCollection<StandardizedAssessmentBatchTarget> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    standardizedassessmentbatchtargetCollection.add((StandardizedAssessmentBatchTarget) model);
        	}
        
        	return standardizedassessmentbatchtargetCollection;
        }

        public static StandardizedAssessmentBatchTarget retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StandardizedAssessmentBatchTarget.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StandardizedAssessmentBatchTarget) gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_BATCH_TARGET, id);
        }

        public StandardizedAssessmentBatch getStandardizedAssessmentBatch ()
        {
            return (StandardizedAssessmentBatch) this.getProperty("standardizedAssessmentBatch");
        }

        public void setStandardizedAssessmentBatch (StandardizedAssessmentBatch standardizedAssessmentBatch)
        {
            this.setProperty("standardizedAssessmentBatch", standardizedAssessmentBatch);
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

