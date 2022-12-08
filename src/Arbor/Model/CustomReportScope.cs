using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportScope : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_SCOPE;
        public const string CUSTOM_REPORT = "customReport";
        public const string BASE_ENTITY_TYPE = "baseEntityType";
        public const string REFERENCE_DATE_RANGE_START_DATE = "referenceDateRangeStartDate";
        public const string REFERENCE_DATE_RANGE_END_DATE = "referenceDateRangeEndDate";
        public const string REFERENCE_DATE_RANGE_PERIOD_TYPE = "referenceDateRangePeriodType";
        public const string REFERENCE_DATE_RANGE_PERIOD_COUNT = "referenceDateRangePeriodCount";
        public const string REFERENCE_DATE_RANGE_PERIOD_OFFSET = "referenceDateRangePeriodOffset";

        public CustomReportScope()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportScope(string resourceType = "CustomReportScope", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportScope> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportScope");
            RestGateway gateway = (RestGateway)CustomReportScope.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportScope> customreportscopeCollection = new ModelCollection<CustomReportScope>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportscopeCollection.add((CustomReportScope)model);
            }

            return customreportscopeCollection;
        }

        public static CustomReportScope retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportScope.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportScope)gateway.retrieve(ResourceType.CUSTOM_REPORT_SCOPE, id);
        }

        public CustomReport getCustomReport()
        {
            return (CustomReport)this.getProperty("customReport");
        }

        public void setCustomReport(CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public int getBaseEntityType()
        {
            return Convert.ToInt32(this.getProperty("baseEntityType"));
        }

        public void setBaseEntityType(int baseEntityType)
        {
            this.setProperty("baseEntityType", baseEntityType);
        }

        public DateTime getReferenceDateRangeStartDate()
        {
            return Convert.ToDateTime(this.getProperty("referenceDateRangeStartDate"));
        }

        public void setReferenceDateRangeStartDate(DateTime referenceDateRangeStartDate)
        {
            this.setProperty("referenceDateRangeStartDate", referenceDateRangeStartDate);
        }

        public DateTime getReferenceDateRangeEndDate()
        {
            return Convert.ToDateTime(this.getProperty("referenceDateRangeEndDate"));
        }

        public void setReferenceDateRangeEndDate(DateTime referenceDateRangeEndDate)
        {
            this.setProperty("referenceDateRangeEndDate", referenceDateRangeEndDate);
        }

        public string getReferenceDateRangePeriodType()
        {
            return this.getProperty("referenceDateRangePeriodType").ToString();
        }

        public void setReferenceDateRangePeriodType(string referenceDateRangePeriodType)
        {
            this.setProperty("referenceDateRangePeriodType", referenceDateRangePeriodType);
        }

        public int getReferenceDateRangePeriodCount()
        {
            return Convert.ToInt32(this.getProperty("referenceDateRangePeriodCount"));
        }

        public void setReferenceDateRangePeriodCount(int referenceDateRangePeriodCount)
        {
            this.setProperty("referenceDateRangePeriodCount", referenceDateRangePeriodCount);
        }

        public int getReferenceDateRangePeriodOffset()
        {
            return Convert.ToInt32(this.getProperty("referenceDateRangePeriodOffset"));
        }

        public void setReferenceDateRangePeriodOffset(int referenceDateRangePeriodOffset)
        {
            this.setProperty("referenceDateRangePeriodOffset", referenceDateRangePeriodOffset);
        }


    }
}

