using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SmsMessagePart : ModelBase
    {
        protected string resourceType = ResourceType.SMS_MESSAGE_PART;
        public const string SMS_MESSAGE = "smsMessage";
        public const string PART_IDENTIFIER = "partIdentifier";
        public const string RECEIVED_DATETIME = "receivedDatetime";
        public const string FAILED_DATETIME = "failedDatetime";
        public const string RECIPIENT_NETWORK_CODE = "recipientNetworkCode";
        public const string COST = "cost";

        public SmsMessagePart ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SmsMessagePart (string resourceType = "SmsMessagePart", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SmsMessagePart> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SmsMessagePart");
        	RestGateway gateway = (RestGateway) SmsMessagePart.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SmsMessagePart> smsmessagepartCollection = new ModelCollection<SmsMessagePart> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    smsmessagepartCollection.add((SmsMessagePart) model);
        	}
        
        	return smsmessagepartCollection;
        }

        public static SmsMessagePart retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SmsMessagePart.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SmsMessagePart) gateway.retrieve(ResourceType.SMS_MESSAGE_PART, id);
        }

        public SmsMessage getSmsMessage ()
        {
            return (SmsMessage) this.getProperty("smsMessage");
        }

        public void setSmsMessage (SmsMessage smsMessage)
        {
            this.setProperty("smsMessage", smsMessage);
        }

        public string getPartIdentifier ()
        {
            return this.getProperty("partIdentifier").ToString();
        }

        public void setPartIdentifier (string partIdentifier)
        {
            this.setProperty("partIdentifier", partIdentifier);
        }

        public DateTime getReceivedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("receivedDatetime"));
        }

        public void setReceivedDatetime (DateTime receivedDatetime)
        {
            this.setProperty("receivedDatetime", receivedDatetime);
        }

        public DateTime getFailedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("failedDatetime"));
        }

        public void setFailedDatetime (DateTime failedDatetime)
        {
            this.setProperty("failedDatetime", failedDatetime);
        }

        public string getRecipientNetworkCode ()
        {
            return this.getProperty("recipientNetworkCode").ToString();
        }

        public void setRecipientNetworkCode (string recipientNetworkCode)
        {
            this.setProperty("recipientNetworkCode", recipientNetworkCode);
        }

        public string getCost ()
        {
            return this.getProperty("cost").ToString();
        }

        public void setCost (string cost)
        {
            this.setProperty("cost", cost);
        }


    }
}

