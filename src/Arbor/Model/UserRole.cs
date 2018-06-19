using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserRole : ModelBase
    {
        protected string resourceType = ResourceType.USER_ROLE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SECTION_NAME = "sectionName";
        public const string FUNCTION_NAME = "functionName";
        public const string PERMISSION_NAME = "permissionName";
        public const string PERMISSION_CATEGORY = "permissionCategory";
        public const string DESCRIPTION = "description";

        public UserRole ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UserRole (string resourceType = "UserRole", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UserRole> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UserRole");
        	RestGateway gateway = (RestGateway) UserRole.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UserRole> userroleCollection = new ModelCollection<UserRole> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    userroleCollection.add((UserRole) model);
        	}
        
        	return userroleCollection;
        }

        public static UserRole retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UserRole.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UserRole) gateway.retrieve(ResourceType.USER_ROLE, id);
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
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getSectionName ()
        {
            return this.getProperty("sectionName").ToString();
        }

        public void setSectionName (string sectionName)
        {
            this.setProperty("sectionName", sectionName);
        }

        public string getFunctionName ()
        {
            return this.getProperty("functionName").ToString();
        }

        public void setFunctionName (string functionName)
        {
            this.setProperty("functionName", functionName);
        }

        public string getPermissionName ()
        {
            return this.getProperty("permissionName").ToString();
        }

        public void setPermissionName (string permissionName)
        {
            this.setProperty("permissionName", permissionName);
        }

        public string getPermissionCategory ()
        {
            return this.getProperty("permissionCategory").ToString();
        }

        public void setPermissionCategory (string permissionCategory)
        {
            this.setProperty("permissionCategory", permissionCategory);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

