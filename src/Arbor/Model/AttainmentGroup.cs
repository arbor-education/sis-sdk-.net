using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttainmentGroup : ModelBase
    {
        protected string resourceType = ResourceType.ATTAINMENT_GROUP;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string CALCULATION_CLASS = "calculationClass";

        public AttainmentGroup()
        {
            base.resourceType = this.resourceType;
        }

        public AttainmentGroup(string resourceType = "AttainmentGroup", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AttainmentGroup> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AttainmentGroup");
            RestGateway gateway = (RestGateway)AttainmentGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AttainmentGroup> attainmentgroupCollection = new ModelCollection<AttainmentGroup>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                attainmentgroupCollection.add((AttainmentGroup)model);
            }

            return attainmentgroupCollection;
        }

        public static AttainmentGroup retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AttainmentGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AttainmentGroup)gateway.retrieve(ResourceType.ATTAINMENT_GROUP, id);
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

        public string getCalculationClass()
        {
            return this.getProperty("calculationClass").ToString();
        }

        public void setCalculationClass(string calculationClass)
        {
            this.setProperty("calculationClass", calculationClass);
        }


    }
}

