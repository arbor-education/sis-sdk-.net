using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AlertRuleCondition : ModelBase
    {
        protected new string resourceType = ResourceType.ALERT_RULE_CONDITION;
        public const string ALERT_RULE = "alertRule";
        public const string TRIGGER_FIELD = "triggerField";
        public const string CONDITION_GROUP = "conditionGroup";
        public const string CONDITION = "condition";
        public const string CONDITION_RESOLVER = "conditionResolver";

        public AlertRuleCondition ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AlertRuleCondition (string resourceType = "AlertRuleCondition", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AlertRuleCondition> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AlertRuleCondition");
        	RestGateway gateway = (RestGateway) AlertRuleCondition.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AlertRuleCondition> alertruleconditionCollection = new ModelCollection<AlertRuleCondition> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    alertruleconditionCollection.add((AlertRuleCondition) model);
        	}
        
        	return alertruleconditionCollection;
        }

        public static AlertRuleCondition retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AlertRuleCondition.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AlertRuleCondition) gateway.retrieve(ResourceType.ALERT_RULE_CONDITION, id);
        }

        public AlertRule getAlertRule ()
        {
            return (AlertRule) this.getProperty("alertRule");
        }

        public void setAlertRule (AlertRule alertRule)
        {
            this.setProperty("alertRule", alertRule);
        }

        public string getTriggerField ()
        {
            return this.getProperty("triggerField").ToString();
        }

        public void setTriggerField (string triggerField)
        {
            this.setProperty("triggerField", triggerField);
        }

        public bool getConditionGroup ()
        {
            return Convert.ToBoolean(this.getProperty("conditionGroup"));
        }

        public void setConditionGroup (bool conditionGroup)
        {
            this.setProperty("conditionGroup", conditionGroup);
        }

        public ModelBase getCondition ()
        {
            return (ModelBase) this.getProperty("condition");
        }

        public void setCondition (ModelBase condition)
        {
            this.setProperty("condition", condition);
        }

        public string getConditionResolver ()
        {
            return this.getProperty("conditionResolver").ToString();
        }

        public void setConditionResolver (string conditionResolver)
        {
            this.setProperty("conditionResolver", conditionResolver);
        }


    }
}

