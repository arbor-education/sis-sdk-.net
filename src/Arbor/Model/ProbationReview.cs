using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProbationReview : ModelBase
    {
        protected string resourceType = ResourceType.PROBATION_REVIEW;
        public const string PROBATION = "probation";
        public const string REVIEW_DATE = "reviewDate";
        public const string REVIEW_OUTCOME = "reviewOutcome";
        public const string REVIEW_NOTES = "reviewNotes";

        public ProbationReview()
        {
            base.resourceType = this.resourceType;
        }

        public ProbationReview(string resourceType = "ProbationReview", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProbationReview> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ProbationReview");
            RestGateway gateway = (RestGateway)ProbationReview.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProbationReview> probationreviewCollection = new ModelCollection<ProbationReview>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                probationreviewCollection.add((ProbationReview)model);
            }

            return probationreviewCollection;
        }

        public static ProbationReview retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProbationReview.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProbationReview)gateway.retrieve(ResourceType.PROBATION_REVIEW, id);
        }

        public Probation getProbation()
        {
            return (Probation)this.getProperty("probation");
        }

        public void setProbation(Probation probation)
        {
            this.setProperty("probation", probation);
        }

        public DateTime getReviewDate()
        {
            return Convert.ToDateTime(this.getProperty("reviewDate"));
        }

        public void setReviewDate(DateTime reviewDate)
        {
            this.setProperty("reviewDate", reviewDate);
        }

        public string getReviewOutcome()
        {
            return this.getProperty("reviewOutcome").ToString();
        }

        public void setReviewOutcome(string reviewOutcome)
        {
            this.setProperty("reviewOutcome", reviewOutcome);
        }

        public string getReviewNotes()
        {
            return this.getProperty("reviewNotes").ToString();
        }

        public void setReviewNotes(string reviewNotes)
        {
            this.setProperty("reviewNotes", reviewNotes);
        }


    }
}

