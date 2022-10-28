using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressAssessmentBatchMeasurementPeriod : ModelBase
    {
        protected new string resourceType = ResourceType.PROGRESS_ASSESSMENT_BATCH_MEASUREMENT_PERIOD;
        public const string PROGRESS_ASSESSMENT_BATCH = "progressAssessmentBatch";
        public const string PROGRESS_MEASUREMENT_PERIOD = "progressMeasurementPeriod";

        public ProgressAssessmentBatchMeasurementPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgressAssessmentBatchMeasurementPeriod (string resourceType = "ProgressAssessmentBatchMeasurementPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgressAssessmentBatchMeasurementPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgressAssessmentBatchMeasurementPeriod");
        	RestGateway gateway = (RestGateway) ProgressAssessmentBatchMeasurementPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgressAssessmentBatchMeasurementPeriod> progressassessmentbatchmeasurementperiodCollection = new ModelCollection<ProgressAssessmentBatchMeasurementPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    progressassessmentbatchmeasurementperiodCollection.add((ProgressAssessmentBatchMeasurementPeriod) model);
        	}
        
        	return progressassessmentbatchmeasurementperiodCollection;
        }

        public static ProgressAssessmentBatchMeasurementPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgressAssessmentBatchMeasurementPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgressAssessmentBatchMeasurementPeriod) gateway.retrieve(ResourceType.PROGRESS_ASSESSMENT_BATCH_MEASUREMENT_PERIOD, id);
        }

        public ProgressAssessmentBatch getProgressAssessmentBatch ()
        {
            return (ProgressAssessmentBatch) this.getProperty("progressAssessmentBatch");
        }

        public void setProgressAssessmentBatch (ProgressAssessmentBatch progressAssessmentBatch)
        {
            this.setProperty("progressAssessmentBatch", progressAssessmentBatch);
        }

        public ProgressMeasurementPeriod getProgressMeasurementPeriod ()
        {
            return (ProgressMeasurementPeriod) this.getProperty("progressMeasurementPeriod");
        }

        public void setProgressMeasurementPeriod (ProgressMeasurementPeriod progressMeasurementPeriod)
        {
            this.setProperty("progressMeasurementPeriod", progressMeasurementPeriod);
        }


    }
}

