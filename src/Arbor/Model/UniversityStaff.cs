using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UniversityStaff : ModelBase
    {
        protected new string resourceType = ResourceType.UNIVERSITY_STAFF;
        public const string UNIVERSITY = "university";
        public const string PERSON = "person";
        public const string POSITION = "position";

        public UniversityStaff()
        {
            base.resourceType = this.resourceType;
        }

        public UniversityStaff(string resourceType = "UniversityStaff", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UniversityStaff> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UniversityStaff");
            RestGateway gateway = (RestGateway)UniversityStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UniversityStaff> universitystaffCollection = new ModelCollection<UniversityStaff>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                universitystaffCollection.add((UniversityStaff)model);
            }

            return universitystaffCollection;
        }

        public static UniversityStaff retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UniversityStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UniversityStaff)gateway.retrieve(ResourceType.UNIVERSITY_STAFF, id);
        }

        public University getUniversity()
        {
            return (University)this.getProperty("university");
        }

        public void setUniversity(University university)
        {
            this.setProperty("university", university);
        }

        public Person getPerson()
        {
            return (Person)this.getProperty("person");
        }

        public void setPerson(Person person)
        {
            this.setProperty("person", person);
        }

        public string getPosition()
        {
            return this.getProperty("position").ToString();
        }

        public void setPosition(string position)
        {
            this.setProperty("position", position);
        }


    }
}

