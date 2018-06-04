using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Demographic : ModelBase
    {
        protected string resourceType = ResourceType.DEMOGRAPHIC;
        public const string LABEL = "label";
        public const string TYPE = "type";
        public const string HAS_INVERSE = "hasInverse";
        public const string INVERSE_LABEL = "inverseLabel";
        public const string DESCRIPTION = "description";
        public const string CALCULATION_CLASS = "calculationClass";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string CODE = "code";
        public const string CALCULATION_PARAMS = "calculationParams";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";

        public Demographic ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Demographic (string resourceType = "Demographic", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Demographic> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Demographic");
        	RestGateway gateway = (RestGateway) Demographic.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Demographic> demographicCollection = new ModelCollection<Demographic> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    demographicCollection.add((Demographic) model);
        	}
        
        	return demographicCollection;
        }

        public static Demographic retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Demographic.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Demographic) gateway.retrieve(ResourceType.DEMOGRAPHIC, id);
        }

        public string getLabel ()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel (string label)
        {
            this.setProperty("label", label);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public bool getHasInverse ()
        {
            return (bool) this.getProperty("hasInverse");
        }

        public void setHasInverse (bool hasInverse)
        {
            this.setProperty("hasInverse", hasInverse);
        }

        public string getInverseLabel ()
        {
            return this.getProperty("inverseLabel").ToString();
        }

        public void setInverseLabel (string inverseLabel)
        {
            this.setProperty("inverseLabel", inverseLabel);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public string getCalculationClass ()
        {
            return this.getProperty("calculationClass").ToString();
        }

        public void setCalculationClass (string calculationClass)
        {
            this.setProperty("calculationClass", calculationClass);
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

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getCalculationParams ()
        {
            return this.getProperty("calculationParams").ToString();
        }

        public void setCalculationParams (string calculationParams)
        {
            this.setProperty("calculationParams", calculationParams);
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


    }
}

