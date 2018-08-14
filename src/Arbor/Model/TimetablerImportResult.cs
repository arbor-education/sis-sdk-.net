using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetablerImportResult : ModelBase
    {
        protected string resourceType = ResourceType.TIMETABLER_IMPORT_RESULT;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string STEPS_COMPLETED = "stepsCompleted";
        public const string STARTED_DATETIME = "startedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string FILE_HASH = "fileHash";

        public TimetablerImportResult ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetablerImportResult (string resourceType = "TimetablerImportResult", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetablerImportResult> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetablerImportResult");
        	RestGateway gateway = (RestGateway) TimetablerImportResult.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetablerImportResult> timetablerimportresultCollection = new ModelCollection<TimetablerImportResult> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetablerimportresultCollection.add((TimetablerImportResult) model);
        	}
        
        	return timetablerimportresultCollection;
        }

        public static TimetablerImportResult retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetablerImportResult.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetablerImportResult) gateway.retrieve(ResourceType.TIMETABLER_IMPORT_RESULT, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public int getStepsCompleted ()
        {
            return Convert.ToInt32(this.getProperty("stepsCompleted"));
        }

        public void setStepsCompleted (int stepsCompleted)
        {
            this.setProperty("stepsCompleted", stepsCompleted);
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

        public string getFileHash ()
        {
            return this.getProperty("fileHash").ToString();
        }

        public void setFileHash (string fileHash)
        {
            this.setProperty("fileHash", fileHash);
        }


    }
}

