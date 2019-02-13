using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserLogin : ModelBase
    {
        protected string resourceType = ResourceType.USER_LOGIN;
        public const string USER = "user";
        public const string LOGIN_DATETIME = "loginDatetime";
        public const string IP_ADDRESS = "ipAddress";
        public const string USER_AGENT = "userAgent";
        public const string TWO_FACTOR_AUTHENTICATION_METHOD = "twoFactorAuthenticationMethod";
        public const string IDENTITY_PROVIDER = "identityProvider";

        public UserLogin ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UserLogin (string resourceType = "UserLogin", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UserLogin> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UserLogin");
        	RestGateway gateway = (RestGateway) UserLogin.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UserLogin> userloginCollection = new ModelCollection<UserLogin> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    userloginCollection.add((UserLogin) model);
        	}
        
        	return userloginCollection;
        }

        public static UserLogin retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UserLogin.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UserLogin) gateway.retrieve(ResourceType.USER_LOGIN, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public DateTime getLoginDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("loginDatetime"))
        }

        public void setLoginDatetime (DateTime loginDatetime)
        {
            this.setProperty("loginDatetime", loginDatetime);
        }

        public string getIpAddress ()
        {
            return this.getProperty("ipAddress").ToString();
        }

        public void setIpAddress (string ipAddress)
        {
            this.setProperty("ipAddress", ipAddress);
        }

        public string getUserAgent ()
        {
            return this.getProperty("userAgent").ToString();
        }

        public void setUserAgent (string userAgent)
        {
            this.setProperty("userAgent", userAgent);
        }

        public string getTwoFactorAuthenticationMethod ()
        {
            return this.getProperty("twoFactorAuthenticationMethod").ToString();
        }

        public void setTwoFactorAuthenticationMethod (string twoFactorAuthenticationMethod)
        {
            this.setProperty("twoFactorAuthenticationMethod", twoFactorAuthenticationMethod);
        }

        public string getIdentityProvider ()
        {
            return this.getProperty("identityProvider").ToString();
        }

        public void setIdentityProvider (string identityProvider)
        {
            this.setProperty("identityProvider", identityProvider);
        }


    }
}

