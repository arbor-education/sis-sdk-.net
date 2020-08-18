using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class CapitaOneStudentExportJob : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CAPITA_ONE_STUDENT_EXPORT_JOB;
        public const string SEQUENCE_NUMBER = "sequenceNumber";
        public const string STARTED_DATETIME = "startedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string ERROR_DATETIME = "errorDatetime";
        public const string ERROR_LOG = "errorLog";

        public CapitaOneStudentExportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CapitaOneStudentExportJob (string resourceType = "CapitaOneStudentExportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CapitaOneStudentExportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_CapitaOneStudentExportJob");
        	RestGateway gateway = (RestGateway) CapitaOneStudentExportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CapitaOneStudentExportJob> capitaonestudentexportjobCollection = new ModelCollection<CapitaOneStudentExportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    capitaonestudentexportjobCollection.add((CapitaOneStudentExportJob) model);
        	}
        
        	return capitaonestudentexportjobCollection;
        }

        public static CapitaOneStudentExportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CapitaOneStudentExportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CapitaOneStudentExportJob) gateway.retrieve(ResourceType.UK_DFE_CAPITA_ONE_STUDENT_EXPORT_JOB, id);
        }

        public int getSequenceNumber ()
        {
            return Convert.ToInt32(this.getProperty("sequenceNumber"));
        }

        public void setSequenceNumber (int sequenceNumber)
        {
            this.setProperty("sequenceNumber", sequenceNumber);
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

        public DateTime getErrorDatetime (){
            return Convert.ToDateTime(this.getProperty("errorDatetime"));
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

