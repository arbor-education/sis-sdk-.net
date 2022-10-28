using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportScheduledExportReport : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOM_REPORT_SCHEDULED_EXPORT_REPORT;
        public const string CUSTOM_REPORT_SCHEDULED_EXPORT = "customReportScheduledExport";
        public const string CUSTOM_REPORT = "customReport";
        public const string EXPORT_FORMAT = "exportFormat";
        public const string SCHEDULED_TIME = "scheduledTime";

        public CustomReportScheduledExportReport ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomReportScheduledExportReport (string resourceType = "CustomReportScheduledExportReport", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomReportScheduledExportReport> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomReportScheduledExportReport");
        	RestGateway gateway = (RestGateway) CustomReportScheduledExportReport.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomReportScheduledExportReport> customreportscheduledexportreportCollection = new ModelCollection<CustomReportScheduledExportReport> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customreportscheduledexportreportCollection.add((CustomReportScheduledExportReport) model);
        	}
        
        	return customreportscheduledexportreportCollection;
        }

        public static CustomReportScheduledExportReport retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomReportScheduledExportReport.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomReportScheduledExportReport) gateway.retrieve(ResourceType.CUSTOM_REPORT_SCHEDULED_EXPORT_REPORT, id);
        }

        public CustomReportScheduledExport getCustomReportScheduledExport ()
        {
            return (CustomReportScheduledExport) this.getProperty("customReportScheduledExport");
        }

        public void setCustomReportScheduledExport (CustomReportScheduledExport customReportScheduledExport)
        {
            this.setProperty("customReportScheduledExport", customReportScheduledExport);
        }

        public CustomReport getCustomReport ()
        {
            return (CustomReport) this.getProperty("customReport");
        }

        public void setCustomReport (CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public string getExportFormat ()
        {
            return this.getProperty("exportFormat").ToString();
        }

        public void setExportFormat (string exportFormat)
        {
            this.setProperty("exportFormat", exportFormat);
        }

        public string getScheduledTime ()
        {
            return this.getProperty("scheduledTime").ToString();
        }

        public void setScheduledTime (string scheduledTime)
        {
            this.setProperty("scheduledTime", scheduledTime);
        }


    }
}

