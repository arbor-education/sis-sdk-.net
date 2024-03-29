using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenStatus : ModelBase
    {
        protected new string resourceType = ResourceType.SEN_STATUS;
        public const string D00229 = "d00229";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SEN_STATUS_NAME = "senStatusName";
        public const string DESCRIPTION = "description";
        public const string COUNTS_AS_SEN_STATUS = "countsAsSenStatus";
        public const string EXPORT_CODE = "exportCode";

        public SenStatus()
        {
            base.resourceType = this.resourceType;
        }

        public SenStatus(string resourceType = "SenStatus", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SenStatus> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SenStatus");
            RestGateway gateway = (RestGateway)SenStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SenStatus> senstatusCollection = new ModelCollection<SenStatus>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                senstatusCollection.add((SenStatus)model);
            }

            return senstatusCollection;
        }

        public static SenStatus retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SenStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SenStatus)gateway.retrieve(ResourceType.SEN_STATUS, id);
        }

        public string getD00229()
        {
            return this.getProperty("d00229").ToString();
        }

        public void setD00229(string d00229)
        {
            this.setProperty("d00229", d00229);
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

        public string getSenStatusName()
        {
            return this.getProperty("senStatusName").ToString();
        }

        public void setSenStatusName(string senStatusName)
        {
            this.setProperty("senStatusName", senStatusName);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public bool getCountsAsSenStatus()
        {
            return Convert.ToBoolean(this.getProperty("countsAsSenStatus"));
        }

        public void setCountsAsSenStatus(bool countsAsSenStatus)
        {
            this.setProperty("countsAsSenStatus", countsAsSenStatus);
        }

        public string getExportCode()
        {
            return this.getProperty("exportCode").ToString();
        }

        public void setExportCode(string exportCode)
        {
            this.setProperty("exportCode", exportCode);
        }


    }
}

