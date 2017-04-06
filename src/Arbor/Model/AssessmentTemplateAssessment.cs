using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentTemplateAssessment : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_TEMPLATE_ASSESSMENT;
        public const string ASSESSMENT_TEMPLATE = "assessmentTemplate";
        public const string ASSESSMENT = "assessment";
        public const string DATA_ORDER = "dataOrder";

        public AssessmentTemplateAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentTemplateAssessment (string resourceType = "AssessmentTemplateAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentTemplateAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentTemplateAssessment");
        	RestGateway gateway = (RestGateway) AssessmentTemplateAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentTemplateAssessment> assessmenttemplateassessmentCollection = new ModelCollection<AssessmentTemplateAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmenttemplateassessmentCollection.add((AssessmentTemplateAssessment) model);
        	}
        
        	return assessmenttemplateassessmentCollection;
        }

        public static AssessmentTemplateAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentTemplateAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentTemplateAssessment) gateway.retrieve(ResourceType.ASSESSMENT_TEMPLATE_ASSESSMENT, id);
        }

        public AssessmentTemplate getAssessmentTemplate ()
        {
            return (AssessmentTemplate) this.getProperty("assessmentTemplate");
        }

        public void setAssessmentTemplate (AssessmentTemplate assessmentTemplate)
        {
            this.setProperty("assessmentTemplate", assessmentTemplate);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
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

