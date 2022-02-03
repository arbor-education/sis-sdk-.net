using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetablerImportResultError : ModelBase
    {
        protected string resourceType = ResourceType.TIMETABLER_IMPORT_RESULT_ERROR;
        public const string TIMETABLER_IMPORT_RESULT = "timetablerImportResult";
        public const string ERROR_MESSAGE = "errorMessage";

        public TimetablerImportResultError ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetablerImportResultError (string resourceType = "TimetablerImportResultError", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetablerImportResultError> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetablerImportResultError");
        	RestGateway gateway = (RestGateway) TimetablerImportResultError.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetablerImportResultError> timetablerimportresulterrorCollection = new ModelCollection<TimetablerImportResultError> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetablerimportresulterrorCollection.add((TimetablerImportResultError) model);
        	}
        
        	return timetablerimportresulterrorCollection;
        }

        public static TimetablerImportResultError retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetablerImportResultError.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetablerImportResultError) gateway.retrieve(ResourceType.TIMETABLER_IMPORT_RESULT_ERROR, id);
        }

        public TimetablerImportResult getTimetablerImportResult ()
        {
            return (TimetablerImportResult) this.getProperty("timetablerImportResult");
        }

        public void setTimetablerImportResult (TimetablerImportResult timetablerImportResult)
        {
            this.setProperty("timetablerImportResult", timetablerImportResult);
        }

        public string getErrorMessage ()
        {
            return this.getProperty("errorMessage").ToString();
        }

        public void setErrorMessage (string errorMessage)
        {
            this.setProperty("errorMessage", errorMessage);
        }


    }
}

