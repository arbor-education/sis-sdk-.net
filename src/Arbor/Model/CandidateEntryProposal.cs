using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateEntryProposal : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_ENTRY_PROPOSAL;
        public const string CANDIDATE_PROPOSAL = "candidateProposal";
        public const string QUALIFICATION_AVAILABILITY_INSTANCE = "qualificationAvailabilityInstance";
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string REJECTED_BY_STAFF = "rejectedByStaff";
        public const string REJECTED_DATETIME = "rejectedDatetime";

        public CandidateEntryProposal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateEntryProposal (string resourceType = "CandidateEntryProposal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateEntryProposal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateEntryProposal");
        	RestGateway gateway = (RestGateway) CandidateEntryProposal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateEntryProposal> candidateentryproposalCollection = new ModelCollection<CandidateEntryProposal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateentryproposalCollection.add((CandidateEntryProposal) model);
        	}
        
        	return candidateentryproposalCollection;
        }

        public static CandidateEntryProposal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateEntryProposal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateEntryProposal) gateway.retrieve(ResourceType.CANDIDATE_ENTRY_PROPOSAL, id);
        }

        public CandidateProposal getCandidateProposal ()
        {
            return (CandidateProposal) this.getProperty("candidateProposal");
        }

        public void setCandidateProposal (CandidateProposal candidateProposal)
        {
            this.setProperty("candidateProposal", candidateProposal);
        }

        public QualificationAvailabilityInstance getQualificationAvailabilityInstance ()
        {
            return (QualificationAvailabilityInstance) this.getProperty("qualificationAvailabilityInstance");
        }

        public void setQualificationAvailabilityInstance (QualificationAvailabilityInstance qualificationAvailabilityInstance)
        {
            this.setProperty("qualificationAvailabilityInstance", qualificationAvailabilityInstance);
        }

        public QualificationLearningUnit getQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit (QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
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

