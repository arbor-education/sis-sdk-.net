using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryPaymentAutomaticCriterion : ModelBase
    {
        protected new string resourceType = ResourceType.BURSARY_PAYMENT_AUTOMATIC_CRITERION;
        public const string BURSARY_TYPE = "bursaryType";
        public const string NAME = "name";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TRANSFORMATION_CLASS = "transformationClass";
        public const string CONDITION_CLASS = "conditionClass";
        public const string CONDITION_PARAMS = "conditionParams";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public BursaryPaymentAutomaticCriterion ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BursaryPaymentAutomaticCriterion (string resourceType = "BursaryPaymentAutomaticCriterion", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BursaryPaymentAutomaticCriterion> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BursaryPaymentAutomaticCriterion");
        	RestGateway gateway = (RestGateway) BursaryPaymentAutomaticCriterion.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BursaryPaymentAutomaticCriterion> bursarypaymentautomaticcriterionCollection = new ModelCollection<BursaryPaymentAutomaticCriterion> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bursarypaymentautomaticcriterionCollection.add((BursaryPaymentAutomaticCriterion) model);
        	}
        
        	return bursarypaymentautomaticcriterionCollection;
        }

        public static BursaryPaymentAutomaticCriterion retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BursaryPaymentAutomaticCriterion.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BursaryPaymentAutomaticCriterion) gateway.retrieve(ResourceType.BURSARY_PAYMENT_AUTOMATIC_CRITERION, id);
        }

        public BursaryType getBursaryType ()
        {
            return (BursaryType) this.getProperty("bursaryType");
        }

        public void setBursaryType (BursaryType bursaryType)
        {
            this.setProperty("bursaryType", bursaryType);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getFieldClass ()
        {
            return this.getProperty("fieldClass").ToString();
        }

        public void setFieldClass (string fieldClass)
        {
            this.setProperty("fieldClass", fieldClass);
        }

        public string getFieldParams ()
        {
            return this.getProperty("fieldParams").ToString();
        }

        public void setFieldParams (string fieldParams)
        {
            this.setProperty("fieldParams", fieldParams);
        }

        public string getTransformationClass ()
        {
            return this.getProperty("transformationClass").ToString();
        }

        public void setTransformationClass (string transformationClass)
        {
            this.setProperty("transformationClass", transformationClass);
        }

        public string getConditionClass ()
        {
            return this.getProperty("conditionClass").ToString();
        }

        public void setConditionClass (string conditionClass)
        {
            this.setProperty("conditionClass", conditionClass);
        }

        public string getConditionParams ()
        {
            return this.getProperty("conditionParams").ToString();
        }

        public void setConditionParams (string conditionParams)
        {
            this.setProperty("conditionParams", conditionParams);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
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

