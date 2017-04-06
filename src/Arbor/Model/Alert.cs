using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Alert : ModelBase
    {
        protected string resourceType = ResourceType.ALERT;
        public const string TRIGGER = "trigger";
        public const string REFERENCE_DATE = "referenceDate";
        public const string OBJECT = "object";
        public const string SEVERITY = "severity";
        public const string ALERT_PARAMS = "alertParams";
        public const string SILENCED_DATETIME = "silencedDatetime";
        public const string ACTION_DATETIME = "actionDatetime";

        public Alert ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Alert (string resourceType = "Alert", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Alert> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Alert");
        	RestGateway gateway = (RestGateway) Alert.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Alert> alertCollection = new ModelCollection<Alert> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    alertCollection.add((Alert) model);
        	}
        
        	return alertCollection;
        }

        public static Alert retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Alert.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Alert) gateway.retrieve(ResourceType.ALERT, id);
        }

        public Trigger getTrigger ()
        {
            return (Trigger) this.getProperty("trigger");
        }

        public void setTrigger (Trigger trigger)
        {
            this.setProperty("trigger", trigger);
        }

        public DateTime getReferenceDate ()
        {
            return (DateTime) this.getProperty("referenceDate");
        }

        public void setReferenceDate (DateTime referenceDate)
        {
            this.setProperty("referenceDate", referenceDate);
        }

        public ModelBase getObject ()
        {
            return (ModelBase) this.getProperty("object");
        }

        public void setObject (ModelBase _object)
        {
            this.setProperty("object", _object);
        }

        public string getSeverity ()
        {
            return this.getProperty("severity").ToString();
        }

        public void setSeverity (string severity)
        {
            this.setProperty("severity", severity);
        }

        public string getAlertParams ()
        {
            return this.getProperty("alertParams").ToString();
        }

        public void setAlertParams (string alertParams)
        {
            this.setProperty("alertParams", alertParams);
        }

        public DateTime getSilencedDatetime ()
        {
            return (DateTime) this.getProperty("silencedDatetime");
        }

        public void setSilencedDatetime (DateTime silencedDatetime)
        {
            this.setProperty("silencedDatetime", silencedDatetime);
        }

        public DateTime getActionDatetime ()
        {
            return (DateTime) this.getProperty("actionDatetime");
        }

        public void setActionDatetime (DateTime actionDatetime)
        {
            this.setProperty("actionDatetime", actionDatetime);
        }


    }
}

