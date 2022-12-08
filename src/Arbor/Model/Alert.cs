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
        public const string ALERT_RULE = "alertRule";
        public const string TRIGGER_EVENT_TYPE = "triggerEventType";
        public const string TRIGGERED_BY = "triggeredBy";
        public const string REFERENCE = "reference";
        public const string TRIGGERED_DATETIME = "triggeredDatetime";

        public Alert()
        {
            base.resourceType = this.resourceType;
        }

        public Alert(string resourceType = "Alert", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Alert> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Alert");
            RestGateway gateway = (RestGateway)Alert.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Alert> alertCollection = new ModelCollection<Alert>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                alertCollection.add((Alert)model);
            }

            return alertCollection;
        }

        public static Alert retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Alert.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Alert)gateway.retrieve(ResourceType.ALERT, id);
        }

        public AlertRule getAlertRule()
        {
            return (AlertRule)this.getProperty("alertRule");
        }

        public void setAlertRule(AlertRule alertRule)
        {
            this.setProperty("alertRule", alertRule);
        }

        public string getTriggerEventType()
        {
            return this.getProperty("triggerEventType").ToString();
        }

        public void setTriggerEventType(string triggerEventType)
        {
            this.setProperty("triggerEventType", triggerEventType);
        }

        public ModelBase getTriggeredBy()
        {
            return (ModelBase)this.getProperty("triggeredBy");
        }

        public void setTriggeredBy(ModelBase triggeredBy)
        {
            this.setProperty("triggeredBy", triggeredBy);
        }

        public ModelBase getReference()
        {
            return (ModelBase)this.getProperty("reference");
        }

        public void setReference(ModelBase reference)
        {
            this.setProperty("reference", reference);
        }

        public DateTime getTriggeredDatetime()
        {
            return Convert.ToDateTime(this.getProperty("triggeredDatetime"));
        }

        public void setTriggeredDatetime(DateTime triggeredDatetime)
        {
            this.setProperty("triggeredDatetime", triggeredDatetime);
        }


    }
}

