using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportCollation : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_COLLATION;
        public const string CUSTOM_REPORT = "customReport";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TRANSFORMATION_CLASS = "transformationClass";
        public const string CUSTOM_LABEL = "customLabel";

        public CustomReportCollation()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportCollation(string resourceType = "CustomReportCollation", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportCollation> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportCollation");
            RestGateway gateway = (RestGateway)CustomReportCollation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportCollation> customreportcollationCollection = new ModelCollection<CustomReportCollation>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportcollationCollection.add((CustomReportCollation)model);
            }

            return customreportcollationCollection;
        }

        public static CustomReportCollation retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportCollation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportCollation)gateway.retrieve(ResourceType.CUSTOM_REPORT_COLLATION, id);
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

        public string getCustomLabel()
        {
            return this.getProperty("customLabel").ToString();
        }

        public void setCustomLabel(string customLabel)
        {
            this.setProperty("customLabel", customLabel);
        }


    }
}

