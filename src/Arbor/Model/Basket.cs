using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Basket : ModelBase
    {
        protected string resourceType = ResourceType.BASKET;
        public const string GUARDIAN = "guardian";

        public Basket()
        {
            base.resourceType = this.resourceType;
        }

        public Basket(string resourceType = "Basket", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Basket> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Basket");
            RestGateway gateway = (RestGateway)Basket.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Basket> basketCollection = new ModelCollection<Basket>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                basketCollection.add((Basket)model);
            }

            return basketCollection;
        }

        public static Basket retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Basket.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Basket)gateway.retrieve(ResourceType.BASKET, id);
        }

        public Guardian getGuardian()
        {
            return (Guardian)this.getProperty("guardian");
        }

        public void setGuardian(Guardian guardian)
        {
            this.setProperty("guardian", guardian);
        }


    }
}

