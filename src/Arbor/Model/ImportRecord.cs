using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ImportRecord : ModelBase
    {
        protected string resourceType = ResourceType.IMPORT_RECORD;
        public const string IMPORTER = "importer";
        public const string IMPORTER_NAME = "importerName";
        public const string IMPORTED_RECORD_ENTITY_TYPE = "importedRecordEntityType";
        public const string IMPORTED_RECORD = "importedRecord";

        public ImportRecord ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ImportRecord (string resourceType = "ImportRecord", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ImportRecord> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ImportRecord");
        	RestGateway gateway = (RestGateway) ImportRecord.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ImportRecord> importrecordCollection = new ModelCollection<ImportRecord> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    importrecordCollection.add((ImportRecord) model);
        	}
        
        	return importrecordCollection;
        }

        public static ImportRecord retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ImportRecord.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ImportRecord) gateway.retrieve(ResourceType.IMPORT_RECORD, id);
        }

        public ModelBase getImporter ()
        {
            return (ModelBase) this.getProperty("importer");
        }

        public void setImporter (ModelBase importer)
        {
            this.setProperty("importer", importer);
        }

        public string getImporterName ()
        {
            return this.getProperty("importerName").ToString();
        }

        public void setImporterName (string importerName)
        {
            this.setProperty("importerName", importerName);
        }

        public int getImportedRecordEntityType ()
        {
            return Convert.ToInt32(this.getProperty("importedRecordEntityType"));
        }

        public void setImportedRecordEntityType (int importedRecordEntityType)
        {
            this.setProperty("importedRecordEntityType", importedRecordEntityType);
        }

        public ModelBase getImportedRecord ()
        {
            return (ModelBase) this.getProperty("importedRecord");
        }

        public void setImportedRecord (ModelBase importedRecord)
        {
            this.setProperty("importedRecord", importedRecord);
        }


    }
}

