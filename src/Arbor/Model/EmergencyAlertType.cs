using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmergencyAlertType : ModelBase
    {
        protected new string resourceType = ResourceType.EMERGENCY_ALERT_TYPE;
        public const string NAME = "name";
        public const string ACTIVE = "active";

        public EmergencyAlertType()
        {
            base.resourceType = this.resourceType;
        }

        public EmergencyAlertType(string resourceType = "EmergencyAlertType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmergencyAlertType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmergencyAlertType");
            RestGateway gateway = (RestGateway)EmergencyAlertType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmergencyAlertType> emergencyalerttypeCollection = new ModelCollection<EmergencyAlertType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emergencyalerttypeCollection.add((EmergencyAlertType)model);
            }

            return emergencyalerttypeCollection;
        }

        public static EmergencyAlertType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmergencyAlertType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmergencyAlertType)gateway.retrieve(ResourceType.EMERGENCY_ALERT_TYPE, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }


    }
}

