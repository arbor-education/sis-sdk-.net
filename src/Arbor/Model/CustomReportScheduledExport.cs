using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportScheduledExport : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT_SCHEDULED_EXPORT;
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string SUBJECT = "subject";
        public const string BODY = "body";
        public const string EXECUTE_ON_MONDAY = "executeOnMonday";
        public const string EXECUTE_ON_TUESDAY = "executeOnTuesday";
        public const string EXECUTE_ON_WEDNESDAY = "executeOnWednesday";
        public const string EXECUTE_ON_THURSDAY = "executeOnThursday";
        public const string EXECUTE_ON_FRIDAY = "executeOnFriday";
        public const string EXECUTE_ON_SATURDAY = "executeOnSaturday";
        public const string EXECUTE_ON_SUNDAY = "executeOnSunday";
        public const string SCHEDULED_TIME = "scheduledTime";
        public const string SCHEDULED_FROM_DATE = "scheduledFromDate";

        public CustomReportScheduledExport ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomReportScheduledExport (string resourceType = "CustomReportScheduledExport", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomReportScheduledExport> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomReportScheduledExport");
        	RestGateway gateway = (RestGateway) CustomReportScheduledExport.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomReportScheduledExport> customreportscheduledexportCollection = new ModelCollection<CustomReportScheduledExport> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customreportscheduledexportCollection.add((CustomReportScheduledExport) model);
        	}
        
        	return customreportscheduledexportCollection;
        }

        public static CustomReportScheduledExport retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomReportScheduledExport.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomReportScheduledExport) gateway.retrieve(ResourceType.CUSTOM_REPORT_SCHEDULED_EXPORT, id);
        }

        public string getEmailAddress ()
        {
            return this.getProperty("emailAddress").ToString();
        }

        public void setEmailAddress (string emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public string getSubject ()
        {
            return this.getProperty("subject").ToString();
        }

        public void setSubject (string subject)
        {
            this.setProperty("subject", subject);
        }

        public string getBody ()
        {
            return this.getProperty("body").ToString();
        }

        public void setBody (string body)
        {
            this.setProperty("body", body);
        }

        public bool getExecuteOnMonday ()
        {
            return Convert.ToBoolean( this.getProperty("executeOnMonday"));
        }

        public void setExecuteOnMonday (bool executeOnMonday)
        {
            this.setProperty("executeOnMonday", executeOnMonday);
        }

        public bool getExecuteOnTuesday ()
        {
            return Convert.ToBoolean( this.getProperty("executeOnTuesday"));
        }

        public void setExecuteOnTuesday (bool executeOnTuesday)
        {
            this.setProperty("executeOnTuesday", executeOnTuesday);
        }

        public bool getExecuteOnWednesday ()
        {
            return Convert.ToBoolean( this.getProperty("executeOnWednesday"));
        }

        public void setExecuteOnWednesday (bool executeOnWednesday)
        {
            this.setProperty("executeOnWednesday", executeOnWednesday);
        }

        public bool getExecuteOnThursday ()
        {
            return Convert.ToBoolean( this.getProperty("executeOnThursday"));
        }

        public void setExecuteOnThursday (bool executeOnThursday)
        {
            this.setProperty("executeOnThursday", executeOnThursday);
        }

        public bool getExecuteOnFriday ()
        {
            return Convert.ToBoolean( this.getProperty("executeOnFriday"));
        }

        public void setExecuteOnFriday (bool executeOnFriday)
        {
            this.setProperty("executeOnFriday", executeOnFriday);
        }

        public bool getExecuteOnSaturday ()
        {
            return Convert.ToBoolean( this.getProperty("executeOnSaturday"));
        }

        public void setExecuteOnSaturday (bool executeOnSaturday)
        {
            this.setProperty("executeOnSaturday", executeOnSaturday);
        }

        public bool getExecuteOnSunday ()
        {
            return Convert.ToBoolean( this.getProperty("executeOnSunday"));
        }

        public void setExecuteOnSunday (bool executeOnSunday)
        {
            this.setProperty("executeOnSunday", executeOnSunday);
        }

        public string getScheduledTime ()
        {
            return this.getProperty("scheduledTime").ToString();
        }

        public void setScheduledTime (string scheduledTime)
        {
            this.setProperty("scheduledTime", scheduledTime);
        }

        public DateTime getScheduledFromDate (){
            return Convert.ToDateTime(this.getProperty("scheduledFromDate"));
        }

        public void setScheduledFromDate (DateTime scheduledFromDate)
        {
            this.setProperty("scheduledFromDate", scheduledFromDate);
        }


    }
}

