using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmergencyAlert : ModelBase
    {
        protected string resourceType = ResourceType.EMERGENCY_ALERT;
        public const string DATETIME = "datetime";
        public const string TRIGGERED_BY_STAFF = "triggeredByStaff";
        public const string LOCATION = "location";
        public const string EVENT = "event";
        public const string COMMENT = "comment";
        public const string EMERGENCY_ALERT_TYPE = "emergencyAlertType";
        public const string STATUS = "status";
        public const string STATUS_MODIFIED_STAFF = "statusModifiedStaff";
        public const string STATUS_MODIFIED_DATETIME = "statusModifiedDatetime";

        public EmergencyAlert()
        {
            base.resourceType = this.resourceType;
        }

        public EmergencyAlert(string resourceType = "EmergencyAlert", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmergencyAlert> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmergencyAlert");
            RestGateway gateway = (RestGateway)EmergencyAlert.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmergencyAlert> emergencyalertCollection = new ModelCollection<EmergencyAlert>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emergencyalertCollection.add((EmergencyAlert)model);
            }

            return emergencyalertCollection;
        }

        public static EmergencyAlert retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmergencyAlert.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmergencyAlert)gateway.retrieve(ResourceType.EMERGENCY_ALERT, id);
        }

        public DateTime getDatetime()
        {
            return Convert.ToDateTime(this.getProperty("datetime"));
        }

        public void setDatetime(DateTime datetime)
        {
            this.setProperty("datetime", datetime);
        }

        public Staff getTriggeredByStaff()
        {
            return (Staff)this.getProperty("triggeredByStaff");
        }

        public void setTriggeredByStaff(Staff triggeredByStaff)
        {
            this.setProperty("triggeredByStaff", triggeredByStaff);
        }

        public Room getLocation()
        {
            return (Room)this.getProperty("location");
        }

        public void setLocation(Room location)
        {
            this.setProperty("location", location);
        }

        public ModelBase getEvent()
        {
            return (ModelBase)this.getProperty("event");
        }

        public void setEvent(ModelBase _event)
        {
            this.setProperty("event", _event);
        }

        public string getComment()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment(string comment)
        {
            this.setProperty("comment", comment);
        }

        public EmergencyAlertType getEmergencyAlertType()
        {
            return (EmergencyAlertType)this.getProperty("emergencyAlertType");
        }

        public void setEmergencyAlertType(EmergencyAlertType emergencyAlertType)
        {
            this.setProperty("emergencyAlertType", emergencyAlertType);
        }

        public string getStatus()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus(string status)
        {
            this.setProperty("status", status);
        }

        public Staff getStatusModifiedStaff()
        {
            return (Staff)this.getProperty("statusModifiedStaff");
        }

        public void setStatusModifiedStaff(Staff statusModifiedStaff)
        {
            this.setProperty("statusModifiedStaff", statusModifiedStaff);
        }

        public DateTime getStatusModifiedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("statusModifiedDatetime"));
        }

        public void setStatusModifiedDatetime(DateTime statusModifiedDatetime)
        {
            this.setProperty("statusModifiedDatetime", statusModifiedDatetime);
        }


    }
}

