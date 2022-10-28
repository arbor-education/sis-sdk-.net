using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationLearningUnitAssessable : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_LEARNING_UNIT_ASSESSABLE;
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string QUALIFICATION_ASSESSABLE = "qualificationAssessable";

        public QualificationLearningUnitAssessable ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationLearningUnitAssessable (string resourceType = "QualificationLearningUnitAssessable", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationLearningUnitAssessable> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationLearningUnitAssessable");
        	RestGateway gateway = (RestGateway) QualificationLearningUnitAssessable.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationLearningUnitAssessable> qualificationlearningunitassessableCollection = new ModelCollection<QualificationLearningUnitAssessable> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationlearningunitassessableCollection.add((QualificationLearningUnitAssessable) model);
        	}
        
        	return qualificationlearningunitassessableCollection;
        }

        public static QualificationLearningUnitAssessable retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationLearningUnitAssessable.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationLearningUnitAssessable) gateway.retrieve(ResourceType.QUALIFICATION_LEARNING_UNIT_ASSESSABLE, id);
        }

        public QualificationLearningUnit getQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit (QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
        }

        public QualificationAssessable getQualificationAssessable ()
        {
            return (QualificationAssessable) this.getProperty("qualificationAssessable");
        }

        public void setQualificationAssessable (QualificationAssessable qualificationAssessable)
        {
            this.setProperty("qualificationAssessable", qualificationAssessable);
        }


    }
}

