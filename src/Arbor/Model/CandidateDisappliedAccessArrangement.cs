using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateDisappliedAccessArrangement : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_DISAPPLIED_ACCESS_ARRANGEMENT;
        public const string CANDIDATE = "candidate";
        public const string ACCESS_ARRANGEMENT = "accessArrangement";
        public const string QUALIFICATION_ASSESSABLE = "qualificationAssessable";

        public CandidateDisappliedAccessArrangement()
        {
            base.resourceType = this.resourceType;
        }

        public CandidateDisappliedAccessArrangement(string resourceType = "CandidateDisappliedAccessArrangement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CandidateDisappliedAccessArrangement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CandidateDisappliedAccessArrangement");
            RestGateway gateway = (RestGateway)CandidateDisappliedAccessArrangement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CandidateDisappliedAccessArrangement> candidatedisappliedaccessarrangementCollection = new ModelCollection<CandidateDisappliedAccessArrangement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                candidatedisappliedaccessarrangementCollection.add((CandidateDisappliedAccessArrangement)model);
            }

            return candidatedisappliedaccessarrangementCollection;
        }

        public static CandidateDisappliedAccessArrangement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CandidateDisappliedAccessArrangement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CandidateDisappliedAccessArrangement)gateway.retrieve(ResourceType.CANDIDATE_DISAPPLIED_ACCESS_ARRANGEMENT, id);
        }

        public Candidate getCandidate()
        {
            return (Candidate)this.getProperty("candidate");
        }

        public void setCandidate(Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public AccessArrangement getAccessArrangement()
        {
            return (AccessArrangement)this.getProperty("accessArrangement");
        }

        public void setAccessArrangement(AccessArrangement accessArrangement)
        {
            this.setProperty("accessArrangement", accessArrangement);
        }

        public QualificationAssessable getQualificationAssessable()
        {
            return (QualificationAssessable)this.getProperty("qualificationAssessable");
        }

        public void setQualificationAssessable(QualificationAssessable qualificationAssessable)
        {
            this.setProperty("qualificationAssessable", qualificationAssessable);
        }


    }
}

