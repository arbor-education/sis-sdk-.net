using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AlternativeProvisionPlacementReason : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ALTERNATIVE_PROVISION_PLACEMENT_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public AlternativeProvisionPlacementReason()
        {
            base.resourceType = this.resourceType;
        }

        public AlternativeProvisionPlacementReason(string resourceType = "AlternativeProvisionPlacementReason", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AlternativeProvisionPlacementReason> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_AlternativeProvisionPlacementReason");
            RestGateway gateway = (RestGateway)AlternativeProvisionPlacementReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AlternativeProvisionPlacementReason> alternativeprovisionplacementreasonCollection = new ModelCollection<AlternativeProvisionPlacementReason>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                alternativeprovisionplacementreasonCollection.add((AlternativeProvisionPlacementReason)model);
            }

            return alternativeprovisionplacementreasonCollection;
        }

        public static AlternativeProvisionPlacementReason retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AlternativeProvisionPlacementReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AlternativeProvisionPlacementReason)gateway.retrieve(ResourceType.UK_DFE_ALTERNATIVE_PROVISION_PLACEMENT_REASON, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
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

