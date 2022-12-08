using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InverseDemographic : ModelBase
    {
        protected string resourceType = ResourceType.INVERSE_DEMOGRAPHIC;
        public const string DEMOGRAPHIC = "demographic";

        public InverseDemographic()
        {
            base.resourceType = this.resourceType;
        }

        public InverseDemographic(string resourceType = "InverseDemographic", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InverseDemographic> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InverseDemographic");
            RestGateway gateway = (RestGateway)InverseDemographic.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InverseDemographic> inversedemographicCollection = new ModelCollection<InverseDemographic>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inversedemographicCollection.add((InverseDemographic)model);
            }

            return inversedemographicCollection;
        }

        public static InverseDemographic retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InverseDemographic.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InverseDemographic)gateway.retrieve(ResourceType.INVERSE_DEMOGRAPHIC, id);
        }

        public Demographic getDemographic()
        {
            return (Demographic)this.getProperty("demographic");
        }

        public void setDemographic(Demographic demographic)
        {
            this.setProperty("demographic", demographic);
        }


    }
}

