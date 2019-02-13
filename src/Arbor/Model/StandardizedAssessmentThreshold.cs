using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentThreshold : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_THRESHOLD;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string MARK_STANDARDIZED_ASSESSMENT = "markStandardizedAssessment";
        public const string OUTCOME_STANDARDIZED_ASSESSMENT = "outcomeStandardizedAssessment";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public StandardizedAssessmentThreshold ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StandardizedAssessmentThreshold (string resourceType = "StandardizedAssessmentThreshold", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StandardizedAssessmentThreshold> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StandardizedAssessmentThreshold");
        	RestGateway gateway = (RestGateway) StandardizedAssessmentThreshold.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StandardizedAssessmentThreshold> standardizedassessmentthresholdCollection = new ModelCollection<StandardizedAssessmentThreshold> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    standardizedassessmentthresholdCollection.add((StandardizedAssessmentThreshold) model);
        	}
        
        	return standardizedassessmentthresholdCollection;
        }

        public static StandardizedAssessmentThreshold retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StandardizedAssessmentThreshold.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StandardizedAssessmentThreshold) gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_THRESHOLD, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"))
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public StandardizedAssessment getMarkStandardizedAssessment ()
        {
            return (StandardizedAssessment) this.getProperty("markStandardizedAssessment");
        }

        public void setMarkStandardizedAssessment (StandardizedAssessment markStandardizedAssessment)
        {
            this.setProperty("markStandardizedAssessment", markStandardizedAssessment);
        }

        public StandardizedAssessment getOutcomeStandardizedAssessment ()
        {
            return (StandardizedAssessment) this.getProperty("outcomeStandardizedAssessment");
        }

        public void setOutcomeStandardizedAssessment (StandardizedAssessment outcomeStandardizedAssessment)
        {
            this.setProperty("outcomeStandardizedAssessment", outcomeStandardizedAssessment);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

