using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class University : ModelBase
    {
        protected string resourceType = ResourceType.UNIVERSITY;
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";

        public University()
        {
            base.resourceType = this.resourceType;
        }

        public University(string resourceType = "University", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<University> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("University");
            RestGateway gateway = (RestGateway)University.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<University> universityCollection = new ModelCollection<University>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                universityCollection.add((University)model);
            }

            return universityCollection;
        }

        public static University retrieve(string id)
        {
            RestGateway gateway = (RestGateway)University.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (University)gateway.retrieve(ResourceType.UNIVERSITY, id);
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


    }
}

