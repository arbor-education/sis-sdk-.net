using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateRegistrationProposal : ModelBase
    {
        protected new string resourceType = ResourceType.CANDIDATE_REGISTRATION_PROPOSAL;
        public const string CANDIDATE_PROPOSAL = "candidateProposal";
        public const string QUALIFICATION_AVAILABILITY_INSTANCE = "qualificationAvailabilityInstance";
        public const string QUALIFICATION_AWARD = "qualificationAward";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string REJECTED_BY_STAFF = "rejectedByStaff";
        public const string REJECTED_DATETIME = "rejectedDatetime";

        public CandidateRegistrationProposal()
        {
            base.resourceType = this.resourceType;
        }

        public CandidateRegistrationProposal(string resourceType = "CandidateRegistrationProposal", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CandidateRegistrationProposal> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CandidateRegistrationProposal");
            RestGateway gateway = (RestGateway)CandidateRegistrationProposal.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CandidateRegistrationProposal> candidateregistrationproposalCollection = new ModelCollection<CandidateRegistrationProposal>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                candidateregistrationproposalCollection.add((CandidateRegistrationProposal)model);
            }

            return candidateregistrationproposalCollection;
        }

        public static CandidateRegistrationProposal retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CandidateRegistrationProposal.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CandidateRegistrationProposal)gateway.retrieve(ResourceType.CANDIDATE_REGISTRATION_PROPOSAL, id);
        }

        public CandidateProposal getCandidateProposal()
        {
            return (CandidateProposal)this.getProperty("candidateProposal");
        }

        public void setCandidateProposal(CandidateProposal candidateProposal)
        {
            this.setProperty("candidateProposal", candidateProposal);
        }

        public QualificationAvailabilityInstance getQualificationAvailabilityInstance()
        {
            return (QualificationAvailabilityInstance)this.getProperty("qualificationAvailabilityInstance");
        }

        public void setQualificationAvailabilityInstance(QualificationAvailabilityInstance qualificationAvailabilityInstance)
        {
            this.setProperty("qualificationAvailabilityInstance", qualificationAvailabilityInstance);
        }

        public QualificationAward getQualificationAward()
        {
            return (QualificationAward)this.getProperty("qualificationAward");
        }

        public void setQualificationAward(QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
        }

        public Staff getApprovedByStaff()
        {
            return (Staff)this.getProperty("approvedByStaff");
        }

        public void setApprovedByStaff(Staff approvedByStaff)
        {
            this.setProperty("approvedByStaff", approvedByStaff);
        }

        public DateTime getApprovedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("approvedDatetime"));
        }

        public void setApprovedDatetime(DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }

        public Staff getRejectedByStaff()
        {
            return (Staff)this.getProperty("rejectedByStaff");
        }

        public void setRejectedByStaff(Staff rejectedByStaff)
        {
            this.setProperty("rejectedByStaff", rejectedByStaff);
        }

        public DateTime getRejectedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("rejectedDatetime"));
        }

        public void setRejectedDatetime(DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }


    }
}

