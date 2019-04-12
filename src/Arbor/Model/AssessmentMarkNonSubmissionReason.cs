using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentMarkNonSubmissionReason : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_MARK_NON_SUBMISSION_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string ASSESSMENT_TYPE = "assessmentType";

        public AssessmentMarkNonSubmissionReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentMarkNonSubmissionReason (string resourceType = "AssessmentMarkNonSubmissionReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentMarkNonSubmissionReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentMarkNonSubmissionReason");
        	RestGateway gateway = (RestGateway) AssessmentMarkNonSubmissionReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentMarkNonSubmissionReason> assessmentmarknonsubmissionreasonCollection = new ModelCollection<AssessmentMarkNonSubmissionReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentmarknonsubmissionreasonCollection.add((AssessmentMarkNonSubmissionReason) model);
        	}
        
        	return assessmentmarknonsubmissionreasonCollection;
        }

        public static AssessmentMarkNonSubmissionReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentMarkNonSubmissionReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentMarkNonSubmissionReason) gateway.retrieve(ResourceType.ASSESSMENT_MARK_NON_SUBMISSION_REASON, id);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getAssessmentType ()
        {
            return this.getProperty("assessmentType").ToString();
        }

        public void setAssessmentType (string assessmentType)
        {
            this.setProperty("assessmentType", assessmentType);
        }


    }
}

