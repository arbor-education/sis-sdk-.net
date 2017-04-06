using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DocumentHtmlTemplate : ModelBase
    {
        protected string resourceType = ResourceType.DOCUMENT_HTML_TEMPLATE;
        public const string TEMPLATE_NAME = "templateName";
        public const string TEMPLATE_TYPE = "templateType";
        public const string DOCUMENT_LAYOUT = "documentLayout";
        public const string TEMPLATE_HTML = "templateHtml";

        public DocumentHtmlTemplate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DocumentHtmlTemplate (string resourceType = "DocumentHtmlTemplate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DocumentHtmlTemplate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DocumentHtmlTemplate");
        	RestGateway gateway = (RestGateway) DocumentHtmlTemplate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DocumentHtmlTemplate> documenthtmltemplateCollection = new ModelCollection<DocumentHtmlTemplate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    documenthtmltemplateCollection.add((DocumentHtmlTemplate) model);
        	}
        
        	return documenthtmltemplateCollection;
        }

        public static DocumentHtmlTemplate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DocumentHtmlTemplate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DocumentHtmlTemplate) gateway.retrieve(ResourceType.DOCUMENT_HTML_TEMPLATE, id);
        }

        public string getTemplateName ()
        {
            return this.getProperty("templateName").ToString();
        }

        public void setTemplateName (string templateName)
        {
            this.setProperty("templateName", templateName);
        }

        public string getTemplateType ()
        {
            return this.getProperty("templateType").ToString();
        }

        public void setTemplateType (string templateType)
        {
            this.setProperty("templateType", templateType);
        }

        public DocumentLayout getDocumentLayout ()
        {
            return (DocumentLayout) this.getProperty("documentLayout");
        }

        public void setDocumentLayout (DocumentLayout documentLayout)
        {
            this.setProperty("documentLayout", documentLayout);
        }

        public string getTemplateHtml ()
        {
            return this.getProperty("templateHtml").ToString();
        }

        public void setTemplateHtml (string templateHtml)
        {
            this.setProperty("templateHtml", templateHtml);
        }


    }
}

