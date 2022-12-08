using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ChildProtectionStatus : ModelBase
    {
        protected string resourceType = ResourceType.CHILD_PROTECTION_STATUS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string CHILD_PROTECTION_STATUS_NAME = "childProtectionStatusName";

        public ChildProtectionStatus()
        {
            base.resourceType = this.resourceType;
        }

        public ChildProtectionStatus(string resourceType = "ChildProtectionStatus", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ChildProtectionStatus> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ChildProtectionStatus");
            RestGateway gateway = (RestGateway)ChildProtectionStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ChildProtectionStatus> childprotectionstatusCollection = new ModelCollection<ChildProtectionStatus>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                childprotectionstatusCollection.add((ChildProtectionStatus)model);
            }

            return childprotectionstatusCollection;
        }

        public static ChildProtectionStatus retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ChildProtectionStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ChildProtectionStatus)gateway.retrieve(ResourceType.CHILD_PROTECTION_STATUS, id);
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

        public string getChildProtectionStatusName()
        {
            return this.getProperty("childProtectionStatusName").ToString();
        }

        public void setChildProtectionStatusName(string childProtectionStatusName)
        {
            this.setProperty("childProtectionStatusName", childProtectionStatusName);
        }


    }
}

