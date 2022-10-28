using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetablerImportResultUpdate : ModelBase
    {
        protected new string resourceType = ResourceType.TIMETABLER_IMPORT_RESULT_UPDATE;
        public const string TIMETABLER_IMPORT_RESULT = "timetablerImportResult";
        public const string UPDATED = "updated";

        public TimetablerImportResultUpdate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetablerImportResultUpdate (string resourceType = "TimetablerImportResultUpdate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetablerImportResultUpdate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetablerImportResultUpdate");
        	RestGateway gateway = (RestGateway) TimetablerImportResultUpdate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetablerImportResultUpdate> timetablerimportresultupdateCollection = new ModelCollection<TimetablerImportResultUpdate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetablerimportresultupdateCollection.add((TimetablerImportResultUpdate) model);
        	}
        
        	return timetablerimportresultupdateCollection;
        }

        public static TimetablerImportResultUpdate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetablerImportResultUpdate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetablerImportResultUpdate) gateway.retrieve(ResourceType.TIMETABLER_IMPORT_RESULT_UPDATE, id);
        }

        public TimetablerImportResult getTimetablerImportResult ()
        {
            return (TimetablerImportResult) this.getProperty("timetablerImportResult");
        }

        public void setTimetablerImportResult (TimetablerImportResult timetablerImportResult)
        {
            this.setProperty("timetablerImportResult", timetablerImportResult);
        }

        public ModelBase getUpdated ()
        {
            return (ModelBase) this.getProperty("updated");
        }

        public void setUpdated (ModelBase updated)
        {
            this.setProperty("updated", updated);
        }


    }
}

