using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class School : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOL;
        public const string LOCAL_AUTHORITY = "localAuthority";
        public const string ESTABLISHMENT_NUMBER = "establishmentNumber";
        public const string SCHOOL_PHASE = "schoolPhase";
        public const string SCHOOL_TYPE = "schoolType";
        public const string SCHOOL_GENDER = "schoolGender";
        public const string GOVERNANCE_TYPE = "governanceType";
        public const string INTAKE_TYPE = "intakeType";
        public const string URN = "urn";
        public const string HAS_CHILD_MOTHER_PROVISION = "hasChildMotherProvision";
        public const string HAS_CHILDCARE_PLACES = "hasChildcarePlaces";
        public const string SCHOOL_NAME = "schoolName";
        public const string SHORT_NAME = "shortName";
        public const string OPENING_DATE = "openingDate";
        public const string CLOSING_DATE = "closingDate";

        public School ()
        {
            base.resourceType = this.resourceType;
        }
        
        public School (string resourceType = "School", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<School> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("School");
        	RestGateway gateway = (RestGateway) School.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<School> schoolCollection = new ModelCollection<School> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolCollection.add((School) model);
        	}
        
        	return schoolCollection;
        }

        public static School retrieve (string id)
        {
            RestGateway gateway = (RestGateway) School.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (School) gateway.retrieve(ResourceType.SCHOOL, id);
        }

        public ModelBase getLocalAuthority ()
        {
            return (ModelBase) this.getProperty("localAuthority");
        }

        public void setLocalAuthority (ModelBase localAuthority)
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

        public ModelBase getSchoolPhase ()
        {
            return (ModelBase) this.getProperty("schoolPhase");
        }

        public void setSchoolPhase (ModelBase schoolPhase)
        {
            this.setProperty("schoolPhase", schoolPhase);
        }

        public ModelBase getSchoolType ()
        {
            return (ModelBase) this.getProperty("schoolType");
        }

        public void setSchoolType (ModelBase schoolType)
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

        public ModelBase getGovernanceType ()
        {
            return (ModelBase) this.getProperty("governanceType");
        }

        public void setGovernanceType (ModelBase governanceType)
        {
            this.setProperty("governanceType", governanceType);
        }

        public ModelBase getIntakeType ()
        {
            return (ModelBase) this.getProperty("intakeType");
        }

        public void setIntakeType (ModelBase intakeType)
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
            return (bool) this.getProperty("hasChildMotherProvision");
        }

        public void setHasChildMotherProvision (bool hasChildMotherProvision)
        {
            this.setProperty("hasChildMotherProvision", hasChildMotherProvision);
        }

        public bool getHasChildcarePlaces ()
        {
            return (bool) this.getProperty("hasChildcarePlaces");
        }

        public void setHasChildcarePlaces (bool hasChildcarePlaces)
        {
            this.setProperty("hasChildcarePlaces", hasChildcarePlaces);
        }

        public string getSchoolName ()
        {
            return this.getProperty("schoolName").ToString();
        }

        public void setSchoolName (string schoolName)
        {
            this.setProperty("schoolName", schoolName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public DateTime getOpeningDate ()
        {
            return (DateTime) this.getProperty("openingDate");
        }

        public void setOpeningDate (DateTime openingDate)
        {
            this.setProperty("openingDate", openingDate);
        }

        public DateTime getClosingDate ()
        {
            return (DateTime) this.getProperty("closingDate");
        }

        public void setClosingDate (DateTime closingDate)
        {
            this.setProperty("closingDate", closingDate);
        }


    }
}

