using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class KpiValue : ModelBase
    {
        protected string resourceType = ResourceType.KPI_VALUE;
        public const string KPI = "kpi";
        public const string KPI_CATEGORY = "kpiCategory";
        public const string REFERENCE_DATETIME = "referenceDatetime";
        public const string CALCULATION_RANGE_START_DATETIME = "calculationRangeStartDatetime";
        public const string CALCULATION_RANGE_END_DATETIME = "calculationRangeEndDatetime";
        public const string BASIS = "basis";
        public const string VALUE = "value";
        public const string KPI_RANGE = "kpiRange";
        public const string RECALCULATION_SCHEDULED_DATETIME = "recalculationScheduledDatetime";
        public const string RECALCULATION_STARTED_DATETIME = "recalculationStartedDatetime";
        public const string LAST_CALCULATED_DATETIME = "lastCalculatedDatetime";

        public KpiValue()
        {
            base.resourceType = this.resourceType;
        }

        public KpiValue(string resourceType = "KpiValue", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<KpiValue> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("KpiValue");
            RestGateway gateway = (RestGateway)KpiValue.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<KpiValue> kpivalueCollection = new ModelCollection<KpiValue>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                kpivalueCollection.add((KpiValue)model);
            }

            return kpivalueCollection;
        }

        public static KpiValue retrieve(string id)
        {
            RestGateway gateway = (RestGateway)KpiValue.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (KpiValue)gateway.retrieve(ResourceType.KPI_VALUE, id);
        }

        public Kpi getKpi()
        {
            return (Kpi)this.getProperty("kpi");
        }

        public void setKpi(Kpi kpi)
        {
            this.setProperty("kpi", kpi);
        }

        public string getKpiCategory()
        {
            return this.getProperty("kpiCategory").ToString();
        }

        public void setKpiCategory(string kpiCategory)
        {
            this.setProperty("kpiCategory", kpiCategory);
        }

        public DateTime getReferenceDatetime()
        {
            return Convert.ToDateTime(this.getProperty("referenceDatetime"));
        }

        public void setReferenceDatetime(DateTime referenceDatetime)
        {
            this.setProperty("referenceDatetime", referenceDatetime);
        }

        public DateTime getCalculationRangeStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("calculationRangeStartDatetime"));
        }

        public void setCalculationRangeStartDatetime(DateTime calculationRangeStartDatetime)
        {
            this.setProperty("calculationRangeStartDatetime", calculationRangeStartDatetime);
        }

        public DateTime getCalculationRangeEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("calculationRangeEndDatetime"));
        }

        public void setCalculationRangeEndDatetime(DateTime calculationRangeEndDatetime)
        {
            this.setProperty("calculationRangeEndDatetime", calculationRangeEndDatetime);
        }

        public ModelBase getBasis()
        {
            return (ModelBase)this.getProperty("basis");
        }

        public void setBasis(ModelBase basis)
        {
            this.setProperty("basis", basis);
        }

        public float getValue()
        {
            return (float)this.getProperty("value");
        }

        public void setValue(float value)
        {
            this.setProperty("value", value);
        }

        public KpiRange getKpiRange()
        {
            return (KpiRange)this.getProperty("kpiRange");
        }

        public void setKpiRange(KpiRange kpiRange)
        {
            this.setProperty("kpiRange", kpiRange);
        }

        public DateTime getRecalculationScheduledDatetime()
        {
            return Convert.ToDateTime(this.getProperty("recalculationScheduledDatetime"));
        }

        public void setRecalculationScheduledDatetime(DateTime recalculationScheduledDatetime)
        {
            this.setProperty("recalculationScheduledDatetime", recalculationScheduledDatetime);
        }

        public DateTime getRecalculationStartedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("recalculationStartedDatetime"));
        }

        public void setRecalculationStartedDatetime(DateTime recalculationStartedDatetime)
        {
            this.setProperty("recalculationStartedDatetime", recalculationStartedDatetime);
        }

        public DateTime getLastCalculatedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastCalculatedDatetime"));
        }

        public void setLastCalculatedDatetime(DateTime lastCalculatedDatetime)
        {
            this.setProperty("lastCalculatedDatetime", lastCalculatedDatetime);
        }


    }
}

