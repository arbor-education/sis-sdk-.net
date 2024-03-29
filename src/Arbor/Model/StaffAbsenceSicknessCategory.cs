using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffAbsenceSicknessCategory : ModelBase
    {
        protected new string resourceType = ResourceType.STAFF_ABSENCE_SICKNESS_CATEGORY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public StaffAbsenceSicknessCategory()
        {
            base.resourceType = this.resourceType;
        }

        public StaffAbsenceSicknessCategory(string resourceType = "StaffAbsenceSicknessCategory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StaffAbsenceSicknessCategory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StaffAbsenceSicknessCategory");
            RestGateway gateway = (RestGateway)StaffAbsenceSicknessCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StaffAbsenceSicknessCategory> staffabsencesicknesscategoryCollection = new ModelCollection<StaffAbsenceSicknessCategory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                staffabsencesicknesscategoryCollection.add((StaffAbsenceSicknessCategory)model);
            }

            return staffabsencesicknesscategoryCollection;
        }

        public static StaffAbsenceSicknessCategory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StaffAbsenceSicknessCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StaffAbsenceSicknessCategory)gateway.retrieve(ResourceType.STAFF_ABSENCE_SICKNESS_CATEGORY, id);
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


    }
}

