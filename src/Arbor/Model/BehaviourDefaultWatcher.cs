using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviourDefaultWatcher : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOUR_DEFAULT_WATCHER;
        public const string BEHAVIOUR = "behaviour";
        public const string RELATION_TO_STUDENT = "relationToStudent";
        public const string STAFF = "staff";

        public BehaviourDefaultWatcher()
        {
            base.resourceType = this.resourceType;
        }

        public BehaviourDefaultWatcher(string resourceType = "BehaviourDefaultWatcher", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BehaviourDefaultWatcher> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BehaviourDefaultWatcher");
            RestGateway gateway = (RestGateway)BehaviourDefaultWatcher.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BehaviourDefaultWatcher> behaviourdefaultwatcherCollection = new ModelCollection<BehaviourDefaultWatcher>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                behaviourdefaultwatcherCollection.add((BehaviourDefaultWatcher)model);
            }

            return behaviourdefaultwatcherCollection;
        }

        public static BehaviourDefaultWatcher retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BehaviourDefaultWatcher.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BehaviourDefaultWatcher)gateway.retrieve(ResourceType.BEHAVIOUR_DEFAULT_WATCHER, id);
        }

        public Behaviour getBehaviour()
        {
            return (Behaviour)this.getProperty("behaviour");
        }

        public void setBehaviour(Behaviour behaviour)
        {
            this.setProperty("behaviour", behaviour);
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

