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
        public const string QUALIFICATION_SUBJECT = "qualificationSubject";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string AWARD_IDENTIFIER = "awardIdentifier";
        public const string TITLE = "title";
        public const string SHORT_TITLE = "shortTitle";
        public const string QUALIFICATION_AWARD_TYPE = "qualificationAwardType";
        public const string QUALIFICATION_AWARD_SUBTYPE = "qualificationAwardSubtype";
        public const string ACCREDITATION_START_DATE = "accreditationStartDate";
        public const string ACCREDITATION_END_DATE = "accreditationEndDate";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string CERTIFICATION_END_DATE = "certificationEndDate";
        public const string OPERATIONAL_START_DATE = "operationalStartDate";
        public const string OPERATIONAL_END_DATE = "operationalEndDate";
        public const string IS_LINEAR_QUALIFICATION = "isLinearQualification";

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

        public QualificationSubject getQualificationSubject ()
        {
            return (QualificationSubject) this.getProperty("qualificationSubject");
        }

        public void setQualificationSubject (QualificationSubject qualificationSubject)
        {
            this.setProperty("qualificationSubject", qualificationSubject);
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

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public string getShortTitle ()
        {
            return this.getProperty("shortTitle").ToString();
        }

        public void setShortTitle (string shortTitle)
        {
            this.setProperty("shortTitle", shortTitle);
        }

        public QualificationAwardType getQualificationAwardType ()
        {
            return (QualificationAwardType) this.getProperty("qualificationAwardType");
        }

        public void setQualificationAwardType (QualificationAwardType qualificationAwardType)
        {
            this.setProperty("qualificationAwardType", qualificationAwardType);
        }

        public QualificationAwardSubtype getQualificationAwardSubtype ()
        {
            return (QualificationAwardSubtype) this.getProperty("qualificationAwardSubtype");
        }

        public void setQualificationAwardSubtype (QualificationAwardSubtype qualificationAwardSubtype)
        {
            this.setProperty("qualificationAwardSubtype", qualificationAwardSubtype);
        }

        public DateTime getAccreditationStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("accreditationStartDate"));
        }

        public void setAccreditationStartDate (DateTime accreditationStartDate)
        {
            this.setProperty("accreditationStartDate", accreditationStartDate);
        }

        public DateTime getAccreditationEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("accreditationEndDate"));
        }

        public void setAccreditationEndDate (DateTime accreditationEndDate)
        {
            this.setProperty("accreditationEndDate", accreditationEndDate);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public DateTime getCertificationEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("certificationEndDate"));
        }

        public void setCertificationEndDate (DateTime certificationEndDate)
        {
            this.setProperty("certificationEndDate", certificationEndDate);
        }

        public DateTime getOperationalStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("operationalStartDate"));
        }

        public void setOperationalStartDate (DateTime operationalStartDate)
        {
            this.setProperty("operationalStartDate", operationalStartDate);
        }

        public DateTime getOperationalEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("operationalEndDate"));
        }

        public void setOperationalEndDate (DateTime operationalEndDate)
        {
            this.setProperty("operationalEndDate", operationalEndDate);
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

