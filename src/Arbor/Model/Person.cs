using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Person : ModelBase
    {
        protected string resourceType = ResourceType.PERSON;
        public const string GENDER = "gender";
        public const string TITLE = "title";
        public const string MARITAL_STATUS = "maritalStatus";
        public const string LEGAL_FIRST_NAME = "legalFirstName";
        public const string LEGAL_MIDDLE_NAMES = "legalMiddleNames";
        public const string LEGAL_LAST_NAME = "legalLastName";
        public const string PREFERRED_FIRST_NAME = "preferredFirstName";
        public const string PREFERRED_LAST_NAME = "preferredLastName";
        public const string DATE_OF_BIRTH = "dateOfBirth";
        public const string COUNTRY_OF_BIRTH = "countryOfBirth";
        public const string DECEASED = "deceased";
        public const string DATE_OF_DEATH = "dateOfDeath";

        public Person ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Person (string resourceType = "Person", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Person> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Person");
        	RestGateway gateway = (RestGateway) Person.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Person> personCollection = new ModelCollection<Person> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    personCollection.add((Person) model);
        	}
        
        	return personCollection;
        }

        public static Person retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Person.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Person) gateway.retrieve(ResourceType.PERSON, id);
        }

        public Gender getGender ()
        {
            return (Gender) this.getProperty("gender");
        }

        public void setGender (Gender gender)
        {
            this.setProperty("gender", gender);
        }

        public Title getTitle ()
        {
            return (Title) this.getProperty("title");
        }

        public void setTitle (Title title)
        {
            this.setProperty("title", title);
        }

        public MaritalStatus getMaritalStatus ()
        {
            return (MaritalStatus) this.getProperty("maritalStatus");
        }

        public void setMaritalStatus (MaritalStatus maritalStatus)
        {
            this.setProperty("maritalStatus", maritalStatus);
        }

        public string getLegalFirstName ()
        {
            return this.getProperty("legalFirstName").ToString();
        }

        public void setLegalFirstName (string legalFirstName)
        {
            this.setProperty("legalFirstName", legalFirstName);
        }

        public string getLegalMiddleNames ()
        {
            return this.getProperty("legalMiddleNames").ToString();
        }

        public void setLegalMiddleNames (string legalMiddleNames)
        {
            this.setProperty("legalMiddleNames", legalMiddleNames);
        }

        public string getLegalLastName ()
        {
            return this.getProperty("legalLastName").ToString();
        }

        public void setLegalLastName (string legalLastName)
        {
            this.setProperty("legalLastName", legalLastName);
        }

        public string getPreferredFirstName ()
        {
            return this.getProperty("preferredFirstName").ToString();
        }

        public void setPreferredFirstName (string preferredFirstName)
        {
            this.setProperty("preferredFirstName", preferredFirstName);
        }

        public string getPreferredLastName ()
        {
            return this.getProperty("preferredLastName").ToString();
        }

        public void setPreferredLastName (string preferredLastName)
        {
            this.setProperty("preferredLastName", preferredLastName);
        }

        public DateTime getDateOfBirth ()
        {
            //return (DateTime) this.getProperty("dateOfBirth");
            return Convert.ToDateTime(this.getProperty("dateOfBirth"));

        }

        public void setDateOfBirth (DateTime dateOfBirth)
        {
            this.setProperty("dateOfBirth", dateOfBirth);
        }

        public Country getCountryOfBirth ()
        {
            return (Country) this.getProperty("countryOfBirth");
        }

        public void setCountryOfBirth (Country countryOfBirth)
        {
            this.setProperty("countryOfBirth", countryOfBirth);
        }

        public bool getDeceased ()
        {
            return (bool) this.getProperty("deceased");
        }

        public void setDeceased (bool deceased)
        {
            this.setProperty("deceased", deceased);
        }

        public DateTime getDateOfDeath ()
        {
            return (DateTime) this.getProperty("dateOfDeath");
        }

        public void setDateOfDeath (DateTime dateOfDeath)
        {
            this.setProperty("dateOfDeath", dateOfDeath);
        }


    }
}

