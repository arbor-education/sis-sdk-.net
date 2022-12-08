using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportColumnConditionalFormatter : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_COLUMN_CONDITIONAL_FORMATTER;
        public const string CUSTOM_REPORT_COLUMN = "customReportColumn";
        public const string CONDITION_CLASS = "conditionClass";
        public const string CONDITION_PARAMS = "conditionParams";
        public const string COLOR = "color";

        public CustomReportColumnConditionalFormatter()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportColumnConditionalFormatter(string resourceType = "CustomReportColumnConditionalFormatter", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportColumnConditionalFormatter> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportColumnConditionalFormatter");
            RestGateway gateway = (RestGateway)CustomReportColumnConditionalFormatter.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportColumnConditionalFormatter> customreportcolumnconditionalformatterCollection = new ModelCollection<CustomReportColumnConditionalFormatter>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportcolumnconditionalformatterCollection.add((CustomReportColumnConditionalFormatter)model);
            }

            return customreportcolumnconditionalformatterCollection;
        }

        public static CustomReportColumnConditionalFormatter retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportColumnConditionalFormatter.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportColumnConditionalFormatter)gateway.retrieve(ResourceType.CUSTOM_REPORT_COLUMN_CONDITIONAL_FORMATTER, id);
        }

        public CustomReportColumn getCustomReportColumn()
        {
            return (CustomReportColumn)this.getProperty("customReportColumn");
        }

        public void setCustomReportColumn(CustomReportColumn customReportColumn)
        {
            this.setProperty("customReportColumn", customReportColumn);
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

        public string getColor()
        {
            return this.getProperty("color").ToString();
        }

        public void setColor(string color)
        {
            this.setProperty("color", color);
        }


    }
}

