using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatchProgressAssessment : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_BATCH_PROGRESS_ASSESSMENT;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string ASSESSMENT = "assessment";
        public const string ORDER = "order";
        public const string MARKING_COMPLETED_DATETIME = "markingCompletedDatetime";

        public ReportCardBatchProgressAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardBatchProgressAssessment (string resourceType = "ReportCardBatchProgressAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardBatchProgressAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardBatchProgressAssessment");
        	RestGateway gateway = (RestGateway) ReportCardBatchProgressAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardBatchProgressAssessment> reportcardbatchprogressassessmentCollection = new ModelCollection<ReportCardBatchProgressAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardbatchprogressassessmentCollection.add((ReportCardBatchProgressAssessment) model);
        	}
        
        	return reportcardbatchprogressassessmentCollection;
        }

        public static ReportCardBatchProgressAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardBatchProgressAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardBatchProgressAssessment) gateway.retrieve(ResourceType.REPORT_CARD_BATCH_PROGRESS_ASSESSMENT, id);
        }

        public NewReportCardBatch getReportCardBatch ()
        {
            return (NewReportCardBatch) this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch (NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public int getOrder ()
        {
            return Convert.ToInt32(this.getProperty("order"));
        }

        public void setOrder (int order)
        {
            this.setProperty("order", order);
        }

        public DateTime getMarkingCompletedDatetime ()
        {
            return (DateTime) this.getProperty("markingCompletedDatetime");
        }

        public void setMarkingCompletedDatetime (DateTime markingCompletedDatetime)
        {
            this.setProperty("markingCompletedDatetime", markingCompletedDatetime);
        }


    }
}

