using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InsightReport : ModelBase
    {
        protected string resourceType = ResourceType.INSIGHT_REPORT;
        public const string REPORT_TYPE = "reportType";
        public const string SUB_REPORT_TYPE = "subReportType";
        public const string PERIOD = "period";
        public const string REPORT_TITLE = "reportTitle";
        public const string GENERATED_DATETIME = "generatedDatetime";
        public const string QUEUED_DATETIME = "queuedDatetime";
        public const string REPORT_FILE = "reportFile";

        public InsightReport ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InsightReport (string resourceType = "InsightReport", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InsightReport> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InsightReport");
        	RestGateway gateway = (RestGateway) InsightReport.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InsightReport> insightreportCollection = new ModelCollection<InsightReport> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    insightreportCollection.add((InsightReport) model);
        	}
        
        	return insightreportCollection;
        }

        public static InsightReport retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InsightReport.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InsightReport) gateway.retrieve(ResourceType.INSIGHT_REPORT, id);
        }

        public string getReportType ()
        {
            return this.getProperty("reportType").ToString();
        }

        public void setReportType (string reportType)
        {
            this.setProperty("reportType", reportType);
        }

        public string getSubReportType ()
        {
            return this.getProperty("subReportType").ToString();
        }

        public void setSubReportType (string subReportType)
        {
            this.setProperty("subReportType", subReportType);
        }

        public string getPeriod ()
        {
            return this.getProperty("period").ToString();
        }

        public void setPeriod (string period)
        {
            this.setProperty("period", period);
        }

        public string getReportTitle ()
        {
            return this.getProperty("reportTitle").ToString();
        }

        public void setReportTitle (string reportTitle)
        {
            this.setProperty("reportTitle", reportTitle);
        }

        public DateTime getGeneratedDatetime ()
        {
            Convert.ToDateTime(this.getProperty("generatedDatetime"))
        }

        public void setGeneratedDatetime (DateTime generatedDatetime)
        {
            this.setProperty("generatedDatetime", generatedDatetime);
        }

        public DateTime getQueuedDatetime ()
        {
            Convert.ToDateTime(this.getProperty("queuedDatetime"))
        }

        public void setQueuedDatetime (DateTime queuedDatetime)
        {
            this.setProperty("queuedDatetime", queuedDatetime);
        }

        public File getReportFile ()
        {
            return (File) this.getProperty("reportFile");
        }

        public void setReportFile (File reportFile)
        {
            this.setProperty("reportFile", reportFile);
        }


    }
}

