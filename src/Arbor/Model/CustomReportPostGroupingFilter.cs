using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportPostGroupingFilter : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_POST_GROUPING_FILTER;
        public const string CUSTOM_REPORT = "customReport";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string CONDITION_CLASS = "conditionClass";
        public const string CONDITION_PARAMS = "conditionParams";
        public const string TARGET_GROUPING = "targetGrouping";
        public const string FILTER_GROUP_INDEX = "filterGroupIndex";

        public CustomReportPostGroupingFilter()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportPostGroupingFilter(string resourceType = "CustomReportPostGroupingFilter", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportPostGroupingFilter> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportPostGroupingFilter");
            RestGateway gateway = (RestGateway)CustomReportPostGroupingFilter.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportPostGroupingFilter> customreportpostgroupingfilterCollection = new ModelCollection<CustomReportPostGroupingFilter>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportpostgroupingfilterCollection.add((CustomReportPostGroupingFilter)model);
            }

            return customreportpostgroupingfilterCollection;
        }

        public static CustomReportPostGroupingFilter retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportPostGroupingFilter.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportPostGroupingFilter)gateway.retrieve(ResourceType.CUSTOM_REPORT_POST_GROUPING_FILTER, id);
        }

        public CustomReport getCustomReport()
        {
            return (CustomReport)this.getProperty("customReport");
        }

        public void setCustomReport(CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public string getFieldClass()
        {
            return this.getProperty("fieldClass").ToString();
        }

        public void setFieldClass(string fieldClass)
        {
            this.setProperty("fieldClass", fieldClass);
        }

        public string getFieldParams()
        {
            return this.getProperty("fieldParams").ToString();
        }

        public void setFieldParams(string fieldParams)
        {
            this.setProperty("fieldParams", fieldParams);
        }

        public string getConditionClass()
        {
            return this.getProperty("conditionClass").ToString();
        }

        public void setConditionClass(string conditionClass)
        {
            this.setProperty("conditionClass", conditionClass);
        }

        public string getConditionParams()
        {
            return this.getProperty("conditionParams").ToString();
        }

        public void setConditionParams(string conditionParams)
        {
            this.setProperty("conditionParams", conditionParams);
        }

        public CustomReportGrouping getTargetGrouping()
        {
            return (CustomReportGrouping)this.getProperty("targetGrouping");
        }

        public void setTargetGrouping(CustomReportGrouping targetGrouping)
        {
            this.setProperty("targetGrouping", targetGrouping);
        }

        public int getFilterGroupIndex()
        {
            return Convert.ToInt32(this.getProperty("filterGroupIndex"));
        }

        public void setFilterGroupIndex(int filterGroupIndex)
        {
            this.setProperty("filterGroupIndex", filterGroupIndex);
        }


    }
}

