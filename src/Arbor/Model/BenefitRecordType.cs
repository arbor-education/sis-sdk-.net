using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BenefitRecordType : ModelBase
    {
        protected new string resourceType = ResourceType.BENEFIT_RECORD_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string APPLIES_TO_STUDENT = "appliesToStudent";
        public const string APPLIES_TO_STAFF = "appliesToStaff";
        public const string APPLIES_TO_GUARDIAN = "appliesToGuardian";

        public BenefitRecordType()
        {
            base.resourceType = this.resourceType;
        }

        public BenefitRecordType(string resourceType = "BenefitRecordType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BenefitRecordType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BenefitRecordType");
            RestGateway gateway = (RestGateway)BenefitRecordType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BenefitRecordType> benefitrecordtypeCollection = new ModelCollection<BenefitRecordType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                benefitrecordtypeCollection.add((BenefitRecordType)model);
            }

            return benefitrecordtypeCollection;
        }

        public static BenefitRecordType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BenefitRecordType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BenefitRecordType)gateway.retrieve(ResourceType.BENEFIT_RECORD_TYPE, id);
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

        public bool getAppliesToStudent()
        {
            return Convert.ToBoolean(this.getProperty("appliesToStudent"));
        }

        public void setAppliesToStudent(bool appliesToStudent)
        {
            this.setProperty("appliesToStudent", appliesToStudent);
        }

        public bool getAppliesToStaff()
        {
            return Convert.ToBoolean(this.getProperty("appliesToStaff"));
        }

        public void setAppliesToStaff(bool appliesToStaff)
        {
            this.setProperty("appliesToStaff", appliesToStaff);
        }

        public bool getAppliesToGuardian()
        {
            return Convert.ToBoolean(this.getProperty("appliesToGuardian"));
        }

        public void setAppliesToGuardian(bool appliesToGuardian)
        {
            this.setProperty("appliesToGuardian", appliesToGuardian);
        }


    }
}

