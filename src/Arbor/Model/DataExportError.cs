using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataExportError : ModelBase
    {
        protected string resourceType = ResourceType.DATA_EXPORT_ERROR;
        public const string EXPORT_JOB = "exportJob";
        public const string ERROR_MESSAGE = "errorMessage";

        public DataExportError ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DataExportError (string resourceType = "DataExportError", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DataExportError> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DataExportError");
        	RestGateway gateway = (RestGateway) DataExportError.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DataExportError> dataexporterrorCollection = new ModelCollection<DataExportError> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    dataexporterrorCollection.add((DataExportError) model);
        	}
        
        	return dataexporterrorCollection;
        }

        public static DataExportError retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DataExportError.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DataExportError) gateway.retrieve(ResourceType.DATA_EXPORT_ERROR, id);
        }

        public ModelBase getExportJob ()
        {
            return (ModelBase) this.getProperty("exportJob");
        }

        public void setExportJob (ModelBase exportJob)
        {
            this.setProperty("exportJob", exportJob);
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

