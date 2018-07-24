using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class KpiCalculationJob : ModelBase
    {
        protected string resourceType = ResourceType.KPI_CALCULATION_JOB;
        public const string KPI = "kpi";
        public const string REFERENCE_DATE = "referenceDate";
        public const string REQUESTED_DATETIME = "requestedDatetime";
        public const string STARTED_DATETIME = "startedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string THREAD_ID = "threadId";

        public KpiCalculationJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public KpiCalculationJob (string resourceType = "KpiCalculationJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<KpiCalculationJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("KpiCalculationJob");
        	RestGateway gateway = (RestGateway) KpiCalculationJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<KpiCalculationJob> kpicalculationjobCollection = new ModelCollection<KpiCalculationJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    kpicalculationjobCollection.add((KpiCalculationJob) model);
        	}
        
        	return kpicalculationjobCollection;
        }

        public static KpiCalculationJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) KpiCalculationJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (KpiCalculationJob) gateway.retrieve(ResourceType.KPI_CALCULATION_JOB, id);
        }

        public Kpi getKpi ()
        {
            return (Kpi) this.getProperty("kpi");
        }

        public void setKpi (Kpi kpi)
        {
            this.setProperty("kpi", kpi);
        }

        public DateTime getReferenceDate (){
            return Convert.ToDateTime(this.getProperty("referenceDate"));
        }

        public void setReferenceDate (DateTime referenceDate)
        {
            this.setProperty("referenceDate", referenceDate);
        }

        public DateTime getRequestedDatetime (){
            return Convert.ToDateTime(this.getProperty("requestedDatetime"));
        }

        public void setRequestedDatetime (DateTime requestedDatetime)
        {
            this.setProperty("requestedDatetime", requestedDatetime);
        }

        public DateTime getStartedDatetime (){
            return Convert.ToDateTime(this.getProperty("startedDatetime"));
        }

        public void setStartedDatetime (DateTime startedDatetime)
        {
            this.setProperty("startedDatetime", startedDatetime);
        }

        public DateTime getCompletedDatetime (){
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public string getThreadId ()
        {
            return this.getProperty("threadId").ToString();
        }

        public void setThreadId (string threadId)
        {
            this.setProperty("threadId", threadId);
        }


    }
}

