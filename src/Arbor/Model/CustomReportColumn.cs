using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportColumn : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_COLUMN;
        public const string CUSTOM_REPORT = "customReport";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TARGET_GROUPING = "targetGrouping";
        public const string TRANSFORMATION_CLASS = "transformationClass";
        public const string DISPLAY_ORDER = "displayOrder";
        public const string FORMATTER_CLASS = "formatterClass";
        public const string LOCKED = "locked";
        public const string CUSTOM_LABEL = "customLabel";
        public const string SUMMARY_ROW_FORMULA_CLASS = "summaryRowFormulaClass";
        public const string IS_HIDDEN = "isHidden";
        public const string IS_SOURCE_UPDATE_PERMITTED = "isSourceUpdatePermitted";

        public CustomReportColumn ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomReportColumn (string resourceType = "CustomReportColumn", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomReportColumn> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomReportColumn");
        	RestGateway gateway = (RestGateway) CustomReportColumn.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomReportColumn> customreportcolumnCollection = new ModelCollection<CustomReportColumn> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customreportcolumnCollection.add((CustomReportColumn) model);
        	}
        
        	return customreportcolumnCollection;
        }

        public static CustomReportColumn retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomReportColumn.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomReportColumn) gateway.retrieve(ResourceType.CUSTOM_REPORT_COLUMN, id);
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

        public CustomReportGrouping getTargetGrouping ()
        {
            return (CustomReportGrouping) this.getProperty("targetGrouping");
        }

        public void setTargetGrouping (CustomReportGrouping targetGrouping)
        {
            this.setProperty("targetGrouping", targetGrouping);
        }

        public string getTransformationClass ()
        {
            return this.getProperty("transformationClass").ToString();
        }

        public void setTransformationClass (string transformationClass)
        {
            this.setProperty("transformationClass", transformationClass);
        }

        public int getDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder (int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }

        public string getFormatterClass ()
        {
            return this.getProperty("formatterClass").ToString();
        }

        public void setFormatterClass (string formatterClass)
        {
            this.setProperty("formatterClass", formatterClass);
        }

        public bool getLocked ()
        {
            return Convert.ToBoolean(this.getProperty("locked"));
        }

        public void setLocked (bool locked)
        {
            this.setProperty("locked", locked);
        }

        public string getCustomLabel ()
        {
            return this.getProperty("customLabel").ToString();
        }

        public void setCustomLabel (string customLabel)
        {
            this.setProperty("customLabel", customLabel);
        }

        public string getSummaryRowFormulaClass ()
        {
            return this.getProperty("summaryRowFormulaClass").ToString();
        }

        public void setSummaryRowFormulaClass (string summaryRowFormulaClass)
        {
            this.setProperty("summaryRowFormulaClass", summaryRowFormulaClass);
        }

        public bool getIsHidden ()
        {
            return Convert.ToBoolean(this.getProperty("isHidden"));
        }

        public void setIsHidden (bool isHidden)
        {
            this.setProperty("isHidden", isHidden);
        }

        public bool getIsSourceUpdatePermitted ()
        {
            return Convert.ToBoolean(this.getProperty("isSourceUpdatePermitted"));
        }

        public void setIsSourceUpdatePermitted (bool isSourceUpdatePermitted)
        {
            this.setProperty("isSourceUpdatePermitted", isSourceUpdatePermitted);
        }


    }
}

