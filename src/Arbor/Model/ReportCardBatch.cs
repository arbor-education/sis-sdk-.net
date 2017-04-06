using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatch : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_BATCH;
        public const string REPORT_CARD_TEMPLATE = "reportCardTemplate";
        public const string BATCH_NAME = "batchName";
        public const string REPORTING_PERIOD_START_DATE = "reportingPeriodStartDate";
        public const string REPORTING_PERIOD_END_DATE = "reportingPeriodEndDate";
        public const string DUE_DATE = "dueDate";

        public ReportCardBatch ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardBatch (string resourceType = "ReportCardBatch", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardBatch> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardBatch");
        	RestGateway gateway = (RestGateway) ReportCardBatch.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardBatch> reportcardbatchCollection = new ModelCollection<ReportCardBatch> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardbatchCollection.add((ReportCardBatch) model);
        	}
        
        	return reportcardbatchCollection;
        }

        public static ReportCardBatch retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardBatch.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardBatch) gateway.retrieve(ResourceType.REPORT_CARD_BATCH, id);
        }

        public ReportCardTemplate getReportCardTemplate ()
        {
            return (ReportCardTemplate) this.getProperty("reportCardTemplate");
        }

        public void setReportCardTemplate (ReportCardTemplate reportCardTemplate)
        {
            this.setProperty("reportCardTemplate", reportCardTemplate);
        }

        public string getBatchName ()
        {
            return this.getProperty("batchName").ToString();
        }

        public void setBatchName (string batchName)
        {
            this.setProperty("batchName", batchName);
        }

        public DateTime getReportingPeriodStartDate ()
        {
            return (DateTime) this.getProperty("reportingPeriodStartDate");
        }

        public void setReportingPeriodStartDate (DateTime reportingPeriodStartDate)
        {
            this.setProperty("reportingPeriodStartDate", reportingPeriodStartDate);
        }

        public DateTime getReportingPeriodEndDate ()
        {
            return (DateTime) this.getProperty("reportingPeriodEndDate");
        }

        public void setReportingPeriodEndDate (DateTime reportingPeriodEndDate)
        {
            this.setProperty("reportingPeriodEndDate", reportingPeriodEndDate);
        }

        public DateTime getDueDate ()
        {
            return (DateTime) this.getProperty("dueDate");
        }

        public void setDueDate (DateTime dueDate)
        {
            this.setProperty("dueDate", dueDate);
        }


    }
}

