using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class PupilPremiumRecipientImportJob : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_IMPORT_JOB;
        public const string START_DATETIME = "startDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";

        public PupilPremiumRecipientImportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PupilPremiumRecipientImportJob (string resourceType = "PupilPremiumRecipientImportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PupilPremiumRecipientImportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PupilPremiumRecipientImportJob");
        	RestGateway gateway = (RestGateway) PupilPremiumRecipientImportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PupilPremiumRecipientImportJob> pupilpremiumrecipientimportjobCollection = new ModelCollection<PupilPremiumRecipientImportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pupilpremiumrecipientimportjobCollection.add((PupilPremiumRecipientImportJob) model);
        	}
        
        	return pupilpremiumrecipientimportjobCollection;
        }

        public static PupilPremiumRecipientImportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PupilPremiumRecipientImportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PupilPremiumRecipientImportJob) gateway.retrieve(ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_IMPORT_JOB, id);
        }

        public DateTime getStartDatetime ()
        {
            Convert.ToDateTime(this.getProperty("startDatetime"))
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getCompletedDatetime ()
        {
            Convert.ToDateTime(this.getProperty("completedDatetime"))
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }


    }
}

