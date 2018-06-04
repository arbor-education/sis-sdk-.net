using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class CtfExportJob : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CTF_EXPORT_JOB;
        public const string EXPORT_TYPE = "exportType";
        public const string LA_SEND = "laSend";
        public const string LA_RECEIVE = "laReceive";
        public const string DFE_SEND = "dfeSend";
        public const string DFE_RECEIVE = "dfeReceive";
        public const string FILE_NAME = "fileName";
        public const string FILE_NUMBER = "fileNumber";
        public const string REPORTING_PERIOD_START_DATE = "reportingPeriodStartDate";
        public const string REPORTING_PERIOD_END_DATE = "reportingPeriodEndDate";
        public const string EXPORT_DATETIME = "exportDatetime";
        public const string XSD_ERROR = "xsdError";
        public const string DATA_ERROR = "dataError";
        public const string DATA_ERROR_MESSAGE = "dataErrorMessage";
        public const string CUSTOM_CTF_INCLUDED_FIELDS = "customCtfIncludedFields";

        public CtfExportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CtfExportJob (string resourceType = "CtfExportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CtfExportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_CtfExportJob");
        	RestGateway gateway = (RestGateway) CtfExportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CtfExportJob> ctfexportjobCollection = new ModelCollection<CtfExportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ctfexportjobCollection.add((CtfExportJob) model);
        	}
        
        	return ctfexportjobCollection;
        }

        public static CtfExportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CtfExportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CtfExportJob) gateway.retrieve(ResourceType.UK_DFE_CTF_EXPORT_JOB, id);
        }

        public string getExportType ()
        {
            return this.getProperty("exportType").ToString();
        }

        public void setExportType (string exportType)
        {
            this.setProperty("exportType", exportType);
        }

        public string getLaSend ()
        {
            return this.getProperty("laSend").ToString();
        }

        public void setLaSend (string laSend)
        {
            this.setProperty("laSend", laSend);
        }

        public string getLaReceive ()
        {
            return this.getProperty("laReceive").ToString();
        }

        public void setLaReceive (string laReceive)
        {
            this.setProperty("laReceive", laReceive);
        }

        public string getDfeSend ()
        {
            return this.getProperty("dfeSend").ToString();
        }

        public void setDfeSend (string dfeSend)
        {
            this.setProperty("dfeSend", dfeSend);
        }

        public string getDfeReceive ()
        {
            return this.getProperty("dfeReceive").ToString();
        }

        public void setDfeReceive (string dfeReceive)
        {
            this.setProperty("dfeReceive", dfeReceive);
        }

        public string getFileName ()
        {
            return this.getProperty("fileName").ToString();
        }

        public void setFileName (string fileName)
        {
            this.setProperty("fileName", fileName);
        }

        public int getFileNumber ()
        {
            return Convert.ToInt32(this.getProperty("fileNumber"));
        }

        public void setFileNumber (int fileNumber)
        {
            this.setProperty("fileNumber", fileNumber);
        }

        public DateTime getReportingPeriodStartDate ()
        {
            return (DateTime) this.getProperty("reportingPeriodStartDate");
        }

        public void setReportingPeriodStartDate (DateTime reportingPeriodStartDate)
        {
            this.setProperty("reportingPeriodStartDate", reportingPeriodStartDate);
        }

        public DateTime getReportingPeriodEndDate ()
        {
            return (DateTime) this.getProperty("reportingPeriodEndDate");
        }

        public void setReportingPeriodEndDate (DateTime reportingPeriodEndDate)
        {
            this.setProperty("reportingPeriodEndDate", reportingPeriodEndDate);
        }

        public DateTime getExportDatetime ()
        {
            return (DateTime) this.getProperty("exportDatetime");
        }

        public void setExportDatetime (DateTime exportDatetime)
        {
            this.setProperty("exportDatetime", exportDatetime);
        }

        public bool getXsdError ()
        {
            return (bool) this.getProperty("xsdError");
        }

        public void setXsdError (bool xsdError)
        {
            this.setProperty("xsdError", xsdError);
        }

        public bool getDataError ()
        {
            return (bool) this.getProperty("dataError");
        }

        public void setDataError (bool dataError)
        {
            this.setProperty("dataError", dataError);
        }

        public string getDataErrorMessage ()
        {
            return this.getProperty("dataErrorMessage").ToString();
        }

        public void setDataErrorMessage (string dataErrorMessage)
        {
            this.setProperty("dataErrorMessage", dataErrorMessage);
        }

        public string getCustomCtfIncludedFields ()
        {
            return this.getProperty("customCtfIncludedFields").ToString();
        }

        public void setCustomCtfIncludedFields (string customCtfIncludedFields)
        {
            this.setProperty("customCtfIncludedFields", customCtfIncludedFields);
        }


    }
}

