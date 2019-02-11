using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Snippet : ModelBase
    {
        protected string resourceType = ResourceType.SNIPPET;
        public const string SNIPPET_NAME = "snippetName";
        public const string SNIPPET_TEXT = "snippetText";
        public const string CATEGORY = "category";
        public const string STAFF = "staff";
        public const string LINKED_TO_ENTITY = "linkedToEntity";
        public const string IS_SHARED = "isShared";

        public Snippet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Snippet (string resourceType = "Snippet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Snippet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Snippet");
        	RestGateway gateway = (RestGateway) Snippet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Snippet> snippetCollection = new ModelCollection<Snippet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    snippetCollection.add((Snippet) model);
        	}
        
        	return snippetCollection;
        }

        public static Snippet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Snippet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Snippet) gateway.retrieve(ResourceType.SNIPPET, id);
        }

        public string getSnippetName ()
        {
            return this.getProperty("snippetName").ToString();
        }

        public void setSnippetName (string snippetName)
        {
            this.setProperty("snippetName", snippetName);
        }

        public string getSnippetText ()
        {
            return this.getProperty("snippetText").ToString();
        }

        public void setSnippetText (string snippetText)
        {
            this.setProperty("snippetText", snippetText);
        }

        public string getCategory ()
        {
            return this.getProperty("category").ToString();
        }

        public void setCategory (string category)
        {
            this.setProperty("category", category);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public ModelBase getLinkedToEntity ()
        {
            return (ModelBase) this.getProperty("linkedToEntity");
        }

        public void setLinkedToEntity (ModelBase linkedToEntity)
        {
            this.setProperty("linkedToEntity", linkedToEntity);
        }

        public bool getIsShared ()
        {
            return Convert.ToBoolean( this.getProperty("isShared"));
        }

        public void setIsShared (bool isShared)
        {
            this.setProperty("isShared", isShared);
        }


    }
}

