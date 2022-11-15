using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmergencyAlertAssignedStaff : ModelBase
    {
        protected new string resourceType = ResourceType.EMERGENCY_ALERT_ASSIGNED_STAFF;
        public const string EMERGENCY_ALERT = "emergencyAlert";
        public const string ASSIGNED_STAFF = "assignedStaff";

        public EmergencyAlertAssignedStaff()
        {
            base.resourceType = this.resourceType;
        }

        public EmergencyAlertAssignedStaff(string resourceType = "EmergencyAlertAssignedStaff", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmergencyAlertAssignedStaff> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmergencyAlertAssignedStaff");
            RestGateway gateway = (RestGateway)EmergencyAlertAssignedStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmergencyAlertAssignedStaff> emergencyalertassignedstaffCollection = new ModelCollection<EmergencyAlertAssignedStaff>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emergencyalertassignedstaffCollection.add((EmergencyAlertAssignedStaff)model);
            }

            return emergencyalertassignedstaffCollection;
        }

        public static EmergencyAlertAssignedStaff retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmergencyAlertAssignedStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmergencyAlertAssignedStaff)gateway.retrieve(ResourceType.EMERGENCY_ALERT_ASSIGNED_STAFF, id);
        }

        public EmergencyAlert getEmergencyAlert()
        {
            return (EmergencyAlert)this.getProperty("emergencyAlert");
        }

        public void setEmergencyAlert(EmergencyAlert emergencyAlert)
        {
            this.setProperty("emergencyAlert", emergencyAlert);
        }

        public Staff getAssignedStaff()
        {
            return (Staff)this.getProperty("assignedStaff");
        }

        public void setAssignedStaff(Staff assignedStaff)
        {
            this.setProperty("assignedStaff", assignedStaff);
        }


    }
}

