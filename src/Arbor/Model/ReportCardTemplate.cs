using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardTemplate : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_TEMPLATE;
        public const string TEMPLATE_NAME = "templateName";
        public const string TEMPLATE_FILE_NAME = "templateFileName";
        public const string HELPER_CLASS_NAME = "helperClassName";

        public ReportCardTemplate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardTemplate (string resourceType = "ReportCardTemplate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardTemplate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardTemplate");
        	RestGateway gateway = (RestGateway) ReportCardTemplate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardTemplate> reportcardtemplateCollection = new ModelCollection<ReportCardTemplate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardtemplateCollection.add((ReportCardTemplate) model);
        	}
        
        	return reportcardtemplateCollection;
        }

        public static ReportCardTemplate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardTemplate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardTemplate) gateway.retrieve(ResourceType.REPORT_CARD_TEMPLATE, id);
        }

        public string getTemplateName ()
        {
            return this.getProperty("templateName").ToString();
        }

        public void setTemplateName (string templateName)
        {
            this.setProperty("templateName", templateName);
        }

        public string getTemplateFileName ()
        {
            return this.getProperty("templateFileName").ToString();
        }

        public void setTemplateFileName (string templateFileName)
        {
            this.setProperty("templateFileName", templateFileName);
        }

        public string getHelperClassName ()
        {
            return this.getProperty("helperClassName").ToString();
        }

        public void setHelperClassName (string helperClassName)
        {
            this.setProperty("helperClassName", helperClassName);
        }


    }
}

