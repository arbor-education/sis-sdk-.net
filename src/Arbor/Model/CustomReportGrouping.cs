using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportGrouping : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_GROUPING;
        public const string CUSTOM_REPORT = "customReport";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TRANSFORMATION_CLASS = "transformationClass";

        public CustomReportGrouping ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomReportGrouping (string resourceType = "CustomReportGrouping", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomReportGrouping> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomReportGrouping");
        	RestGateway gateway = (RestGateway) CustomReportGrouping.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomReportGrouping> customreportgroupingCollection = new ModelCollection<CustomReportGrouping> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customreportgroupingCollection.add((CustomReportGrouping) model);
        	}
        
        	return customreportgroupingCollection;
        }

        public static CustomReportGrouping retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomReportGrouping.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomReportGrouping) gateway.retrieve(ResourceType.CUSTOM_REPORT_GROUPING, id);
        }

        public CustomReport getCustomReport ()
        {
            return (CustomReport) this.getProperty("customReport");
        }

        public void setCustomReport (CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public string getFieldClass ()
        {
            return this.getProperty("fieldClass").ToString();
        }

        public void setFieldClass (string fieldClass)
        {
            this.setProperty("fieldClass", fieldClass);
        }

        public string getFieldParams ()
        {
            return this.getProperty("fieldParams").ToString();
        }

        public void setFieldParams (string fieldParams)
        {
            this.setProperty("fieldParams", fieldParams);
        }

        public string getTransformationClass ()
        {
            return this.getProperty("transformationClass").ToString();
        }

        public void setTransformationClass (string transformationClass)
        {
            this.setProperty("transformationClass", transformationClass);
        }


    }
}

