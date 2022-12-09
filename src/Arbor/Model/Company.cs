using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Company : ModelBase
    {
        protected new string resourceType = ResourceType.COMPANY;
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string REGISTRATION_NUMBER = "registrationNumber";
        public const string VAT_IDENTIFICATION_NUMBER = "vatIdentificationNumber";

        public Company()
        {
            base.resourceType = this.resourceType;
        }

        public Company(string resourceType = "Company", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Company> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Company");
            RestGateway gateway = (RestGateway)Company.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Company> companyCollection = new ModelCollection<Company>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                companyCollection.add((Company)model);
            }

            return companyCollection;
        }

        public static Company retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Company.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Company)gateway.retrieve(ResourceType.COMPANY, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getRegistrationNumber()
        {
            return this.getProperty("registrationNumber").ToString();
        }

        public void setRegistrationNumber(string registrationNumber)
        {
            this.setProperty("registrationNumber", registrationNumber);
        }

        public string getVatIdentificationNumber()
        {
            return this.getProperty("vatIdentificationNumber").ToString();
        }

        public void setVatIdentificationNumber(string vatIdentificationNumber)
        {
            this.setProperty("vatIdentificationNumber", vatIdentificationNumber);
        }


    }
}

