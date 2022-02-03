using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportScopeFilter : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_SCOPE_FILTER;
        public const string CUSTOM_REPORT_SCOPE = "customReportScope";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TRANSFORMATION_CLASS = "transformationClass";
        public const string CONDITION_CLASS = "conditionClass";
        public const string CONDITION_PARAMS = "conditionParams";
        public const string FILTER_GROUP_INDEX = "filterGroupIndex";

        public CustomReportScopeFilter ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomReportScopeFilter (string resourceType = "CustomReportScopeFilter", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomReportScopeFilter> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomReportScopeFilter");
        	RestGateway gateway = (RestGateway) CustomReportScopeFilter.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomReportScopeFilter> customreportscopefilterCollection = new ModelCollection<CustomReportScopeFilter> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customreportscopefilterCollection.add((CustomReportScopeFilter) model);
        	}
        
        	return customreportscopefilterCollection;
        }

        public static CustomReportScopeFilter retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomReportScopeFilter.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomReportScopeFilter) gateway.retrieve(ResourceType.CUSTOM_REPORT_SCOPE_FILTER, id);
        }

        public CustomReportScope getCustomReportScope ()
        {
            return (CustomReportScope) this.getProperty("customReportScope");
        }

        public void setCustomReportScope (CustomReportScope customReportScope)
        {
            this.setProperty("customReportScope", customReportScope);
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

        public string getConditionClass ()
        {
            return this.getProperty("conditionClass").ToString();
        }

        public void setConditionClass (string conditionClass)
        {
            this.setProperty("conditionClass", conditionClass);
        }

        public string getConditionParams ()
        {
            return this.getProperty("conditionParams").ToString();
        }

        public void setConditionParams (string conditionParams)
        {
            this.setProperty("conditionParams", conditionParams);
        }

        public int getFilterGroupIndex ()
        {
            return Convert.ToInt32(this.getProperty("filterGroupIndex"));
        }

        public void setFilterGroupIndex (int filterGroupIndex)
        {
            this.setProperty("filterGroupIndex", filterGroupIndex);
        }


    }
}

