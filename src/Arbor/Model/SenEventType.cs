using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenEventType : ModelBase
    {
        protected string resourceType = ResourceType.SEN_EVENT_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SEN_EVENT_TYPE = "senEventType";

        public SenEventType()
        {
            base.resourceType = this.resourceType;
        }

        public SenEventType(string resourceType = "SenEventType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SenEventType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SenEventType");
            RestGateway gateway = (RestGateway)SenEventType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SenEventType> seneventtypeCollection = new ModelCollection<SenEventType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                seneventtypeCollection.add((SenEventType)model);
            }

            return seneventtypeCollection;
        }

        public static SenEventType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SenEventType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SenEventType)gateway.retrieve(ResourceType.SEN_EVENT_TYPE, id);
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

        public string getSenEventType()
        {
            return this.getProperty("senEventType").ToString();
        }

        public void setSenEventType(string senEventType)
        {
            this.setProperty("senEventType", senEventType);
        }


    }
}

