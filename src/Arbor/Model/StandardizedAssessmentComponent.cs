using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentComponent : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_COMPONENT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string STANDARDIZED_ASSESSMENT_SUITE = "standardizedAssessmentSuite";
        public const string SUBJECT = "subject";
        public const string CURRICULUM_GRADE = "curriculumGrade";
        public const string NAME = "name";

        public StandardizedAssessmentComponent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StandardizedAssessmentComponent (string resourceType = "StandardizedAssessmentComponent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StandardizedAssessmentComponent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StandardizedAssessmentComponent");
        	RestGateway gateway = (RestGateway) StandardizedAssessmentComponent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StandardizedAssessmentComponent> standardizedassessmentcomponentCollection = new ModelCollection<StandardizedAssessmentComponent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    standardizedassessmentcomponentCollection.add((StandardizedAssessmentComponent) model);
        	}
        
        	return standardizedassessmentcomponentCollection;
        }

        public static StandardizedAssessmentComponent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StandardizedAssessmentComponent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StandardizedAssessmentComponent) gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_COMPONENT, id);
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

        public StandardizedAssessmentSuite getStandardizedAssessmentSuite ()
        {
            return (StandardizedAssessmentSuite) this.getProperty("standardizedAssessmentSuite");
        }

        public void setStandardizedAssessmentSuite (StandardizedAssessmentSuite standardizedAssessmentSuite)
        {
            this.setProperty("standardizedAssessmentSuite", standardizedAssessmentSuite);
        }

        public Subject getSubject ()
        {
            return (Subject) this.getProperty("subject");
        }

        public void setSubject (Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public CurriculumGrade getCurriculumGrade ()
        {
            return (CurriculumGrade) this.getProperty("curriculumGrade");
        }

        public void setCurriculumGrade (CurriculumGrade curriculumGrade)
        {
            this.setProperty("curriculumGrade", curriculumGrade);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }


    }
}

