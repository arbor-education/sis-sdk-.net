using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ExternalAdministrator : ModelBase
    {
        protected new string resourceType = ResourceType.EXTERNAL_ADMINISTRATOR;
        public const string FIRST_NAME = "firstName";
        public const string LAST_NAME = "lastName";
        public const string EMAIL = "email";
        public const string APPLICATION = "application";

        public ExternalAdministrator ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ExternalAdministrator (string resourceType = "ExternalAdministrator", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ExternalAdministrator> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ExternalAdministrator");
        	RestGateway gateway = (RestGateway) ExternalAdministrator.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ExternalAdministrator> externaladministratorCollection = new ModelCollection<ExternalAdministrator> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    externaladministratorCollection.add((ExternalAdministrator) model);
        	}
        
        	return externaladministratorCollection;
        }

        public static ExternalAdministrator retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ExternalAdministrator.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ExternalAdministrator) gateway.retrieve(ResourceType.EXTERNAL_ADMINISTRATOR, id);
        }

        public string getFirstName ()
        {
            return this.getProperty("firstName").ToString();
        }

        public void setFirstName (string firstName)
        {
            this.setProperty("firstName", firstName);
        }

        public string getLastName ()
        {
            return this.getProperty("lastName").ToString();
        }

        public void setLastName (string lastName)
        {
            this.setProperty("lastName", lastName);
        }

        public string getEmail ()
        {
            return this.getProperty("email").ToString();
        }

        public void setEmail (string email)
        {
            this.setProperty("email", email);
        }

        public string getApplication ()
        {
            return this.getProperty("application").ToString();
        }

        public void setApplication (string application)
        {
            this.setProperty("application", application);
        }


    }
}

