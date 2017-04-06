using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardPathwayExclusion : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_PATHWAY_EXCLUSION;
        public const string PARENT_PATHWAY = "parentPathway";
        public const string EXCLUDING_LEARNING_UNIT_1 = "excludingLearningUnit_1";
        public const string EXCLUDING_LEARNING_UNIT_2 = "excludingLearningUnit_2";

        public QualificationAwardPathwayExclusion ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardPathwayExclusion (string resourceType = "QualificationAwardPathwayExclusion", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardPathwayExclusion> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardPathwayExclusion");
        	RestGateway gateway = (RestGateway) QualificationAwardPathwayExclusion.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardPathwayExclusion> qualificationawardpathwayexclusionCollection = new ModelCollection<QualificationAwardPathwayExclusion> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardpathwayexclusionCollection.add((QualificationAwardPathwayExclusion) model);
        	}
        
        	return qualificationawardpathwayexclusionCollection;
        }

        public static QualificationAwardPathwayExclusion retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardPathwayExclusion.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardPathwayExclusion) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_PATHWAY_EXCLUSION, id);
        }

        public QualificationAwardPathway getParentPathway ()
        {
            return (QualificationAwardPathway) this.getProperty("parentPathway");
        }

        public void setParentPathway (QualificationAwardPathway parentPathway)
        {
            this.setProperty("parentPathway", parentPathway);
        }

        public QualificationLearningUnit getExcludingLearningUnit_1 ()
        {
            return (QualificationLearningUnit) this.getProperty("excludingLearningUnit_1");
        }

        public void setExcludingLearningUnit_1 (QualificationLearningUnit excludingLearningUnit_1)
        {
            this.setProperty("excludingLearningUnit_1", excludingLearningUnit_1);
        }

        public QualificationLearningUnit getExcludingLearningUnit_2 ()
        {
            return (QualificationLearningUnit) this.getProperty("excludingLearningUnit_2");
        }

        public void setExcludingLearningUnit_2 (QualificationLearningUnit excludingLearningUnit_2)
        {
            this.setProperty("excludingLearningUnit_2", excludingLearningUnit_2);
        }


    }
}

