using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressAssessmentBatchTarget : ModelBase
    {
        protected new string resourceType = ResourceType.PROGRESS_ASSESSMENT_BATCH_TARGET;
        public const string PROGRESS_ASSESSMENT_BATCH = "progressAssessmentBatch";
        public const string TARGET = "target";

        public ProgressAssessmentBatchTarget ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgressAssessmentBatchTarget (string resourceType = "ProgressAssessmentBatchTarget", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgressAssessmentBatchTarget> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgressAssessmentBatchTarget");
        	RestGateway gateway = (RestGateway) ProgressAssessmentBatchTarget.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgressAssessmentBatchTarget> progressassessmentbatchtargetCollection = new ModelCollection<ProgressAssessmentBatchTarget> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    progressassessmentbatchtargetCollection.add((ProgressAssessmentBatchTarget) model);
        	}
        
        	return progressassessmentbatchtargetCollection;
        }

        public static ProgressAssessmentBatchTarget retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgressAssessmentBatchTarget.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgressAssessmentBatchTarget) gateway.retrieve(ResourceType.PROGRESS_ASSESSMENT_BATCH_TARGET, id);
        }

        public ProgressAssessmentBatch getProgressAssessmentBatch ()
        {
            return (ProgressAssessmentBatch) this.getProperty("progressAssessmentBatch");
        }

        public void setProgressAssessmentBatch (ProgressAssessmentBatch progressAssessmentBatch)
        {
            this.setProperty("progressAssessmentBatch", progressAssessmentBatch);
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

