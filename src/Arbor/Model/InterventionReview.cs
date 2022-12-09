using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionReview : ModelBase
    {
        protected new string resourceType = ResourceType.INTERVENTION_REVIEW;
        public const string INTERVENTION = "intervention";
        public const string REVIEW_DUE_DATE = "reviewDueDate";
        public const string REVIEW_COMPLETED_DATE = "reviewCompletedDate";
        public const string REVIEW = "review";
        public const string RECOMMENDATIONS = "recommendations";

        public InterventionReview()
        {
            base.resourceType = this.resourceType;
        }

        public InterventionReview(string resourceType = "InterventionReview", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InterventionReview> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InterventionReview");
            RestGateway gateway = (RestGateway)InterventionReview.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InterventionReview> interventionreviewCollection = new ModelCollection<InterventionReview>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                interventionreviewCollection.add((InterventionReview)model);
            }

            return interventionreviewCollection;
        }

        public static InterventionReview retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InterventionReview.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InterventionReview)gateway.retrieve(ResourceType.INTERVENTION_REVIEW, id);
        }

        public Intervention getIntervention()
        {
            return (Intervention)this.getProperty("intervention");
        }

        public void setIntervention(Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public DateTime getReviewDueDate()
        {
            return Convert.ToDateTime(this.getProperty("reviewDueDate"));
        }

        public void setReviewDueDate(DateTime reviewDueDate)
        {
            this.setProperty("reviewDueDate", reviewDueDate);
        }

        public DateTime getReviewCompletedDate()
        {
            return Convert.ToDateTime(this.getProperty("reviewCompletedDate"));
        }

        public void setReviewCompletedDate(DateTime reviewCompletedDate)
        {
            this.setProperty("reviewCompletedDate", reviewCompletedDate);
        }

        public string getReview()
        {
            return this.getProperty("review").ToString();
        }

        public void setReview(string review)
        {
            this.setProperty("review", review);
        }

        public string getRecommendations()
        {
            return this.getProperty("recommendations").ToString();
        }

        public void setRecommendations(string recommendations)
        {
            this.setProperty("recommendations", recommendations);
        }


    }
}

