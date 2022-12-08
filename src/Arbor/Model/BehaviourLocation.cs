using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviourLocation : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOUR_LOCATION;
        public const string NAME = "name";

        public BehaviourLocation()
        {
            base.resourceType = this.resourceType;
        }

        public BehaviourLocation(string resourceType = "BehaviourLocation", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BehaviourLocation> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BehaviourLocation");
            RestGateway gateway = (RestGateway)BehaviourLocation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BehaviourLocation> behaviourlocationCollection = new ModelCollection<BehaviourLocation>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                behaviourlocationCollection.add((BehaviourLocation)model);
            }

            return behaviourlocationCollection;
        }

        public static BehaviourLocation retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BehaviourLocation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BehaviourLocation)gateway.retrieve(ResourceType.BEHAVIOUR_LOCATION, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }


    }
}

