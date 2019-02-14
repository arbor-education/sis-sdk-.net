using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AlertRecipient : ModelBase
    {
        protected string resourceType = ResourceType.ALERT_RECIPIENT;
        public const string ALERT = "alert";
        public const string ALERT_RULE_RECIPIENT = "alertRuleRecipient";
        public const string CHANNEL = "channel";
        public const string RECIPIENT = "recipient";
        public const string MESSAGE = "message";

        public AlertRecipient ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AlertRecipient (string resourceType = "AlertRecipient", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AlertRecipient> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AlertRecipient");
        	RestGateway gateway = (RestGateway) AlertRecipient.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AlertRecipient> alertrecipientCollection = new ModelCollection<AlertRecipient> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    alertrecipientCollection.add((AlertRecipient) model);
        	}
        
        	return alertrecipientCollection;
        }

        public static AlertRecipient retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AlertRecipient.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AlertRecipient) gateway.retrieve(ResourceType.ALERT_RECIPIENT, id);
        }

        public Alert getAlert ()
        {
            return (Alert) this.getProperty("alert");
        }

        public void setAlert (Alert alert)
        {
            this.setProperty("alert", alert);
        }

        public AlertRuleRecipient getAlertRuleRecipient ()
        {
            return (AlertRuleRecipient) this.getProperty("alertRuleRecipient");
        }

        public void setAlertRuleRecipient (AlertRuleRecipient alertRuleRecipient)
        {
            this.setProperty("alertRuleRecipient", alertRuleRecipient);
        }

        public string getChannel ()
        {
            return this.getProperty("channel").ToString();
        }

        public void setChannel (string channel)
        {
            this.setProperty("channel", channel);
        }

        public ModelBase getRecipient ()
        {
            return (ModelBase) this.getProperty("recipient");
        }

        public void setRecipient (ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public ModelBase getMessage ()
        {
            return (ModelBase) this.getProperty("message");
        }

        public void setMessage (ModelBase message)
        {
            this.setProperty("message", message);
        }


    }
}

