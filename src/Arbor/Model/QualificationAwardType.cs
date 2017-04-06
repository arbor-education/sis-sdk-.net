using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardType : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string AWARD_TYPE_NAME = "awardTypeName";
        public const string SHORT_NAME = "shortName";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string UK_JCQ_EDI_IDENTIFIER = "ukJcq_EdiIdentifier";
        public const string UK_JCQ_A2C_IDENTIFIER = "ukJcq_A2cIdentifier";

        public QualificationAwardType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardType (string resourceType = "QualificationAwardType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardType");
        	RestGateway gateway = (RestGateway) QualificationAwardType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardType> qualificationawardtypeCollection = new ModelCollection<QualificationAwardType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardtypeCollection.add((QualificationAwardType) model);
        	}
        
        	return qualificationawardtypeCollection;
        }

        public static QualificationAwardType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardType) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_TYPE, id);
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

        public string getAwardTypeName ()
        {
            return this.getProperty("awardTypeName").ToString();
        }

        public void setAwardTypeName (string awardTypeName)
        {
            this.setProperty("awardTypeName", awardTypeName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public DateTime getEffectiveDate ()
        {
            return (DateTime) this.getProperty("effectiveDate");
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getUkJcq_EdiIdentifier ()
        {
            return this.getProperty("ukJcq_EdiIdentifier").ToString();
        }

        public void setUkJcq_EdiIdentifier (string ukJcq_EdiIdentifier)
        {
            this.setProperty("ukJcq_EdiIdentifier", ukJcq_EdiIdentifier);
        }

        public string getUkJcq_A2cIdentifier ()
        {
            return this.getProperty("ukJcq_A2cIdentifier").ToString();
        }

        public void setUkJcq_A2cIdentifier (string ukJcq_A2cIdentifier)
        {
            this.setProperty("ukJcq_A2cIdentifier", ukJcq_A2cIdentifier);
        }


    }
}

