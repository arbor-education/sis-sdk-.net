using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Tag : ModelBase
    {
        protected new string resourceType = ResourceType.TAG;
        public const string TAG_NAME = "tagName";
        public const string TAG_IDENTIFIER = "tagIdentifier";

        public Tag()
        {
            base.resourceType = this.resourceType;
        }

        public Tag(string resourceType = "Tag", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Tag> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Tag");
            RestGateway gateway = (RestGateway)Tag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Tag> tagCollection = new ModelCollection<Tag>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                tagCollection.add((Tag)model);
            }

            return tagCollection;
        }

        public static Tag retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Tag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Tag)gateway.retrieve(ResourceType.TAG, id);
        }

        public string getTagName()
        {
            return this.getProperty("tagName").ToString();
        }

        public void setTagName(string tagName)
        {
            this.setProperty("tagName", tagName);
        }

        public string getTagIdentifier()
        {
            return this.getProperty("tagIdentifier").ToString();
        }

        public void setTagIdentifier(string tagIdentifier)
        {
            this.setProperty("tagIdentifier", tagIdentifier);
        }


    }
}

