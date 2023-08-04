using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserDefinedFieldOption : ModelBase
    {
        protected new string resourceType = ResourceType.USER_DEFINED_FIELD_OPTION;
        public const string USER_DEFINED_FIELD = "userDefinedField";
        public const string NAME = "name";
        public const string CODE = "code";
        public const string ACTIVE = "active";

        public UserDefinedFieldOption ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UserDefinedFieldOption (string resourceType = "UserDefinedFieldOption", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UserDefinedFieldOption> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UserDefinedFieldOption");
        	RestGateway gateway = (RestGateway) UserDefinedFieldOption.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UserDefinedFieldOption> userdefinedfieldoptionCollection = new ModelCollection<UserDefinedFieldOption> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    userdefinedfieldoptionCollection.add((UserDefinedFieldOption) model);
        	}
        
        	return userdefinedfieldoptionCollection;
        }

        public static UserDefinedFieldOption retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UserDefinedFieldOption.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UserDefinedFieldOption) gateway.retrieve(ResourceType.USER_DEFINED_FIELD_OPTION, id);
        }

        public UserDefinedField getUserDefinedField ()
        {
            return (UserDefinedField) this.getProperty("userDefinedField");
        }

        public void setUserDefinedField (UserDefinedField userDefinedField)
        {
            this.setProperty("userDefinedField", userDefinedField);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }


    }
}

