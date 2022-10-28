using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateProposal : ModelBase
    {
        protected new string resourceType = ResourceType.CANDIDATE_PROPOSAL;
        public const string CANDIDATE = "candidate";
        public const string SUGGESTED_BY_STAFF = "suggestedByStaff";
        public const string SUGGESTED_DATETIME = "suggestedDatetime";

        public CandidateProposal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateProposal (string resourceType = "CandidateProposal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateProposal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateProposal");
        	RestGateway gateway = (RestGateway) CandidateProposal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateProposal> candidateproposalCollection = new ModelCollection<CandidateProposal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateproposalCollection.add((CandidateProposal) model);
        	}
        
        	return candidateproposalCollection;
        }

        public static CandidateProposal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateProposal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateProposal) gateway.retrieve(ResourceType.CANDIDATE_PROPOSAL, id);
        }

        public Candidate getCandidate ()
        {
            return (Candidate) this.getProperty("candidate");
        }

        public void setCandidate (Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public Staff getSuggestedByStaff ()
        {
            return (Staff) this.getProperty("suggestedByStaff");
        }

        public void setSuggestedByStaff (Staff suggestedByStaff)
        {
            this.setProperty("suggestedByStaff", suggestedByStaff);
        }

        public DateTime getSuggestedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("suggestedDatetime"));
        }

        public void setSuggestedDatetime (DateTime suggestedDatetime)
        {
            this.setProperty("suggestedDatetime", suggestedDatetime);
        }


    }
}

