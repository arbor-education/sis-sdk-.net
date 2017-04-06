using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAward : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_SCHEME = "qualificationScheme";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string AWARD_IDENTIFIER = "awardIdentifier";
        public const string FULL_TITLE = "fullTitle";
        public const string SHORT_TITLE = "shortTitle";
        public const string DESCRIPTION = "description";
        public const string QUALIFICATION_AWARD_TYPE = "qualificationAwardType";
        public const string QUALIFICATION_AWARD_LEVEL = "qualificationAwardLevel";
        public const string ACCREDITATION_NUMBER = "accreditationNumber";
        public const string ACCREDITATION_START_DATE = "accreditationStartDate";
        public const string ACCREDITATION_END_DATE = "accreditationEndDate";
        public const string ACCREDITATION_REVIEW_DATE = "accreditationReviewDate";
        public const string EFFECTIVE_VERSION_START_DATE = "effectiveVersionStartDate";
        public const string EFFECTIVE_VERSION_END_DATE = "effectiveVersionEndDate";
        public const string CERTIFICATION_START_DATE = "certificationStartDate";
        public const string CERTIFICATION_END_DATE = "certificationEndDate";
        public const string OPERATIONAL_START_DATE = "operationalStartDate";
        public const string OPERATIONAL_END_DATE = "operationalEndDate";
        public const string CLASSIFICATION = "classification";
        public const string SECTOR_LEAD_ORGANIZATION = "sectorLeadOrganization";
        public const string ASSESSOR = "assessor";
        public const string QUALIFICATION_DISCOUNT_CODE = "qualificationDiscountCode";

        public QualificationAward ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAward (string resourceType = "QualificationAward", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAward> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAward");
        	RestGateway gateway = (RestGateway) QualificationAward.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAward> qualificationawardCollection = new ModelCollection<QualificationAward> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardCollection.add((QualificationAward) model);
        	}
        
        	return qualificationawardCollection;
        }

        public static QualificationAward retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAward.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAward) gateway.retrieve(ResourceType.QUALIFICATION_AWARD, id);
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

        public string getAwardIdentifier ()
        {
            return this.getProperty("awardIdentifier").ToString();
        }

        public void setAwardIdentifier (string awardIdentifier)
        {
            this.setProperty("awardIdentifier", awardIdentifier);
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

        public QualificationAwardType getQualificationAwardType ()
        {
            return (QualificationAwardType) this.getProperty("qualificationAwardType");
        }

        public void setQualificationAwardType (QualificationAwardType qualificationAwardType)
        {
            this.setProperty("qualificationAwardType", qualificationAwardType);
        }

        public QualificationAwardLevel getQualificationAwardLevel ()
        {
            return (QualificationAwardLevel) this.getProperty("qualificationAwardLevel");
        }

        public void setQualificationAwardLevel (QualificationAwardLevel qualificationAwardLevel)
        {
            this.setProperty("qualificationAwardLevel", qualificationAwardLevel);
        }

        public string getAccreditationNumber ()
        {
            return this.getProperty("accreditationNumber").ToString();
        }

        public void setAccreditationNumber (string accreditationNumber)
        {
            this.setProperty("accreditationNumber", accreditationNumber);
        }

        public DateTime getAccreditationStartDate ()
        {
            return (DateTime) this.getProperty("accreditationStartDate");
        }

        public void setAccreditationStartDate (DateTime accreditationStartDate)
        {
            this.setProperty("accreditationStartDate", accreditationStartDate);
        }

        public DateTime getAccreditationEndDate ()
        {
            return (DateTime) this.getProperty("accreditationEndDate");
        }

        public void setAccreditationEndDate (DateTime accreditationEndDate)
        {
            this.setProperty("accreditationEndDate", accreditationEndDate);
        }

        public DateTime getAccreditationReviewDate ()
        {
            return (DateTime) this.getProperty("accreditationReviewDate");
        }

        public void setAccreditationReviewDate (DateTime accreditationReviewDate)
        {
            this.setProperty("accreditationReviewDate", accreditationReviewDate);
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

        public DateTime getCertificationStartDate ()
        {
            return (DateTime) this.getProperty("certificationStartDate");
        }

        public void setCertificationStartDate (DateTime certificationStartDate)
        {
            this.setProperty("certificationStartDate", certificationStartDate);
        }

        public DateTime getCertificationEndDate ()
        {
            return (DateTime) this.getProperty("certificationEndDate");
        }

        public void setCertificationEndDate (DateTime certificationEndDate)
        {
            this.setProperty("certificationEndDate", certificationEndDate);
        }

        public DateTime getOperationalStartDate ()
        {
            return (DateTime) this.getProperty("operationalStartDate");
        }

        public void setOperationalStartDate (DateTime operationalStartDate)
        {
            this.setProperty("operationalStartDate", operationalStartDate);
        }

        public DateTime getOperationalEndDate ()
        {
            return (DateTime) this.getProperty("operationalEndDate");
        }

        public void setOperationalEndDate (DateTime operationalEndDate)
        {
            this.setProperty("operationalEndDate", operationalEndDate);
        }

        public string getClassification ()
        {
            return this.getProperty("classification").ToString();
        }

        public void setClassification (string classification)
        {
            this.setProperty("classification", classification);
        }

        public string getSectorLeadOrganization ()
        {
            return this.getProperty("sectorLeadOrganization").ToString();
        }

        public void setSectorLeadOrganization (string sectorLeadOrganization)
        {
            this.setProperty("sectorLeadOrganization", sectorLeadOrganization);
        }

        public string getAssessor ()
        {
            return this.getProperty("assessor").ToString();
        }

        public void setAssessor (string assessor)
        {
            this.setProperty("assessor", assessor);
        }

        public QualificationDiscountCode getQualificationDiscountCode ()
        {
            return (QualificationDiscountCode) this.getProperty("qualificationDiscountCode");
        }

        public void setQualificationDiscountCode (QualificationDiscountCode qualificationDiscountCode)
        {
            this.setProperty("qualificationDiscountCode", qualificationDiscountCode);
        }


    }
}

