using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateRegistration : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_REGISTRATION;
        public const string CANDIDATE = "candidate";
        public const string QUALIFICATION_AWARD = "qualificationAward";
        public const string QUALIFICATION_AVAILABILITY_INSTANCE = "qualificationAvailabilityInstance";
        public const string ENTRY_STATUS = "entryStatus";
        public const string WITHDRAWAL_STATUS = "withdrawalStatus";

        public CandidateRegistration ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateRegistration (string resourceType = "CandidateRegistration", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateRegistration> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateRegistration");
        	RestGateway gateway = (RestGateway) CandidateRegistration.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateRegistration> candidateregistrationCollection = new ModelCollection<CandidateRegistration> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateregistrationCollection.add((CandidateRegistration) model);
        	}
        
        	return candidateregistrationCollection;
        }

        public static CandidateRegistration retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateRegistration.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateRegistration) gateway.retrieve(ResourceType.CANDIDATE_REGISTRATION, id);
        }

        public Candidate getCandidate ()
        {
            return (Candidate) this.getProperty("candidate");
        }

        public void setCandidate (Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public QualificationAward getQualificationAward ()
        {
            return (QualificationAward) this.getProperty("qualificationAward");
        }

        public void setQualificationAward (QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
        }

        public QualificationAvailabilityInstance getQualificationAvailabilityInstance ()
        {
            return (QualificationAvailabilityInstance) this.getProperty("qualificationAvailabilityInstance");
        }

        public void setQualificationAvailabilityInstance (QualificationAvailabilityInstance qualificationAvailabilityInstance)
        {
            this.setProperty("qualificationAvailabilityInstance", qualificationAvailabilityInstance);
        }

        public string getEntryStatus ()
        {
            return this.getProperty("entryStatus").ToString();
        }

        public void setEntryStatus (string entryStatus)
        {
            this.setProperty("entryStatus", entryStatus);
        }

        public string getWithdrawalStatus ()
        {
            return this.getProperty("withdrawalStatus").ToString();
        }

        public void setWithdrawalStatus (string withdrawalStatus)
        {
            this.setProperty("withdrawalStatus", withdrawalStatus);
        }


    }
}

