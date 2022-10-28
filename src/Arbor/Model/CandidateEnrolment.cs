using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateEnrolment : ModelBase
    {
        protected new string resourceType = ResourceType.CANDIDATE_ENROLMENT;
        public const string CANDIDATE = "candidate";
        public const string ENROLMENT_NUMBER = "enrolmentNumber";
        public const string ENROLMENT_REQUESTED_DATETIME = "enrolmentRequestedDatetime";
        public const string ENROLMENT_CONFIRMED_DATETIME = "enrolmentConfirmedDatetime";

        public CandidateEnrolment()
        {
            base.resourceType = this.resourceType;
        }

        public CandidateEnrolment(string resourceType = "CandidateEnrolment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CandidateEnrolment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CandidateEnrolment");
            RestGateway gateway = (RestGateway)CandidateEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CandidateEnrolment> candidateenrolmentCollection = new ModelCollection<CandidateEnrolment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                candidateenrolmentCollection.add((CandidateEnrolment)model);
            }

            return candidateenrolmentCollection;
        }

        public static CandidateEnrolment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CandidateEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CandidateEnrolment)gateway.retrieve(ResourceType.CANDIDATE_ENROLMENT, id);
        }

        public Candidate getCandidate()
        {
            return (Candidate)this.getProperty("candidate");
        }

        public void setCandidate(Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public string getEnrolmentNumber()
        {
            return this.getProperty("enrolmentNumber").ToString();
        }

        public void setEnrolmentNumber(string enrolmentNumber)
        {
            this.setProperty("enrolmentNumber", enrolmentNumber);
        }

        public DateTime getEnrolmentRequestedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("enrolmentRequestedDatetime"));
        }

        public void setEnrolmentRequestedDatetime(DateTime enrolmentRequestedDatetime)
        {
            this.setProperty("enrolmentRequestedDatetime", enrolmentRequestedDatetime);
        }

        public DateTime getEnrolmentConfirmedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("enrolmentConfirmedDatetime"));
        }

        public void setEnrolmentConfirmedDatetime(DateTime enrolmentConfirmedDatetime)
        {
            this.setProperty("enrolmentConfirmedDatetime", enrolmentConfirmedDatetime);
        }


    }
}

