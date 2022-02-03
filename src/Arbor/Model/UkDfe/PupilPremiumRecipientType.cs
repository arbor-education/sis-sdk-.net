using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class PupilPremiumRecipientType : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_TYPE;
        public const string PUPIL_PREMIUM_RECIPIENT = "pupilPremiumRecipient";
        public const string PUPIL_PREMIUM_TYPE = "pupilPremiumType";

        public PupilPremiumRecipientType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PupilPremiumRecipientType (string resourceType = "PupilPremiumRecipientType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PupilPremiumRecipientType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PupilPremiumRecipientType");
        	RestGateway gateway = (RestGateway) PupilPremiumRecipientType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PupilPremiumRecipientType> pupilpremiumrecipienttypeCollection = new ModelCollection<PupilPremiumRecipientType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pupilpremiumrecipienttypeCollection.add((PupilPremiumRecipientType) model);
        	}
        
        	return pupilpremiumrecipienttypeCollection;
        }

        public static PupilPremiumRecipientType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PupilPremiumRecipientType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PupilPremiumRecipientType) gateway.retrieve(ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_TYPE, id);
        }

        public PupilPremiumRecipient getPupilPremiumRecipient ()
        {
            return (PupilPremiumRecipient) this.getProperty("pupilPremiumRecipient");
        }

        public void setPupilPremiumRecipient (PupilPremiumRecipient pupilPremiumRecipient)
        {
            this.setProperty("pupilPremiumRecipient", pupilPremiumRecipient);
        }

        public string getPupilPremiumType ()
        {
            return this.getProperty("pupilPremiumType").ToString();
        }

        public void setPupilPremiumType (string pupilPremiumType)
        {
            this.setProperty("pupilPremiumType", pupilPremiumType);
        }


    }
}

