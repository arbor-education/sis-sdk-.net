using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalInstitutionStaff : ModelBase
    {
        protected string resourceType = ResourceType.MEDICAL_INSTITUTION_STAFF;
        public const string MEDICAL_INSTITUTION = "medicalInstitution";
        public const string PERSON = "person";
        public const string POSITION = "position";

        public MedicalInstitutionStaff()
        {
            base.resourceType = this.resourceType;
        }

        public MedicalInstitutionStaff(string resourceType = "MedicalInstitutionStaff", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MedicalInstitutionStaff> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MedicalInstitutionStaff");
            RestGateway gateway = (RestGateway)MedicalInstitutionStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MedicalInstitutionStaff> medicalinstitutionstaffCollection = new ModelCollection<MedicalInstitutionStaff>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                medicalinstitutionstaffCollection.add((MedicalInstitutionStaff)model);
            }

            return medicalinstitutionstaffCollection;
        }

        public static MedicalInstitutionStaff retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MedicalInstitutionStaff.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MedicalInstitutionStaff)gateway.retrieve(ResourceType.MEDICAL_INSTITUTION_STAFF, id);
        }

        public MedicalInstitution getMedicalInstitution()
        {
            return (MedicalInstitution)this.getProperty("medicalInstitution");
        }

        public void setMedicalInstitution(MedicalInstitution medicalInstitution)
        {
            this.setProperty("medicalInstitution", medicalInstitution);
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

