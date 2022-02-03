using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Programme : ModelBase
    {
        protected string resourceType = ResourceType.PROGRAMME;
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string IDENTIFIER = "identifier";
        public const string FACULTY = "faculty";

        public Programme ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Programme (string resourceType = "Programme", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Programme> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Programme");
        	RestGateway gateway = (RestGateway) Programme.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Programme> programmeCollection = new ModelCollection<Programme> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    programmeCollection.add((Programme) model);
        	}
        
        	return programmeCollection;
        }

        public static Programme retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Programme.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Programme) gateway.retrieve(ResourceType.PROGRAMME, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getIdentifier ()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier (string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public Faculty getFaculty ()
        {
            return (Faculty) this.getProperty("faculty");
        }

        public void setFaculty (Faculty faculty)
        {
            this.setProperty("faculty", faculty);
        }


    }
}

