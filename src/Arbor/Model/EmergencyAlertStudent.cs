using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmergencyAlertStudent : ModelBase
    {
        protected new string resourceType = ResourceType.EMERGENCY_ALERT_STUDENT;
        public const string EMERGENCY_ALERT = "emergencyAlert";
        public const string STUDENT = "student";

        public EmergencyAlertStudent()
        {
            base.resourceType = this.resourceType;
        }

        public EmergencyAlertStudent(string resourceType = "EmergencyAlertStudent", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmergencyAlertStudent> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmergencyAlertStudent");
            RestGateway gateway = (RestGateway)EmergencyAlertStudent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmergencyAlertStudent> emergencyalertstudentCollection = new ModelCollection<EmergencyAlertStudent>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emergencyalertstudentCollection.add((EmergencyAlertStudent)model);
            }

            return emergencyalertstudentCollection;
        }

        public static EmergencyAlertStudent retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmergencyAlertStudent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmergencyAlertStudent)gateway.retrieve(ResourceType.EMERGENCY_ALERT_STUDENT, id);
        }

        public EmergencyAlert getEmergencyAlert()
        {
            return (EmergencyAlert)this.getProperty("emergencyAlert");
        }

        public void setEmergencyAlert(EmergencyAlert emergencyAlert)
        {
            this.setProperty("emergencyAlert", emergencyAlert);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }


    }
}

