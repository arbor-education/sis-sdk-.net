using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffAbsenceSicknessSubcategory : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_ABSENCE_SICKNESS_SUBCATEGORY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string STAFF_ABSENCE_SICKNESS_CATEGORY = "staffAbsenceSicknessCategory";
        public const string NAME = "name";

        public StaffAbsenceSicknessSubcategory()
        {
            base.resourceType = this.resourceType;
        }

        public StaffAbsenceSicknessSubcategory(string resourceType = "StaffAbsenceSicknessSubcategory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StaffAbsenceSicknessSubcategory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StaffAbsenceSicknessSubcategory");
            RestGateway gateway = (RestGateway)StaffAbsenceSicknessSubcategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StaffAbsenceSicknessSubcategory> staffabsencesicknesssubcategoryCollection = new ModelCollection<StaffAbsenceSicknessSubcategory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                staffabsencesicknesssubcategoryCollection.add((StaffAbsenceSicknessSubcategory)model);
            }

            return staffabsencesicknesssubcategoryCollection;
        }

        public static StaffAbsenceSicknessSubcategory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StaffAbsenceSicknessSubcategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StaffAbsenceSicknessSubcategory)gateway.retrieve(ResourceType.STAFF_ABSENCE_SICKNESS_SUBCATEGORY, id);
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

        public StaffAbsenceSicknessCategory getStaffAbsenceSicknessCategory()
        {
            return (StaffAbsenceSicknessCategory)this.getProperty("staffAbsenceSicknessCategory");
        }

        public void setStaffAbsenceSicknessCategory(StaffAbsenceSicknessCategory staffAbsenceSicknessCategory)
        {
            this.setProperty("staffAbsenceSicknessCategory", staffAbsenceSicknessCategory);
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

