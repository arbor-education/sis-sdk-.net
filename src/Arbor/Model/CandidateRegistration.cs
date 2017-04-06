using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateRegistration : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_REGISTRATION;
        public const string CANDIDATE = "candidate";
        public const string QUALIFICATION_AWARD = "qualificationAward";
        public const string REGISTRATION_NUMBER = "registrationNumber";
        public const string REGISTRATION_REQUESTED_DATETIME = "registrationRequestedDatetime";
        public const string REGISTRATION_CONFIRMED_DATETIME = "registrationConfirmedDatetime";
        public const string RESPONSE_RECEIVED_DATETIME = "responseReceivedDatetime";
        public const string RESPONSE_MESSAGE = "responseMessage";

        public CandidateRegistration ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateRegistration (string resourceType = "CandidateRegistration", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateRegistration> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateRegistration");
        	RestGateway gateway = (RestGateway) CandidateRegistration.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateRegistration> candidateregistrationCollection = new ModelCollection<CandidateRegistration> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateregistrationCollection.add((CandidateRegistration) model);
        	}
        
        	return candidateregistrationCollection;
        }

        public static CandidateRegistration retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateRegistration.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateRegistration) gateway.retrieve(ResourceType.CANDIDATE_REGISTRATION, id);
        }

        public Candidate getCandidate ()
        {
            return (Candidate) this.getProperty("candidate");
        }

        public void setCandidate (Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public QualificationAward getQualificationAward ()
        {
            return (QualificationAward) this.getProperty("qualificationAward");
        }

        public void setQualificationAward (QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
        }

        public string getRegistrationNumber ()
        {
            return this.getProperty("registrationNumber").ToString();
        }

        public void setRegistrationNumber (string registrationNumber)
        {
            this.setProperty("registrationNumber", registrationNumber);
        }

        public DateTime getRegistrationRequestedDatetime ()
        {
            return (DateTime) this.getProperty("registrationRequestedDatetime");
        }

        public void setRegistrationRequestedDatetime (DateTime registrationRequestedDatetime)
        {
            this.setProperty("registrationRequestedDatetime", registrationRequestedDatetime);
        }

        public DateTime getRegistrationConfirmedDatetime ()
        {
            return (DateTime) this.getProperty("registrationConfirmedDatetime");
        }

        public void setRegistrationConfirmedDatetime (DateTime registrationConfirmedDatetime)
        {
            this.setProperty("registrationConfirmedDatetime", registrationConfirmedDatetime);
        }

        public DateTime getResponseReceivedDatetime ()
        {
            return (DateTime) this.getProperty("responseReceivedDatetime");
        }

        public void setResponseReceivedDatetime (DateTime responseReceivedDatetime)
        {
            this.setProperty("responseReceivedDatetime", responseReceivedDatetime);
        }

        public string getResponseMessage ()
        {
            return this.getProperty("responseMessage").ToString();
        }

        public void setResponseMessage (string responseMessage)
        {
            this.setProperty("responseMessage", responseMessage);
        }


    }
}

