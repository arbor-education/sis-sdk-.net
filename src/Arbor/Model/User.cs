using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class User : ModelBase
    {
        protected string resourceType = ResourceType.USER;
        public const string STAFF = "staff";
        public const string STUDENT = "student";
        public const string GUARDIAN = "guardian";
        public const string USERNAME = "username";
        public const string EMAIL = "email";
        public const string PASSWORD_HASH = "passwordHash";
        public const string AUTHENTICATION_TYPE = "authenticationType";
        public const string AUTHENTICATION_TOKEN = "authenticationToken";
        public const string AUTHENTICATION_TOKEN_EXPIRY_DATETIME = "authenticationTokenExpiryDatetime";
        public const string CURRENT_IP_ADDRESS = "currentIpAddress";
        public const string LAST_ACCESS_DATETIME = "lastAccessDatetime";
        public const string ENABLED = "enabled";
        public const string VERIFIED_DATETIME = "verifiedDatetime";
        public const string TERMS_ACCEPTED_DATETIME = "termsAcceptedDatetime";
        public const string WELCOME_MESSAGE_DATETIME = "welcomeMessageDatetime";

        public User ()
        {
            base.resourceType = this.resourceType;
        }
        
        public User (string resourceType = "User", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<User> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("User");
        	RestGateway gateway = (RestGateway) User.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<User> userCollection = new ModelCollection<User> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    userCollection.add((User) model);
        	}
        
        	return userCollection;
        }

        public static User retrieve (string id)
        {
            RestGateway gateway = (RestGateway) User.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (User) gateway.retrieve(ResourceType.USER, id);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Guardian getGuardian ()
        {
            return (Guardian) this.getProperty("guardian");
        }

        public void setGuardian (Guardian guardian)
        {
            this.setProperty("guardian", guardian);
        }

        public string getUsername ()
        {
            return this.getProperty("username").ToString();
        }

        public void setUsername (string username)
        {
            this.setProperty("username", username);
        }

        public string getEmail ()
        {
            return this.getProperty("email").ToString();
        }

        public void setEmail (string email)
        {
            this.setProperty("email", email);
        }

        public string getPasswordHash ()
        {
            return this.getProperty("passwordHash").ToString();
        }

        public void setPasswordHash (string passwordHash)
        {
            this.setProperty("passwordHash", passwordHash);
        }

        public string getAuthenticationType ()
        {
            return this.getProperty("authenticationType").ToString();
        }

        public void setAuthenticationType (string authenticationType)
        {
            this.setProperty("authenticationType", authenticationType);
        }

        public string getAuthenticationToken ()
        {
            return this.getProperty("authenticationToken").ToString();
        }

        public void setAuthenticationToken (string authenticationToken)
        {
            this.setProperty("authenticationToken", authenticationToken);
        }

        public DateTime getAuthenticationTokenExpiryDatetime ()
        {
            return (DateTime) this.getProperty("authenticationTokenExpiryDatetime");
        }

        public void setAuthenticationTokenExpiryDatetime (DateTime authenticationTokenExpiryDatetime)
        {
            this.setProperty("authenticationTokenExpiryDatetime", authenticationTokenExpiryDatetime);
        }

        public string getCurrentIpAddress ()
        {
            return this.getProperty("currentIpAddress").ToString();
        }

        public void setCurrentIpAddress (string currentIpAddress)
        {
            this.setProperty("currentIpAddress", currentIpAddress);
        }

        public DateTime getLastAccessDatetime ()
        {
            return (DateTime) this.getProperty("lastAccessDatetime");
        }

        public void setLastAccessDatetime (DateTime lastAccessDatetime)
        {
            this.setProperty("lastAccessDatetime", lastAccessDatetime);
        }

        public bool getEnabled ()
        {
            return (bool) this.getProperty("enabled");
        }

        public void setEnabled (bool enabled)
        {
            this.setProperty("enabled", enabled);
        }

        public DateTime getVerifiedDatetime ()
        {
            return (DateTime) this.getProperty("verifiedDatetime");
        }

        public void setVerifiedDatetime (DateTime verifiedDatetime)
        {
            this.setProperty("verifiedDatetime", verifiedDatetime);
        }

        public DateTime getTermsAcceptedDatetime ()
        {
            return (DateTime) this.getProperty("termsAcceptedDatetime");
        }

        public void setTermsAcceptedDatetime (DateTime termsAcceptedDatetime)
        {
            this.setProperty("termsAcceptedDatetime", termsAcceptedDatetime);
        }

        public DateTime getWelcomeMessageDatetime ()
        {
            return (DateTime) this.getProperty("welcomeMessageDatetime");
        }

        public void setWelcomeMessageDatetime (DateTime welcomeMessageDatetime)
        {
            this.setProperty("welcomeMessageDatetime", welcomeMessageDatetime);
        }


    }
}

