using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationDiscountCode : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_DISCOUNT_CODE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public QualificationDiscountCode ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationDiscountCode (string resourceType = "QualificationDiscountCode", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationDiscountCode> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationDiscountCode");
        	RestGateway gateway = (RestGateway) QualificationDiscountCode.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationDiscountCode> qualificationdiscountcodeCollection = new ModelCollection<QualificationDiscountCode> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationdiscountcodeCollection.add((QualificationDiscountCode) model);
        	}
        
        	return qualificationdiscountcodeCollection;
        }

        public static QualificationDiscountCode retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationDiscountCode.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationDiscountCode) gateway.retrieve(ResourceType.QUALIFICATION_DISCOUNT_CODE, id);
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

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
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


    }
}

