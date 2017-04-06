using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateExtraTimeRequest : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_EXTRA_TIME_REQUEST;
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string TIME_REQUESTED = "timeRequested";
        public const string REASON = "reason";
        public const string NARRATIVE = "narrative";
        public const string REQUESTED_DATETIME = "requestedDatetime";
        public const string CONFIRMED_DATETIME = "confirmedDatetime";
        public const string REJECTED_DATETIME = "rejectedDatetime";

        public CandidateExtraTimeRequest ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateExtraTimeRequest (string resourceType = "CandidateExtraTimeRequest", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateExtraTimeRequest> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateExtraTimeRequest");
        	RestGateway gateway = (RestGateway) CandidateExtraTimeRequest.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateExtraTimeRequest> candidateextratimerequestCollection = new ModelCollection<CandidateExtraTimeRequest> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateextratimerequestCollection.add((CandidateExtraTimeRequest) model);
        	}
        
        	return candidateextratimerequestCollection;
        }

        public static CandidateExtraTimeRequest retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateExtraTimeRequest.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateExtraTimeRequest) gateway.retrieve(ResourceType.CANDIDATE_EXTRA_TIME_REQUEST, id);
        }

        public CandidateEntry getCandidateEntry ()
        {
            return (CandidateEntry) this.getProperty("candidateEntry");
        }

        public void setCandidateEntry (CandidateEntry candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public string getTimeRequested ()
        {
            return this.getProperty("timeRequested").ToString();
        }

        public void setTimeRequested (string timeRequested)
        {
            this.setProperty("timeRequested", timeRequested);
        }

        public string getReason ()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason (string reason)
        {
            this.setProperty("reason", reason);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getRequestedDatetime ()
        {
            return (DateTime) this.getProperty("requestedDatetime");
        }

        public void setRequestedDatetime (DateTime requestedDatetime)
        {
            this.setProperty("requestedDatetime", requestedDatetime);
        }

        public DateTime getConfirmedDatetime ()
        {
            return (DateTime) this.getProperty("confirmedDatetime");
        }

        public void setConfirmedDatetime (DateTime confirmedDatetime)
        {
            this.setProperty("confirmedDatetime", confirmedDatetime);
        }

        public DateTime getRejectedDatetime ()
        {
            return (DateTime) this.getProperty("rejectedDatetime");
        }

        public void setRejectedDatetime (DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }


    }
}

