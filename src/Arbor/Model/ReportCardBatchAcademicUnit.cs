using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatchAcademicUnit : ModelBase
    {
        protected new string resourceType = ResourceType.REPORT_CARD_BATCH_ACADEMIC_UNIT;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string ORDER = "order";
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string MARKING_COMPLETED_DATETIME = "markingCompletedDatetime";

        public ReportCardBatchAcademicUnit()
        {
            base.resourceType = this.resourceType;
        }

        public ReportCardBatchAcademicUnit(string resourceType = "ReportCardBatchAcademicUnit", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ReportCardBatchAcademicUnit> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ReportCardBatchAcademicUnit");
            RestGateway gateway = (RestGateway)ReportCardBatchAcademicUnit.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ReportCardBatchAcademicUnit> reportcardbatchacademicunitCollection = new ModelCollection<ReportCardBatchAcademicUnit>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                reportcardbatchacademicunitCollection.add((ReportCardBatchAcademicUnit)model);
            }

            return reportcardbatchacademicunitCollection;
        }

        public static ReportCardBatchAcademicUnit retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ReportCardBatchAcademicUnit.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ReportCardBatchAcademicUnit)gateway.retrieve(ResourceType.REPORT_CARD_BATCH_ACADEMIC_UNIT, id);
        }

        public NewReportCardBatch getReportCardBatch()
        {
            return (NewReportCardBatch)this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch(NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public int getOrder()
        {
            return Convert.ToInt32(this.getProperty("order"));
        }

        public void setOrder(int order)
        {
            this.setProperty("order", order);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public DateTime getMarkingCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("markingCompletedDatetime"));
        }

        public void setMarkingCompletedDatetime(DateTime markingCompletedDatetime)
        {
            this.setProperty("markingCompletedDatetime", markingCompletedDatetime);
        }


    }
}

