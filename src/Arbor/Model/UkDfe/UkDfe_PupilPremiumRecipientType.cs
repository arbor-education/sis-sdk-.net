using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_PupilPremiumRecipientType : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_TYPE;
        public const string PUPIL_PREMIUM_RECIPIENT = "pupilPremiumRecipient";
        public const string PUPIL_PREMIUM_TYPE = "pupilPremiumType";

        public UkDfe_PupilPremiumRecipientType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_PupilPremiumRecipientType (string resourceType = "UkDfe_PupilPremiumRecipientType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_PupilPremiumRecipientType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PupilPremiumRecipientType");
        	RestGateway gateway = (RestGateway) UkDfe_PupilPremiumRecipientType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_PupilPremiumRecipientType> ukdfe_pupilpremiumrecipienttypeCollection = new ModelCollection<UkDfe_PupilPremiumRecipientType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_pupilpremiumrecipienttypeCollection.add((UkDfe_PupilPremiumRecipientType) model);
        	}
        
        	return ukdfe_pupilpremiumrecipienttypeCollection;
        }

        public static UkDfe_PupilPremiumRecipientType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_PupilPremiumRecipientType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_PupilPremiumRecipientType) gateway.retrieve(ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT_TYPE, id);
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

