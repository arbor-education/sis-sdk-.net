using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressAssessmentImportJob : ModelBase
    {
        protected string resourceType = ResourceType.PROGRESS_ASSESSMENT_IMPORT_JOB;
        public const string UPLOADED_DATETIME = "uploadedDatetime";
        public const string IMPORT_STARTED_DATETIME = "importStartedDatetime";
        public const string IMPORTED_DATETIME = "importedDatetime";
        public const string DATA = "data";

        public ProgressAssessmentImportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgressAssessmentImportJob (string resourceType = "ProgressAssessmentImportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgressAssessmentImportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgressAssessmentImportJob");
        	RestGateway gateway = (RestGateway) ProgressAssessmentImportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgressAssessmentImportJob> progressassessmentimportjobCollection = new ModelCollection<ProgressAssessmentImportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    progressassessmentimportjobCollection.add((ProgressAssessmentImportJob) model);
        	}
        
        	return progressassessmentimportjobCollection;
        }

        public static ProgressAssessmentImportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgressAssessmentImportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgressAssessmentImportJob) gateway.retrieve(ResourceType.PROGRESS_ASSESSMENT_IMPORT_JOB, id);
        }

        public DateTime getUploadedDatetime (){
            return Convert.ToDateTime(this.getProperty("uploadedDatetime"));
        }

        public void setUploadedDatetime (DateTime uploadedDatetime)
        {
            this.setProperty("uploadedDatetime", uploadedDatetime);
        }

        public DateTime getImportStartedDatetime (){
            return Convert.ToDateTime(this.getProperty("importStartedDatetime"));
        }

        public void setImportStartedDatetime (DateTime importStartedDatetime)
        {
            this.setProperty("importStartedDatetime", importStartedDatetime);
        }

        public DateTime getImportedDatetime (){
            return Convert.ToDateTime(this.getProperty("importedDatetime"));
        }

        public void setImportedDatetime (DateTime importedDatetime)
        {
            this.setProperty("importedDatetime", importedDatetime);
        }

        public string getData ()
        {
            return this.getProperty("data").ToString();
        }

        public void setData (string data)
        {
            this.setProperty("data", data);
        }


    }
}

