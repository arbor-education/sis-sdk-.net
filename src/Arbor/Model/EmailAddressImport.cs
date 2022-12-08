using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmailAddressImport : ModelBase
    {
        protected string resourceType = ResourceType.EMAIL_ADDRESS_IMPORT;
        public const string EMAIL_ADDRESS_OWNER = "emailAddressOwner";
        public const string EMAIL_ADDRESS_TYPE = "emailAddressType";
        public const string EMAIL_ADDRESS = "emailAddress";
        public const string ROW_INDEX = "rowIndex";
        public const string ERRORS = "errors";
        public const string REQUIRED_ERRORS = "requiredErrors";

        public EmailAddressImport()
        {
            base.resourceType = this.resourceType;
        }

        public EmailAddressImport(string resourceType = "EmailAddressImport", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EmailAddressImport> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EmailAddressImport");
            RestGateway gateway = (RestGateway)EmailAddressImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EmailAddressImport> emailaddressimportCollection = new ModelCollection<EmailAddressImport>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                emailaddressimportCollection.add((EmailAddressImport)model);
            }

            return emailaddressimportCollection;
        }

        public static EmailAddressImport retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EmailAddressImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EmailAddressImport)gateway.retrieve(ResourceType.EMAIL_ADDRESS_IMPORT, id);
        }

        public ModelBase getEmailAddressOwner()
        {
            return (ModelBase)this.getProperty("emailAddressOwner");
        }

        public void setEmailAddressOwner(ModelBase emailAddressOwner)
        {
            this.setProperty("emailAddressOwner", emailAddressOwner);
        }

        public string getEmailAddressType()
        {
            return this.getProperty("emailAddressType").ToString();
        }

        public void setEmailAddressType(string emailAddressType)
        {
            this.setProperty("emailAddressType", emailAddressType);
        }

        public string getEmailAddress()
        {
            return this.getProperty("emailAddress").ToString();
        }

        public void setEmailAddress(string emailAddress)
        {
            this.setProperty("emailAddress", emailAddress);
        }

        public int getRowIndex()
        {
            return Convert.ToInt32(this.getProperty("rowIndex"));
        }

        public void setRowIndex(int rowIndex)
        {
            this.setProperty("rowIndex", rowIndex);
        }

        public string getErrors()
        {
            return this.getProperty("errors").ToString();
        }

        public void setErrors(string errors)
        {
            this.setProperty("errors", errors);
        }

        public string getRequiredErrors()
        {
            return this.getProperty("requiredErrors").ToString();
        }

        public void setRequiredErrors(string requiredErrors)
        {
            this.setProperty("requiredErrors", requiredErrors);
        }


    }
}

