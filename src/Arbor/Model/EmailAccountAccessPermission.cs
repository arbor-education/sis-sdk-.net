using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailAccountAccessPermission : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_ACCOUNT_ACCESS_PERMISSION;
        public const string EMAIL_ACCOUNT = "emailAccount";
        public const string BUSINESS_ROLE = "businessRole";

        public EmailAccountAccessPermission()
        {
            base.resourceType = this.resourceType;
        }

        public EmailAccountAccessPermission(string resourceType = "EmailAccountAccessPermission", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailAccountAccessPermission> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailAccountAccessPermission");
            RestGateway gateway = (RestGateway)EmailAccountAccessPermission.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailAccountAccessPermission> emailaccountaccesspermissionCollection = new ModelCollection<EmailAccountAccessPermission>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailaccountaccesspermissionCollection.add((EmailAccountAccessPermission)model);
            }

            return emailaccountaccesspermissionCollection;
        }

        public static EmailAccountAccessPermission retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailAccountAccessPermission.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailAccountAccessPermission)gateway.retrieve(ResourceType.EMAIL_ACCOUNT_ACCESS_PERMISSION, id);
        }

        public EmailAccount getEmailAccount()
        {
            return (EmailAccount)this.getProperty("emailAccount");
        }

        public void setEmailAccount(EmailAccount emailAccount)
        {
            this.setProperty("emailAccount", emailAccount);
        }

        public BusinessRole getBusinessRole()
        {
            return (BusinessRole)this.getProperty("businessRole");
        }

        public void setBusinessRole(BusinessRole businessRole)
        {
            this.setProperty("businessRole", businessRole);
        }


    }
}

