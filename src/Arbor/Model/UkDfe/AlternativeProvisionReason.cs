using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AlternativeProvisionReason : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_ALTERNATIVE_PROVISION_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public AlternativeProvisionReason()
        {
            base.resourceType = this.resourceType;
        }

        public AlternativeProvisionReason(string resourceType = "AlternativeProvisionReason", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AlternativeProvisionReason> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_AlternativeProvisionReason");
            RestGateway gateway = (RestGateway)AlternativeProvisionReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AlternativeProvisionReason> alternativeprovisionreasonCollection = new ModelCollection<AlternativeProvisionReason>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                alternativeprovisionreasonCollection.add((AlternativeProvisionReason)model);
            }

            return alternativeprovisionreasonCollection;
        }

        public static AlternativeProvisionReason retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AlternativeProvisionReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AlternativeProvisionReason)gateway.retrieve(ResourceType.UK_DFE_ALTERNATIVE_PROVISION_REASON, id);
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

