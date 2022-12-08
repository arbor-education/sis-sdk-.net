using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Employer : ModelBase
    {
        protected string resourceType = ResourceType.EMPLOYER;
        public const string NAME = "name";
        public const string IDENTIFIER = "identifier";

        public Employer()
        {
            base.resourceType = this.resourceType;
        }

        public Employer(string resourceType = "Employer", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Employer> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Employer");
            RestGateway gateway = (RestGateway)Employer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Employer> employerCollection = new ModelCollection<Employer>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                employerCollection.add((Employer)model);
            }

            return employerCollection;
        }

        public static Employer retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Employer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Employer)gateway.retrieve(ResourceType.EMPLOYER, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getIdentifier()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier(string identifier)
        {
            this.setProperty("identifier", identifier);
        }


    }
}

