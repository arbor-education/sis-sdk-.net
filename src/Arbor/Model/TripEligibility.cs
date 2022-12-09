using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TripEligibility : ModelBase
    {
        protected new string resourceType = ResourceType.TRIP_ELIGIBILITY;
        public const string TRIP = "trip";
        public const string ELIGIBILE = "eligibile";

        public TripEligibility()
        {
            base.resourceType = this.resourceType;
        }

        public TripEligibility(string resourceType = "TripEligibility", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TripEligibility> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TripEligibility");
            RestGateway gateway = (RestGateway)TripEligibility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TripEligibility> tripeligibilityCollection = new ModelCollection<TripEligibility>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                tripeligibilityCollection.add((TripEligibility)model);
            }

            return tripeligibilityCollection;
        }

        public static TripEligibility retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TripEligibility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TripEligibility)gateway.retrieve(ResourceType.TRIP_ELIGIBILITY, id);
        }

        public Trip getTrip()
        {
            return (Trip)this.getProperty("trip");
        }

        public void setTrip(Trip trip)
        {
            this.setProperty("trip", trip);
        }

        public ModelBase getEligibile()
        {
            return (ModelBase)this.getProperty("eligibile");
        }

        public void setEligibile(ModelBase eligibile)
        {
            this.setProperty("eligibile", eligibile);
        }


    }
}

