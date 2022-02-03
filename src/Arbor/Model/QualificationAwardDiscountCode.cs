using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardDiscountCode : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_DISCOUNT_CODE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_AWARD = "qualificationAward";
        public const string DISCOUNT_CODE = "discountCode";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public QualificationAwardDiscountCode ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardDiscountCode (string resourceType = "QualificationAwardDiscountCode", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardDiscountCode> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardDiscountCode");
        	RestGateway gateway = (RestGateway) QualificationAwardDiscountCode.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardDiscountCode> qualificationawarddiscountcodeCollection = new ModelCollection<QualificationAwardDiscountCode> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawarddiscountcodeCollection.add((QualificationAwardDiscountCode) model);
        	}
        
        	return qualificationawarddiscountcodeCollection;
        }

        public static QualificationAwardDiscountCode retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardDiscountCode.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardDiscountCode) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_DISCOUNT_CODE, id);
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

        public QualificationAward getQualificationAward ()
        {
            return (QualificationAward) this.getProperty("qualificationAward");
        }

        public void setQualificationAward (QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
        }

        public string getDiscountCode ()
        {
            return this.getProperty("discountCode").ToString();
        }

        public void setDiscountCode (string discountCode)
        {
            this.setProperty("discountCode", discountCode);
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


    }
}

