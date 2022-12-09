using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ImmunizationType : ModelBase
    {
        protected new string resourceType = ResourceType.IMMUNIZATION_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string IMMUNIZATION_TYPE_NAME = "immunizationTypeName";

        public ImmunizationType()
        {
            base.resourceType = this.resourceType;
        }

        public ImmunizationType(string resourceType = "ImmunizationType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ImmunizationType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ImmunizationType");
            RestGateway gateway = (RestGateway)ImmunizationType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ImmunizationType> immunizationtypeCollection = new ModelCollection<ImmunizationType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                immunizationtypeCollection.add((ImmunizationType)model);
            }

            return immunizationtypeCollection;
        }

        public static ImmunizationType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ImmunizationType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ImmunizationType)gateway.retrieve(ResourceType.IMMUNIZATION_TYPE, id);
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

        public string getImmunizationTypeName()
        {
            return this.getProperty("immunizationTypeName").ToString();
        }

        public void setImmunizationTypeName(string immunizationTypeName)
        {
            this.setProperty("immunizationTypeName", immunizationTypeName);
        }


    }
}

