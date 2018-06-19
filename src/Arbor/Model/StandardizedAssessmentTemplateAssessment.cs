using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentTemplateAssessment : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_TEMPLATE_ASSESSMENT;
        public const string STANDARDIZED_ASSESSMENT_TEMPLATE = "standardizedAssessmentTemplate";
        public const string ASSESSMENT = "assessment";
        public const string STANDARDIZED_ASSESSMENT = "standardizedAssessment";
        public const string DATA_ORDER = "dataOrder";

        public StandardizedAssessmentTemplateAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StandardizedAssessmentTemplateAssessment (string resourceType = "StandardizedAssessmentTemplateAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StandardizedAssessmentTemplateAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StandardizedAssessmentTemplateAssessment");
        	RestGateway gateway = (RestGateway) StandardizedAssessmentTemplateAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StandardizedAssessmentTemplateAssessment> standardizedassessmenttemplateassessmentCollection = new ModelCollection<StandardizedAssessmentTemplateAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    standardizedassessmenttemplateassessmentCollection.add((StandardizedAssessmentTemplateAssessment) model);
        	}
        
        	return standardizedassessmenttemplateassessmentCollection;
        }

        public static StandardizedAssessmentTemplateAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StandardizedAssessmentTemplateAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StandardizedAssessmentTemplateAssessment) gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_TEMPLATE_ASSESSMENT, id);
        }

        public StandardizedAssessmentTemplate getStandardizedAssessmentTemplate ()
        {
            return (StandardizedAssessmentTemplate) this.getProperty("standardizedAssessmentTemplate");
        }

        public void setStandardizedAssessmentTemplate (StandardizedAssessmentTemplate standardizedAssessmentTemplate)
        {
            this.setProperty("standardizedAssessmentTemplate", standardizedAssessmentTemplate);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public StandardizedAssessment getStandardizedAssessment ()
        {
            return (StandardizedAssessment) this.getProperty("standardizedAssessment");
        }

        public void setStandardizedAssessment (StandardizedAssessment standardizedAssessment)
        {
            this.setProperty("standardizedAssessment", standardizedAssessment);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }


    }
}

