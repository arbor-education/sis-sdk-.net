using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class KpiRange : ModelBase
    {
        protected new string resourceType = ResourceType.KPI_RANGE;
        public const string KPI = "kpi";
        public const string KPI_TARGET = "kpiTarget";
        public const string RANGE_NAME = "rangeName";
        public const string ABBREVIATION = "abbreviation";
        public const string LOWER_VALUE = "lowerValue";
        public const string UPPER_VALUE = "upperValue";
        public const string VALUE_TYPE = "valueType";
        public const string COLOR = "color";

        public KpiRange ()
        {
            base.resourceType = this.resourceType;
        }
        
        public KpiRange (string resourceType = "KpiRange", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<KpiRange> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("KpiRange");
        	RestGateway gateway = (RestGateway) KpiRange.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<KpiRange> kpirangeCollection = new ModelCollection<KpiRange> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    kpirangeCollection.add((KpiRange) model);
        	}
        
        	return kpirangeCollection;
        }

        public static KpiRange retrieve (string id)
        {
            RestGateway gateway = (RestGateway) KpiRange.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (KpiRange) gateway.retrieve(ResourceType.KPI_RANGE, id);
        }

        public Kpi getKpi ()
        {
            return (Kpi) this.getProperty("kpi");
        }

        public void setKpi (Kpi kpi)
        {
            this.setProperty("kpi", kpi);
        }

        public KpiTarget getKpiTarget ()
        {
            return (KpiTarget) this.getProperty("kpiTarget");
        }

        public void setKpiTarget (KpiTarget kpiTarget)
        {
            this.setProperty("kpiTarget", kpiTarget);
        }

        public string getRangeName ()
        {
            return this.getProperty("rangeName").ToString();
        }

        public void setRangeName (string rangeName)
        {
            this.setProperty("rangeName", rangeName);
        }

        public string getAbbreviation ()
        {
            return this.getProperty("abbreviation").ToString();
        }

        public void setAbbreviation (string abbreviation)
        {
            this.setProperty("abbreviation", abbreviation);
        }

        public float getLowerValue ()
        {
            return (float) this.getProperty("lowerValue");
        }

        public void setLowerValue (float lowerValue)
        {
            this.setProperty("lowerValue", lowerValue);
        }

        public float getUpperValue ()
        {
            return (float) this.getProperty("upperValue");
        }

        public void setUpperValue (float upperValue)
        {
            this.setProperty("upperValue", upperValue);
        }

        public string getValueType ()
        {
            return this.getProperty("valueType").ToString();
        }

        public void setValueType (string valueType)
        {
            this.setProperty("valueType", valueType);
        }

        public string getColor ()
        {
            return this.getProperty("color").ToString();
        }

        public void setColor (string color)
        {
            this.setProperty("color", color);
        }


    }
}

