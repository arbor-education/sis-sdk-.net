using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardLearningUnit : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_LEARNING_UNIT;
        public const string QUALIFICATION_AWARD = "qualificationAward";
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string IS_USER_DEFINED = "isUserDefined";

        public QualificationAwardLearningUnit ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardLearningUnit (string resourceType = "QualificationAwardLearningUnit", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardLearningUnit> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardLearningUnit");
        	RestGateway gateway = (RestGateway) QualificationAwardLearningUnit.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardLearningUnit> qualificationawardlearningunitCollection = new ModelCollection<QualificationAwardLearningUnit> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardlearningunitCollection.add((QualificationAwardLearningUnit) model);
        	}
        
        	return qualificationawardlearningunitCollection;
        }

        public static QualificationAwardLearningUnit retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardLearningUnit.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardLearningUnit) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_LEARNING_UNIT, id);
        }

        public QualificationAward getQualificationAward ()
        {
            return (QualificationAward) this.getProperty("qualificationAward");
        }

        public void setQualificationAward (QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
        }

        public QualificationLearningUnit getQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit (QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
        }

        public bool getIsUserDefined ()
        {
            return Convert.ToBoolean(this.getProperty("isUserDefined"));
        }

        public void setIsUserDefined (bool isUserDefined)
        {
            this.setProperty("isUserDefined", isUserDefined);
        }


    }
}

