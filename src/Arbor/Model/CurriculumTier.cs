using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumTier : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_TIER;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string CURRICULUM_TIER_NAME = "curriculumTierName";

        public CurriculumTier()
        {
            base.resourceType = this.resourceType;
        }

        public CurriculumTier(string resourceType = "CurriculumTier", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CurriculumTier> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CurriculumTier");
            RestGateway gateway = (RestGateway)CurriculumTier.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CurriculumTier> curriculumtierCollection = new ModelCollection<CurriculumTier>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                curriculumtierCollection.add((CurriculumTier)model);
            }

            return curriculumtierCollection;
        }

        public static CurriculumTier retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CurriculumTier.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CurriculumTier)gateway.retrieve(ResourceType.CURRICULUM_TIER, id);
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

        public string getCurriculumTierName()
        {
            return this.getProperty("curriculumTierName").ToString();
        }

        public void setCurriculumTierName(string curriculumTierName)
        {
            this.setProperty("curriculumTierName", curriculumTierName);
        }


    }
}

