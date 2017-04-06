using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationScheme : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_SCHEME;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string SCHEME_IDENTIFIER = "schemeIdentifier";
        public const string QUALIFICATION_SCHEME_TYPE = "qualificationSchemeType";
        public const string FULL_TITLE = "fullTitle";
        public const string SHORT_TITLE = "shortTitle";
        public const string DESCRIPTION = "description";
        public const string SCHEME_START_DATE = "schemeStartDate";
        public const string SCHEME_END_DATE = "schemeEndDate";
        public const string EFFECTIVE_VERSION_START_DATE = "effectiveVersionStartDate";
        public const string EFFECTIVE_VERSION_END_DATE = "effectiveVersionEndDate";
        public const string FIRST_TEACHING_DATE = "firstTeachingDate";
        public const string LAST_TEACHING_DATE = "lastTeachingDate";
        public const string ASSESSMENT_MINIMUM_LEARNER_AGE = "assessmentMinimumLearnerAge";
        public const string ASSESSMENT_MAXIMUM_LEARNER_AGE = "assessmentMaximumLearnerAge";

        public QualificationScheme ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationScheme (string resourceType = "QualificationScheme", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationScheme> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationScheme");
        	RestGateway gateway = (RestGateway) QualificationScheme.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationScheme> qualificationschemeCollection = new ModelCollection<QualificationScheme> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationschemeCollection.add((QualificationScheme) model);
        	}
        
        	return qualificationschemeCollection;
        }

        public static QualificationScheme retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationScheme.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationScheme) gateway.retrieve(ResourceType.QUALIFICATION_SCHEME, id);
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
            return (bool) this.getProperty("active");
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

        public AwardingOrganization getAwardingOrganization ()
        {
            return (AwardingOrganization) this.getProperty("awardingOrganization");
        }

        public void setAwardingOrganization (AwardingOrganization awardingOrganization)
        {
            this.setProperty("awardingOrganization", awardingOrganization);
        }

        public string getSchemeIdentifier ()
        {
            return this.getProperty("schemeIdentifier").ToString();
        }

        public void setSchemeIdentifier (string schemeIdentifier)
        {
            this.setProperty("schemeIdentifier", schemeIdentifier);
        }

        public QualificationSchemeType getQualificationSchemeType ()
        {
            return (QualificationSchemeType) this.getProperty("qualificationSchemeType");
        }

        public void setQualificationSchemeType (QualificationSchemeType qualificationSchemeType)
        {
            this.setProperty("qualificationSchemeType", qualificationSchemeType);
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

        public DateTime getSchemeStartDate ()
        {
            return (DateTime) this.getProperty("schemeStartDate");
        }

        public void setSchemeStartDate (DateTime schemeStartDate)
        {
            this.setProperty("schemeStartDate", schemeStartDate);
        }

        public DateTime getSchemeEndDate ()
        {
            return (DateTime) this.getProperty("schemeEndDate");
        }

        public void setSchemeEndDate (DateTime schemeEndDate)
        {
            this.setProperty("schemeEndDate", schemeEndDate);
        }

        public DateTime getEffectiveVersionStartDate ()
        {
            return (DateTime) this.getProperty("effectiveVersionStartDate");
        }

        public void setEffectiveVersionStartDate (DateTime effectiveVersionStartDate)
        {
            this.setProperty("effectiveVersionStartDate", effectiveVersionStartDate);
        }

        public DateTime getEffectiveVersionEndDate ()
        {
            return (DateTime) this.getProperty("effectiveVersionEndDate");
        }

        public void setEffectiveVersionEndDate (DateTime effectiveVersionEndDate)
        {
            this.setProperty("effectiveVersionEndDate", effectiveVersionEndDate);
        }

        public DateTime getFirstTeachingDate ()
        {
            return (DateTime) this.getProperty("firstTeachingDate");
        }

        public void setFirstTeachingDate (DateTime firstTeachingDate)
        {
            this.setProperty("firstTeachingDate", firstTeachingDate);
        }

        public DateTime getLastTeachingDate ()
        {
            return (DateTime) this.getProperty("lastTeachingDate");
        }

        public void setLastTeachingDate (DateTime lastTeachingDate)
        {
            this.setProperty("lastTeachingDate", lastTeachingDate);
        }

        public int getAssessmentMinimumLearnerAge ()
        {
            return Convert.ToInt32(this.getProperty("assessmentMinimumLearnerAge"));
        }

        public void setAssessmentMinimumLearnerAge (int assessmentMinimumLearnerAge)
        {
            this.setProperty("assessmentMinimumLearnerAge", assessmentMinimumLearnerAge);
        }

        public int getAssessmentMaximumLearnerAge ()
        {
            return Convert.ToInt32(this.getProperty("assessmentMaximumLearnerAge"));
        }

        public void setAssessmentMaximumLearnerAge (int assessmentMaximumLearnerAge)
        {
            this.setProperty("assessmentMaximumLearnerAge", assessmentMaximumLearnerAge);
        }


    }
}

