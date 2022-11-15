using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateEntry : ModelBase
    {
        protected new string resourceType = ResourceType.CANDIDATE_ENTRY;
        public const string CANDIDATE = "candidate";
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string QUALIFICATION_AVAILABILITY_INSTANCE = "qualificationAvailabilityInstance";
        public const string ENTRY_STATUS = "entryStatus";
        public const string WITHDRAWAL_STATUS = "withdrawalStatus";

        public CandidateEntry()
        {
            base.resourceType = this.resourceType;
        }

        public CandidateEntry(string resourceType = "CandidateEntry", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CandidateEntry> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CandidateEntry");
            RestGateway gateway = (RestGateway)CandidateEntry.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CandidateEntry> candidateentryCollection = new ModelCollection<CandidateEntry>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                candidateentryCollection.add((CandidateEntry)model);
            }

            return candidateentryCollection;
        }

        public static CandidateEntry retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CandidateEntry.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CandidateEntry)gateway.retrieve(ResourceType.CANDIDATE_ENTRY, id);
        }

        public Candidate getCandidate()
        {
            return (Candidate)this.getProperty("candidate");
        }

        public void setCandidate(Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public QualificationLearningUnit getQualificationLearningUnit()
        {
            return (QualificationLearningUnit)this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit(QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
        }

        public QualificationAvailabilityInstance getQualificationAvailabilityInstance()
        {
            return (QualificationAvailabilityInstance)this.getProperty("qualificationAvailabilityInstance");
        }

        public void setQualificationAvailabilityInstance(QualificationAvailabilityInstance qualificationAvailabilityInstance)
        {
            this.setProperty("qualificationAvailabilityInstance", qualificationAvailabilityInstance);
        }

        public string getEntryStatus()
        {
            return this.getProperty("entryStatus").ToString();
        }

        public void setEntryStatus(string entryStatus)
        {
            this.setProperty("entryStatus", entryStatus);
        }

        public string getWithdrawalStatus()
        {
            return this.getProperty("withdrawalStatus").ToString();
        }

        public void setWithdrawalStatus(string withdrawalStatus)
        {
            this.setProperty("withdrawalStatus", withdrawalStatus);
        }


    }
}

