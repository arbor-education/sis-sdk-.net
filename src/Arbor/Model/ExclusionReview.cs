using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ExclusionReview : ModelBase
    {
        protected string resourceType = ResourceType.EXCLUSION_REVIEW;
        public const string COMMENT = "comment";
        public const string EXCLUSION_REVIEW_OUTCOME = "exclusionReviewOutcome";
        public const string PERMANENT_EXCLUSION = "permanentExclusion";
        public const string REVIEW_DATE = "reviewDate";
        public const string STUDENT = "student";
        public const string STUDENT_REINSTATEMENT_DATE = "studentReinstatementDate";
        public const string SEN_EXPERT_REQUESTED = "senExpertRequested";

        public ExclusionReview ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ExclusionReview (string resourceType = "ExclusionReview", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ExclusionReview> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ExclusionReview");
        	RestGateway gateway = (RestGateway) ExclusionReview.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ExclusionReview> exclusionreviewCollection = new ModelCollection<ExclusionReview> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    exclusionreviewCollection.add((ExclusionReview) model);
        	}
        
        	return exclusionreviewCollection;
        }

        public static ExclusionReview retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ExclusionReview.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ExclusionReview) gateway.retrieve(ResourceType.EXCLUSION_REVIEW, id);
        }

        public string getComment ()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment (string comment)
        {
            this.setProperty("comment", comment);
        }

        public ExclusionReviewOutcome getExclusionReviewOutcome ()
        {
            return (ExclusionReviewOutcome) this.getProperty("exclusionReviewOutcome");
        }

        public void setExclusionReviewOutcome (ExclusionReviewOutcome exclusionReviewOutcome)
        {
            this.setProperty("exclusionReviewOutcome", exclusionReviewOutcome);
        }

        public PermanentExclusion getPermanentExclusion ()
        {
            return (PermanentExclusion) this.getProperty("permanentExclusion");
        }

        public void setPermanentExclusion (PermanentExclusion permanentExclusion)
        {
            this.setProperty("permanentExclusion", permanentExclusion);
        }

        public DateTime getReviewDate ()
        {
            return Convert.ToDateTime(this.getProperty("reviewDate"));
        }

        public void setReviewDate (DateTime reviewDate)
        {
            this.setProperty("reviewDate", reviewDate);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStudentReinstatementDate ()
        {
            return Convert.ToDateTime(this.getProperty("studentReinstatementDate"));
        }

        public void setStudentReinstatementDate (DateTime studentReinstatementDate)
        {
            this.setProperty("studentReinstatementDate", studentReinstatementDate);
        }

        public bool getSenExpertRequested ()
        {
            return Convert.ToBoolean(this.getProperty("senExpertRequested"));
        }

        public void setSenExpertRequested (bool senExpertRequested)
        {
            this.setProperty("senExpertRequested", senExpertRequested);
        }


    }
}

