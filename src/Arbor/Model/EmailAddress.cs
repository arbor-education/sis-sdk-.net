using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailAddress : ModelBase
    {
        protected new string resourceType = ResourceType.EMAIL_ADDRESS;
        public const string EMAIL_ADDRESS_OWNER = "emailAddressOwner";
        public const string EMAIL_ADDRESS_TYPE = "emailAddressType";
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string DATA_ORDER = "dataOrder";
        public const string ROLE = "role";
        public const string FREE = "free";
        public const string DISPOSABLE = "disposable";

        public EmailAddress ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EmailAddress (string resourceType = "EmailAddress", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EmailAddress> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EmailAddress");
        	RestGateway gateway = (RestGateway) EmailAddress.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EmailAddress> emailaddressCollection = new ModelCollection<EmailAddress> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    emailaddressCollection.add((EmailAddress) model);
        	}
        
        	return emailaddressCollection;
        }

        public static EmailAddress retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EmailAddress.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EmailAddress) gateway.retrieve(ResourceType.EMAIL_ADDRESS, id);
        }

        public ModelBase getEmailAddressOwner ()
        {
            return (ModelBase) this.getProperty("emailAddressOwner");
        }

        public void setEmailAddressOwner (ModelBase emailAddressOwner)
        {
            this.setProperty("emailAddressOwner", emailAddressOwner);
        }

        public string getEmailAddressType ()
        {
            return this.getProperty("emailAddressType").ToString();
        }

        public void setEmailAddressType (string emailAddressType)
        {
            this.setProperty("emailAddressType", emailAddressType);
        }

        public string getEmailAddress ()
        {
            return this.getProperty("emailAddress").ToString();
        }

        public void setEmailAddress (string emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public bool getRole ()
        {
            return Convert.ToBoolean(this.getProperty("role"));
        }

        public void setRole (bool role)
        {
            this.setProperty("role", role);
        }

        public bool getFree ()
        {
            return Convert.ToBoolean(this.getProperty("free"));
        }

        public void setFree (bool free)
        {
            this.setProperty("free", free);
        }

        public bool getDisposable ()
        {
            return Convert.ToBoolean(this.getProperty("disposable"));
        }

        public void setDisposable (bool disposable)
        {
            this.setProperty("disposable", disposable);
        }


    }
}

