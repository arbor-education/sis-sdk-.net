using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TripLocation : ModelBase
    {
        protected new string resourceType = ResourceType.TRIP_LOCATION;
        public const string NAME = "name";

        public TripLocation()
        {
            base.resourceType = this.resourceType;
        }

        public TripLocation(string resourceType = "TripLocation", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TripLocation> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TripLocation");
            RestGateway gateway = (RestGateway)TripLocation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TripLocation> triplocationCollection = new ModelCollection<TripLocation>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                triplocationCollection.add((TripLocation)model);
            }

            return triplocationCollection;
        }

        public static TripLocation retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TripLocation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TripLocation)gateway.retrieve(ResourceType.TRIP_LOCATION, id);
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

