using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EntityPushdownVersion : ModelBase
    {
        protected new string resourceType = ResourceType.ENTITY_PUSHDOWN_VERSION;
        public const string ENTITY_PUSHDOWN = "entityPushdown";
        public const string VERSION_DATA = "versionData";
        public const string VERSION_NUMBER = "versionNumber";

        public EntityPushdownVersion()
        {
            base.resourceType = this.resourceType;
        }

        public EntityPushdownVersion(string resourceType = "EntityPushdownVersion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EntityPushdownVersion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EntityPushdownVersion");
            RestGateway gateway = (RestGateway)EntityPushdownVersion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EntityPushdownVersion> entitypushdownversionCollection = new ModelCollection<EntityPushdownVersion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                entitypushdownversionCollection.add((EntityPushdownVersion)model);
            }

            return entitypushdownversionCollection;
        }

        public static EntityPushdownVersion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EntityPushdownVersion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EntityPushdownVersion)gateway.retrieve(ResourceType.ENTITY_PUSHDOWN_VERSION, id);
        }

        public EntityPushdown getEntityPushdown()
        {
            return (EntityPushdown)this.getProperty("entityPushdown");
        }

        public void setEntityPushdown(EntityPushdown entityPushdown)
        {
            this.setProperty("entityPushdown", entityPushdown);
        }

        public string getVersionData()
        {
            return this.getProperty("versionData").ToString();
        }

        public void setVersionData(string versionData)
        {
            this.setProperty("versionData", versionData);
        }

        public int getVersionNumber()
        {
            return Convert.ToInt32(this.getProperty("versionNumber"));
        }

        public void setVersionNumber(int versionNumber)
        {
            this.setProperty("versionNumber", versionNumber);
        }


    }
}

