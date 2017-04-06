using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardPathway : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_PATHWAY;
        public const string PARENT_PATHWAY = "parentPathway";
        public const string DEPENDENT_LEARNING_UNIT_1 = "dependentLearningUnit_1";
        public const string DEPENDENT_LEARNING_UNIT_2 = "dependentLearningUnit_2";

        public QualificationAwardPathway ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardPathway (string resourceType = "QualificationAwardPathway", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardPathway> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardPathway");
        	RestGateway gateway = (RestGateway) QualificationAwardPathway.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardPathway> qualificationawardpathwayCollection = new ModelCollection<QualificationAwardPathway> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardpathwayCollection.add((QualificationAwardPathway) model);
        	}
        
        	return qualificationawardpathwayCollection;
        }

        public static QualificationAwardPathway retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardPathway.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardPathway) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_PATHWAY, id);
        }

        public QualificationAwardPathway getParentPathway ()
        {
            return (QualificationAwardPathway) this.getProperty("parentPathway");
        }

        public void setParentPathway (QualificationAwardPathway parentPathway)
        {
            this.setProperty("parentPathway", parentPathway);
        }

        public QualificationLearningUnit getDependentLearningUnit_1 ()
        {
            return (QualificationLearningUnit) this.getProperty("dependentLearningUnit_1");
        }

        public void setDependentLearningUnit_1 (QualificationLearningUnit dependentLearningUnit_1)
        {
            this.setProperty("dependentLearningUnit_1", dependentLearningUnit_1);
        }

        public QualificationLearningUnit getDependentLearningUnit_2 ()
        {
            return (QualificationLearningUnit) this.getProperty("dependentLearningUnit_2");
        }

        public void setDependentLearningUnit_2 (QualificationLearningUnit dependentLearningUnit_2)
        {
            this.setProperty("dependentLearningUnit_2", dependentLearningUnit_2);
        }


    }
}

