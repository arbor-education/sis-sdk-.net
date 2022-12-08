using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Religion : ModelBase
    {
        protected string resourceType = ResourceType.RELIGION;
        public const string D00009 = "d00009";
        public const string D00195 = "d00195";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";

        public Religion()
        {
            base.resourceType = this.resourceType;
        }

        public Religion(string resourceType = "Religion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Religion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Religion");
            RestGateway gateway = (RestGateway)Religion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Religion> religionCollection = new ModelCollection<Religion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                religionCollection.add((Religion)model);
            }

            return religionCollection;
        }

        public static Religion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Religion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Religion)gateway.retrieve(ResourceType.RELIGION, id);
        }

        public string getD00009()
        {
            return this.getProperty("d00009").ToString();
        }

        public void setD00009(string d00009)
        {
            this.setProperty("d00009", d00009);
        }

        public string getD00195()
        {
            return this.getProperty("d00195").ToString();
        }

        public void setD00195(string d00195)
        {
            this.setProperty("d00195", d00195);
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

