using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class LgflExportJob : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_LGFL_EXPORT_JOB;
        public const string STARTED_DATETIME = "startedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string ERROR_DATETIME = "errorDatetime";
        public const string ERROR_LOG = "errorLog";

        public LgflExportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LgflExportJob (string resourceType = "LgflExportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LgflExportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_LgflExportJob");
        	RestGateway gateway = (RestGateway) LgflExportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LgflExportJob> lgflexportjobCollection = new ModelCollection<LgflExportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    lgflexportjobCollection.add((LgflExportJob) model);
        	}
        
        	return lgflexportjobCollection;
        }

        public static LgflExportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LgflExportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LgflExportJob) gateway.retrieve(ResourceType.UK_DFE_LGFL_EXPORT_JOB, id);
        }

        public DateTime getStartedDatetime ()
        {
            return (DateTime) this.getProperty("startedDatetime");
        }

        public void setStartedDatetime (DateTime startedDatetime)
        {
            this.setProperty("startedDatetime", startedDatetime);
        }

        public DateTime getCompletedDatetime ()
        {
            return (DateTime) this.getProperty("completedDatetime");
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public DateTime getErrorDatetime ()
        {
            return (DateTime) this.getProperty("errorDatetime");
        }

        public void setErrorDatetime (DateTime errorDatetime)
        {
            this.setProperty("errorDatetime", errorDatetime);
        }

        public string getErrorLog ()
        {
            return this.getProperty("errorLog").ToString();
        }

        public void setErrorLog (string errorLog)
        {
            this.setProperty("errorLog", errorLog);
        }


    }
}

