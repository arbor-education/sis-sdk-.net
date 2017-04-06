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
        protected string resourceType = ResourceType.CANDIDATE_ENTRY;
        public const string CANDIDATE = "candidate";
        public const string QUALIFICATION_ASSESSABLE = "qualificationAssessable";
        public const string QUALIFICATION_ASSESSABLE_INSTANCE = "qualificationAssessableInstance";
        public const string INVIGILATION_SESSION = "invigilationSession";
        public const string ENTRY_NUMBER = "entryNumber";
        public const string ENTRY_REQUESTED_DATETIME = "entryRequestedDatetime";
        public const string ENTRY_CONFIRMED_DATETIME = "entryConfirmedDatetime";
        public const string RESPONSE_RECEIVED_DATETIME = "responseReceivedDatetime";
        public const string START_DATETIME = "startDatetime";
        public const string RESPONSE_MESSAGE = "responseMessage";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string MINUTES_LATE = "minutesLate";

        public CandidateEntry ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateEntry (string resourceType = "CandidateEntry", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateEntry> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateEntry");
        	RestGateway gateway = (RestGateway) CandidateEntry.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateEntry> candidateentryCollection = new ModelCollection<CandidateEntry> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateentryCollection.add((CandidateEntry) model);
        	}
        
        	return candidateentryCollection;
        }

        public static CandidateEntry retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateEntry.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateEntry) gateway.retrieve(ResourceType.CANDIDATE_ENTRY, id);
        }

        public Candidate getCandidate ()
        {
            return (Candidate) this.getProperty("candidate");
        }

        public void setCandidate (Candidate candidate)
        {
            this.setProperty("candidate", candidate);
        }

        public QualificationAssessable getQualificationAssessable ()
        {
            return (QualificationAssessable) this.getProperty("qualificationAssessable");
        }

        public void setQualificationAssessable (QualificationAssessable qualificationAssessable)
        {
            this.setProperty("qualificationAssessable", qualificationAssessable);
        }

        public QualificationAssessableInstance getQualificationAssessableInstance ()
        {
            return (QualificationAssessableInstance) this.getProperty("qualificationAssessableInstance");
        }

        public void setQualificationAssessableInstance (QualificationAssessableInstance qualificationAssessableInstance)
        {
            this.setProperty("qualificationAssessableInstance", qualificationAssessableInstance);
        }

        public InvigilationSession getInvigilationSession ()
        {
            return (InvigilationSession) this.getProperty("invigilationSession");
        }

        public void setInvigilationSession (InvigilationSession invigilationSession)
        {
            this.setProperty("invigilationSession", invigilationSession);
        }

        public string getEntryNumber ()
        {
            return this.getProperty("entryNumber").ToString();
        }

        public void setEntryNumber (string entryNumber)
        {
            this.setProperty("entryNumber", entryNumber);
        }

        public DateTime getEntryRequestedDatetime ()
        {
            return (DateTime) this.getProperty("entryRequestedDatetime");
        }

        public void setEntryRequestedDatetime (DateTime entryRequestedDatetime)
        {
            this.setProperty("entryRequestedDatetime", entryRequestedDatetime);
        }

        public DateTime getEntryConfirmedDatetime ()
        {
            return (DateTime) this.getProperty("entryConfirmedDatetime");
        }

        public void setEntryConfirmedDatetime (DateTime entryConfirmedDatetime)
        {
            this.setProperty("entryConfirmedDatetime", entryConfirmedDatetime);
        }

        public DateTime getResponseReceivedDatetime ()
        {
            return (DateTime) this.getProperty("responseReceivedDatetime");
        }

        public void setResponseReceivedDatetime (DateTime responseReceivedDatetime)
        {
            this.setProperty("responseReceivedDatetime", responseReceivedDatetime);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public string getResponseMessage ()
        {
            return this.getProperty("responseMessage").ToString();
        }

        public void setResponseMessage (string responseMessage)
        {
            this.setProperty("responseMessage", responseMessage);
        }

        public string getAttendanceMark ()
        {
            return this.getProperty("attendanceMark").ToString();
        }

        public void setAttendanceMark (string attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public int getMinutesLate ()
        {
            return Convert.ToInt32(this.getProperty("minutesLate"));
        }

        public void setMinutesLate (int minutesLate)
        {
            this.setProperty("minutesLate", minutesLate);
        }


    }
}

