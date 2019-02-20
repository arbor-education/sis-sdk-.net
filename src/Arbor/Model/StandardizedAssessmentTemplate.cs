using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentTemplate : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_TEMPLATE;
        public const string TEMPLATE_NAME = "templateName";
        public const string CODE = "code";
        public const string VALIDITY_START_DATE = "validityStartDate";
        public const string VALIDITY_END_DATE = "validityEndDate";

        public StandardizedAssessmentTemplate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StandardizedAssessmentTemplate (string resourceType = "StandardizedAssessmentTemplate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StandardizedAssessmentTemplate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StandardizedAssessmentTemplate");
        	RestGateway gateway = (RestGateway) StandardizedAssessmentTemplate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StandardizedAssessmentTemplate> standardizedassessmenttemplateCollection = new ModelCollection<StandardizedAssessmentTemplate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    standardizedassessmenttemplateCollection.add((StandardizedAssessmentTemplate) model);
        	}
        
        	return standardizedassessmenttemplateCollection;
        }

        public static StandardizedAssessmentTemplate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StandardizedAssessmentTemplate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StandardizedAssessmentTemplate) gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_TEMPLATE, id);
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
            return Convert.ToDateTime(this.getProperty("validityStartDate"));
        }

        public void setValidityStartDate (DateTime validityStartDate)
        {
            this.setProperty("validityStartDate", validityStartDate);
        }

        public DateTime getValidityEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("validityEndDate"));
        }

        public void setValidityEndDate (DateTime validityEndDate)
        {
            this.setProperty("validityEndDate", validityEndDate);
        }


    }
}

