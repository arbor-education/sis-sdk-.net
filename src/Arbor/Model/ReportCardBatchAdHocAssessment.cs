using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatchAdHocAssessment : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_BATCH_AD_HOC_ASSESSMENT;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string AD_HOC_ASSESSMENT = "adHocAssessment";
        public const string ORDER = "order";
        public const string MARKING_COMPLETED_DATETIME = "markingCompletedDatetime";

        public ReportCardBatchAdHocAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardBatchAdHocAssessment (string resourceType = "ReportCardBatchAdHocAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardBatchAdHocAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardBatchAdHocAssessment");
        	RestGateway gateway = (RestGateway) ReportCardBatchAdHocAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardBatchAdHocAssessment> reportcardbatchadhocassessmentCollection = new ModelCollection<ReportCardBatchAdHocAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardbatchadhocassessmentCollection.add((ReportCardBatchAdHocAssessment) model);
        	}
        
        	return reportcardbatchadhocassessmentCollection;
        }

        public static ReportCardBatchAdHocAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardBatchAdHocAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardBatchAdHocAssessment) gateway.retrieve(ResourceType.REPORT_CARD_BATCH_AD_HOC_ASSESSMENT, id);
        }

        public NewReportCardBatch getReportCardBatch ()
        {
            return (NewReportCardBatch) this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch (NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public AdHocAssessment getAdHocAssessment ()
        {
            return (AdHocAssessment) this.getProperty("adHocAssessment");
        }

        public void setAdHocAssessment (AdHocAssessment adHocAssessment)
        {
            this.setProperty("adHocAssessment", adHocAssessment);
        }

        public int getOrder ()
        {
            return Convert.ToInt32(this.getProperty("order"));
        }

        public void setOrder (int order)
        {
            this.setProperty("order", order);
        }

        public DateTime getMarkingCompletedDatetime (){
            return Convert.ToDateTime(this.getProperty("markingCompletedDatetime"));
        }

        public void setMarkingCompletedDatetime (DateTime markingCompletedDatetime)
        {
            this.setProperty("markingCompletedDatetime", markingCompletedDatetime);
        }


    }
}

