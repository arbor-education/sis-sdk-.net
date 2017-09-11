using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateEntryWithdrawalProposal : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_ENTRY_WITHDRAWAL_PROPOSAL;
        public const string CANDIDATE_PROPOSAL = "candidateProposal";
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string REJECTED_BY_STAFF = "rejectedByStaff";
        public const string REJECTED_DATETIME = "rejectedDatetime";

        public CandidateEntryWithdrawalProposal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateEntryWithdrawalProposal (string resourceType = "CandidateEntryWithdrawalProposal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateEntryWithdrawalProposal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateEntryWithdrawalProposal");
        	RestGateway gateway = (RestGateway) CandidateEntryWithdrawalProposal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateEntryWithdrawalProposal> candidateentrywithdrawalproposalCollection = new ModelCollection<CandidateEntryWithdrawalProposal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateentrywithdrawalproposalCollection.add((CandidateEntryWithdrawalProposal) model);
        	}
        
        	return candidateentrywithdrawalproposalCollection;
        }

        public static CandidateEntryWithdrawalProposal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateEntryWithdrawalProposal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateEntryWithdrawalProposal) gateway.retrieve(ResourceType.CANDIDATE_ENTRY_WITHDRAWAL_PROPOSAL, id);
        }

        public CandidateProposal getCandidateProposal ()
        {
            return (CandidateProposal) this.getProperty("candidateProposal");
        }

        public void setCandidateProposal (CandidateProposal candidateProposal)
        {
            this.setProperty("candidateProposal", candidateProposal);
        }

        public Candidate getCandidateEntry ()
        {
            return (Candidate) this.getProperty("candidateEntry");
        }

        public void setCandidateEntry (Candidate candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public Staff getApprovedByStaff ()
        {
            return (Staff) this.getProperty("approvedByStaff");
        }

        public void setApprovedByStaff (Staff approvedByStaff)
        {
            this.setProperty("approvedByStaff", approvedByStaff);
        }

        public DateTime getApprovedDatetime ()
        {
            return (DateTime) this.getProperty("approvedDatetime");
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }

        public Staff getRejectedByStaff ()
        {
            return (Staff) this.getProperty("rejectedByStaff");
        }

        public void setRejectedByStaff (Staff rejectedByStaff)
        {
            this.setProperty("rejectedByStaff", rejectedByStaff);
        }

        public DateTime getRejectedDatetime ()
        {
            return (DateTime) this.getProperty("rejectedDatetime");
        }

        public void setRejectedDatetime (DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }


    }
}

