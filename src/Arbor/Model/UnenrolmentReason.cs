using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UnenrolmentReason : ModelBase
    {
        protected string resourceType = ResourceType.UNENROLMENT_REASON;
        public const string D00206 = "d00206";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string UNENROLMENT_REASON = "unenrolmentReason";

        public UnenrolmentReason()
        {
            base.resourceType = this.resourceType;
        }

        public UnenrolmentReason(string resourceType = "UnenrolmentReason", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UnenrolmentReason> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UnenrolmentReason");
            RestGateway gateway = (RestGateway)UnenrolmentReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UnenrolmentReason> unenrolmentreasonCollection = new ModelCollection<UnenrolmentReason>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                unenrolmentreasonCollection.add((UnenrolmentReason)model);
            }

            return unenrolmentreasonCollection;
        }

        public static UnenrolmentReason retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UnenrolmentReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UnenrolmentReason)gateway.retrieve(ResourceType.UNENROLMENT_REASON, id);
        }

        public string getD00206()
        {
            return this.getProperty("d00206").ToString();
        }

        public void setD00206(string d00206)
        {
            this.setProperty("d00206", d00206);
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

        public string getUnenrolmentReason()
        {
            return this.getProperty("unenrolmentReason").ToString();
        }

        public void setUnenrolmentReason(string unenrolmentReason)
        {
            this.setProperty("unenrolmentReason", unenrolmentReason);
        }


    }
}

