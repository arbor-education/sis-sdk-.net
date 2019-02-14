using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailStatus : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_STATUS;
        public const string EMAIL = "email";
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string EMAIL_RECIPIENT = "emailRecipient";
        public const string STATUS_TYPE = "statusType";
        public const string STATUS_DATETIME = "statusDatetime";
        public const string STATUS_CODE = "statusCode";
        public const string STATUS_DETAIL = "statusDetail";
        public const string DELIVERY_ATTEMPT_NUMBER = "deliveryAttemptNumber";

        public EmailStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EmailStatus (string resourceType = "EmailStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EmailStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EmailStatus");
        	RestGateway gateway = (RestGateway) EmailStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EmailStatus> emailstatusCollection = new ModelCollection<EmailStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    emailstatusCollection.add((EmailStatus) model);
        	}
        
        	return emailstatusCollection;
        }

        public static EmailStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EmailStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EmailStatus) gateway.retrieve(ResourceType.EMAIL_STATUS, id);
        }

        public Email getEmail ()
        {
            return (Email) this.getProperty("email");
        }

        public void setEmail (Email email)
        {
            this.setProperty("email", email);
        }

        public string getEmailAddress ()
        {
            return this.getProperty("emailAddress").ToString();
        }

        public void setEmailAddress (string emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public EmailRecipient getEmailRecipient ()
        {
            return (EmailRecipient) this.getProperty("emailRecipient");
        }

        public void setEmailRecipient (EmailRecipient emailRecipient)
        {
            this.setProperty("emailRecipient", emailRecipient);
        }

        public string getStatusType ()
        {
            return this.getProperty("statusType").ToString();
        }

        public void setStatusType (string statusType)
        {
            this.setProperty("statusType", statusType);
        }

        public DateTime getStatusDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("statusDatetime"))
        }

        public void setStatusDatetime (DateTime statusDatetime)
        {
            this.setProperty("statusDatetime", statusDatetime);
        }

        public int getStatusCode ()
        {
            return Convert.ToInt32(this.getProperty("statusCode"));
        }

        public void setStatusCode (int statusCode)
        {
            this.setProperty("statusCode", statusCode);
        }

        public string getStatusDetail ()
        {
            return this.getProperty("statusDetail").ToString();
        }

        public void setStatusDetail (string statusDetail)
        {
            this.setProperty("statusDetail", statusDetail);
        }

        public int getDeliveryAttemptNumber ()
        {
            return Convert.ToInt32(this.getProperty("deliveryAttemptNumber"));
        }

        public void setDeliveryAttemptNumber (int deliveryAttemptNumber)
        {
            this.setProperty("deliveryAttemptNumber", deliveryAttemptNumber);
        }


    }
}

