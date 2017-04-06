using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Content : ModelBase
    {
        protected string resourceType = ResourceType.CONTENT;
        public const string CONTENT_NAME = "contentName";
        public const string DESCRIPTION = "description";

        public Content ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Content (string resourceType = "Content", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Content> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Content");
        	RestGateway gateway = (RestGateway) Content.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Content> contentCollection = new ModelCollection<Content> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    contentCollection.add((Content) model);
        	}
        
        	return contentCollection;
        }

        public static Content retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Content.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Content) gateway.retrieve(ResourceType.CONTENT, id);
        }

        public string getContentName ()
        {
            return this.getProperty("contentName").ToString();
        }

        public void setContentName (string contentName)
        {
            this.setProperty("contentName", contentName);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

