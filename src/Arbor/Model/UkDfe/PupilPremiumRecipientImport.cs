using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class PupilPremiumRecipientImport : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_IMPORT;
        public const string PUPIL_PREMIUM_RECIPIENT_IMPORT_JOB_ID = "pupilPremiumRecipientImportJobId";
        public const string PUPIL_PREMIUM_RECIPIENT_ID = "pupilPremiumRecipientId";

        public PupilPremiumRecipientImport ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PupilPremiumRecipientImport (string resourceType = "PupilPremiumRecipientImport", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PupilPremiumRecipientImport> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PupilPremiumRecipientImport");
        	RestGateway gateway = (RestGateway) PupilPremiumRecipientImport.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PupilPremiumRecipientImport> pupilpremiumrecipientimportCollection = new ModelCollection<PupilPremiumRecipientImport> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pupilpremiumrecipientimportCollection.add((PupilPremiumRecipientImport) model);
        	}
        
        	return pupilpremiumrecipientimportCollection;
        }

        public static PupilPremiumRecipientImport retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PupilPremiumRecipientImport.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PupilPremiumRecipientImport) gateway.retrieve(ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_IMPORT, id);
        }

        public Pupil getPupilPremiumRecipientImportJobId ()
        {
            return (Pupil) this.getProperty("pupilPremiumRecipientImportJobId");
        }

        public void setPupilPremiumRecipientImportJobId (Pupil pupilPremiumRecipientImportJobId)
        {
            this.setProperty("pupilPremiumRecipientImportJobId", pupilPremiumRecipientImportJobId);
        }

        public Pupil getPupilPremiumRecipientId ()
        {
            return (Pupil) this.getProperty("pupilPremiumRecipientId");
        }

        public void setPupilPremiumRecipientId (Pupil pupilPremiumRecipientId)
        {
            this.setProperty("pupilPremiumRecipientId", pupilPremiumRecipientId);
        }


    }
}

