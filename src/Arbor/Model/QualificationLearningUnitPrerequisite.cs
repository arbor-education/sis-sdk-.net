using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationLearningUnitPrerequisite : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_LEARNING_UNIT_PREREQUISITE;
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string REQUIRED_LEARNING_UNIT = "requiredLearningUnit";

        public QualificationLearningUnitPrerequisite ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationLearningUnitPrerequisite (string resourceType = "QualificationLearningUnitPrerequisite", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationLearningUnitPrerequisite> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationLearningUnitPrerequisite");
        	RestGateway gateway = (RestGateway) QualificationLearningUnitPrerequisite.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationLearningUnitPrerequisite> qualificationlearningunitprerequisiteCollection = new ModelCollection<QualificationLearningUnitPrerequisite> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationlearningunitprerequisiteCollection.add((QualificationLearningUnitPrerequisite) model);
        	}
        
        	return qualificationlearningunitprerequisiteCollection;
        }

        public static QualificationLearningUnitPrerequisite retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationLearningUnitPrerequisite.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationLearningUnitPrerequisite) gateway.retrieve(ResourceType.QUALIFICATION_LEARNING_UNIT_PREREQUISITE, id);
        }

        public QualificationLearningUnit getQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit (QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
        }

        public QualificationLearningUnit getRequiredLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("requiredLearningUnit");
        }

        public void setRequiredLearningUnit (QualificationLearningUnit requiredLearningUnit)
        {
            this.setProperty("requiredLearningUnit", requiredLearningUnit);
        }


    }
}

