using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolType : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_SCHOOL_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";

        public SchoolType()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolType(string resourceType = "SchoolType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_SchoolType");
            RestGateway gateway = (RestGateway)SchoolType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolType> schooltypeCollection = new ModelCollection<SchoolType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schooltypeCollection.add((SchoolType)model);
            }

            return schooltypeCollection;
        }

        public static SchoolType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolType)gateway.retrieve(ResourceType.UK_DFE_SCHOOL_TYPE, id);
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

        public string getLabel()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel(string label)
        {
            this.setProperty("label", label);
        }


    }
}

