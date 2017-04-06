using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolworkDefinition : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOLWORK_DEFINITION;
        public const string SCHOOLWORK_DEFINITION_NAME = "schoolworkDefinitionName";
        public const string CODE = "code";
        public const string SCHOOLWORK_TYPE = "schoolworkType";

        public SchoolworkDefinition ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolworkDefinition (string resourceType = "SchoolworkDefinition", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolworkDefinition> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolworkDefinition");
        	RestGateway gateway = (RestGateway) SchoolworkDefinition.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolworkDefinition> schoolworkdefinitionCollection = new ModelCollection<SchoolworkDefinition> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkdefinitionCollection.add((SchoolworkDefinition) model);
        	}
        
        	return schoolworkdefinitionCollection;
        }

        public static SchoolworkDefinition retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolworkDefinition.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolworkDefinition) gateway.retrieve(ResourceType.SCHOOLWORK_DEFINITION, id);
        }

        public string getSchoolworkDefinitionName ()
        {
            return this.getProperty("schoolworkDefinitionName").ToString();
        }

        public void setSchoolworkDefinitionName (string schoolworkDefinitionName)
        {
            this.setProperty("schoolworkDefinitionName", schoolworkDefinitionName);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public SchoolworkType getSchoolworkType ()
        {
            return (SchoolworkType) this.getProperty("schoolworkType");
        }

        public void setSchoolworkType (SchoolworkType schoolworkType)
        {
            this.setProperty("schoolworkType", schoolworkType);
        }


    }
}

