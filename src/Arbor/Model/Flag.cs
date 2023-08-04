using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Flag : ModelBase
    {
        protected string resourceType = ResourceType.FLAG;
        public const string PERSON = "person";
        public const string TEXT = "text";
        public const string TARGET = "target";

        public Flag()
        {
            base.resourceType = this.resourceType;
        }

        public Flag(string resourceType = "Flag", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Flag> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Flag");
            RestGateway gateway = (RestGateway)Flag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Flag> flagCollection = new ModelCollection<Flag>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                flagCollection.add((Flag)model);
            }

            return flagCollection;
        }

        public static Flag retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Flag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Flag)gateway.retrieve(ResourceType.FLAG, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public string getText()
        {
            return this.getProperty("text").ToString();
        }

        public void setText(string text)
        {
            this.setProperty("text", text);
        }

        public ModelBase getTarget()
        {
            return (ModelBase)this.getProperty("target");
        }

        public void setTarget(ModelBase target)
        {
            this.setProperty("target", target);
        }


    }
}

