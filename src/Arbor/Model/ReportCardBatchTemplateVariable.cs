using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatchTemplateVariable : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_BATCH_TEMPLATE_VARIABLE;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string VARIABLE_NAME = "variableName";
        public const string VARIABLE_TYPE = "variableType";
        public const string INT_VALUE = "intValue";
        public const string DOUBLE_VALUE = "doubleValue";
        public const string STRING_VALUE = "stringValue";
        public const string DATETIME_VALUE = "datetimeValue";

        public ReportCardBatchTemplateVariable ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardBatchTemplateVariable (string resourceType = "ReportCardBatchTemplateVariable", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardBatchTemplateVariable> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardBatchTemplateVariable");
        	RestGateway gateway = (RestGateway) ReportCardBatchTemplateVariable.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardBatchTemplateVariable> reportcardbatchtemplatevariableCollection = new ModelCollection<ReportCardBatchTemplateVariable> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardbatchtemplatevariableCollection.add((ReportCardBatchTemplateVariable) model);
        	}
        
        	return reportcardbatchtemplatevariableCollection;
        }

        public static ReportCardBatchTemplateVariable retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardBatchTemplateVariable.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardBatchTemplateVariable) gateway.retrieve(ResourceType.REPORT_CARD_BATCH_TEMPLATE_VARIABLE, id);
        }

        public ReportCardBatch getReportCardBatch ()
        {
            return (ReportCardBatch) this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch (ReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public string getVariableName ()
        {
            return this.getProperty("variableName").ToString();
        }

        public void setVariableName (string variableName)
        {
            this.setProperty("variableName", variableName);
        }

        public string getVariableType ()
        {
            return this.getProperty("variableType").ToString();
        }

        public void setVariableType (string variableType)
        {
            this.setProperty("variableType", variableType);
        }

        public int getIntValue ()
        {
            return Convert.ToInt32(this.getProperty("intValue"));
        }

        public void setIntValue (int intValue)
        {
            this.setProperty("intValue", intValue);
        }

        public float getDoubleValue ()
        {
            return (float) this.getProperty("doubleValue");
        }

        public void setDoubleValue (float doubleValue)
        {
            this.setProperty("doubleValue", doubleValue);
        }

        public string getStringValue ()
        {
            return this.getProperty("stringValue").ToString();
        }

        public void setStringValue (string stringValue)
        {
            this.setProperty("stringValue", stringValue);
        }

        public DateTime getDatetimeValue ()
        {
            return (DateTime) this.getProperty("datetimeValue");
        }

        public void setDatetimeValue (DateTime datetimeValue)
        {
            this.setProperty("datetimeValue", datetimeValue);
        }


    }
}

