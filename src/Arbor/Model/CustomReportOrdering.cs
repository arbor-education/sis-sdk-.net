using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportOrdering : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_ORDERING;
        public const string CUSTOM_REPORT = "customReport";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TRANSFORMATION_CLASS = "transformationClass";
        public const string DIRECTION = "direction";
        public const string TARGET_GROUPING = "targetGrouping";
        public const string CUSTOM_REPORT_COLUMN = "customReportColumn";

        public CustomReportOrdering()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportOrdering(string resourceType = "CustomReportOrdering", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportOrdering> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportOrdering");
            RestGateway gateway = (RestGateway)CustomReportOrdering.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportOrdering> customreportorderingCollection = new ModelCollection<CustomReportOrdering>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportorderingCollection.add((CustomReportOrdering)model);
            }

            return customreportorderingCollection;
        }

        public static CustomReportOrdering retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportOrdering.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportOrdering)gateway.retrieve(ResourceType.CUSTOM_REPORT_ORDERING, id);
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

        public string getTransformationClass()
        {
            return this.getProperty("transformationClass").ToString();
        }

        public void setTransformationClass(string transformationClass)
        {
            this.setProperty("transformationClass", transformationClass);
        }

        public string getDirection()
        {
            return this.getProperty("direction").ToString();
        }

        public void setDirection(string direction)
        {
            this.setProperty("direction", direction);
        }

        public CustomReportGrouping getTargetGrouping()
        {
            return (CustomReportGrouping)this.getProperty("targetGrouping");
        }

        public void setTargetGrouping(CustomReportGrouping targetGrouping)
        {
            this.setProperty("targetGrouping", targetGrouping);
        }

        public CustomReportColumn getCustomReportColumn()
        {
            return (CustomReportColumn)this.getProperty("customReportColumn");
        }

        public void setCustomReportColumn(CustomReportColumn customReportColumn)
        {
            this.setProperty("customReportColumn", customReportColumn);
        }


    }
}

