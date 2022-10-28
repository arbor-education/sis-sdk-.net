using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationLearningUnit : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_LEARNING_UNIT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_SCHEME = "qualificationScheme";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string QUALIFICATION_LEARNING_UNIT_LEVEL = "qualificationLearningUnitLevel";
        public const string LEARNING_UNIT_IDENTIFIER = "learningUnitIdentifier";
        public const string TITLE = "title";
        public const string IS_LINEAR_QUALIFICATION = "isLinearQualification";

        public QualificationLearningUnit ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationLearningUnit (string resourceType = "QualificationLearningUnit", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationLearningUnit> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationLearningUnit");
        	RestGateway gateway = (RestGateway) QualificationLearningUnit.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationLearningUnit> qualificationlearningunitCollection = new ModelCollection<QualificationLearningUnit> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationlearningunitCollection.add((QualificationLearningUnit) model);
        	}
        
        	return qualificationlearningunitCollection;
        }

        public static QualificationLearningUnit retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationLearningUnit.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationLearningUnit) gateway.retrieve(ResourceType.QUALIFICATION_LEARNING_UNIT, id);
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

        public QualificationScheme getQualificationScheme ()
        {
            return (QualificationScheme) this.getProperty("qualificationScheme");
        }

        public void setQualificationScheme (QualificationScheme qualificationScheme)
        {
            this.setProperty("qualificationScheme", qualificationScheme);
        }

        public AwardingOrganization getAwardingOrganization ()
        {
            return (AwardingOrganization) this.getProperty("awardingOrganization");
        }

        public void setAwardingOrganization (AwardingOrganization awardingOrganization)
        {
            this.setProperty("awardingOrganization", awardingOrganization);
        }

        public QualificationLearningUnitLevel getQualificationLearningUnitLevel ()
        {
            return (QualificationLearningUnitLevel) this.getProperty("qualificationLearningUnitLevel");
        }

        public void setQualificationLearningUnitLevel (QualificationLearningUnitLevel qualificationLearningUnitLevel)
        {
            this.setProperty("qualificationLearningUnitLevel", qualificationLearningUnitLevel);
        }

        public string getLearningUnitIdentifier ()
        {
            return this.getProperty("learningUnitIdentifier").ToString();
        }

        public void setLearningUnitIdentifier (string learningUnitIdentifier)
        {
            this.setProperty("learningUnitIdentifier", learningUnitIdentifier);
        }

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public bool getIsLinearQualification ()
        {
            return Convert.ToBoolean(this.getProperty("isLinearQualification"));
        }

        public void setIsLinearQualification (bool isLinearQualification)
        {
            this.setProperty("isLinearQualification", isLinearQualification);
        }


    }
}

