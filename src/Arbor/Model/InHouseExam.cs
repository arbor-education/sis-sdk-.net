using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseExam : ModelBase
    {
        protected string resourceType = ResourceType.IN_HOUSE_EXAM;
        public const string MOCK_QUALIFICATION_ASSESSABLE = "mockQualificationAssessable";
        public const string MOCK_QUALIFICATION_LEARNING_UNIT = "mockQualificationLearningUnit";
        public const string DURATION = "duration";
        public const string NAME = "name";

        public InHouseExam ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InHouseExam (string resourceType = "InHouseExam", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InHouseExam> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InHouseExam");
        	RestGateway gateway = (RestGateway) InHouseExam.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InHouseExam> inhouseexamCollection = new ModelCollection<InHouseExam> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    inhouseexamCollection.add((InHouseExam) model);
        	}
        
        	return inhouseexamCollection;
        }

        public static InHouseExam retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InHouseExam.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InHouseExam) gateway.retrieve(ResourceType.IN_HOUSE_EXAM, id);
        }

        public QualificationAssessable getMockQualificationAssessable ()
        {
            return (QualificationAssessable) this.getProperty("mockQualificationAssessable");
        }

        public void setMockQualificationAssessable (QualificationAssessable mockQualificationAssessable)
        {
            this.setProperty("mockQualificationAssessable", mockQualificationAssessable);
        }

        public QualificationLearningUnit getMockQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("mockQualificationLearningUnit");
        }

        public void setMockQualificationLearningUnit (QualificationLearningUnit mockQualificationLearningUnit)
        {
            this.setProperty("mockQualificationLearningUnit", mockQualificationLearningUnit);
        }

        public string getDuration ()
        {
            return this.getProperty("duration").ToString();
        }

        public void setDuration (string duration)
        {
            this.setProperty("duration", duration);
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

