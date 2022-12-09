using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentDefaultWatcher : ModelBase
    {
        protected new string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_DEFAULT_WATCHER;
        public const string LEVEL_OF_INCIDENT = "levelOfIncident";
        public const string RELATION_TO_STUDENT = "relationToStudent";
        public const string STAFF = "staff";

        public BehaviouralIncidentDefaultWatcher()
        {
            base.resourceType = this.resourceType;
        }

        public BehaviouralIncidentDefaultWatcher(string resourceType = "BehaviouralIncidentDefaultWatcher", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BehaviouralIncidentDefaultWatcher> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BehaviouralIncidentDefaultWatcher");
            RestGateway gateway = (RestGateway)BehaviouralIncidentDefaultWatcher.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BehaviouralIncidentDefaultWatcher> behaviouralincidentdefaultwatcherCollection = new ModelCollection<BehaviouralIncidentDefaultWatcher>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                behaviouralincidentdefaultwatcherCollection.add((BehaviouralIncidentDefaultWatcher)model);
            }

            return behaviouralincidentdefaultwatcherCollection;
        }

        public static BehaviouralIncidentDefaultWatcher retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BehaviouralIncidentDefaultWatcher.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BehaviouralIncidentDefaultWatcher)gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_DEFAULT_WATCHER, id);
        }

        public int getLevelOfIncident()
        {
            return Convert.ToInt32(this.getProperty("levelOfIncident"));
        }

        public void setLevelOfIncident(int levelOfIncident)
        {
            this.setProperty("levelOfIncident", levelOfIncident);
        }

        public string getRelationToStudent()
        {
            return this.getProperty("relationToStudent").ToString();
        }

        public void setRelationToStudent(string relationToStudent)
        {
            this.setProperty("relationToStudent", relationToStudent);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }


    }
}

