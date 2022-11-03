using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_EducationalInstitution : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_EDUCATIONAL_INSTITUTION;
        public const string LOCAL_AUTHORITY = "localAuthority";
        public const string ESTABLISHMENT_NUMBER = "establishmentNumber";
        public const string CENSUS_SCHOOL_PHASE = "censusSchoolPhase";
        public const string SCHOOL_TYPE = "schoolType";
        public const string SCHOOL_GENDER = "schoolGender";
        public const string GOVERNANCE_TYPE = "governanceType";
        public const string INTAKE_TYPE = "intakeType";
        public const string URN = "urn";
        public const string HAS_CHILD_MOTHER_PROVISION = "hasChildMotherProvision";
        public const string HAS_CHILDCARE_PLACES = "hasChildcarePlaces";
        public const string CENTER_NUMBER = "centerNumber";
        public const string SPECIAL_SCHOOL_ACCOMMODATION = "specialSchoolAccommodation";
        public const string SPECIAL_SCHOOL_MAX_DAY_PUPILS = "specialSchoolMaxDayPupils";
        public const string SPECIAL_SCHOOL_MAX_BOARDERS = "specialSchoolMaxBoarders";
        public const string SPECIAL_SCHOOL_MIN_MALE_AGE = "specialSchoolMinMaleAge";
        public const string SPECIAL_SCHOOL_MAX_MALE_AGE = "specialSchoolMaxMaleAge";
        public const string SPECIAL_SCHOOL_MIN_FEMALE_AGE = "specialSchoolMinFemaleAge";
        public const string SPECIAL_SCHOOL_MAX_FEMALE_AGE = "specialSchoolMaxFemaleAge";
        public const string SPECIAL_SCHOOL_SEN_PROVISIONS = "specialSchoolSenProvisions";
        public const string CENSUS_SCHOOL_OPENING_DATE = "censusSchoolOpeningDate";

        public UkDfe_EducationalInstitution ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_EducationalInstitution (string resourceType = "UkDfe_EducationalInstitution", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_EducationalInstitution> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_EducationalInstitution");
        	RestGateway gateway = (RestGateway) UkDfe_EducationalInstitution.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_EducationalInstitution> ukdfe_educationalinstitutionCollection = new ModelCollection<UkDfe_EducationalInstitution> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_educationalinstitutionCollection.add((UkDfe_EducationalInstitution) model);
        	}
        
        	return ukdfe_educationalinstitutionCollection;
        }

        public static UkDfe_EducationalInstitution retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_EducationalInstitution.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_EducationalInstitution) gateway.retrieve(ResourceType.UK_DFE_EDUCATIONAL_INSTITUTION, id);
        }

        public LocalAuthority getLocalAuthority ()
        {
            return (LocalAuthority) this.getProperty("localAuthority");
        }

        public void setLocalAuthority (LocalAuthority localAuthority)
        {
            this.setProperty("localAuthority", localAuthority);
        }

        public string getEstablishmentNumber ()
        {
            return this.getProperty("establishmentNumber").ToString();
        }

        public void setEstablishmentNumber (string establishmentNumber)
        {
            this.setProperty("establishmentNumber", establishmentNumber);
        }

        public CensusSchoolPhase getCensusSchoolPhase ()
        {
            return (CensusSchoolPhase) this.getProperty("censusSchoolPhase");
        }

        public void setCensusSchoolPhase (CensusSchoolPhase censusSchoolPhase)
        {
            this.setProperty("censusSchoolPhase", censusSchoolPhase);
        }

        public SchoolType getSchoolType ()
        {
            return (SchoolType) this.getProperty("schoolType");
        }

        public void setSchoolType (SchoolType schoolType)
        {
            this.setProperty("schoolType", schoolType);
        }

        public string getSchoolGender ()
        {
            return this.getProperty("schoolGender").ToString();
        }

        public void setSchoolGender (string schoolGender)
        {
            this.setProperty("schoolGender", schoolGender);
        }

        public SchoolGovernanceType getGovernanceType ()
        {
            return (SchoolGovernanceType) this.getProperty("governanceType");
        }

        public void setGovernanceType (SchoolGovernanceType governanceType)
        {
            this.setProperty("governanceType", governanceType);
        }

        public SchoolIntakeType getIntakeType ()
        {
            return (SchoolIntakeType) this.getProperty("intakeType");
        }

        public void setIntakeType (SchoolIntakeType intakeType)
        {
            this.setProperty("intakeType", intakeType);
        }

        public string getUrn ()
        {
            return this.getProperty("urn").ToString();
        }

        public void setUrn (string urn)
        {
            this.setProperty("urn", urn);
        }

        public bool getHasChildMotherProvision ()
        {
            return Convert.ToBoolean(this.getProperty("hasChildMotherProvision"));
        }

        public void setHasChildMotherProvision (bool hasChildMotherProvision)
        {
            this.setProperty("hasChildMotherProvision", hasChildMotherProvision);
        }

        public bool getHasChildcarePlaces ()
        {
            return Convert.ToBoolean(this.getProperty("hasChildcarePlaces"));
        }

        public void setHasChildcarePlaces (bool hasChildcarePlaces)
        {
            this.setProperty("hasChildcarePlaces", hasChildcarePlaces);
        }

        public string getCenterNumber ()
        {
            return this.getProperty("centerNumber").ToString();
        }

        public void setCenterNumber (string centerNumber)
        {
            this.setProperty("centerNumber", centerNumber);
        }

        public string getSpecialSchoolAccommodation ()
        {
            return this.getProperty("specialSchoolAccommodation").ToString();
        }

        public void setSpecialSchoolAccommodation (string specialSchoolAccommodation)
        {
            this.setProperty("specialSchoolAccommodation", specialSchoolAccommodation);
        }

        public int getSpecialSchoolMaxDayPupils ()
        {
            return Convert.ToInt32(this.getProperty("specialSchoolMaxDayPupils"));
        }

        public void setSpecialSchoolMaxDayPupils (int specialSchoolMaxDayPupils)
        {
            this.setProperty("specialSchoolMaxDayPupils", specialSchoolMaxDayPupils);
        }

        public int getSpecialSchoolMaxBoarders ()
        {
            return Convert.ToInt32(this.getProperty("specialSchoolMaxBoarders"));
        }

        public void setSpecialSchoolMaxBoarders (int specialSchoolMaxBoarders)
        {
            this.setProperty("specialSchoolMaxBoarders", specialSchoolMaxBoarders);
        }

        public int getSpecialSchoolMinMaleAge ()
        {
            return Convert.ToInt32(this.getProperty("specialSchoolMinMaleAge"));
        }

        public void setSpecialSchoolMinMaleAge (int specialSchoolMinMaleAge)
        {
            this.setProperty("specialSchoolMinMaleAge", specialSchoolMinMaleAge);
        }

        public int getSpecialSchoolMaxMaleAge ()
        {
            return Convert.ToInt32(this.getProperty("specialSchoolMaxMaleAge"));
        }

        public void setSpecialSchoolMaxMaleAge (int specialSchoolMaxMaleAge)
        {
            this.setProperty("specialSchoolMaxMaleAge", specialSchoolMaxMaleAge);
        }

        public int getSpecialSchoolMinFemaleAge ()
        {
            return Convert.ToInt32(this.getProperty("specialSchoolMinFemaleAge"));
        }

        public void setSpecialSchoolMinFemaleAge (int specialSchoolMinFemaleAge)
        {
            this.setProperty("specialSchoolMinFemaleAge", specialSchoolMinFemaleAge);
        }

        public int getSpecialSchoolMaxFemaleAge ()
        {
            return Convert.ToInt32(this.getProperty("specialSchoolMaxFemaleAge"));
        }

        public void setSpecialSchoolMaxFemaleAge (int specialSchoolMaxFemaleAge)
        {
            this.setProperty("specialSchoolMaxFemaleAge", specialSchoolMaxFemaleAge);
        }

        public string getSpecialSchoolSenProvisions ()
        {
            return this.getProperty("specialSchoolSenProvisions").ToString();
        }

        public void setSpecialSchoolSenProvisions (string specialSchoolSenProvisions)
        {
            this.setProperty("specialSchoolSenProvisions", specialSchoolSenProvisions);
        }

        public DateTime getCensusSchoolOpeningDate ()
        {
            return Convert.ToDateTime(this.getProperty("censusSchoolOpeningDate"));
        }

        public void setCensusSchoolOpeningDate (DateTime censusSchoolOpeningDate)
        {
            this.setProperty("censusSchoolOpeningDate", censusSchoolOpeningDate);
        }


    }
}
