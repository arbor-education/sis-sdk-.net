using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonIdentificationDocument : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_IDENTIFICATION_DOCUMENT;
        public const string PERSON = "person";
        public const string DOCUMENT_TYPE = "documentType";
        public const string DOCUMENT_NUMBER = "documentNumber";
        public const string ISSUE_DATE = "issueDate";
        public const string EXPIRY_DATE = "expiryDate";
        public const string NAME_ON_DOCUMENT = "nameOnDocument";
        public const string ISSUING_COUNTRY = "issuingCountry";
        public const string FILE = "file";

        public PersonIdentificationDocument ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PersonIdentificationDocument (string resourceType = "PersonIdentificationDocument", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PersonIdentificationDocument> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PersonIdentificationDocument");
        	RestGateway gateway = (RestGateway) PersonIdentificationDocument.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PersonIdentificationDocument> personidentificationdocumentCollection = new ModelCollection<PersonIdentificationDocument> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    personidentificationdocumentCollection.add((PersonIdentificationDocument) model);
        	}
        
        	return personidentificationdocumentCollection;
        }

        public static PersonIdentificationDocument retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PersonIdentificationDocument.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PersonIdentificationDocument) gateway.retrieve(ResourceType.PERSON_IDENTIFICATION_DOCUMENT, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public IdentificationDocumentType getDocumentType ()
        {
            return (IdentificationDocumentType) this.getProperty("documentType");
        }

        public void setDocumentType (IdentificationDocumentType documentType)
        {
            this.setProperty("documentType", documentType);
        }

        public string getDocumentNumber ()
        {
            return this.getProperty("documentNumber").ToString();
        }

        public void setDocumentNumber (string documentNumber)
        {
            this.setProperty("documentNumber", documentNumber);
        }

        public DateTime getIssueDate ()
        {
            return (DateTime) this.getProperty("issueDate");
        }

        public void setIssueDate (DateTime issueDate)
        {
            this.setProperty("issueDate", issueDate);
        }

        public DateTime getExpiryDate ()
        {
            return (DateTime) this.getProperty("expiryDate");
        }

        public void setExpiryDate (DateTime expiryDate)
        {
            this.setProperty("expiryDate", expiryDate);
        }

        public string getNameOnDocument ()
        {
            return this.getProperty("nameOnDocument").ToString();
        }

        public void setNameOnDocument (string nameOnDocument)
        {
            this.setProperty("nameOnDocument", nameOnDocument);
        }

        public Country getIssuingCountry ()
        {
            return (Country) this.getProperty("issuingCountry");
        }

        public void setIssuingCountry (Country issuingCountry)
        {
            this.setProperty("issuingCountry", issuingCountry);
        }

        public int getFile ()
        {
            return Convert.ToInt32(this.getProperty("file"));
        }

        public void setFile (int file)
        {
            this.setProperty("file", file);
        }


    }
}

