using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PhantomModel : ModelBase
    {
        protected string resourceType = ResourceType.PHANTOM_MODEL;
        public const string ENTITY_TYPE = "entityType";
        public const string USER = "user";
        public const string MODEL_CREATED_DATETIME = "modelCreatedDatetime";

        public PhantomModel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PhantomModel (string resourceType = "PhantomModel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PhantomModel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PhantomModel");
        	RestGateway gateway = (RestGateway) PhantomModel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PhantomModel> phantommodelCollection = new ModelCollection<PhantomModel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    phantommodelCollection.add((PhantomModel) model);
        	}
        
        	return phantommodelCollection;
        }

        public static PhantomModel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PhantomModel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PhantomModel) gateway.retrieve(ResourceType.PHANTOM_MODEL, id);
        }

        public int getEntityType ()
        {
            return Convert.ToInt32(this.getProperty("entityType"));
        }

        public void setEntityType (int entityType)
        {
            this.setProperty("entityType", entityType);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public DateTime getModelCreatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("modelCreatedDatetime"));
        }

        public void setModelCreatedDatetime (DateTime modelCreatedDatetime)
        {
            this.setProperty("modelCreatedDatetime", modelCreatedDatetime);
        }


    }
}

