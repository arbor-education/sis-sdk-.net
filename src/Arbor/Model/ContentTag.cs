using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ContentTag : ModelBase
    {
        protected string resourceType = ResourceType.CONTENT_TAG;
        public const string CONTENT = "content";
        public const string TAGGED = "tagged";
        public const string TAG_NAME = "tagName";
        public const string TAG_VALUE = "tagValue";

        public ContentTag ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ContentTag (string resourceType = "ContentTag", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ContentTag> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ContentTag");
        	RestGateway gateway = (RestGateway) ContentTag.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ContentTag> contenttagCollection = new ModelCollection<ContentTag> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    contenttagCollection.add((ContentTag) model);
        	}
        
        	return contenttagCollection;
        }

        public static ContentTag retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ContentTag.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ContentTag) gateway.retrieve(ResourceType.CONTENT_TAG, id);
        }

        public Content getContent ()
        {
            return (Content) this.getProperty("content");
        }

        public void setContent (Content content)
        {
            this.setProperty("content", content);
        }

        public ModelBase getTagged ()
        {
            return (ModelBase) this.getProperty("tagged");
        }

        public void setTagged (ModelBase tagged)
        {
            this.setProperty("tagged", tagged);
        }

        public string getTagName ()
        {
            return this.getProperty("tagName").ToString();
        }

        public void setTagName (string tagName)
        {
            this.setProperty("tagName", tagName);
        }

        public string getTagValue ()
        {
            return this.getProperty("tagValue").ToString();
        }

        public void setTagValue (string tagValue)
        {
            this.setProperty("tagValue", tagValue);
        }


    }
}

