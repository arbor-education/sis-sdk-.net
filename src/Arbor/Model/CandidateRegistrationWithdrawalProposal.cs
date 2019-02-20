using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateRegistrationWithdrawalProposal : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_REGISTRATION_WITHDRAWAL_PROPOSAL;
        public const string CANDIDATE_PROPOSAL = "candidateProposal";
        public const string CANDIDATE_REGISTRATION = "candidateRegistration";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string REJECTED_BY_STAFF = "rejectedByStaff";
        public const string REJECTED_DATETIME = "rejectedDatetime";

        public CandidateRegistrationWithdrawalProposal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateRegistrationWithdrawalProposal (string resourceType = "CandidateRegistrationWithdrawalProposal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateRegistrationWithdrawalProposal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateRegistrationWithdrawalProposal");
        	RestGateway gateway = (RestGateway) CandidateRegistrationWithdrawalProposal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateRegistrationWithdrawalProposal> candidateregistrationwithdrawalproposalCollection = new ModelCollection<CandidateRegistrationWithdrawalProposal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateregistrationwithdrawalproposalCollection.add((CandidateRegistrationWithdrawalProposal) model);
        	}
        
        	return candidateregistrationwithdrawalproposalCollection;
        }

        public static CandidateRegistrationWithdrawalProposal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateRegistrationWithdrawalProposal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateRegistrationWithdrawalProposal) gateway.retrieve(ResourceType.CANDIDATE_REGISTRATION_WITHDRAWAL_PROPOSAL, id);
        }

        public CandidateProposal getCandidateProposal ()
        {
            return (CandidateProposal) this.getProperty("candidateProposal");
        }

        public void setCandidateProposal (CandidateProposal candidateProposal)
        {
            this.setProperty("candidateProposal", candidateProposal);
        }

        public CandidateRegistration getCandidateRegistration ()
        {
            return (CandidateRegistration) this.getProperty("candidateRegistration");
        }

        public void setCandidateRegistration (CandidateRegistration candidateRegistration)
        {
            this.setProperty("candidateRegistration", candidateRegistration);
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
            return Convert.ToDateTime(this.getProperty("approvedDatetime"));
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
            return Convert.ToDateTime(this.getProperty("rejectedDatetime"));
        }

        public void setRejectedDatetime (DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }


    }
}

