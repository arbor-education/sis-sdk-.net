using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewReportCardTemplate : ModelBase
    {
        protected string resourceType = ResourceType.NEW_REPORT_CARD_TEMPLATE;
        public const string TEMPLATE_NAME = "templateName";
        public const string TEMPLATE_FILENAME = "templateFilename";
        public const string TEMPLATE_HTML = "templateHtml";
        public const string CSS = "css";
        public const string HELPER_CLASS_NAME = "helperClassName";
        public const string VARIABLES = "variables";
        public const string CODE = "code";
        public const string ORIENTATION = "orientation";
        public const string IS_CUSTOM = "isCustom";

        public NewReportCardTemplate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NewReportCardTemplate (string resourceType = "NewReportCardTemplate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NewReportCardTemplate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NewReportCardTemplate");
        	RestGateway gateway = (RestGateway) NewReportCardTemplate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NewReportCardTemplate> newreportcardtemplateCollection = new ModelCollection<NewReportCardTemplate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    newreportcardtemplateCollection.add((NewReportCardTemplate) model);
        	}
        
        	return newreportcardtemplateCollection;
        }

        public static NewReportCardTemplate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NewReportCardTemplate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NewReportCardTemplate) gateway.retrieve(ResourceType.NEW_REPORT_CARD_TEMPLATE, id);
        }

        public string getTemplateName ()
        {
            return this.getProperty("templateName").ToString();
        }

        public void setTemplateName (string templateName)
        {
            this.setProperty("templateName", templateName);
        }

        public string getTemplateFilename ()
        {
            return this.getProperty("templateFilename").ToString();
        }

        public void setTemplateFilename (string templateFilename)
        {
            this.setProperty("templateFilename", templateFilename);
        }

        public string getTemplateHtml ()
        {
            return this.getProperty("templateHtml").ToString();
        }

        public void setTemplateHtml (string templateHtml)
        {
            this.setProperty("templateHtml", templateHtml);
        }

        public string getCss ()
        {
            return this.getProperty("css").ToString();
        }

        public void setCss (string css)
        {
            this.setProperty("css", css);
        }

        public string getHelperClassName ()
        {
            return this.getProperty("helperClassName").ToString();
        }

        public void setHelperClassName (string helperClassName)
        {
            this.setProperty("helperClassName", helperClassName);
        }

        public string getVariables ()
        {
            return this.getProperty("variables").ToString();
        }

        public void setVariables (string variables)
        {
            this.setProperty("variables", variables);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getOrientation ()
        {
            return this.getProperty("orientation").ToString();
        }

        public void setOrientation (string orientation)
        {
            this.setProperty("orientation", orientation);
        }

        public bool getIsCustom ()
        {
            return Convert.ToBoolean( this.getProperty("isCustom"));
        }

        public void setIsCustom (bool isCustom)
        {
            this.setProperty("isCustom", isCustom);
        }


    }
}

