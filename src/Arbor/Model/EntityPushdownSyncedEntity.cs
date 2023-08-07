using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EntityPushdownSyncedEntity : ModelBase
    {
        protected new string resourceType = ResourceType.ENTITY_PUSHDOWN_SYNCED_ENTITY;
        public const string ENTITY_PUSHDOWN = "entityPushdown";
        public const string SYNCED_ENTITY = "syncedEntity";
        public const string SYNCED_ENTITY_OBJECT_TYPE_ID = "syncedEntityObjectTypeId";
        public const string GLOBAL_IDENTIFIER = "globalIdentifier";
        public const string IS_TEMPLATE = "isTemplate";
        public const string ALLOW_EDIT = "allowEdit";

        public EntityPushdownSyncedEntity()
        {
            base.resourceType = this.resourceType;
        }

        public EntityPushdownSyncedEntity(string resourceType = "EntityPushdownSyncedEntity", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EntityPushdownSyncedEntity> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EntityPushdownSyncedEntity");
            RestGateway gateway = (RestGateway)EntityPushdownSyncedEntity.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EntityPushdownSyncedEntity> entitypushdownsyncedentityCollection = new ModelCollection<EntityPushdownSyncedEntity>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                entitypushdownsyncedentityCollection.add((EntityPushdownSyncedEntity)model);
            }

            return entitypushdownsyncedentityCollection;
        }

        public static EntityPushdownSyncedEntity retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EntityPushdownSyncedEntity.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EntityPushdownSyncedEntity)gateway.retrieve(ResourceType.ENTITY_PUSHDOWN_SYNCED_ENTITY, id);
        }

        public EntityPushdown getEntityPushdown()
        {
            return (EntityPushdown)this.getProperty("entityPushdown");
        }

        public void setEntityPushdown(EntityPushdown entityPushdown)
        {
            this.setProperty("entityPushdown", entityPushdown);
        }

        public ModelBase getSyncedEntity()
        {
            return (ModelBase)this.getProperty("syncedEntity");
        }

        public void setSyncedEntity(ModelBase syncedEntity)
        {
            this.setProperty("syncedEntity", syncedEntity);
        }

        public int getSyncedEntityObjectTypeId()
        {
            return Convert.ToInt32(this.getProperty("syncedEntityObjectTypeId"));
        }

        public void setSyncedEntityObjectTypeId(int syncedEntityObjectTypeId)
        {
            this.setProperty("syncedEntityObjectTypeId", syncedEntityObjectTypeId);
        }

        public string getGlobalIdentifier()
        {
            return this.getProperty("globalIdentifier").ToString();
        }

        public void setGlobalIdentifier(string globalIdentifier)
        {
            this.setProperty("globalIdentifier", globalIdentifier);
        }

        public bool getIsTemplate()
        {
            return Convert.ToBoolean(this.getProperty("isTemplate"));
        }

        public void setIsTemplate(bool isTemplate)
        {
            this.setProperty("isTemplate", isTemplate);
        }

        public bool getAllowEdit()
        {
            return Convert.ToBoolean(this.getProperty("allowEdit"));
        }

        public void setAllowEdit(bool allowEdit)
        {
            this.setProperty("allowEdit", allowEdit);
        }


    }
}

