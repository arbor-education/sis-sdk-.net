using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateRegistrationAudit : ModelBase
    {
        protected new string resourceType = ResourceType.CANDIDATE_REGISTRATION_AUDIT;
        public const string CANDIDATE_REGISTRATION = "candidateRegistration";
        public const string TYPE = "type";
        public const string ACTION_DATETIME = "actionDatetime";

        public CandidateRegistrationAudit ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateRegistrationAudit (string resourceType = "CandidateRegistrationAudit", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateRegistrationAudit> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateRegistrationAudit");
        	RestGateway gateway = (RestGateway) CandidateRegistrationAudit.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateRegistrationAudit> candidateregistrationauditCollection = new ModelCollection<CandidateRegistrationAudit> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateregistrationauditCollection.add((CandidateRegistrationAudit) model);
        	}
        
        	return candidateregistrationauditCollection;
        }

        public static CandidateRegistrationAudit retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateRegistrationAudit.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateRegistrationAudit) gateway.retrieve(ResourceType.CANDIDATE_REGISTRATION_AUDIT, id);
        }

        public CandidateRegistration getCandidateRegistration ()
        {
            return (CandidateRegistration) this.getProperty("candidateRegistration");
        }

        public void setCandidateRegistration (CandidateRegistration candidateRegistration)
        {
            this.setProperty("candidateRegistration", candidateRegistration);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public DateTime getActionDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("actionDatetime"));
        }

        public void setActionDatetime (DateTime actionDatetime)
        {
            this.setProperty("actionDatetime", actionDatetime);
        }


    }
}

