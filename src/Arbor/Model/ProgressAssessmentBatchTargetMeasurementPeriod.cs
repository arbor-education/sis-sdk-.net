using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressAssessmentBatchTargetMeasurementPeriod : ModelBase
    {
        protected string resourceType = ResourceType.PROGRESS_ASSESSMENT_BATCH_TARGET_MEASUREMENT_PERIOD;
        public const string PROGRESS_ASSESSMENT_BATCH_TARGET = "progressAssessmentBatchTarget";
        public const string PROGRESS_MEASUREMENT_PERIOD = "progressMeasurementPeriod";
        public const string MARKING_STARTED_DATETIME = "markingStartedDatetime";
        public const string MARKING_COMPLETED_DATETIME = "markingCompletedDatetime";
        public const string MARKING_FINALIZED_DATETIME = "markingFinalizedDatetime";

        public ProgressAssessmentBatchTargetMeasurementPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgressAssessmentBatchTargetMeasurementPeriod (string resourceType = "ProgressAssessmentBatchTargetMeasurementPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgressAssessmentBatchTargetMeasurementPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgressAssessmentBatchTargetMeasurementPeriod");
        	RestGateway gateway = (RestGateway) ProgressAssessmentBatchTargetMeasurementPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgressAssessmentBatchTargetMeasurementPeriod> progressassessmentbatchtargetmeasurementperiodCollection = new ModelCollection<ProgressAssessmentBatchTargetMeasurementPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    progressassessmentbatchtargetmeasurementperiodCollection.add((ProgressAssessmentBatchTargetMeasurementPeriod) model);
        	}
        
        	return progressassessmentbatchtargetmeasurementperiodCollection;
        }

        public static ProgressAssessmentBatchTargetMeasurementPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgressAssessmentBatchTargetMeasurementPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgressAssessmentBatchTargetMeasurementPeriod) gateway.retrieve(ResourceType.PROGRESS_ASSESSMENT_BATCH_TARGET_MEASUREMENT_PERIOD, id);
        }

        public ProgressAssessmentBatchTarget getProgressAssessmentBatchTarget ()
        {
            return (ProgressAssessmentBatchTarget) this.getProperty("progressAssessmentBatchTarget");
        }

        public void setProgressAssessmentBatchTarget (ProgressAssessmentBatchTarget progressAssessmentBatchTarget)
        {
            this.setProperty("progressAssessmentBatchTarget", progressAssessmentBatchTarget);
        }

        public ProgressMeasurementPeriod getProgressMeasurementPeriod ()
        {
            return (ProgressMeasurementPeriod) this.getProperty("progressMeasurementPeriod");
        }

        public void setProgressMeasurementPeriod (ProgressMeasurementPeriod progressMeasurementPeriod)
        {
            this.setProperty("progressMeasurementPeriod", progressMeasurementPeriod);
        }

        public DateTime getMarkingStartedDatetime ()
        {
            return (DateTime) this.getProperty("markingStartedDatetime");
        }

        public void setMarkingStartedDatetime (DateTime markingStartedDatetime)
        {
            this.setProperty("markingStartedDatetime", markingStartedDatetime);
        }

        public DateTime getMarkingCompletedDatetime ()
        {
            return (DateTime) this.getProperty("markingCompletedDatetime");
        }

        public void setMarkingCompletedDatetime (DateTime markingCompletedDatetime)
        {
            this.setProperty("markingCompletedDatetime", markingCompletedDatetime);
        }

        public DateTime getMarkingFinalizedDatetime ()
        {
            return (DateTime) this.getProperty("markingFinalizedDatetime");
        }

        public void setMarkingFinalizedDatetime (DateTime markingFinalizedDatetime)
        {
            this.setProperty("markingFinalizedDatetime", markingFinalizedDatetime);
        }


    }
}

