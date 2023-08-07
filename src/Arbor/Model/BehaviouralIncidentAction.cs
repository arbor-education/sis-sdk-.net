using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentAction : ModelBase
    {
        protected new string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_ACTION;
        public const string BEHAVIOURAL_INCIDENT = "behaviouralIncident";
        public const string STUDENT = "student";
        public const string ACTION = "action";
        public const string IS_AUTOMATIC = "isAutomatic";

        public BehaviouralIncidentAction()
        {
            base.resourceType = this.resourceType;
        }

        public BehaviouralIncidentAction(string resourceType = "BehaviouralIncidentAction", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BehaviouralIncidentAction> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BehaviouralIncidentAction");
            RestGateway gateway = (RestGateway)BehaviouralIncidentAction.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BehaviouralIncidentAction> behaviouralincidentactionCollection = new ModelCollection<BehaviouralIncidentAction>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                behaviouralincidentactionCollection.add((BehaviouralIncidentAction)model);
            }

            return behaviouralincidentactionCollection;
        }

        public static BehaviouralIncidentAction retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BehaviouralIncidentAction.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BehaviouralIncidentAction)gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_ACTION, id);
        }

        public BehaviouralIncident getBehaviouralIncident()
        {
            return (BehaviouralIncident)this.getProperty("behaviouralIncident");
        }

        public void setBehaviouralIncident(BehaviouralIncident behaviouralIncident)
        {
            this.setProperty("behaviouralIncident", behaviouralIncident);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public ModelBase getAction()
        {
            return (ModelBase)this.getProperty("action");
        }

        public void setAction(ModelBase action)
        {
            this.setProperty("action", action);
        }

        public bool getIsAutomatic()
        {
            return Convert.ToBoolean(this.getProperty("isAutomatic"));
        }

        public void setIsAutomatic(bool isAutomatic)
        {
            this.setProperty("isAutomatic", isAutomatic);
        }


    }
}

