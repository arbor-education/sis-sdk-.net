using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContractPostEndReason : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT_POST_END_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";

        public StaffContractPostEndReason()
        {
            base.resourceType = this.resourceType;
        }

        public StaffContractPostEndReason(string resourceType = "StaffContractPostEndReason", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StaffContractPostEndReason> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StaffContractPostEndReason");
            RestGateway gateway = (RestGateway)StaffContractPostEndReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StaffContractPostEndReason> staffcontractpostendreasonCollection = new ModelCollection<StaffContractPostEndReason>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                staffcontractpostendreasonCollection.add((StaffContractPostEndReason)model);
            }

            return staffcontractpostendreasonCollection;
        }

        public static StaffContractPostEndReason retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StaffContractPostEndReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StaffContractPostEndReason)gateway.retrieve(ResourceType.STAFF_CONTRACT_POST_END_REASON, id);
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

