using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SmsMessageStatus : ModelBase
    {
        protected new string resourceType = ResourceType.SMS_MESSAGE_STATUS;
        public const string SMS_MESSAGE = "smsMessage";
        public const string SMS_MESSAGE_PART = "smsMessagePart";
        public const string STATUS_TYPE = "statusType";
        public const string STATUS_DATETIME = "statusDatetime";
        public const string ERROR_TYPE = "errorType";

        public SmsMessageStatus()
        {
            base.resourceType = this.resourceType;
        }

        public SmsMessageStatus(string resourceType = "SmsMessageStatus", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SmsMessageStatus> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SmsMessageStatus");
            RestGateway gateway = (RestGateway)SmsMessageStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SmsMessageStatus> smsmessagestatusCollection = new ModelCollection<SmsMessageStatus>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                smsmessagestatusCollection.add((SmsMessageStatus)model);
            }

            return smsmessagestatusCollection;
        }

        public static SmsMessageStatus retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SmsMessageStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SmsMessageStatus)gateway.retrieve(ResourceType.SMS_MESSAGE_STATUS, id);
        }

        public SmsMessage getSmsMessage()
        {
            return (SmsMessage)this.getProperty("smsMessage");
        }

        public void setSmsMessage(SmsMessage smsMessage)
        {
            this.setProperty("smsMessage", smsMessage);
        }

        public SmsMessagePart getSmsMessagePart()
        {
            return (SmsMessagePart)this.getProperty("smsMessagePart");
        }

        public void setSmsMessagePart(SmsMessagePart smsMessagePart)
        {
            this.setProperty("smsMessagePart", smsMessagePart);
        }

        public string getStatusType()
        {
            return this.getProperty("statusType").ToString();
        }

        public void setStatusType(string statusType)
        {
            this.setProperty("statusType", statusType);
        }

        public DateTime getStatusDatetime()
        {
            return Convert.ToDateTime(this.getProperty("statusDatetime"));
        }

        public void setStatusDatetime(DateTime statusDatetime)
        {
            this.setProperty("statusDatetime", statusDatetime);
        }

        public string getErrorType()
        {
            return this.getProperty("errorType").ToString();
        }

        public void setErrorType(string errorType)
        {
            this.setProperty("errorType", errorType);
        }


    }
}

