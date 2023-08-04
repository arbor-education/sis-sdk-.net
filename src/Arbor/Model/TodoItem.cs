using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TodoItem : ModelBase
    {
        protected string resourceType = ResourceType.TODO_ITEM;
        public const string IDENTIFIER = "identifier";
        public const string TEXT = "text";
        public const string ASSIGNEE = "assignee";
        public const string REFERENCE_DATETIME = "referenceDatetime";
        public const string DUE_DATETIME = "dueDatetime";
        public const string RESOLVED_DATETIME = "resolvedDatetime";
        public const string ORIGIN = "origin";
        public const string TYPE = "type";

        public TodoItem()
        {
            base.resourceType = this.resourceType;
        }

        public TodoItem(string resourceType = "TodoItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TodoItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TodoItem");
            RestGateway gateway = (RestGateway)TodoItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TodoItem> todoitemCollection = new ModelCollection<TodoItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                todoitemCollection.add((TodoItem)model);
            }

            return todoitemCollection;
        }

        public static TodoItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TodoItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TodoItem)gateway.retrieve(ResourceType.TODO_ITEM, id);
        }

        public string getIdentifier()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier(string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public string getText()
        {
            return this.getProperty("text").ToString();
        }

        public void setText(string text)
        {
            this.setProperty("text", text);
        }

        public ModelBase getAssignee()
        {
            return (ModelBase)this.getProperty("assignee");
        }

        public void setAssignee(ModelBase assignee)
        {
            this.setProperty("assignee", assignee);
        }

        public DateTime getReferenceDatetime()
        {
            return (DateTime)this.getProperty("referenceDatetime");
        }

        public void setReferenceDatetime(DateTime referenceDatetime)
        {
            this.setProperty("referenceDatetime", referenceDatetime);
        }

        public DateTime getDueDatetime()
        {
            return (DateTime)this.getProperty("dueDatetime");
        }

        public void setDueDatetime(DateTime dueDatetime)
        {
            this.setProperty("dueDatetime", dueDatetime);
        }

        public DateTime getResolvedDatetime()
        {
            return (DateTime)this.getProperty("resolvedDatetime");
        }

        public void setResolvedDatetime(DateTime resolvedDatetime)
        {
            this.setProperty("resolvedDatetime", resolvedDatetime);
        }

        public ModelBase getOrigin()
        {
            return (ModelBase)this.getProperty("origin");
        }

        public void setOrigin(ModelBase origin)
        {
            this.setProperty("origin", origin);
        }

        public string getType()
        {
            return this.getProperty("type").ToString();
        }

        public void setType(string type)
        {
            this.setProperty("type", type);
        }


    }
}

