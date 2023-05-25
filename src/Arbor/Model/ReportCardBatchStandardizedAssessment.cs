using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatchStandardizedAssessment : ModelBase
    {
        protected new string resourceType = ResourceType.REPORT_CARD_BATCH_STANDARDIZED_ASSESSMENT;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string STANDARDIZED_ASSESSMENT = "standardizedAssessment";
        public const string ORDER = "order";

        public ReportCardBatchStandardizedAssessment()
        {
            base.resourceType = this.resourceType;
        }

        public ReportCardBatchStandardizedAssessment(string resourceType = "ReportCardBatchStandardizedAssessment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ReportCardBatchStandardizedAssessment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ReportCardBatchStandardizedAssessment");
            RestGateway gateway = (RestGateway)ReportCardBatchStandardizedAssessment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ReportCardBatchStandardizedAssessment> reportcardbatchstandardizedassessmentCollection = new ModelCollection<ReportCardBatchStandardizedAssessment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                reportcardbatchstandardizedassessmentCollection.add((ReportCardBatchStandardizedAssessment)model);
            }

            return reportcardbatchstandardizedassessmentCollection;
        }

        public static ReportCardBatchStandardizedAssessment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ReportCardBatchStandardizedAssessment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ReportCardBatchStandardizedAssessment)gateway.retrieve(ResourceType.REPORT_CARD_BATCH_STANDARDIZED_ASSESSMENT, id);
        }

        public NewReportCardBatch getReportCardBatch()
        {
            return (NewReportCardBatch)this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch(NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public StandardizedAssessment getStandardizedAssessment()
        {
            return (StandardizedAssessment)this.getProperty("standardizedAssessment");
        }

        public void setStandardizedAssessment(StandardizedAssessment standardizedAssessment)
        {
            this.setProperty("standardizedAssessment", standardizedAssessment);
        }

        public int getOrder()
        {
            return Convert.ToInt32(this.getProperty("order"));
        }

        public void setOrder(int order)
        {
            this.setProperty("order", order);
        }


    }
}

