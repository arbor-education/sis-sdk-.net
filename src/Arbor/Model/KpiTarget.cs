using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class KpiTarget : ModelBase
    {
        protected string resourceType = ResourceType.KPI_TARGET;
        public const string KPI = "kpi";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string TARGET_VALUE = "targetValue";
        public const string TARGET_NAME = "targetName";
        public const string ABBREVIATION = "abbreviation";
        public const string VALUE_TYPE = "valueType";
        public const string BASIS = "basis";

        public KpiTarget ()
        {
            base.resourceType = this.resourceType;
        }
        
        public KpiTarget (string resourceType = "KpiTarget", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<KpiTarget> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("KpiTarget");
        	RestGateway gateway = (RestGateway) KpiTarget.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<KpiTarget> kpitargetCollection = new ModelCollection<KpiTarget> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    kpitargetCollection.add((KpiTarget) model);
        	}
        
        	return kpitargetCollection;
        }

        public static KpiTarget retrieve (string id)
        {
            RestGateway gateway = (RestGateway) KpiTarget.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (KpiTarget) gateway.retrieve(ResourceType.KPI_TARGET, id);
        }

        public Kpi getKpi ()
        {
            return (Kpi) this.getProperty("kpi");
        }

        public void setKpi (Kpi kpi)
        {
            this.setProperty("kpi", kpi);
        }

        public DateTime getEffectiveDate (){
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public float getTargetValue ()
        {
            return (float) this.getProperty("targetValue");
        }

        public void setTargetValue (float targetValue)
        {
            this.setProperty("targetValue", targetValue);
        }

        public string getTargetName ()
        {
            return this.getProperty("targetName").ToString();
        }

        public void setTargetName (string targetName)
        {
            this.setProperty("targetName", targetName);
        }

        public string getAbbreviation ()
        {
            return this.getProperty("abbreviation").ToString();
        }

        public void setAbbreviation (string abbreviation)
        {
            this.setProperty("abbreviation", abbreviation);
        }

        public string getValueType ()
        {
            return this.getProperty("valueType").ToString();
        }

        public void setValueType (string valueType)
        {
            this.setProperty("valueType", valueType);
        }

        public ModelBase getBasis ()
        {
            return (ModelBase) this.getProperty("basis");
        }

        public void setBasis (ModelBase basis)
        {
            this.setProperty("basis", basis);
        }


    }
}

