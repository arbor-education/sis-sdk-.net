using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DocumentImageTemplate : ModelBase
    {
        protected string resourceType = ResourceType.DOCUMENT_IMAGE_TEMPLATE;
        public const string TEMPLATE_NAME = "templateName";
        public const string CONTENT = "content";
        public const string PLACEHOLDERS = "placeholders";

        public DocumentImageTemplate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DocumentImageTemplate (string resourceType = "DocumentImageTemplate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DocumentImageTemplate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DocumentImageTemplate");
        	RestGateway gateway = (RestGateway) DocumentImageTemplate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DocumentImageTemplate> documentimagetemplateCollection = new ModelCollection<DocumentImageTemplate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    documentimagetemplateCollection.add((DocumentImageTemplate) model);
        	}
        
        	return documentimagetemplateCollection;
        }

        public static DocumentImageTemplate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DocumentImageTemplate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DocumentImageTemplate) gateway.retrieve(ResourceType.DOCUMENT_IMAGE_TEMPLATE, id);
        }

        public string getTemplateName ()
        {
            return this.getProperty("templateName").ToString();
        }

        public void setTemplateName (string templateName)
        {
            this.setProperty("templateName", templateName);
        }

        public Content getContent ()
        {
            return (Content) this.getProperty("content");
        }

        public void setContent (Content content)
        {
            this.setProperty("content", content);
        }

        public string getPlaceholders ()
        {
            return this.getProperty("placeholders").ToString();
        }

        public void setPlaceholders (string placeholders)
        {
            this.setProperty("placeholders", placeholders);
        }


    }
}

