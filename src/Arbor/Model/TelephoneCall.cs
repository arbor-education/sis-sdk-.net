using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TelephoneCall : ModelBase
    {
        protected string resourceType = ResourceType.TELEPHONE_CALL;
        public const string CALLER_NAME = "callerName";
        public const string CALLER = "caller";
        public const string CALLER_TELEPHONE_NUMBER = "callerTelephoneNumber";
        public const string CALLER_TELEPHONE_NUMBER_MODEL = "callerTelephoneNumberModel";
        public const string CALL_DATETIME = "callDatetime";
        public const string CALL_DURATION = "callDuration";
        public const string RECIPIENT_NAME = "recipientName";
        public const string RECIPIENT = "recipient";
        public const string RECIPIENT_TELEPHONE_NUMBER = "recipientTelephoneNumber";
        public const string RECIPIENT_TELEPHONE_NUMBER_MODEL = "recipientTelephoneNumberModel";
        public const string SUBJECT = "subject";
        public const string SUMMARY = "summary";
        public const string ACTION_REQUIRED_BY_DATETIME = "actionRequiredByDatetime";

        public TelephoneCall()
        {
            base.resourceType = this.resourceType;
        }

        public TelephoneCall(string resourceType = "TelephoneCall", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TelephoneCall> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TelephoneCall");
            RestGateway gateway = (RestGateway)TelephoneCall.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TelephoneCall> telephonecallCollection = new ModelCollection<TelephoneCall>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                telephonecallCollection.add((TelephoneCall)model);
            }

            return telephonecallCollection;
        }

        public static TelephoneCall retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TelephoneCall.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TelephoneCall)gateway.retrieve(ResourceType.TELEPHONE_CALL, id);
        }

        public string getCallerName()
        {
            return this.getProperty("callerName").ToString();
        }

        public void setCallerName(string callerName)
        {
            this.setProperty("callerName", callerName);
        }

        public ModelBase getCaller()
        {
            return (ModelBase)this.getProperty("caller");
        }

        public void setCaller(ModelBase caller)
        {
            this.setProperty("caller", caller);
        }

        public string getCallerTelephoneNumber()
        {
            return this.getProperty("callerTelephoneNumber").ToString();
        }

        public void setCallerTelephoneNumber(string callerTelephoneNumber)
        {
            this.setProperty("callerTelephoneNumber", callerTelephoneNumber);
        }

        public TelephoneNumber getCallerTelephoneNumberModel()
        {
            return (TelephoneNumber)this.getProperty("callerTelephoneNumberModel");
        }

        public void setCallerTelephoneNumberModel(TelephoneNumber callerTelephoneNumberModel)
        {
            this.setProperty("callerTelephoneNumberModel", callerTelephoneNumberModel);
        }

        public DateTime getCallDatetime()
        {
            return Convert.ToDateTime(this.getProperty("callDatetime"));
        }

        public void setCallDatetime(DateTime callDatetime)
        {
            this.setProperty("callDatetime", callDatetime);
        }

        public string getCallDuration()
        {
            return this.getProperty("callDuration").ToString();
        }

        public void setCallDuration(string callDuration)
        {
            this.setProperty("callDuration", callDuration);
        }

        public string getRecipientName()
        {
            return this.getProperty("recipientName").ToString();
        }

        public void setRecipientName(string recipientName)
        {
            this.setProperty("recipientName", recipientName);
        }

        public ModelBase getRecipient()
        {
            return (ModelBase)this.getProperty("recipient");
        }

        public void setRecipient(ModelBase recipient)
        {
            this.setProperty("recipient", recipient);
        }

        public string getRecipientTelephoneNumber()
        {
            return this.getProperty("recipientTelephoneNumber").ToString();
        }

        public void setRecipientTelephoneNumber(string recipientTelephoneNumber)
        {
            this.setProperty("recipientTelephoneNumber", recipientTelephoneNumber);
        }

        public TelephoneNumber getRecipientTelephoneNumberModel()
        {
            return (TelephoneNumber)this.getProperty("recipientTelephoneNumberModel");
        }

        public void setRecipientTelephoneNumberModel(TelephoneNumber recipientTelephoneNumberModel)
        {
            this.setProperty("recipientTelephoneNumberModel", recipientTelephoneNumberModel);
        }

        public string getSubject()
        {
            return this.getProperty("subject").ToString();
        }

        public void setSubject(string subject)
        {
            this.setProperty("subject", subject);
        }

        public string getSummary()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary(string summary)
        {
            this.setProperty("summary", summary);
        }

        public DateTime getActionRequiredByDatetime()
        {
            return Convert.ToDateTime(this.getProperty("actionRequiredByDatetime"));
        }

        public void setActionRequiredByDatetime(DateTime actionRequiredByDatetime)
        {
            this.setProperty("actionRequiredByDatetime", actionRequiredByDatetime);
        }


    }
}

