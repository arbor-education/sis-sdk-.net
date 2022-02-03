using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UsageLogEntry : ModelBase
    {
        protected string resourceType = ResourceType.USAGE_LOG_ENTRY;
        public const string TIMESTAMP = "timestamp";
        public const string USER = "user";
        public const string SEVERITY = "severity";
        public const string MESSAGE = "message";
        public const string EVENT_TYPE = "event_type";
        public const string EVENT_NAME = "event_name";
        public const string EVENT_DATA = "event_data";
        public const string MODULE = "module";
        public const string CONTROLLER = "controller";
        public const string ACTION = "action";
        public const string CLIENT_IP = "clientIp";
        public const string USER_AGENT = "userAgent";

        public UsageLogEntry ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UsageLogEntry (string resourceType = "UsageLogEntry", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UsageLogEntry> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UsageLogEntry");
        	RestGateway gateway = (RestGateway) UsageLogEntry.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UsageLogEntry> usagelogentryCollection = new ModelCollection<UsageLogEntry> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    usagelogentryCollection.add((UsageLogEntry) model);
        	}
        
        	return usagelogentryCollection;
        }

        public static UsageLogEntry retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UsageLogEntry.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UsageLogEntry) gateway.retrieve(ResourceType.USAGE_LOG_ENTRY, id);
        }

        public DateTime getTimestamp ()
        {
            return Convert.ToDateTime(this.getProperty("timestamp"));
        }

        public void setTimestamp (DateTime timestamp)
        {
            this.setProperty("timestamp", timestamp);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public int getSeverity ()
        {
            return Convert.ToInt32(this.getProperty("severity"));
        }

        public void setSeverity (int severity)
        {
            this.setProperty("severity", severity);
        }

        public string getMessage ()
        {
            return this.getProperty("message").ToString();
        }

        public void setMessage (string message)
        {
            this.setProperty("message", message);
        }

        public string getEvent_type ()
        {
            return this.getProperty("event_type").ToString();
        }

        public void setEvent_type (string event_type)
        {
            this.setProperty("event_type", event_type);
        }

        public string getEvent_name ()
        {
            return this.getProperty("event_name").ToString();
        }

        public void setEvent_name (string event_name)
        {
            this.setProperty("event_name", event_name);
        }

        public string getEvent_data ()
        {
            return this.getProperty("event_data").ToString();
        }

        public void setEvent_data (string event_data)
        {
            this.setProperty("event_data", event_data);
        }

        public string getModule ()
        {
            return this.getProperty("module").ToString();
        }

        public void setModule (string module)
        {
            this.setProperty("module", module);
        }

        public string getController ()
        {
            return this.getProperty("controller").ToString();
        }

        public void setController (string controller)
        {
            this.setProperty("controller", controller);
        }

        public string getAction ()
        {
            return this.getProperty("action").ToString();
        }

        public void setAction (string action)
        {
            this.setProperty("action", action);
        }

        public string getClientIp ()
        {
            return this.getProperty("clientIp").ToString();
        }

        public void setClientIp (string clientIp)
        {
            this.setProperty("clientIp", clientIp);
        }

        public string getUserAgent ()
        {
            return this.getProperty("userAgent").ToString();
        }

        public void setUserAgent (string userAgent)
        {
            this.setProperty("userAgent", userAgent);
        }


    }
}

