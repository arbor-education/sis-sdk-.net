using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateAccessArrangement : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_ACCESS_ARRANGEMENT;
        public const string CANDIDATE = "candidate";
        public const string ACCESS_ARRANGEMENT = "accessArrangement";
        public const string EXTRA_TIME_PERCENTAGE = "extraTimePercentage";
        public const string REASON = "reason";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public CandidateAccessArrangement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateAccessArrangement (string resourceType = "CandidateAccessArrangement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateAccessArrangement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateAccessArrangement");
        	RestGateway gateway = (RestGateway) CandidateAccessArrangement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateAccessArrangement> candidateaccessarrangementCollection = new ModelCollection<CandidateAccessArrangement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateaccessarrangementCollection.add((CandidateAccessArrangement) model);
        	}
        
        	return candidateaccessarrangementCollection;
        }

        public static CandidateAccessArrangement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateAccessArrangement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateAccessArrangement) gateway.retrieve(ResourceType.CANDIDATE_ACCESS_ARRANGEMENT, id);
        }

        public Candidate getCandidate ()
        {
            return (Candidate) this.getProperty("candidate");
        }

        public void setCandidate (Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public AccessArrangement getAccessArrangement ()
        {
            return (AccessArrangement) this.getProperty("accessArrangement");
        }

        public void setAccessArrangement (AccessArrangement accessArrangement)
        {
            this.setProperty("accessArrangement", accessArrangement);
        }

        public float getExtraTimePercentage ()
        {
            return (float) this.getProperty("extraTimePercentage");
        }

        public void setExtraTimePercentage (float extraTimePercentage)
        {
            this.setProperty("extraTimePercentage", extraTimePercentage);
        }

        public string getReason ()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason (string reason)
        {
            this.setProperty("reason", reason);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

