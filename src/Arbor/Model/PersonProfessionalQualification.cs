using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonProfessionalQualification : ModelBase
    {
        protected new string resourceType = ResourceType.PERSON_PROFESSIONAL_QUALIFICATION;
        public const string PERSON = "person";
        public const string QUALIFICATION_NAME = "qualificationName";
        public const string DATE_AWARDED = "dateAwarded";
        public const string AWARDING_INSTITUTION = "awardingInstitution";
        public const string PROFESSIONAL_QUALIFICATION_TYPE = "professionalQualificationType";
        public const string PROFESSIONAL_QUALIFICATION_CLASS = "professionalQualificationClass";
        public const string FIRST_SUBJECT = "firstSubject";
        public const string SECOND_SUBJECT = "secondSubject";
        public const string ORIGIN_COUNTRY = "originCountry";
        public const string IS_VOCATIONAL_QUALIFICATION = "isVocationalQualification";
        public const string IS_VERIFIED = "isVerified";

        public PersonProfessionalQualification ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PersonProfessionalQualification (string resourceType = "PersonProfessionalQualification", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PersonProfessionalQualification> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PersonProfessionalQualification");
        	RestGateway gateway = (RestGateway) PersonProfessionalQualification.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PersonProfessionalQualification> personprofessionalqualificationCollection = new ModelCollection<PersonProfessionalQualification> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    personprofessionalqualificationCollection.add((PersonProfessionalQualification) model);
        	}
        
        	return personprofessionalqualificationCollection;
        }

        public static PersonProfessionalQualification retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PersonProfessionalQualification.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PersonProfessionalQualification) gateway.retrieve(ResourceType.PERSON_PROFESSIONAL_QUALIFICATION, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public string getQualificationName ()
        {
            return this.getProperty("qualificationName").ToString();
        }

        public void setQualificationName (string qualificationName)
        {
            this.setProperty("qualificationName", qualificationName);
        }

        public DateTime getDateAwarded ()
        {
            return Convert.ToDateTime(this.getProperty("dateAwarded"));
        }

        public void setDateAwarded (DateTime dateAwarded)
        {
            this.setProperty("dateAwarded", dateAwarded);
        }

        public string getAwardingInstitution ()
        {
            return this.getProperty("awardingInstitution").ToString();
        }

        public void setAwardingInstitution (string awardingInstitution)
        {
            this.setProperty("awardingInstitution", awardingInstitution);
        }

        public ProfessionalQualificationType getProfessionalQualificationType ()
        {
            return (ProfessionalQualificationType) this.getProperty("professionalQualificationType");
        }

        public void setProfessionalQualificationType (ProfessionalQualificationType professionalQualificationType)
        {
            this.setProperty("professionalQualificationType", professionalQualificationType);
        }

        public ProfessionalQualificationClass getProfessionalQualificationClass ()
        {
            return (ProfessionalQualificationClass) this.getProperty("professionalQualificationClass");
        }

        public void setProfessionalQualificationClass (ProfessionalQualificationClass professionalQualificationClass)
        {
            this.setProperty("professionalQualificationClass", professionalQualificationClass);
        }

        public ProfessionalQualificationSubject getFirstSubject ()
        {
            return (ProfessionalQualificationSubject) this.getProperty("firstSubject");
        }

        public void setFirstSubject (ProfessionalQualificationSubject firstSubject)
        {
            this.setProperty("firstSubject", firstSubject);
        }

        public ProfessionalQualificationSubject getSecondSubject ()
        {
            return (ProfessionalQualificationSubject) this.getProperty("secondSubject");
        }

        public void setSecondSubject (ProfessionalQualificationSubject secondSubject)
        {
            this.setProperty("secondSubject", secondSubject);
        }

        public Country getOriginCountry ()
        {
            return (Country) this.getProperty("originCountry");
        }

        public void setOriginCountry (Country originCountry)
        {
            this.setProperty("originCountry", originCountry);
        }

        public bool getIsVocationalQualification ()
        {
            return Convert.ToBoolean(this.getProperty("isVocationalQualification"));
        }

        public void setIsVocationalQualification (bool isVocationalQualification)
        {
            this.setProperty("isVocationalQualification", isVocationalQualification);
        }

        public bool getIsVerified ()
        {
            return Convert.ToBoolean(this.getProperty("isVerified"));
        }

        public void setIsVerified (bool isVerified)
        {
            this.setProperty("isVerified", isVerified);
        }


    }
}

