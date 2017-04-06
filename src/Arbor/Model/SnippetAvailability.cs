using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SnippetAvailability : ModelBase
    {
        protected string resourceType = ResourceType.SNIPPET_AVAILABILITY;
        public const string SNIPPET = "snippet";
        public const string AVAILABLE_TO_ENTITY = "availableToEntity";

        public SnippetAvailability ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SnippetAvailability (string resourceType = "SnippetAvailability", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SnippetAvailability> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SnippetAvailability");
        	RestGateway gateway = (RestGateway) SnippetAvailability.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SnippetAvailability> snippetavailabilityCollection = new ModelCollection<SnippetAvailability> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    snippetavailabilityCollection.add((SnippetAvailability) model);
        	}
        
        	return snippetavailabilityCollection;
        }

        public static SnippetAvailability retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SnippetAvailability.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SnippetAvailability) gateway.retrieve(ResourceType.SNIPPET_AVAILABILITY, id);
        }

        public Snippet getSnippet ()
        {
            return (Snippet) this.getProperty("snippet");
        }

        public void setSnippet (Snippet snippet)
        {
            this.setProperty("snippet", snippet);
        }

        public ModelBase getAvailableToEntity ()
        {
            return (ModelBase) this.getProperty("availableToEntity");
        }

        public void setAvailableToEntity (ModelBase availableToEntity)
        {
            this.setProperty("availableToEntity", availableToEntity);
        }


    }
}

