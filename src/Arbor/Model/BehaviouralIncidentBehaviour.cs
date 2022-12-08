using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentBehaviour : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_BEHAVIOUR;
        public const string BEHAVIOURAL_INCIDENT = "behaviouralIncident";
        public const string STUDENT = "student";
        public const string BEHAVIOUR = "behaviour";

        public BehaviouralIncidentBehaviour()
        {
            base.resourceType = this.resourceType;
        }

        public BehaviouralIncidentBehaviour(string resourceType = "BehaviouralIncidentBehaviour", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BehaviouralIncidentBehaviour> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BehaviouralIncidentBehaviour");
            RestGateway gateway = (RestGateway)BehaviouralIncidentBehaviour.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BehaviouralIncidentBehaviour> behaviouralincidentbehaviourCollection = new ModelCollection<BehaviouralIncidentBehaviour>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                behaviouralincidentbehaviourCollection.add((BehaviouralIncidentBehaviour)model);
            }

            return behaviouralincidentbehaviourCollection;
        }

        public static BehaviouralIncidentBehaviour retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BehaviouralIncidentBehaviour.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BehaviouralIncidentBehaviour)gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_BEHAVIOUR, id);
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

        public Behaviour getBehaviour()
        {
            return (Behaviour)this.getProperty("behaviour");
        }

        public void setBehaviour(Behaviour behaviour)
        {
            this.setProperty("behaviour", behaviour);
        }


    }
}

