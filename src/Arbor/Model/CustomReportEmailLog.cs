using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportEmailLog : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_EMAIL_LOG;
        public const string CUSTOM_REPORT = "customReport";
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string SENT_DATETIME = "sentDatetime";

        public CustomReportEmailLog ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomReportEmailLog (string resourceType = "CustomReportEmailLog", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomReportEmailLog> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomReportEmailLog");
        	RestGateway gateway = (RestGateway) CustomReportEmailLog.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomReportEmailLog> customreportemaillogCollection = new ModelCollection<CustomReportEmailLog> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customreportemaillogCollection.add((CustomReportEmailLog) model);
        	}
        
        	return customreportemaillogCollection;
        }

        public static CustomReportEmailLog retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomReportEmailLog.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomReportEmailLog) gateway.retrieve(ResourceType.CUSTOM_REPORT_EMAIL_LOG, id);
        }

        public CustomReport getCustomReport ()
        {
            return (CustomReport) this.getProperty("customReport");
        }

        public void setCustomReport (CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public string getEmailAddress ()
        {
            return this.getProperty("emailAddress").ToString();
        }

        public void setEmailAddress (string emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public DateTime getSentDatetime ()
        {
            return (DateTime) this.getProperty("sentDatetime");
        }

        public void setSentDatetime (DateTime sentDatetime)
        {
            this.setProperty("sentDatetime", sentDatetime);
        }


    }
}

