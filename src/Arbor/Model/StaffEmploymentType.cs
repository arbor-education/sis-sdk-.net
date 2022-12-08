using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffEmploymentType : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_EMPLOYMENT_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string EMPLOYMENT_TYPE_NAME = "employmentTypeName";

        public StaffEmploymentType()
        {
            base.resourceType = this.resourceType;
        }

        public StaffEmploymentType(string resourceType = "StaffEmploymentType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StaffEmploymentType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StaffEmploymentType");
            RestGateway gateway = (RestGateway)StaffEmploymentType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StaffEmploymentType> staffemploymenttypeCollection = new ModelCollection<StaffEmploymentType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                staffemploymenttypeCollection.add((StaffEmploymentType)model);
            }

            return staffemploymenttypeCollection;
        }

        public static StaffEmploymentType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StaffEmploymentType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StaffEmploymentType)gateway.retrieve(ResourceType.STAFF_EMPLOYMENT_TYPE, id);
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

        public string getEmploymentTypeName()
        {
            return this.getProperty("employmentTypeName").ToString();
        }

        public void setEmploymentTypeName(string employmentTypeName)
        {
            this.setProperty("employmentTypeName", employmentTypeName);
        }


    }
}

