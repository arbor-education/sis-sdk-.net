using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalInstitution : ModelBase
    {
        protected string resourceType = ResourceType.MEDICAL_INSTITUTION;
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";

        public MedicalInstitution()
        {
            base.resourceType = this.resourceType;
        }

        public MedicalInstitution(string resourceType = "MedicalInstitution", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MedicalInstitution> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MedicalInstitution");
            RestGateway gateway = (RestGateway)MedicalInstitution.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MedicalInstitution> medicalinstitutionCollection = new ModelCollection<MedicalInstitution>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                medicalinstitutionCollection.add((MedicalInstitution)model);
            }

            return medicalinstitutionCollection;
        }

        public static MedicalInstitution retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MedicalInstitution.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MedicalInstitution)gateway.retrieve(ResourceType.MEDICAL_INSTITUTION, id);
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

