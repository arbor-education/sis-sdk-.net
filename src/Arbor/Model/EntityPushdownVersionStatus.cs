using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EntityPushdownVersionStatus : ModelBase
    {
        protected new string resourceType = ResourceType.ENTITY_PUSHDOWN_VERSION_STATUS;
        public const string ENTITY_PUSHDOWN_VERSION = "entityPushdownVersion";
        public const string SUBSCRIBER_APPLICATION = "subscriberApplication";
        public const string STATUS = "status";
        public const string ERROR_MESSAGE = "errorMessage";
        public const string SUBSCRIBE_MODE = "subscribeMode";
        public const string ALLOW_EDIT = "allowEdit";
        public const string ALLOW_DELETE = "allowDelete";
        public const string RETRIES = "retries";

        public EntityPushdownVersionStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EntityPushdownVersionStatus (string resourceType = "EntityPushdownVersionStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EntityPushdownVersionStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EntityPushdownVersionStatus");
        	RestGateway gateway = (RestGateway) EntityPushdownVersionStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EntityPushdownVersionStatus> entitypushdownversionstatusCollection = new ModelCollection<EntityPushdownVersionStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    entitypushdownversionstatusCollection.add((EntityPushdownVersionStatus) model);
        	}
        
        	return entitypushdownversionstatusCollection;
        }

        public static EntityPushdownVersionStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EntityPushdownVersionStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EntityPushdownVersionStatus) gateway.retrieve(ResourceType.ENTITY_PUSHDOWN_VERSION_STATUS, id);
        }

        public EntityPushdownVersion getEntityPushdownVersion ()
        {
            return (EntityPushdownVersion) this.getProperty("entityPushdownVersion");
        }

        public void setEntityPushdownVersion (EntityPushdownVersion entityPushdownVersion)
        {
            this.setProperty("entityPushdownVersion", entityPushdownVersion);
        }

        public string getSubscriberApplication ()
        {
            return this.getProperty("subscriberApplication").ToString();
        }

        public void setSubscriberApplication (string subscriberApplication)
        {
            this.setProperty("subscriberApplication", subscriberApplication);
        }

        public string getStatus ()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus (string status)
        {
            this.setProperty("status", status);
        }

        public string getErrorMessage ()
        {
            return this.getProperty("errorMessage").ToString();
        }

        public void setErrorMessage (string errorMessage)
        {
            this.setProperty("errorMessage", errorMessage);
        }

        public string getSubscribeMode ()
        {
            return this.getProperty("subscribeMode").ToString();
        }

        public void setSubscribeMode (string subscribeMode)
        {
            this.setProperty("subscribeMode", subscribeMode);
        }

        public bool getAllowEdit ()
        {
            return Convert.ToBoolean(this.getProperty("allowEdit"));
        }

        public void setAllowEdit (bool allowEdit)
        {
            this.setProperty("allowEdit", allowEdit);
        }

        public bool getAllowDelete ()
        {
            return Convert.ToBoolean(this.getProperty("allowDelete"));
        }

        public void setAllowDelete (bool allowDelete)
        {
            this.setProperty("allowDelete", allowDelete);
        }

        public int getRetries ()
        {
            return Convert.ToInt32(this.getProperty("retries"));
        }

        public void setRetries (int retries)
        {
            this.setProperty("retries", retries);
        }


    }
}

