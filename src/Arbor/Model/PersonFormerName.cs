using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonFormerName : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_FORMER_NAME;
        public const string PERSON = "person";
        public const string FROM_DATE = "fromDate";
        public const string END_DATE = "endDate";
        public const string LEGAL_FIRST_NAME = "legalFirstName";
        public const string LEGAL_MIDDLE_NAMES = "legalMiddleNames";
        public const string LEGAL_LAST_NAME = "legalLastName";

        public PersonFormerName ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PersonFormerName (string resourceType = "PersonFormerName", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PersonFormerName> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PersonFormerName");
        	RestGateway gateway = (RestGateway) PersonFormerName.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PersonFormerName> personformernameCollection = new ModelCollection<PersonFormerName> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    personformernameCollection.add((PersonFormerName) model);
        	}
        
        	return personformernameCollection;
        }

        public static PersonFormerName retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PersonFormerName.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PersonFormerName) gateway.retrieve(ResourceType.PERSON_FORMER_NAME, id);
        }

        public Person getPerson ()
        {
            return (Person) this.getProperty("person");
        }

        public void setPerson (Person person)
        {
            this.setProperty("person", person);
        }

        public DateTime getFromDate ()
        {
            return (DateTime) this.getProperty("fromDate");
        }

        public void setFromDate (DateTime fromDate)
        {
            this.setProperty("fromDate", fromDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
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


    }
}

