using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AlertRule : ModelBase
    {
        protected new string resourceType = ResourceType.ALERT_RULE;
        public const string TRIGGER_EVENT_TYPE = "triggerEventType";

        public AlertRule ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AlertRule (string resourceType = "AlertRule", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AlertRule> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AlertRule");
        	RestGateway gateway = (RestGateway) AlertRule.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AlertRule> alertruleCollection = new ModelCollection<AlertRule> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    alertruleCollection.add((AlertRule) model);
        	}
        
        	return alertruleCollection;
        }

        public static AlertRule retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AlertRule.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AlertRule) gateway.retrieve(ResourceType.ALERT_RULE, id);
        }

        public string getTriggerEventType ()
        {
            return this.getProperty("triggerEventType").ToString();
        }

        public void setTriggerEventType (string triggerEventType)
        {
            this.setProperty("triggerEventType", triggerEventType);
        }


    }
}

