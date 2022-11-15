using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffOrigin : ModelBase
    {
        protected new string resourceType = ResourceType.STAFF_ORIGIN;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";

        public StaffOrigin()
        {
            base.resourceType = this.resourceType;
        }

        public StaffOrigin(string resourceType = "StaffOrigin", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StaffOrigin> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StaffOrigin");
            RestGateway gateway = (RestGateway)StaffOrigin.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StaffOrigin> stafforiginCollection = new ModelCollection<StaffOrigin>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                stafforiginCollection.add((StaffOrigin)model);
            }

            return stafforiginCollection;
        }

        public static StaffOrigin retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StaffOrigin.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StaffOrigin)gateway.retrieve(ResourceType.STAFF_ORIGIN, id);
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

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }


    }
}

