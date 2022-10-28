using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EducationalInstitutionStaff : ModelBase
    {
        protected new string resourceType = ResourceType.EDUCATIONAL_INSTITUTION_STAFF;
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string PERSON = "person";
        public const string POSITION = "position";

        public EducationalInstitutionStaff()
        {
            base.resourceType = this.resourceType;
        }

        public EducationalInstitutionStaff(string resourceType = "EducationalInstitutionStaff", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EducationalInstitutionStaff> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EducationalInstitutionStaff");
            RestGateway gateway = (RestGateway)EducationalInstitutionStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EducationalInstitutionStaff> educationalinstitutionstaffCollection = new ModelCollection<EducationalInstitutionStaff>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                educationalinstitutionstaffCollection.add((EducationalInstitutionStaff)model);
            }

            return educationalinstitutionstaffCollection;
        }

        public static EducationalInstitutionStaff retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EducationalInstitutionStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EducationalInstitutionStaff)gateway.retrieve(ResourceType.EDUCATIONAL_INSTITUTION_STAFF, id);
        }

        public EducationalInstitution getEducationalInstitution()
        {
            return (EducationalInstitution)this.getProperty("educationalInstitution");
        }

        public void setEducationalInstitution(EducationalInstitution educationalInstitution)
        {
            this.setProperty("educationalInstitution", educationalInstitution);
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

