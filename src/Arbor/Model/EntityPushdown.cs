using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EntityPushdown : ModelBase
    {
        protected new string resourceType = ResourceType.ENTITY_PUSHDOWN;
        public const string CONTROLLER_APPLICATION = "controllerApplication";
        public const string CONTROLLER_ENTITY_PUSHDOWN_ID = "controllerEntityPushdownId";
        public const string TITLE = "title";
        public const string CONTROLLER_PARENT_ENTITY = "controllerParentEntity";
        public const string CONTROLLER_PARENT_ENTITY_OBJECT_TYPE_ID = "controllerParentEntityObjectTypeId";
        public const string SYNC_MODE = "syncMode";
        public const string DEFAULT_SUBSCRIBE_MODE = "defaultSubscribeMode";
        public const string DEFAULT_ALLOW_EDIT = "defaultAllowEdit";
        public const string DEFAULT_ALLOW_DELETE = "defaultAllowDelete";

        public EntityPushdown()
        {
            base.resourceType = this.resourceType;
        }

        public EntityPushdown(string resourceType = "EntityPushdown", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EntityPushdown> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EntityPushdown");
            RestGateway gateway = (RestGateway)EntityPushdown.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EntityPushdown> entitypushdownCollection = new ModelCollection<EntityPushdown>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                entitypushdownCollection.add((EntityPushdown)model);
            }

            return entitypushdownCollection;
        }

        public static EntityPushdown retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EntityPushdown.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EntityPushdown)gateway.retrieve(ResourceType.ENTITY_PUSHDOWN, id);
        }

        public string getControllerApplication()
        {
            return this.getProperty("controllerApplication").ToString();
        }

        public void setControllerApplication(string controllerApplication)
        {
            this.setProperty("controllerApplication", controllerApplication);
        }

        public int getControllerEntityPushdownId()
        {
            return Convert.ToInt32(this.getProperty("controllerEntityPushdownId"));
        }

        public void setControllerEntityPushdownId(int controllerEntityPushdownId)
        {
            this.setProperty("controllerEntityPushdownId", controllerEntityPushdownId);
        }

        public string getTitle()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle(string title)
        {
            this.setProperty("title", title);
        }

        public ModelBase getControllerParentEntity()
        {
            return (ModelBase)this.getProperty("controllerParentEntity");
        }

        public void setControllerParentEntity(ModelBase controllerParentEntity)
        {
            this.setProperty("controllerParentEntity", controllerParentEntity);
        }

        public int getControllerParentEntityObjectTypeId()
        {
            return Convert.ToInt32(this.getProperty("controllerParentEntityObjectTypeId"));
        }

        public void setControllerParentEntityObjectTypeId(int controllerParentEntityObjectTypeId)
        {
            this.setProperty("controllerParentEntityObjectTypeId", controllerParentEntityObjectTypeId);
        }

        public string getSyncMode()
        {
            return this.getProperty("syncMode").ToString();
        }

        public void setSyncMode(string syncMode)
        {
            this.setProperty("syncMode", syncMode);
        }

        public string getDefaultSubscribeMode()
        {
            return this.getProperty("defaultSubscribeMode").ToString();
        }

        public void setDefaultSubscribeMode(string defaultSubscribeMode)
        {
            this.setProperty("defaultSubscribeMode", defaultSubscribeMode);
        }

        public bool getDefaultAllowEdit()
        {
            return Convert.ToBoolean(this.getProperty("defaultAllowEdit"));
        }

        public void setDefaultAllowEdit(bool defaultAllowEdit)
        {
            this.setProperty("defaultAllowEdit", defaultAllowEdit);
        }

        public bool getDefaultAllowDelete()
        {
            return Convert.ToBoolean(this.getProperty("defaultAllowDelete"));
        }

        public void setDefaultAllowDelete(bool defaultAllowDelete)
        {
            this.setProperty("defaultAllowDelete", defaultAllowDelete);
        }


    }
}

