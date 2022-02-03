using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class OfstedGrade : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_OFSTED_GRADE;
        public const string LABEL = "label";
        public const string CODE = "code";
        public const string NUMERICAL_CODE = "numericalCode";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";

        public OfstedGrade ()
        {
            base.resourceType = this.resourceType;
        }
        
        public OfstedGrade (string resourceType = "OfstedGrade", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<OfstedGrade> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_OfstedGrade");
        	RestGateway gateway = (RestGateway) OfstedGrade.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<OfstedGrade> ofstedgradeCollection = new ModelCollection<OfstedGrade> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ofstedgradeCollection.add((OfstedGrade) model);
        	}
        
        	return ofstedgradeCollection;
        }

        public static OfstedGrade retrieve (string id)
        {
            RestGateway gateway = (RestGateway) OfstedGrade.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (OfstedGrade) gateway.retrieve(ResourceType.UK_DFE_OFSTED_GRADE, id);
        }

        public string getLabel ()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel (string label)
        {
            this.setProperty("label", label);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public int getNumericalCode ()
        {
            return Convert.ToInt32(this.getProperty("numericalCode"));
        }

        public void setNumericalCode (int numericalCode)
        {
            this.setProperty("numericalCode", numericalCode);
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


    }
}

