using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitMarksheetCustomReport : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_UNIT_MARKSHEET_CUSTOM_REPORT;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string CUSTOM_REPORT = "customReport";

        public AcademicUnitMarksheetCustomReport()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnitMarksheetCustomReport(string resourceType = "AcademicUnitMarksheetCustomReport", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnitMarksheetCustomReport> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnitMarksheetCustomReport");
            RestGateway gateway = (RestGateway)AcademicUnitMarksheetCustomReport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnitMarksheetCustomReport> academicunitmarksheetcustomreportCollection = new ModelCollection<AcademicUnitMarksheetCustomReport>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitmarksheetcustomreportCollection.add((AcademicUnitMarksheetCustomReport)model);
            }

            return academicunitmarksheetcustomreportCollection;
        }

        public static AcademicUnitMarksheetCustomReport retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnitMarksheetCustomReport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnitMarksheetCustomReport)gateway.retrieve(ResourceType.ACADEMIC_UNIT_MARKSHEET_CUSTOM_REPORT, id);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public CustomReport getCustomReport()
        {
            return (CustomReport)this.getProperty("customReport");
        }

        public void setCustomReport(CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }


    }
}

