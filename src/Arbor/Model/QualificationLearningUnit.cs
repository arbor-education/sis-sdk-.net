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
        protected string resourceType = ResourceType.QUALIFICATION_LEARNING_UNIT;
        public const string CODE = "code";
        public const string QUALIFICATION_SCHEME = "qualificationScheme";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string LEARNING_UNIT_IDENTIFIER = "learningUnitIdentifier";
        public const string FULL_TITLE = "fullTitle";
        public const string SHORT_TITLE = "shortTitle";
        public const string DESCRIPTION = "description";

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

        public string getLearningUnitIdentifier ()
        {
            return this.getProperty("learningUnitIdentifier").ToString();
        }

        public void setLearningUnitIdentifier (string learningUnitIdentifier)
        {
            this.setProperty("learningUnitIdentifier", learningUnitIdentifier);
        }

        public string getFullTitle ()
        {
            return this.getProperty("fullTitle").ToString();
        }

        public void setFullTitle (string fullTitle)
        {
            this.setProperty("fullTitle", fullTitle);
        }

        public string getShortTitle ()
        {
            return this.getProperty("shortTitle").ToString();
        }

        public void setShortTitle (string shortTitle)
        {
            this.setProperty("shortTitle", shortTitle);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

