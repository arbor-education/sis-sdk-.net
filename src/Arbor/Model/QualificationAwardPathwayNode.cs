using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardPathwayNode : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_PATHWAY_NODE;
        public const string QUALIFICATION_AWARD_PATHWAY = "qualificationAwardPathway";
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string QUALIFICATION_AWARD_ASSESSMENT = "qualificationAwardAssessment";
        public const string MANDATORY_NODE = "mandatoryNode";

        public QualificationAwardPathwayNode ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardPathwayNode (string resourceType = "QualificationAwardPathwayNode", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardPathwayNode> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardPathwayNode");
        	RestGateway gateway = (RestGateway) QualificationAwardPathwayNode.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardPathwayNode> qualificationawardpathwaynodeCollection = new ModelCollection<QualificationAwardPathwayNode> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardpathwaynodeCollection.add((QualificationAwardPathwayNode) model);
        	}
        
        	return qualificationawardpathwaynodeCollection;
        }

        public static QualificationAwardPathwayNode retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardPathwayNode.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardPathwayNode) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_PATHWAY_NODE, id);
        }

        public QualificationAwardPathway getQualificationAwardPathway ()
        {
            return (QualificationAwardPathway) this.getProperty("qualificationAwardPathway");
        }

        public void setQualificationAwardPathway (QualificationAwardPathway qualificationAwardPathway)
        {
            this.setProperty("qualificationAwardPathway", qualificationAwardPathway);
        }

        public QualificationLearningUnit getQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit (QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
        }

        public QualificationAwardAssessment getQualificationAwardAssessment ()
        {
            return (QualificationAwardAssessment) this.getProperty("qualificationAwardAssessment");
        }

        public void setQualificationAwardAssessment (QualificationAwardAssessment qualificationAwardAssessment)
        {
            this.setProperty("qualificationAwardAssessment", qualificationAwardAssessment);
        }

        public QualificationAwardPathwayNode getMandatoryNode ()
        {
            return (QualificationAwardPathwayNode) this.getProperty("mandatoryNode");
        }

        public void setMandatoryNode (QualificationAwardPathwayNode mandatoryNode)
        {
            this.setProperty("mandatoryNode", mandatoryNode);
        }


    }
}

