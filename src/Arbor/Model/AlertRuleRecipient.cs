using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AlertRuleRecipient : ModelBase
    {
        protected new string resourceType = ResourceType.ALERT_RULE_RECIPIENT;
        public const string ALERT_RULE = "alertRule";
        public const string CHANNEL = "channel";
        public const string RECIPIENT = "recipient";
        public const string RECIPIENT_FIELD = "recipientField";
        public const string RECIPIENT_RESOLVER = "recipientResolver";

        public AlertRuleRecipient()
        {
            base.resourceType = this.resourceType;
        }

        public AlertRuleRecipient(string resourceType = "AlertRuleRecipient", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AlertRuleRecipient> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AlertRuleRecipient");
            RestGateway gateway = (RestGateway)AlertRuleRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AlertRuleRecipient> alertrulerecipientCollection = new ModelCollection<AlertRuleRecipient>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                alertrulerecipientCollection.add((AlertRuleRecipient)model);
            }

            return alertrulerecipientCollection;
        }

        public static AlertRuleRecipient retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AlertRuleRecipient.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AlertRuleRecipient)gateway.retrieve(ResourceType.ALERT_RULE_RECIPIENT, id);
        }

        public AlertRule getAlertRule()
        {
            return (AlertRule)this.getProperty("alertRule");
        }

        public void setAlertRule(AlertRule alertRule)
        {
            this.setProperty("alertRule", alertRule);
        }

        public string getChannel()
        {
            return this.getProperty("channel").ToString();
        }

        public void setChannel(string channel)
        {
            this.setProperty("channel", channel);
        }

        public ModelBase getRecipient()
        {
            return (ModelBase)this.getProperty("recipient");
        }

        public void setRecipient(ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public string getRecipientField()
        {
            return this.getProperty("recipientField").ToString();
        }

        public void setRecipientField(string recipientField)
        {
            this.setProperty("recipientField", recipientField);
        }

        public string getRecipientResolver()
        {
            return this.getProperty("recipientResolver").ToString();
        }

        public void setRecipientResolver(string recipientResolver)
        {
            this.setProperty("recipientResolver", recipientResolver);
        }


    }
}

