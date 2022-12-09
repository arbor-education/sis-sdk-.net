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
        protected new string resourceType = ResourceType.USER;
        public const string STAFF = "staff";
        public const string STUDENT = "student";
        public const string GUARDIAN = "guardian";
        public const string EXTERNAL_ADMINISTRATOR = "externalAdministrator";
        public const string USERNAME = "username";
        public const string EMAIL = "email";
        public const string PASSWORD_HASH = "passwordHash";
        public const string PASSWORD_RESET_HASH = "passwordResetHash";
        public const string AUTHENTICATION_TYPE = "authenticationType";
        public const string AUTHENTICATION_TOKEN = "authenticationToken";
        public const string AUTHENTICATION_TOKEN_EXPIRY_DATETIME = "authenticationTokenExpiryDatetime";
        public const string CURRENT_IP_ADDRESS = "currentIpAddress";
        public const string LAST_ACCESS_DATETIME = "lastAccessDatetime";
        public const string PASSWORD_LAST_CHANGED_DATETIME = "passwordLastChangedDatetime";
        public const string ENABLED = "enabled";
        public const string VERIFIED_DATETIME = "verifiedDatetime";
        public const string TERMS_OF_USE_ACCEPTED_DATETIME = "termsOfUseAcceptedDatetime";
        public const string WELCOME_MESSAGE_DATETIME = "welcomeMessageDatetime";
        public const string TWO_FACTOR_AUTH_METHOD = "twoFactorAuthMethod";
        public const string TWO_FACTOR_DEVICE_IDENTIFIER = "twoFactorDeviceIdentifier";
        public const string DELETED_ENTITY_TYPE = "deletedEntityType";
        public const string DELETED_OBJECT_ID = "deletedObjectId";
        public const string DELETED_DISPLAY_NAME = "deletedDisplayName";
        public const string GOOGLE_TWO_FACTOR_SECRET = "googleTwoFactorSecret";
        public const string SSO_TWO_FACTOR_ACTIVATED = "ssoTwoFactorActivated";
        public const string ACCEPT_SAAS_TERMS_AND_CONDITIONS_BY_DATETIME = "acceptSaasTermsAndConditionsByDatetime";

        public User()
        {
            base.resourceType = this.resourceType;
        }

        public User(string resourceType = "User", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<User> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("User");
            RestGateway gateway = (RestGateway)User.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<User> userCollection = new ModelCollection<User>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                userCollection.add((User)model);
            }

            return userCollection;
        }

        public static User retrieve(string id)
        {
            RestGateway gateway = (RestGateway)User.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (User)gateway.retrieve(ResourceType.USER, id);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public Guardian getGuardian()
        {
            return (Guardian)this.getProperty("guardian");
        }

        public void setGuardian(Guardian guardian)
        {
            this.setProperty("guardian", guardian);
        }

        public ExternalAdministrator getExternalAdministrator()
        {
            return (ExternalAdministrator)this.getProperty("externalAdministrator");
        }

        public void setExternalAdministrator(ExternalAdministrator externalAdministrator)
        {
            this.setProperty("externalAdministrator", externalAdministrator);
        }

        public string getUsername()
        {
            return this.getProperty("username").ToString();
        }

        public void setUsername(string username)
        {
            this.setProperty("username", username);
        }

        public string getEmail()
        {
            return this.getProperty("email").ToString();
        }

        public void setEmail(string email)
        {
            this.setProperty("email", email);
        }

        public string getPasswordHash()
        {
            return this.getProperty("passwordHash").ToString();
        }

        public void setPasswordHash(string passwordHash)
        {
            this.setProperty("passwordHash", passwordHash);
        }

        public string getPasswordResetHash()
        {
            return this.getProperty("passwordResetHash").ToString();
        }

        public void setPasswordResetHash(string passwordResetHash)
        {
            this.setProperty("passwordResetHash", passwordResetHash);
        }

        public string getAuthenticationType()
        {
            return this.getProperty("authenticationType").ToString();
        }

        public void setAuthenticationType(string authenticationType)
        {
            this.setProperty("authenticationType", authenticationType);
        }

        public string getAuthenticationToken()
        {
            return this.getProperty("authenticationToken").ToString();
        }

        public void setAuthenticationToken(string authenticationToken)
        {
            this.setProperty("authenticationToken", authenticationToken);
        }

        public DateTime getAuthenticationTokenExpiryDatetime()
        {
            return Convert.ToDateTime(this.getProperty("authenticationTokenExpiryDatetime"));
        }

        public void setAuthenticationTokenExpiryDatetime(DateTime authenticationTokenExpiryDatetime)
        {
            this.setProperty("authenticationTokenExpiryDatetime", authenticationTokenExpiryDatetime);
        }

        public string getCurrentIpAddress()
        {
            return this.getProperty("currentIpAddress").ToString();
        }

        public void setCurrentIpAddress(string currentIpAddress)
        {
            this.setProperty("currentIpAddress", currentIpAddress);
        }

        public DateTime getLastAccessDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastAccessDatetime"));
        }

        public void setLastAccessDatetime(DateTime lastAccessDatetime)
        {
            this.setProperty("lastAccessDatetime", lastAccessDatetime);
        }

        public DateTime getPasswordLastChangedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("passwordLastChangedDatetime"));
        }

        public void setPasswordLastChangedDatetime(DateTime passwordLastChangedDatetime)
        {
            this.setProperty("passwordLastChangedDatetime", passwordLastChangedDatetime);
        }

        public bool getEnabled()
        {
            return Convert.ToBoolean(this.getProperty("enabled"));
        }

        public void setEnabled(bool enabled)
        {
            this.setProperty("enabled", enabled);
        }

        public DateTime getVerifiedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("verifiedDatetime"));
        }

        public void setVerifiedDatetime(DateTime verifiedDatetime)
        {
            this.setProperty("verifiedDatetime", verifiedDatetime);
        }

        public DateTime getTermsOfUseAcceptedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("termsOfUseAcceptedDatetime"));
        }

        public void setTermsOfUseAcceptedDatetime(DateTime termsOfUseAcceptedDatetime)
        {
            this.setProperty("termsOfUseAcceptedDatetime", termsOfUseAcceptedDatetime);
        }

        public DateTime getWelcomeMessageDatetime()
        {
            return Convert.ToDateTime(this.getProperty("welcomeMessageDatetime"));
        }

        public void setWelcomeMessageDatetime(DateTime welcomeMessageDatetime)
        {
            this.setProperty("welcomeMessageDatetime", welcomeMessageDatetime);
        }

        public string getTwoFactorAuthMethod()
        {
            return this.getProperty("twoFactorAuthMethod").ToString();
        }

        public void setTwoFactorAuthMethod(string twoFactorAuthMethod)
        {
            this.setProperty("twoFactorAuthMethod", twoFactorAuthMethod);
        }

        public string getTwoFactorDeviceIdentifier()
        {
            return this.getProperty("twoFactorDeviceIdentifier").ToString();
        }

        public void setTwoFactorDeviceIdentifier(string twoFactorDeviceIdentifier)
        {
            this.setProperty("twoFactorDeviceIdentifier", twoFactorDeviceIdentifier);
        }

        public int getDeletedEntityType()
        {
            return Convert.ToInt32(this.getProperty("deletedEntityType"));
        }

        public void setDeletedEntityType(int deletedEntityType)
        {
            this.setProperty("deletedEntityType", deletedEntityType);
        }

        public int getDeletedObjectId()
        {
            return Convert.ToInt32(this.getProperty("deletedObjectId"));
        }

        public void setDeletedObjectId(int deletedObjectId)
        {
            this.setProperty("deletedObjectId", deletedObjectId);
        }

        public string getDeletedDisplayName()
        {
            return this.getProperty("deletedDisplayName").ToString();
        }

        public void setDeletedDisplayName(string deletedDisplayName)
        {
            this.setProperty("deletedDisplayName", deletedDisplayName);
        }

        public string getGoogleTwoFactorSecret()
        {
            return this.getProperty("googleTwoFactorSecret").ToString();
        }

        public void setGoogleTwoFactorSecret(string googleTwoFactorSecret)
        {
            this.setProperty("googleTwoFactorSecret", googleTwoFactorSecret);
        }

        public bool getSsoTwoFactorActivated()
        {
            return Convert.ToBoolean(this.getProperty("ssoTwoFactorActivated"));
        }

        public void setSsoTwoFactorActivated(bool ssoTwoFactorActivated)
        {
            this.setProperty("ssoTwoFactorActivated", ssoTwoFactorActivated);
        }

        public DateTime getAcceptSaasTermsAndConditionsByDatetime()
        {
            return Convert.ToDateTime(this.getProperty("acceptSaasTermsAndConditionsByDatetime"));
        }

        public void setAcceptSaasTermsAndConditionsByDatetime(DateTime acceptSaasTermsAndConditionsByDatetime)
        {
            this.setProperty("acceptSaasTermsAndConditionsByDatetime", acceptSaasTermsAndConditionsByDatetime);
        }


    }
}

