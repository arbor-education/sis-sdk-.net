using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonNationality : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_NATIONALITY;
        public const string PERSON = "person";
        public const string COUNTRY = "country";
        public const string NATIONALITY_STATUS = "nationalityStatus";

        public PersonNationality()
        {
            base.resourceType = this.resourceType;
        }

        public PersonNationality(string resourceType = "PersonNationality", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PersonNationality> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PersonNationality");
            RestGateway gateway = (RestGateway)PersonNationality.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PersonNationality> personnationalityCollection = new ModelCollection<PersonNationality>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                personnationalityCollection.add((PersonNationality)model);
            }

            return personnationalityCollection;
        }

        public static PersonNationality retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PersonNationality.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PersonNationality)gateway.retrieve(ResourceType.PERSON_NATIONALITY, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public Country getCountry()
        {
            return (Country)this.getProperty("country");
        }

        public void setCountry(Country country)
        {
            this.setProperty("country", country);
        }

        public NationalityStatus getNationalityStatus()
        {
            return (NationalityStatus)this.getProperty("nationalityStatus");
        }

        public void setNationalityStatus(NationalityStatus nationalityStatus)
        {
            this.setProperty("nationalityStatus", nationalityStatus);
        }


    }
}

