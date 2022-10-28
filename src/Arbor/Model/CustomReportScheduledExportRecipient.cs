using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportScheduledExportRecipient : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOM_REPORT_SCHEDULED_EXPORT_RECIPIENT;
        public const string CUSTOM_REPORT_SCHEDULED_EXPORT = "customReportScheduledExport";
        public const string STAFF = "staff";
        public const string EMAIL_ADDRESS = "emailAddress";

        public CustomReportScheduledExportRecipient()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportScheduledExportRecipient(string resourceType = "CustomReportScheduledExportRecipient", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportScheduledExportRecipient> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportScheduledExportRecipient");
            RestGateway gateway = (RestGateway)CustomReportScheduledExportRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportScheduledExportRecipient> customreportscheduledexportrecipientCollection = new ModelCollection<CustomReportScheduledExportRecipient>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportscheduledexportrecipientCollection.add((CustomReportScheduledExportRecipient)model);
            }

            return customreportscheduledexportrecipientCollection;
        }

        public static CustomReportScheduledExportRecipient retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportScheduledExportRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportScheduledExportRecipient)gateway.retrieve(ResourceType.CUSTOM_REPORT_SCHEDULED_EXPORT_RECIPIENT, id);
        }

        public CustomReportScheduledExport getCustomReportScheduledExport()
        {
            return (CustomReportScheduledExport)this.getProperty("customReportScheduledExport");
        }

        public void setCustomReportScheduledExport(CustomReportScheduledExport customReportScheduledExport)
        {
            this.setProperty("customReportScheduledExport", customReportScheduledExport);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public string getEmailAddress()
        {
            return this.getProperty("emailAddress").ToString();
        }

        public void setEmailAddress(string emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }


    }
}

