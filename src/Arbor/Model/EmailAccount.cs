using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailAccount : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_ACCOUNT;
        public const string SERVER_TYPE = "serverType";
        public const string SERVER_HOST = "serverHost";
        public const string SERVER_PORT = "serverPort";
        public const string SERVER_ENCRYPTION = "serverEncryption";
        public const string USERNAME = "username";
        public const string PASSWORD = "password";
        public const string OWNER = "owner";

        public EmailAccount()
        {
            base.resourceType = this.resourceType;
        }

        public EmailAccount(string resourceType = "EmailAccount", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailAccount> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailAccount");
            RestGateway gateway = (RestGateway)EmailAccount.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailAccount> emailaccountCollection = new ModelCollection<EmailAccount>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailaccountCollection.add((EmailAccount)model);
            }

            return emailaccountCollection;
        }

        public static EmailAccount retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailAccount.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailAccount)gateway.retrieve(ResourceType.EMAIL_ACCOUNT, id);
        }

        public string getServerType()
        {
            return this.getProperty("serverType").ToString();
        }

        public void setServerType(string serverType)
        {
            this.setProperty("serverType", serverType);
        }

        public string getServerHost()
        {
            return this.getProperty("serverHost").ToString();
        }

        public void setServerHost(string serverHost)
        {
            this.setProperty("serverHost", serverHost);
        }

        public int getServerPort()
        {
            return Convert.ToInt32(this.getProperty("serverPort"));
        }

        public void setServerPort(int serverPort)
        {
            this.setProperty("serverPort", serverPort);
        }

        public string getServerEncryption()
        {
            return this.getProperty("serverEncryption").ToString();
        }

        public void setServerEncryption(string serverEncryption)
        {
            this.setProperty("serverEncryption", serverEncryption);
        }

        public string getUsername()
        {
            return this.getProperty("username").ToString();
        }

        public void setUsername(string username)
        {
            this.setProperty("username", username);
        }

        public string getPassword()
        {
            return this.getProperty("password").ToString();
        }

        public void setPassword(string password)
        {
            this.setProperty("password", password);
        }

        public ModelBase getOwner()
        {
            return (ModelBase)this.getProperty("owner");
        }

        public void setOwner(ModelBase owner)
        {
            this.setProperty("owner", owner);
        }


    }
}

