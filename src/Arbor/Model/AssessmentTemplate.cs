using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentTemplate : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_TEMPLATE;
        public const string TEMPLATE_NAME = "templateName";
        public const string CODE = "code";
        public const string VALIDITY_START_DATE = "validityStartDate";
        public const string VALIDITY_END_DATE = "validityEndDate";

        public AssessmentTemplate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentTemplate (string resourceType = "AssessmentTemplate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentTemplate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentTemplate");
        	RestGateway gateway = (RestGateway) AssessmentTemplate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentTemplate> assessmenttemplateCollection = new ModelCollection<AssessmentTemplate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmenttemplateCollection.add((AssessmentTemplate) model);
        	}
        
        	return assessmenttemplateCollection;
        }

        public static AssessmentTemplate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentTemplate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentTemplate) gateway.retrieve(ResourceType.ASSESSMENT_TEMPLATE, id);
        }

        public string getTemplateName ()
        {
            return this.getProperty("templateName").ToString();
        }

        public void setTemplateName (string templateName)
        {
            this.setProperty("templateName", templateName);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public DateTime getValidityStartDate ()
        {
            return (DateTime) this.getProperty("validityStartDate");
        }

        public void setValidityStartDate (DateTime validityStartDate)
        {
            this.setProperty("validityStartDate", validityStartDate);
        }

        public DateTime getValidityEndDate ()
        {
            return (DateTime) this.getProperty("validityEndDate");
        }

        public void setValidityEndDate (DateTime validityEndDate)
        {
            this.setProperty("validityEndDate", validityEndDate);
        }


    }
}

