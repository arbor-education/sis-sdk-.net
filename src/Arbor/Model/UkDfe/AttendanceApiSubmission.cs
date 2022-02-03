using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AttendanceApiSubmission : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ATTENDANCE_API_SUBMISSION;
        public const string PAYLOAD = "payload";
        public const string PAYLOAD_SENT_DATETIME = "payloadSentDatetime";
        public const string RESPONSE = "response";
        public const string RESPONSE_STATUS_CODE = "responseStatusCode";
        public const string RESPONSE_RECEIVED_DATETIME = "responseReceivedDatetime";
        public const string RESPONSE_SUBMISSION_REFERENCE = "responseSubmissionReference";
        public const string STATUS = "status";

        public AttendanceApiSubmission ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AttendanceApiSubmission (string resourceType = "AttendanceApiSubmission", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AttendanceApiSubmission> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_AttendanceApiSubmission");
        	RestGateway gateway = (RestGateway) AttendanceApiSubmission.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AttendanceApiSubmission> attendanceapisubmissionCollection = new ModelCollection<AttendanceApiSubmission> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    attendanceapisubmissionCollection.add((AttendanceApiSubmission) model);
        	}
        
        	return attendanceapisubmissionCollection;
        }

        public static AttendanceApiSubmission retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AttendanceApiSubmission.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AttendanceApiSubmission) gateway.retrieve(ResourceType.UK_DFE_ATTENDANCE_API_SUBMISSION, id);
        }

        public string getPayload ()
        {
            return this.getProperty("payload").ToString();
        }

        public void setPayload (string payload)
        {
            this.setProperty("payload", payload);
        }

        public DateTime getPayloadSentDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("payloadSentDatetime"));
        }

        public void setPayloadSentDatetime (DateTime payloadSentDatetime)
        {
            this.setProperty("payloadSentDatetime", payloadSentDatetime);
        }

        public string getResponse ()
        {
            return this.getProperty("response").ToString();
        }

        public void setResponse (string response)
        {
            this.setProperty("response", response);
        }

        public int getResponseStatusCode ()
        {
            return Convert.ToInt32(this.getProperty("responseStatusCode"));
        }

        public void setResponseStatusCode (int responseStatusCode)
        {
            this.setProperty("responseStatusCode", responseStatusCode);
        }

        public DateTime getResponseReceivedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("responseReceivedDatetime"));
        }

        public void setResponseReceivedDatetime (DateTime responseReceivedDatetime)
        {
            this.setProperty("responseReceivedDatetime", responseReceivedDatetime);
        }

        public string getResponseSubmissionReference ()
        {
            return this.getProperty("responseSubmissionReference").ToString();
        }

        public void setResponseSubmissionReference (string responseSubmissionReference)
        {
            this.setProperty("responseSubmissionReference", responseSubmissionReference);
        }

        public bool getStatus ()
        {
            return Convert.ToBoolean(this.getProperty("status"));
        }

        public void setStatus (bool status)
        {
            this.setProperty("status", status);
        }


    }
}

