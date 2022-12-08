using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonTransportationMethod : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_TRANSPORTATION_METHOD;
        public const string PERSON = "person";
        public const string TRANSPORTATION_METHOD = "transportationMethod";
        public const string NOTES = "notes";

        public PersonTransportationMethod()
        {
            base.resourceType = this.resourceType;
        }

        public PersonTransportationMethod(string resourceType = "PersonTransportationMethod", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PersonTransportationMethod> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PersonTransportationMethod");
            RestGateway gateway = (RestGateway)PersonTransportationMethod.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PersonTransportationMethod> persontransportationmethodCollection = new ModelCollection<PersonTransportationMethod>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                persontransportationmethodCollection.add((PersonTransportationMethod)model);
            }

            return persontransportationmethodCollection;
        }

        public static PersonTransportationMethod retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PersonTransportationMethod.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PersonTransportationMethod)gateway.retrieve(ResourceType.PERSON_TRANSPORTATION_METHOD, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public TransportationMethod getTransportationMethod()
        {
            return (TransportationMethod)this.getProperty("transportationMethod");
        }

        public void setTransportationMethod(TransportationMethod transportationMethod)
        {
            this.setProperty("transportationMethod", transportationMethod);
        }

        public string getNotes()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes(string notes)
        {
            this.setProperty("notes", notes);
        }


    }
}

