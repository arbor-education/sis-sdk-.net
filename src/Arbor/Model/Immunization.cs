using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Immunization : ModelBase
    {
        protected string resourceType = ResourceType.IMMUNIZATION;
        public const string PERSON = "person";
        public const string IMMUNIZATION_TYPE = "immunizationType";
        public const string IMMUNIZATION_DATE = "immunizationDate";
        public const string ADMINISTERED_BY_MEDICAL_INSTITUTION = "administeredByMedicalInstitution";

        public Immunization ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Immunization (string resourceType = "Immunization", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Immunization> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Immunization");
        	RestGateway gateway = (RestGateway) Immunization.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Immunization> immunizationCollection = new ModelCollection<Immunization> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    immunizationCollection.add((Immunization) model);
        	}
        
        	return immunizationCollection;
        }

        public static Immunization retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Immunization.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Immunization) gateway.retrieve(ResourceType.IMMUNIZATION, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public ImmunizationType getImmunizationType ()
        {
            return (ImmunizationType) this.getProperty("immunizationType");
        }

        public void setImmunizationType (ImmunizationType immunizationType)
        {
            this.setProperty("immunizationType", immunizationType);
        }

        public DateTime getImmunizationDate ()
        {
            return Convert.ToDateTime(this.getProperty("immunizationDate"))
        }

        public void setImmunizationDate (DateTime immunizationDate)
        {
            this.setProperty("immunizationDate", immunizationDate);
        }

        public MedicalInstitution getAdministeredByMedicalInstitution ()
        {
            return (MedicalInstitution) this.getProperty("administeredByMedicalInstitution");
        }

        public void setAdministeredByMedicalInstitution (MedicalInstitution administeredByMedicalInstitution)
        {
            this.setProperty("administeredByMedicalInstitution", administeredByMedicalInstitution);
        }


    }
}

