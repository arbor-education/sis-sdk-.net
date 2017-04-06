using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardLevel : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_LEVEL;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string AWARD_LEVEL_TYPE_NAME = "awardLevelTypeName";
        public const string SHORT_NAME = "shortName";
        public const string UK_JCQ_EDI_IDENTIFIER = "ukJcq_EdiIdentifier";
        public const string UK_JCQ_A2C_IDENTIFIER = "ukJcq_A2cIdentifier";

        public QualificationAwardLevel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardLevel (string resourceType = "QualificationAwardLevel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardLevel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardLevel");
        	RestGateway gateway = (RestGateway) QualificationAwardLevel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardLevel> qualificationawardlevelCollection = new ModelCollection<QualificationAwardLevel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardlevelCollection.add((QualificationAwardLevel) model);
        	}
        
        	return qualificationawardlevelCollection;
        }

        public static QualificationAwardLevel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardLevel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardLevel) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_LEVEL, id);
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

        public string getAwardLevelTypeName ()
        {
            return this.getProperty("awardLevelTypeName").ToString();
        }

        public void setAwardLevelTypeName (string awardLevelTypeName)
        {
            this.setProperty("awardLevelTypeName", awardLevelTypeName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
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

